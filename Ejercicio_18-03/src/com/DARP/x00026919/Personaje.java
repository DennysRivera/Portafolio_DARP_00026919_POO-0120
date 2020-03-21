package com.DARP.x00026919;

import java.util.Scanner;

public class Personaje{
    Scanner sca = new Scanner(System.in);
    //Atributos de Personajes
    private String nickname;
    private String clase;
    private int atk;
    private int def;
    private int mp;

    //Sobrecarga de constructores
    public Personaje(String unNickname, String unaClase, int sAtk, int sDef, int sMp){
        nickname = unNickname;
        clase = unaClase;
        atk = sAtk;
        def = sDef;
        mp = sMp;
    }

    public Personaje(){
        System.out.println("Creando personaje...");
    }
    /////

    //Setters y Getters
    public void setNickname(){
        System.out.print("Ponle un nombre a tu personaje: ");
        nickname = sca.nextLine();
    }

    public String getNickname(){
        return nickname;
    }

    public void setClase(String tuClase){
        clase = tuClase;
    }

    public String getClase(){
        return clase;
    }

    public void setStats(int sAtk, int sDef, int sMp){
        atk = sAtk;
        def = sDef;
        mp = sMp;
    }

    public int getAtk() { return atk; }

    public int getDef() { return  def;}

    public int getMp() { return mp;}
    /////////

    //Métodos de Personaje
    public void atacar(){
        System.out.println("Magicarp salpica!");
        System.out.println("Atacas!...pero uno de tus compañeros se pone en medio...");
    }

    public void defender(){
        System.out.println("Te defiendes!...pero tus compañeros se distraen y son atacados...");
    }

    public void huir(){
        System.out.println("Huyes!...pero el ataque del enemigo te alcanza a ti y a tus compañeros...");
        System.out.println("Game over");
    }
}

