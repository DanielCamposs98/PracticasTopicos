package Implements;


import java.util.Random;

public class TareaImprimir implements Runnable {

    private final int tiempoInactividad;
    private final String nombreTarea;
    private final static Random generador = new Random();

    public TareaImprimir(String nombre) {
        nombreTarea = nombre;
        tiempoInactividad = generador.nextInt(5000);
    }

    public void run() {
        try {
            System.out.printf("%s estará inactivo por %d milisegundos.\n", nombreTarea, tiempoInactividad);
            Thread.sleep(tiempoInactividad);
        } catch (InterruptedException ex) {
            System.out.printf("%s %s \n", nombreTarea, " terminó prematuramente, debido a la interrupción");

        }
        System.out.printf("%s terminó su inactividad\n", nombreTarea);
    }

}
