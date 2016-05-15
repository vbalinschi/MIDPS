package com.example.tomas.juego_pokemon;

import android.app.ProgressDialog;
import android.content.Intent;
import android.media.MediaPlayer;
import android.os.AsyncTask;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.view.Window;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.Collections;


public class Play extends AppCompatActivity implements View.OnClickListener {
    ImageView image;
    TextView lblattempts;
    TextView lblcount;
    private MediaPlayer reproductor;
    private final int WAITING_TIME = 5000;
    private Button btn1, btn2, btn3, btn4;

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.supportRequestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_play);
        initiateComponents();
        PokemonDB.addData(getApplicationContext());
        reproductor = MediaPlayer.create(this, R.raw.backmusic2);
        reproductor.setLooping(true);
        reproductor.start();
        new MyWork().execute();
        PokemonDB.addConfig(getApplicationContext());
        lblattempts.setText(String.valueOf(PokemonDB.ATTEMPTS));
    }


    public void setShadow(int id) {
        int resId = getResources().getIdentifier(PokemonDB.getShadow(id), "drawable", getPackageName());
        image.setImageResource(resId);
    }

    public void setPokemon(int id) {
        int resId = getResources().getIdentifier(PokemonDB.getName(id), "drawable", getPackageName());
        image.setImageResource(resId);
    }

    private void initiateComponents() {
        image = (ImageView) findViewById(R.id.myimage);
        lblattempts = (TextView) findViewById(R.id.lblattempts);
        lblcount = (TextView) findViewById(R.id.lblcount);
        btn1 = (Button) findViewById(R.id.btn1);
        btn2 = (Button) findViewById(R.id.btn2);
        btn3 = (Button) findViewById(R.id.btn3);
        btn4 = (Button) findViewById(R.id.btn4);
        btn1.setOnClickListener(this);
        btn2.setOnClickListener(this);
        btn3.setOnClickListener(this);
        btn4.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        Button boton = (Button) v;
        String namePokemon = boton.getText().toString().toLowerCase();
        if (PokemonDB.isPokemon(namePokemon)) {
            setPokemon(PokemonDB.GENERATEDNUMBER);
            PokemonDB.setGuessed(PokemonDB.GENERATEDNUMBER, true);
            PokemonDB.GUESSED++;
            enableButtons(false);
            boton.setVisibility(View.VISIBLE);
            boton.setClickable(false);
            waiting();
        } else {
            PokemonDB.DecreaseAttempts();
            lblattempts.setText(String.valueOf(PokemonDB.ATTEMPTS));
            v.setVisibility(View.INVISIBLE);
        }

        if (PokemonDB.isGameOver()) {
            Intent i = new Intent(Play.this, Lose.class);
            startActivity(i);
            finish();
        }
    }

    public void waiting() {
        new CountDownTimer(WAITING_TIME, 1000) {

            @Override
            public void onTick(long millisUntilFinished) {
                lblcount.setText("Next one in " + (millisUntilFinished / 1000));
            }

            @Override
            public void onFinish() {
                lblcount.setText("");
                if (!PokemonDB.isWin()) {
                    new MyWork().execute();
                } else {
                    Toast.makeText(getApplicationContext(), getResources().getString(R.string.msg_win), Toast.LENGTH_SHORT).show();
                    finish();
                }
            }
        }.start();
    }

    public void enableButtons(boolean value) {
        if (value) {
            btn1.setVisibility(View.VISIBLE);
            btn2.setVisibility(View.VISIBLE);
            btn3.setVisibility(View.VISIBLE);
            btn4.setVisibility(View.VISIBLE);
            btn1.setClickable(true);
            btn2.setClickable(true);
            btn3.setClickable(true);
            btn4.setClickable(true);
        } else {
            btn1.setVisibility(View.INVISIBLE);
            btn2.setVisibility(View.INVISIBLE);
            btn3.setVisibility(View.INVISIBLE);
            btn4.setVisibility(View.INVISIBLE);
        }
    }

    @Override
    protected void onStop() {
        super.onStop();
        if (PokemonDB.isGameOver()) {
            PokemonDB.removeData(getApplicationContext());
        } else {
            PokemonDB.keepData(getApplicationContext());
        }
        reproductor.pause();
    }

    @Override
    protected void onResume() {
        super.onResume();
        reproductor.start();
    }

    @Override
    protected void onDestroy() {
        if (reproductor.isPlaying()) {
            reproductor.stop();
            reproductor.release();
        }
        super.onDestroy();
    }

    private class MyWork extends AsyncTask<Void, Void, Void> {
        private ProgressDialog dialog;
        private int number = 0;
        private int totalgenerated = 4;
        private int numbersleft = totalgenerated - 1;
        private int counter = 0;
        private int accepted = 0;
        private int generatedvalue = -1;
        ArrayList<Integer> numbers = new ArrayList<>();

        @Override
        protected void onPreExecute() {
            dialog = new ProgressDialog(Play.this);
            dialog.setMessage("Next one in ...");
            dialog.show();
        }

        @Override
        protected Void doInBackground(Void... params) {
            do {
                number = ((int) (Math.random() * PokemonDB.getSize()));
                if (!PokemonDB.isGuessed(number) && generatedvalue <= 0) {
                    generatedvalue = number;
                    counter++;
                    numbers.add(number);
                } else if (!numbers.contains(number) && accepted < numbersleft) {
                    numbers.add(number);
                    counter++;
                    accepted++;
                }
            } while (counter < totalgenerated);
            Collections.shuffle(numbers);

            try {
                Thread.sleep(250);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            return null;
        }

        @Override
        protected void onPostExecute(Void aVoid) {
            PokemonDB.GENERATEDNUMBER = generatedvalue;
            setShadow(generatedvalue);
            enableButtons(true);
            btn1.setText(PokemonDB.getName(numbers.get(0)));
            btn2.setText(PokemonDB.getName(numbers.get(1)));
            btn3.setText(PokemonDB.getName(numbers.get(2)));
            btn4.setText(PokemonDB.getName(numbers.get(3)));
            if (dialog.isShowing()) {
                dialog.dismiss();
            }
            super.onPostExecute(aVoid);
        }
    }
}
