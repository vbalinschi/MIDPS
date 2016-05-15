package com.example.tomas.juego_pokemon;

import android.content.Intent;
import android.media.MediaPlayer;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.Toast;


public class Principal extends AppCompatActivity {
    private Button play, credits, listapokemon, exit;
    private MediaPlayer reproductor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        getWindow().addFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(R.layout.activity_principal);
        play = (Button) findViewById(R.id.btnplay);
        credits = (Button) findViewById(R.id.btnabout);
        listapokemon = (Button) findViewById(R.id.btnlista);
        exit = (Button) findViewById(R.id.btnexit);
        PokemonDB.addData(getApplicationContext());
        reproductor = MediaPlayer.create(this, R.raw.backmusic);
        reproductor.setLooping(true);
        reproductor.start();

        play.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (PokemonDB.isWin()) {
                    Toast.makeText(getApplication(), getResources().getString(R.string.msg_win), Toast.LENGTH_SHORT).show();
                } else {
                    Intent intent = new Intent(Principal.this, Play.class);
                    startActivity(intent);
                }

            }
        });

        listapokemon.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent newform = new Intent(Principal.this, Pokedex.class);
                startActivity(newform);
            }
        });

        credits.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent newform = new Intent(Principal.this, Credits.class);
                startActivity(newform);

            }
        });

        exit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        if (reproductor.isPlaying()) {
            reproductor.stop();
            reproductor.release();
        }
    }

    @Override
    protected void onResume() {
        super.onResume();
        reproductor.start();
    }

    @Override
    protected void onPause() {
        super.onPause();
        reproductor.pause();
    }
}
