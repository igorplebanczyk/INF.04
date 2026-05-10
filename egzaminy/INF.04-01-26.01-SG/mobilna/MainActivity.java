package com.example.a2026_styczen_01_mobilna;

import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.HashMap;
import java.util.Random;

public class MainActivity extends AppCompatActivity {
    boolean dice1Available = true;
    boolean dice2Available = true;
    boolean dice3Available = true;
    boolean dice4Available = true;
    boolean dice5Available = true;

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

        HashMap<Integer, Drawable> diceImages = new HashMap<>();
        diceImages.put(1, getDrawable(R.drawable.kosc1));
        diceImages.put(2, getDrawable(R.drawable.kosc2));
        diceImages.put(3, getDrawable(R.drawable.kosc3));
        diceImages.put(4, getDrawable(R.drawable.kosc4));
        diceImages.put(5, getDrawable(R.drawable.kosc5));
        diceImages.put(6, getDrawable(R.drawable.kosc6));

        ImageView imageViewDice1 = findViewById(R.id.image_view_dice_1);
        ImageView imageViewDice2 = findViewById(R.id.image_view_dice_2);
        ImageView imageViewDice3 = findViewById(R.id.image_view_dice_3);
        ImageView imageViewDice4 = findViewById(R.id.image_view_dice_4);
        ImageView imageViewDice5 = findViewById(R.id.image_view_dice_5);

        TextView textViewResult = findViewById(R.id.text_view_result);
        Button buttonThrow = findViewById(R.id.button_throw);
        buttonThrow.setOnClickListener(View -> {
            Random random = new Random();
            int score = 0;

            if (dice1Available) {
                int value = random.nextInt(6) + 1;
                imageViewDice1.setImageDrawable(diceImages.get(value));
                score += value;
            }

            if (dice2Available) {
                int value = random.nextInt(6) + 1;
                imageViewDice2.setImageDrawable(diceImages.get(value));
                score += value;
            }

            if (dice3Available) {
                int value = random.nextInt(6) + 1;
                imageViewDice3.setImageDrawable(diceImages.get(value));
                score += value;
            }

            if (dice4Available) {
                int value = random.nextInt(6) + 1;
                imageViewDice4.setImageDrawable(diceImages.get(value));
                score += value;
            }

            if (dice5Available) {
                int value = random.nextInt(6) + 1;
                imageViewDice5.setImageDrawable(diceImages.get(value));
                score += value;
            }

            textViewResult.setText(String.valueOf(score));
        });

        imageViewDice1.setOnClickListener(View -> {
            dice1Available = !dice1Available;
            if (!dice1Available) imageViewDice1.setImageAlpha(50);
            else imageViewDice1.setImageAlpha(255);
        });

        imageViewDice2.setOnClickListener(View -> {
            dice2Available = !dice2Available;
            if (!dice2Available) imageViewDice2.setImageAlpha(50);
            else imageViewDice2.setImageAlpha(255);
        });

        imageViewDice3.setOnClickListener(View -> {
            dice3Available = !dice3Available;
            if (!dice3Available) imageViewDice3.setImageAlpha(50);
            else imageViewDice3.setImageAlpha(255);
        });

        imageViewDice4.setOnClickListener(View -> {
            dice4Available = !dice4Available;
            if (!dice4Available) imageViewDice4.setImageAlpha(50);
            else imageViewDice4.setImageAlpha(255);
        });

        imageViewDice5.setOnClickListener(View -> {
            dice5Available = !dice5Available;
            if (!dice5Available) imageViewDice5.setImageAlpha(50);
            else imageViewDice5.setImageAlpha(255);
        });
    }
}