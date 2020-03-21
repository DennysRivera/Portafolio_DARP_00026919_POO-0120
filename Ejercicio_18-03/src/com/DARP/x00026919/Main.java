package com.DARP.x00026919;

import java.util.Scanner;

public class Main {
    static Scanner sca = new Scanner(System.in);

    public static void main(String[] args) {
        //Se crea el primer objeto de la clase Laptop
        Laptop unaLaptop = new Laptop("admin", "password");
        unaLaptop.setMarca("Acer");
        unaLaptop.encender();
        System.out.println(unaLaptop.getMarca());
        System.out.println("Perfil de administrador creado");
        System.out.println("Nombre de administrador: " + unaLaptop.getUsuario() + "\nContraseña: " + unaLaptop.getPass());

        //Se crea un segundo objeto de la clase Laptop
        Laptop miLaptop = new Laptop();
        miLaptop.setUsuario();
        miLaptop.setPass();

        System.out.println("\nSe ha creado el usuario: " + miLaptop.getUsuario());
        System.out.println("Con contraseña: " + miLaptop.getPass());

        unicaOpcion();

        miLaptop.apagar();
    }

    public static void unicaOpcion(){
        byte opc = 0;

        while(opc != 2) {
            System.out.print("Abrir: \n\t1. Un RPG pre-instalado\n\t2. Apagar Laptop\n\tOpción: ");
            opc = sca.nextByte();
            if (opc == 1) rpg();
            else if(opc == 2);
            else System.out.println("No hay más opciones");
        }
    }

    public static int rpg(){
        byte opc = 0, opc2 = 0;
        System.out.println("Bienvenido al juego!");
        Personaje miPersonaje = new Personaje();//Se crea el primer objeto de la clase Personaje
        miPersonaje.setNickname();

        //Información para pasar al primer objeto
        while(opc < 1 || opc > 4) {
            System.out.print("Escoge tu clase:\n1. Aventurero\n2. Guerrero\n3. Arquero\n4. Mago\nOpción: ");
            opc = sca.nextByte();

            switch (opc) {
                case 1:
                    miPersonaje.setClase("Aventurero");
                    break;
                case 2:
                    miPersonaje.setClase("Guerrero");
                    break;
                case 3:
                    miPersonaje.setClase("Arquero");
                    break;
                case 4:
                    miPersonaje.setClase("Mago");
                    break;
                default:
                    System.out.println("No hay más clases");
                    break;
            }
        }

        miPersonaje.setStats(5, 5, 5);
        System.out.println("Se creó el " + miPersonaje.getClase() + " " + miPersonaje.getNickname());
        System.out.println("Stats iniciales: ATK: "  + miPersonaje.getAtk() + "\tDEF: " + miPersonaje.getDef() + "\tMP: " + miPersonaje.getMp());

        //Se crean otros dos objetos de la clase Personaje
        System.out.println("Creando a tus compañeros...\n");
        Personaje personaje1 = new Personaje("Aqua", "Sacerdotisa", 3, 3, 40);
        Personaje personaje2 = new Personaje("Magicarp", "", 1, 0, 0);
        System.out.print("Tus compañeros son " + personaje1.getNickname() + ", " + personaje1.getClase() + "\nStats: ");
        System.out.println("ATK: " + personaje1.getAtk() + "\tDEF: " + personaje1.getDef() + "\tMP: " + personaje1.getMp());
        System.out.print("\n" + personaje2.getNickname() + personaje2.getClase() + "\nStats: ");
        System.out.println("ATK: " + personaje2.getAtk() + "\tDEF: " + personaje2.getDef() + "\tMP: " + personaje2.getMp());

        //Se utilizan los métodos de Personaje
        while(opc2 != 3) {
            System.out.print("\nTe encuentras un enemigo:\n\t1. Atacar\n\t2. Defender\n\t3. Huir\n\tOpción: ");
            opc2 = sca.nextByte();

            switch (opc2) {
                case 1:
                    miPersonaje.atacar();
                    break;
                case 2:
                    miPersonaje.defender();
                    break;
                case 3:
                    miPersonaje.huir();
                    return 0;
                default:
                    System.out.println("Opción inválida");
                    break;
            }
        }
        return 0;
    }
}
