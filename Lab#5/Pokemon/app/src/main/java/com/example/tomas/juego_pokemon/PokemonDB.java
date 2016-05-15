package com.example.tomas.juego_pokemon;

import android.content.Context;
import android.content.SharedPreferences;

import java.util.ArrayList;
import java.util.Arrays;


public class PokemonDB {
    private static ArrayList<Pokemon> listaPokemon = new ArrayList<>(Arrays.asList(
            new Pokemon(0,"bulbasaur", "s_bulbasaur", false)
            ,new Pokemon(1,"ivysaur","s_ivysaur",false)
            ,new Pokemon(2,"venasaur","s_venasaur",false)
            ,new Pokemon(3,"ivysaur","s_ivysaur",false)
            ,new Pokemon(4,"charmander","s_charmander",false)
            ,new Pokemon(5,"charmeleon","s_charmeleon",false)
            ,new Pokemon(6,"charizard","s_charizard",false)
            ,new Pokemon(7,"squirtle","s_squirtle",false)
            ,new Pokemon(8,"wartortle","s_wartortle",false)
            ,new Pokemon(9,"blastoise","s_blastoise",false)
            ,new Pokemon(10,"caterpie","s_caterpie",false)
            ,new Pokemon(11,"metapod","s_metapod",false)
            ,new Pokemon(12,"butterfree","s_butterfree",false)
            ,new Pokemon(13,"weedle","s_weedle",false)
            ,new Pokemon(14,"kakuna","s_kakuna",false)
            ,new Pokemon(15,"beedrill","s_beedrill",false)
            ,new Pokemon(16,"pidgey","s_pidgey",false)
            ,new Pokemon(17,"pidgeotto","s_pidgeotto",false)
            ,new Pokemon(18,"pidgeot","s_pidgeot",false)
            ,new Pokemon(19,"rattata","s_rattata",false)
            ,new Pokemon(20,"raticate","s_raticate",false)
            ,new Pokemon(21,"spearow","s_spearow",false)
            ,new Pokemon(22,"fearow","s_fearow",false)
            ,new Pokemon(23,"ekans","s_ekans",false)
            ,new Pokemon(24,"arbok","s_arbok",false)
            ,new Pokemon(25,"pikachu","s_pikachu",false)
            ,new Pokemon(26,"raichu","s_raichu",false)
            ,new Pokemon(27,"sandshrew","s_sandshrew",false)
            ,new Pokemon(28,"sandslash","s_sandslash",false)
            ,new Pokemon(29,"nidoran","s_nidoran",false)
            ,new Pokemon(30,"nidorina","s_nidorina",false)
            ,new Pokemon(31,"nidoqueen","s_nidoqueen",false)
            ,new Pokemon(32,"cloyster","s_cloyster",false)
            ,new Pokemon(33,"gloom","s_gloom",false)
            ,new Pokemon(34,"krabby","s_krabby",false)
            ,new Pokemon(35,"magmar","s_magmar",false)
            ,new Pokemon(36,"marowak","s_marowak",false)
            ,new Pokemon(37,"snorlax","s_snorlax",false)
            ,new Pokemon(38,"starmie","s_starmie",false)
            ,new Pokemon(39,"vulpix","s_vulpix",false)
             ));

    public static int GUESSED=0;
    public static int ATTEMPTS =3;
    public static int GENERATEDNUMBER =0;
    private static boolean ACTIVATE_SOUND=true;

    public static String getName(int id)
    {
        return listaPokemon.get(id).getName().toLowerCase().replace(" ", "_");
    }

    public static String getShadow(int id)
    {
        return listaPokemon.get(id).getShadow().toLowerCase().replace(" ", "_");
    }

    public static Pokemon getPokemon(int id)
    {
        return listaPokemon.get(id);
    }
    public static int getSize()
    {
        return listaPokemon.size();
    }
    public static boolean isGuessed(int id)
    {
        return listaPokemon.get(id).isGuessed();
    }

    public static void setGuessed(int id, boolean valor)
    {
        listaPokemon.get(id).setGuessed(valor);
    }

    public static void addData(Context c)
    {
        SharedPreferences mypreferences = c.getSharedPreferences("GameData", Context.MODE_PRIVATE);
        ATTEMPTS = mypreferences.getInt("ATTEMPTS",3);
        GUESSED = mypreferences.getInt("GUESSED",0);
        ACTIVATE_SOUND = mypreferences.getBoolean("SOUND",true);
        for (Pokemon element : listaPokemon)
        {
            element.setGuessed(mypreferences.getBoolean(element.getName(), false));
        }
    }

    public static void keepData(Context c)
    {
        SharedPreferences mypreferences = c.getSharedPreferences("GameData", Context.MODE_PRIVATE);
        SharedPreferences.Editor editor = mypreferences.edit();
        editor.putInt("ATTEMPTS", ATTEMPTS);
        editor.putInt("GUESSED",GUESSED);
        editor.putBoolean("SOUND",ACTIVATE_SOUND);
        for (Pokemon element : listaPokemon)
        {
            editor.putBoolean(element.getName(), element.isGuessed());
        }
        editor.apply();
    }

    public static void addConfig(Context c)
    {
        SharedPreferences mypreferences = c.getSharedPreferences("DataConfig", Context.MODE_PRIVATE);
        ACTIVATE_SOUND = mypreferences.getBoolean("SOUND",true);
    }

    public static void keepConfig(Context c)
    {
        SharedPreferences mypreferences = c.getSharedPreferences("DataConfig", Context.MODE_PRIVATE);
        SharedPreferences.Editor editor = mypreferences.edit();
        editor.putBoolean("SOUND",ACTIVATE_SOUND);
        editor.apply();
    }

    public static void removeConfig(Context c)
    {
        SharedPreferences settings = c.getSharedPreferences("DataConfig", Context.MODE_PRIVATE);
        settings.edit().clear().apply();
    }

    public static void removeData(Context c)
    {
        SharedPreferences settings = c.getSharedPreferences("GameData", Context.MODE_PRIVATE);
        settings.edit().clear().apply();
    }

    public static boolean isPokemon(String x)
    {
        return listaPokemon.get(GENERATEDNUMBER).getName().equalsIgnoreCase(x);
    }

    public static void DecreaseAttempts()
    {
        ATTEMPTS--;
    }
    public static boolean isGameOver()
    {
        return ATTEMPTS==0;
    }
    public static boolean isWin()
    {
        return GUESSED==getSize();
    }
    public static boolean isACTIVATE_SOUND() {
        return ACTIVATE_SOUND;
    }

    public static void setACTIVATE_SOUND(boolean ACTIVATE_SOUND) {
        PokemonDB.ACTIVATE_SOUND = ACTIVATE_SOUND;
    }
}
