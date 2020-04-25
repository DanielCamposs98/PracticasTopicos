public class DemoPrioridadGet extends Thread {

    private String nombre;

    DemoPrioridadGet(String n) {
        nombre = n;
    }

    public void run() {
        System.out.println("Hilo " + nombre+" terminado.");
    }

    public static void main(String[] a) {
        DemoPrioridadGet t1 = new DemoPrioridadGet("Uriel");
        DemoPrioridadGet t2 = new DemoPrioridadGet("Daniel");
        DemoPrioridadGet t3 = new DemoPrioridadGet("Christopher");
        System.out.println("Prioridad del Hilo 1: " + t1.getPriority());
        System.out.println("Prioridad del Hilo 2: " + t2.getPriority());
        System.out.println("Prioridad del Hilo 3: " + t3.getPriority());

        t1.setPriority(2);
        t2.setPriority(3);
        t3.setPriority(8);
        t1.start();
        t2.start();
        t3.start();
        System.out.println("Prioridad del Hilo 1: " + t1.getPriority());
        System.out.println("Prioridad del Hilo 2: " + t2.getPriority());
        System.out.println("Prioridad del Hilo 3: " + t3.getPriority());

        System.out.println("Prioridad del Hilo Main: " + Thread.currentThread().getPriority());
        Thread.currentThread().setPriority(10); //Si se pone un numero 0, negativo o mayor a 10, lanzará un IllegalArgumentException
        System.out.println("Prioridad del Hilo Main: " + Thread.currentThread().getPriority());
    }
}
