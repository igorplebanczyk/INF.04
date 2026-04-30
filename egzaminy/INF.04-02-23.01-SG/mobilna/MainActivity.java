package com.example.a2023_czerwiec_02_mobilna;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

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

        EditText editTextNewNote = findViewById(R.id.edit_text_new_note);
        Button buttonAdd = findViewById(R.id.button_add);
        ListView listViewNotes = findViewById(R.id.list_view_notes);

        ArrayList<String> notesList = new ArrayList<>();
        notesList.add("Zakupy: chleb, masło, ser");
        notesList.add("Do zrobienia: obiad, umyć podłogi");
        notesList.add("weekend: kino, spacer z psem");

        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, notesList);
        listViewNotes.setAdapter(adapter);

        buttonAdd.setOnClickListener(view -> {
            notesList.add(editTextNewNote.getText().toString());
            adapter.notifyDataSetChanged();
        });
    }
}