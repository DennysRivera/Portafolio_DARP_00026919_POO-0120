package com.DARP.x00026919;

public class Autor {
    private String nombre, email;
    private char genero;

    public Autor(String nombre, String email, char genero){
        this.nombre = nombre;
        this.email = email;
        this.genero = genero;
    }

    public String getNombre(){
        return nombre;
    }

    public String getEmail(){
        return email;
    }

    public void setEmail(String email){
        this.email = email;
    }

    public char getGenero(){
        return genero;
    }

    @Override
    public String toString() {
        return nombre + '(' + genero + "): " + email;
    }
}
