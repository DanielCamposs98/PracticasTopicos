package Colecciones;

import Colecciones.ArrayLDias;
import ClasesBase.*;
import java.util.ArrayList;
import java.util.Enumeration;

public class ArrayLNomina {

    private ArrayList<Nomina> arrayNomina = new ArrayList<>();

    private ArrayLDias arrDias;
    private HashTEmpleado htEmp;

    public ArrayLNomina(ArrayLDias arrDias, HashTEmpleado htEmp) {
        this.arrDias = arrDias;
        this.htEmp = htEmp;
    }

    public ArrayList<Nomina> getArrayNomina() {
        return arrayNomina;
    }
   
    public void borraNomina() {
        arrayNomina.clear();
    }

    public boolean vacia() {
        if (arrayNomina.isEmpty()) {
            return true;
        }
        return false;
    }

    public int getSize() {
        return arrayNomina.size();
    }

    public void obtenerEmpleados() {
        Enumeration<Integer> e = htEmp.getTabla().keys();

        while (e.hasMoreElements()) {
            Integer f = e.nextElement();
            Empleado emp = (Empleado) htEmp.getTabla().get(f);
            Nomina n = new Nomina(f, getDiasEmp(f), emp.getSueldoDiario(), emp.getBonoExtra());
            agregarEmpleado(n);
        }
    }

    public Object[][] getDatos() {
        obtenerEmpleados();
        Object[][] datos = new Object[arrayNomina.size()][5];
        for (int i = 0; i < arrayNomina.size(); i++) {
            datos[i][0] = arrayNomina.get(i).getIdEmpleado();
            datos[i][1] = arrayNomina.get(i).getDiasLaborados();
            datos[i][2] = arrayNomina.get(i).getSueldoD();
            datos[i][3] = arrayNomina.get(i).getBonoEx();
            datos[i][4] = arrayNomina.get(i).getTotal();
        }
        return datos;
    }

    public float getTotalNomina() {
        float total = 0;
        for (int i = 0; i < arrayNomina.size(); i++) {
            total += arrayNomina.get(i).getTotal();
        }
        return total;
    }

    public int getDiasEmp(int id) {
        for (int i = 0; i < arrDias.getArrDias().size(); i++) {
            if (arrDias.getArrDias().get(i).getClaveEmpleado() == id) {
                return arrDias.getArrDias().get(i).getDias();
            }
        }
        return 0;
    }

    public void agregarEmpleado(Nomina n) {
        arrayNomina.add(n);
    }

}
