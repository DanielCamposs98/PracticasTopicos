package SinHilos;


public class CreadorSubproceso {
    
    public static void main(String[]a){
      
        new TareaImprimir("Tarea1");
        new TareaImprimir("Tarea 2");
        
        System.out.println("Subprocesos creados, iniciando tareas.");
        
       
        System.out.println("Tareas iniciadas. Main termina.");
    }
}
