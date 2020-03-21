package com.DARP.x00026919;

import java.util.Scanner;

public class Laptop{
    Scanner sca = new Scanner(System.in);
    //Atributos de Laptop
    private String marca;
    private String usuario;
    private String pass;

    //Sobrecarga de constructores
    public Laptop(String unUsuario, String unaPass){
        usuario = unUsuario;
        pass = unaPass;
    }

    public Laptop(){
        System.out.println("\nCreando nuevo perfil de usuario...");
    }
    /////////

    //Métodos de Laptop
    public void encender(){
        System.out.print("Iniciando...\nBienvenido a su equipo ");
    }

    public void apagar(){
        System.out.println("Cerrando sesión...\nApagando\n*Equipo apagado*");
    }
    ////////////

    //Setters y Getters
    public void setMarca(String sMarca){
        marca = sMarca;
    }

    public String getMarca(){
        return marca;
    }

    public void setUsuario(){
        System.out.print("Nombre: ");
        usuario = sca.nextLine();
    }

    public String getUsuario(){
        return usuario;
    }

    public void setPass(){
        System.out.print("Contraseña: ");
        pass = sca.nextLine();
    }

    public String getPass(){
        return pass;
    }
}
