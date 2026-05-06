package com.example.a2024_czerwiec_01_mobilna;

import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.content.res.AppCompatResources;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.HashMap;
import java.util.Random;

public class MainActivity extends AppCompatActivity {
    int drawScore = 0;
    int gameScore = 0;

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

        Random random = new Random();
        HashMap<Integer, Drawable> imagePaths = new HashMap<>();
        imagePaths.put(1, getDrawable(R.drawable.k1));
        imagePaths.put(2, getDrawable(R.drawable.k2));
        imagePaths.put(3, getDrawable(R.drawable.k3));
        imagePaths.put(4, getDrawable(R.drawable.k4));
        imagePaths.put(5, getDrawable(R.drawable.k5));
        imagePaths.put(6, getDrawable(R.drawable.k6));

        ImageView imageViewDice1 = findViewById(R.id.image_view_dice_1);
        ImageView imageViewDice2 = findViewById(R.id.image_view_dice_2);
        ImageView imageViewDice3 = findViewById(R.id.image_view_dice_3);
        ImageView imageViewDice4 = findViewById(R.id.image_view_dice_4);
        ImageView imageViewDice5 = findViewById(R.id.image_view_dice_5);

        TextView textViewDrawScore = findViewById(R.id.text_view_draw_score);
        TextView textViewGameScore = findViewById(R.id.text_view_game_score);

        Button buttonThrow = findViewById(R.id.button_throw);
        buttonThrow.setOnClickListener(view -> {
            int[] diceThrows = new int[5];
            for (int i = 0; i < 5; i++) diceThrows[i] = random.nextInt(6) + 1;

            imageViewDice1.setImageDrawable(imagePaths.get(diceThrows[0]));
            imageViewDice2.setImageDrawable(imagePaths.get(diceThrows[1]));
            imageViewDice3.setImageDrawable(imagePaths.get(diceThrows[2]));
            imageViewDice4.setImageDrawable(imagePaths.get(diceThrows[3]));
            imageViewDice5.setImageDrawable(imagePaths.get(diceThrows[4]));

            HashMap<Integer, Integer> counts = new HashMap<>();
            for (int diceThrow : diceThrows) {
                if (counts.containsKey(diceThrow)) counts.replace(diceThrow, counts.get(diceThrow) + 1);
                else counts.put(diceThrow, 1);
            }

            counts.forEach((dotsCount, count) -> {
                if (count >= 2) drawScore = dotsCount * count;
            });

            gameScore += drawScore;

            textViewDrawScore.setText("Wynik tego losowania: " + drawScore);
            textViewGameScore.setText("Wynik gry: " + gameScore);
        });

        Button buttonReset = findViewById(R.id.button_reset);
        buttonReset.setOnClickListener(View -> {
            imageViewDice1.setImageDrawable(getDrawable(R.drawable.question));
            imageViewDice2.setImageDrawable(getDrawable(R.drawable.question));
            imageViewDice3.setImageDrawable(getDrawable(R.drawable.question));
            imageViewDice4.setImageDrawable(getDrawable(R.drawable.question));
            imageViewDice5.setImageDrawable(getDrawable(R.drawable.question));

            drawScore = 0;
            gameScore = 0;

            textViewDrawScore.setText("Wynik tego losowania: 0");
            textViewGameScore.setText("Wynik gry: 0");
        });
    }
}