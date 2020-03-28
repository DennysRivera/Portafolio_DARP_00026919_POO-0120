package com.DARP.x00026919;

public class Libro {
    private String nombre;
    private int paginas, ISBN;

    public Libro(String nombre, int paginas){
        ISBN = GeneradorISBN.nuevoISBN();
        this.nombre = nombre;
        this.paginas = paginas;
    }

    public String getISBN(){
        return String.valueOf(ISBN);
    }

    public String getNombre() {
        return nombre;
    }

    public int getPaginas() {
        return paginas;
    }

    @Override
    public String toString() {
        return "ISBN: " + ISBN + ", " + nombre + " (" + paginas + " páginas)";
    }
}
