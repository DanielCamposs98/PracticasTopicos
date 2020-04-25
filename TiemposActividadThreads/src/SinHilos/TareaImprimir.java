package SinHilos;

import java.util.Random;
import java.util.Timer;
import java.util.TimerTask;

public class TareaImprimir {

    private final int tiempoInactividad;
    private final String nombreTarea;
    private final static Random generador = new Random();

    TareaImprimir(String nombre) {
        nombreTarea = nombre;
        tiempoInactividad = generador.nextInt(100);
        Timer tm = new Timer();
                      System.out.println(nombreTarea + " se ejecutará por " + tiempoInactividad + " milisegundos.");
        TimerTask timer = new TimerTask() {
 
            @Override
            public void run() {
                System.out.println(nombreTarea);
                if (generador.nextInt(100) == tiempoInactividad) {
                    tm.cancel();
                    System.out.println(nombreTarea + " ha terminado.");
                }
            }
        };
        tm.schedule(timer,0,100);

    }

}
