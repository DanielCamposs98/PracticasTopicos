package Implements;


public class CreadorSubproceso {
    
    public static void main(String[]a){
       System.out.println("\t\t\t\t\tHilo con Implements Runnable\t\t\t\t\t\nCreación de Subprocesos.");
       
        Thread sub1= new Thread(new TareaImprimir("Tarea 1"));
        Thread sub2= new Thread(new TareaImprimir("Tarea 2"));
        Thread sub3= new Thread(new TareaImprimir("Tarea 3"));
        
        System.out.println("Subprocesos creados, iniciando tareas.");
        
        sub1.start();
        sub2.start();
        sub3.start();
        System.out.println("Tareas iniciadas. Main termina.");
    }
}
