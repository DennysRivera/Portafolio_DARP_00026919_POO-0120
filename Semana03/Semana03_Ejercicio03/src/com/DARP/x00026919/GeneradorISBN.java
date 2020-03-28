package com.DARP.x00026919;

public final class GeneradorISBN {
    static private int contador = 1;

    private GeneradorISBN(){

    }

    public static int nuevoISBN(){
        return contador++;
    }
}
