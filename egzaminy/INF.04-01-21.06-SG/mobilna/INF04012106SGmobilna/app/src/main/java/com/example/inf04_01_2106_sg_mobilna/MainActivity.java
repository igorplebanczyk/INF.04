package com.example.inf04_01_2106_sg_mobilna;

import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

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

        EditText emailEditText = findViewById(R.id.email_edit_text);
        EditText passwordEditText = findViewById(R.id.password_edit_text);
        EditText repeatPasswordEditText = findViewById(R.id.repeat_password_edit_text);
        Button confirmButton = findViewById(R.id.confirm_button);
        TextView infoTextView = findViewById(R.id.info_text_view);

        confirmButton.setOnClickListener(view -> {
            if (!emailEditText.getText().toString().contains("@")) {
                infoTextView.setText("Nieprawidłowy adres e-mail");
                return;
            }

            if (!passwordEditText.getText().toString().equals(repeatPasswordEditText.getText().toString())) {
                infoTextView.setText("Hasła się różnią");
                return;
            }

            infoTextView.setText(String.format("Witaj %s", emailEditText.getText().toString()));
        });
    }
}