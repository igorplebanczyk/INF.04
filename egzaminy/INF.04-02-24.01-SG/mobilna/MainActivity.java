package com.example.a2024_styczen_02_mobilna;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.SeekBar;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    private int currentAge;
    private String currentSpecies;

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

        TextView textViewAge = findViewById(R.id.text_view_age);

        SeekBar seekBarAge = findViewById(R.id.seek_bar_age);
        seekBarAge.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int i, boolean b) {
                textViewAge.setText("Ile ma lat? " + i);
                currentAge = i;
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {}

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {}
        });

        ArrayList<String> species = new ArrayList<>();
        species.add("Pies");
        species.add("Kot");
        species.add("Świnka morska");

        ArrayAdapter<String> adapter = new ArrayAdapter<>(
                this,
                android.R.layout.simple_selectable_list_item,
                species
        );

        ListView listViewSpecies = findViewById(R.id.list_view_species);
        listViewSpecies.setAdapter(adapter);
        listViewSpecies.setOnItemClickListener((adapterView, view, i, l) -> {
            String selectedItem = listViewSpecies.getItemAtPosition(i).toString();

            if (selectedItem.equals("Pies")) seekBarAge.setMax(18);
            if (selectedItem.equals("Kot")) seekBarAge.setMax(20);
            if (selectedItem.equals("Świnka morska")) seekBarAge.setMax(9);

            currentSpecies = selectedItem;
        });

        EditText editTextName = findViewById(R.id.edit_text_name);
        EditText editTextPurpose = findViewById(R.id.edit_text_purpose);
        EditText editTextTime = findViewById(R.id.edit_text_time);
        TextView textViewResult = findViewById(R.id.text_view_result);

        Button buttonConfirm = findViewById(R.id.button_confirm);
        buttonConfirm.setOnClickListener(view -> textViewResult.setText(String.format(
                "%s, %s, %d, %s, %s",
                editTextName.getText(),
                currentSpecies,
                currentAge,
                editTextPurpose.getText(),
                editTextTime.getText()
        )));
    }
}