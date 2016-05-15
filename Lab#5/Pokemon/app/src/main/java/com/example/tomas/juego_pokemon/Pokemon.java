package com.example.tomas.juego_pokemon;


public class Pokemon {

    private int id;
    private String name;
    private String shadow;
    private boolean guessed;

    public Pokemon(int id,String name,String shadow, boolean guessed) {
        this.id = id;
        this.name = name;
        this.shadow = shadow;
        this.guessed = guessed;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getShadow() {
        return shadow;
    }

    public void setShadow(String shadow) {
        this.shadow = shadow;
    }

    public boolean isGuessed() {
        return guessed;
    }

    public void setGuessed(boolean guessed) {
        this.guessed = guessed;
    }
}
