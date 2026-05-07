package com.example.a2025_styczen_02_mobilna;

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
    private boolean isVacuumOn = false;

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

        EditText editTextProgramNumber = findViewById(R.id.edit_text_program_number);
        Button buttonConfirm = findViewById(R.id.button_confirm);
        TextView textViewProgramNumber = findViewById(R.id.text_view_program_number);

        buttonConfirm.setOnClickListener(View -> {
            int programNumber = Integer.parseInt(editTextProgramNumber.getText().toString());

            if (programNumber >= 1 && programNumber <= 12) textViewProgramNumber.setText("Numer prania: " + programNumber);
        });

        Button buttonOnOff = findViewById(R.id.button_on_off);
        TextView textViewOnOff = findViewById(R.id.text_view_on_off);

        buttonOnOff.setOnClickListener(View -> {
            if (isVacuumOn) {
                buttonOnOff.setText("Włącz");
                textViewOnOff.setText("Odkurzacz wyłączony");
                isVacuumOn = false;
            } else {
                buttonOnOff.setText("Wyłącz");
                textViewOnOff.setText("Odkurzacz włączony");
                isVacuumOn = true;
            }
        });
    }
}