package com.example.a2023_czerwiec_02_mobilna;

import android.os.Bundle;
import android.widget.Button;
import android.widget.SeekBar;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;

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

        ArrayList<String> quotes = new ArrayList<>();
        quotes.add("Dzień dobry");
        quotes.add("Good morning");
        quotes.add("Buenos dias");

        SeekBar seekBarSize = findViewById(R.id.seek_bar_size);
        TextView textViewSize = findViewById(R.id.text_view_size);
        TextView textViewQuote = findViewById(R.id.text_view_quote);
        Button buttonChange = findViewById(R.id.button_change);

        seekBarSize.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int i, boolean b) {
                textViewSize.setText(String.format("Rozmiar: %d", i));
                textViewQuote.setTextSize(i);
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {}

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {}
        });

        buttonChange.setOnClickListener(view -> {
            int currentQuoteIndex = quotes.indexOf(textViewQuote.getText());
            int newQuoteIndex = currentQuoteIndex + 1;

            if (currentQuoteIndex == quotes.size() - 1) {
                newQuoteIndex = 0;
            }

            textViewQuote.setText(quotes.get(newQuoteIndex));
        });
    }
}