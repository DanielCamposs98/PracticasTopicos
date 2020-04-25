package Colecciones;

import ClasesBase.Departamento;
import ClasesBase.Empleado;
import java.util.ArrayList;
import java.util.Enumeration;
import java.util.Hashtable;
import java.util.Iterator;
import java.util.Set;

public class HashTEmpleado {

    private Hashtable<Integer, Empleado> tabla = new Hashtable<>();

    public void agregarEmpleado(int claveEmp, Empleado emp) {
        tabla.put(claveEmp, emp);
    }

    public boolean contieneClave(int clave) {
        if (tabla.containsKey(clave)) {
            return true;
        }
        return false;
    }

    public Object[][] ObtenerDatos() {
        Object datos[][] = new Object[tabla.size()][8];
        int con = 0;
        Enumeration<Integer> e = tabla.keys();
        while (e.hasMoreElements()) {
            Integer f = e.nextElement();
            Empleado emp = tabla.get(f);
            datos[con][0] = emp.getClaveEmp();
            datos[con][1] = emp.getNombre();
            datos[con][2] = emp.getApPat();
            datos[con][3] = emp.getApMat();
            datos[con][4] = emp.getDomicilio();
            datos[con][5] = emp.getDepto();
            datos[con][6] = emp.getSueldoDiario();
            datos[con][7] = emp.getBonoExtra();
            con++;
        }
        return datos;
    }

    public Object[][] ObtenerDatosDepto(Departamento d) {
        ArrayList<Empleado> empleados = new ArrayList<Empleado>();
        Enumeration<Integer> e = tabla.keys();

        while (e.hasMoreElements()) {
            Integer f = e.nextElement();
            Empleado emp = (Empleado) tabla.get(f);
            if (d.getNombreDepto() == emp.getDepto().getNombreDepto()) {
                empleados.add(emp);
            }
        }

        if (empleados.size() == 0) {
            return new Object[0][0];
        }

        Object datos[][] = new Object[empleados.size()][8];
        for (int i = 0; i < empleados.size(); i++) {
            datos[i][0] = empleados.get(i).getClaveEmp();
            datos[i][1] = empleados.get(i).getNombre();
            datos[i][2] = empleados.get(i).getApPat();
            datos[i][3] = empleados.get(i).getApMat();
            datos[i][4] = empleados.get(i).getDomicilio();
            datos[i][5] = empleados.get(i).getDepto();
            datos[i][6] = empleados.get(i).getSueldoDiario();
            datos[i][7] = empleados.get(i).getBonoExtra();
        }
        return datos;
    }

    public int getTamaño() {
        return tabla.size();
    }

    public Hashtable getTabla() {
        return tabla;
    }

    public void reiniciaBonos() {
        Enumeration<Integer> e = tabla.keys();
        while (e.hasMoreElements()) {
            Integer f = e.nextElement();
            Empleado emp = tabla.get(f);
            emp.setBonoExtra(0);
        }
    }

    public boolean vacia() {
        if (tabla.isEmpty()) {
            return true;
        }
        return false;
    }

    public Object[][] ObtenerDatosBonos() {
        Object[][] datos = new Object[getTamaño()][6];
        int cont = 0;

        Set<Integer> set = tabla.keySet();
        Iterator it = set.iterator();
        while (it.hasNext()) {

            Empleado emp = (Empleado) tabla.get(it.next());
            datos[cont][0] = emp.getClaveEmp();
            datos[cont][1] = emp.getNombre();
            datos[cont][2] = emp.getApPat();
            datos[cont][3] = emp.getApMat();
            datos[cont][4] = emp.getDepto();
            datos[cont][5] = emp.getBonoExtra();
            cont++;
        }
        return datos;
    }

    public Empleado[] obtenerDatosEmpleados() {
        Empleado[] arr = new Empleado[tabla.size()];
        Set<Integer> set = tabla.keySet();
        int cont = 0;
        Iterator it = set.iterator();
        while (it.hasNext()) {

            Empleado emp = (Empleado) tabla.get(it.next());
            arr[cont] = emp;
            cont++;
        }
        return arr;
    }

    public boolean contieneEmpleadosDepto(Departamento depto) {
        boolean est = false;
        if (vacia()) {
            return est;
        } else {
            Set<Integer> set = tabla.keySet();
            Iterator it = set.iterator();
            while (it.hasNext()) {

                Empleado emp = (Empleado) tabla.get(it.next());

                if (emp.getDepto().getNombreDepto().equalsIgnoreCase(depto.getNombreDepto())) {
                    est = true;
                    break;
                }
            }
        }
        return est;
    }

}
