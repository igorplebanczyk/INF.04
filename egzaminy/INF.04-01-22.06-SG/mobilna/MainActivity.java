package com.example.a2022_czerwiec_01_mobilna;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    int likes;

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

        this.likes = 0;

        Button buttonLike = findViewById(R.id.button_like);
        Button buttonDelete = findViewById(R.id.button_delete);
        TextView textViewLikes = findViewById(R.id.text_view_likes);

        buttonLike.setOnClickListener(view -> {
            this.likes++;
            textViewLikes.setText(this.likes + " polubień");
        });

        buttonDelete.setOnClickListener(view -> {
            if (this.likes != 0) this.likes--;
            textViewLikes.setText(this.likes + " polubień");
        });
    }
}