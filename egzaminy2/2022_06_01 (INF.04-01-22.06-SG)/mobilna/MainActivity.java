package com.example.a2022_06_01_m;

import android.os.Bundle;
import android.widget.Button;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    int likes = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        TextView textViewLikes = findViewById(R.id.text_view_likes);

        Button buttonLike = findViewById(R.id.button_like);
        buttonLike.setOnClickListener(View -> {
            likes++;
            textViewLikes.setText(likes + " polubień");
        });

        Button buttonDelete = findViewById(R.id.button_delete);
        buttonDelete.setOnClickListener(View -> {
            if (likes > 0) likes--;
            textViewLikes.setText(likes + " polubień");
        });
    }
}