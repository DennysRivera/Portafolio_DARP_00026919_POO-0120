package com.DARP.x00026919;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    static Scanner sca = new Scanner(System.in);
    public static void main(String[] args) {
        ArrayList<Autor> autores = new ArrayList<>();
        ArrayList<Libro> libros = new ArrayList<>();
        byte opc;

        System.out.println("\nSistema de registro de autores y libros");
        do {
            menu();
            opc = sca.nextByte(); sca.nextLine();
            switch (opc){
                case 1: autores.add(agregarAutor(autores)); break;
                case 2: libros.add(agregarLibro(libros)); break;
                case 3: if(autores.isEmpty()) System.out.println("No hay autores añadidos");
                    else {
                    String autorRemover = removerAutor();
                    autores.removeIf(a -> {
                        if (a.getNombre().equalsIgnoreCase(autorRemover)) {
                            System.out.println("Autor removido");
                            return true;
                        } else {
                            System.out.println("Autor no encontrado");
                            return false;
                        }
                    });
                }
                    break;
                case 4: if(libros.isEmpty()) System.out.println("No hay libros añadidos");
                    else {
                    String libroRemover = removerLibro();
                    libros.removeIf(l -> {
                        if (l.getISBN().equalsIgnoreCase(libroRemover)) {
                            System.out.println("Libro removido");
                            return true;
                        } else {
                            System.out.println("Libro no encontrado");
                            return false;
                        }
                    });
                }
                    break;
                case 5: if(autores.isEmpty()) System.out.println("No hay autores agregados");
                    else autores.forEach(a -> System.out.println('\t' + a.toString()));
                    break;
                case 6: if(libros.isEmpty()) System.out.println("No hay libros agregados");
                    else libros.forEach(a -> System.out.println('\t' + a.toString()));
                    break;
                case 7: if(autores.isEmpty()) System.out.println("No hay Emails para modificar");
                    else modificarEmail(autores);
                    break;
                case 8: break;
                default: System.out.println("Opción inválida"); break;
            }
        }while (opc != 8);
    }

    public static void menu(){
        System.out.println("\n1. Ingresar autor\n2. Ingresar libro\n3. Remover autor\n4. Remover libro");
        System.out.print("5. Mostrar autores\n6. Mostrar libros\n7. Modificar Email\n8. Salir\nOpción: ");
    }

    public static Autor agregarAutor(ArrayList<Autor> autores){
        String nombre, email;
        char genero;
        System.out.print("Nombre: ");
        nombre = sca.nextLine();

        do {
            System.out.print("Género(F/M): ");
            genero = sca.next().charAt(0); sca.nextLine();
            genero = Character.toUpperCase(genero);
        }while(!(genero == 'F' || genero == 'M'));

        boolean flag = true;
        int i;
        do {
            System.out.print("Email: ");
            email = sca.nextLine().toLowerCase();
            for (i = 0; i < email.length(); i++)
                if (email.charAt(i) == '@')
                    flag = false;
        }while (flag);

        for(Autor x : autores)
            if (x.getNombre().equalsIgnoreCase(nombre) && x.getGenero() == genero && x.getEmail().equals(email)) {
                System.out.println("El autor ya está agregado");
                break;
            }

        return new Autor(nombre, email, genero);
    }

    public static Libro agregarLibro(ArrayList<Libro> libros){
        String ISBN, nombre;
        int paginas;
        System.out.print("Nombre: ");
        nombre = sca.nextLine();
        System.out.print("ISBN: ");
        ISBN = sca.nextLine();
        System.out.print("Páginas: ");
        paginas = sca.nextInt();

        for(Libro x : libros)
            if(x.getNombre().equalsIgnoreCase(nombre) && x.getISBN().equals(ISBN) && x.getPaginas() == paginas) {
                System.out.println("Este libro/ejemplar ya está agregado");
                break;
            }

        return new Libro(ISBN, nombre, paginas);
    }

    public static String removerAutor(){
        System.out.print("Nombre del autor a remover: ");

        return sca.nextLine();
    }

    public static String removerLibro(){
        System.out.print("ISBN del libro a remover: ");

        return sca.nextLine();
    }

    public static void modificarEmail(ArrayList<Autor> autores){
        System.out.print("Autor del correo a modificar: ");
        String nombre = sca.nextLine();
        System.out.print("Género del autor: ");
        char genero = sca.next().charAt(0); sca.nextLine();
        genero = Character.toUpperCase(genero);
        System.out.print("Correo a modificar: ");
        String correoMod = sca.nextLine();
        for(Autor x : autores)
            if(x.getNombre().equalsIgnoreCase(nombre) && x.getGenero() == genero && x.getEmail().equals(correoMod)){
                System.out.print("Nuevo correo: ");
                x.setEmail(sca.nextLine());
                System.out.println("Email modificado");
            }
            else System.out.println("Autor no encontrado");
    }
}
