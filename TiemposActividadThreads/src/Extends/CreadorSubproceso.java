package Extends;

public class CreadorSubproceso {
    
    public static void main(String[]a){
        
        
        System.out.println("\t\t\t\t\tHilo con Extends Thread\t\t\t\t\t\nCreación de Subprocesos.");
       
      
        TareaImprimir sub1= new TareaImprimir("Tarea 1");
        TareaImprimir sub2= new TareaImprimir("Tarea 2");
        TareaImprimir sub3= new TareaImprimir("Tarea 3");
        
        System.out.println("Subprocesos creados, iniciando tareas.");
        
        sub1.start();
        sub2.start();
        sub3.start();
        System.out.println("Tareas iniciadas. Main termina.");
    }
}
