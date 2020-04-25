package Colecciones;

import ClasesBase.Departamento;
import java.util.ArrayList;

public class ArrayLDepartamentos {

    private ArrayList<Departamento> arrDeptos = new ArrayList<>();

    public void registraDepartamento(Departamento d) {
        arrDeptos.add(d);
    }

    public boolean vacia() {
        if (arrDeptos.isEmpty()) {
            return true;
        }
        return false;
    }

    public int getSize() {
        return arrDeptos.size();
    }

    public Object[][] ObtenerDatosDepto() {
        Object datos[][] = new Object[getSize()][2];
        for (int i = 0; i < getSize(); i++) {
            datos[i][0] = arrDeptos.get(i).getClaveDepto();
            datos[i][1] = arrDeptos.get(i).getNombreDepto();
        }
        return datos;
    }

    public Object[][] ObtenerDatos() {
        Object datos[][] = new Object[getSize()][3];
        for (int i = 0; i < getSize(); i++) {
            if (arrDeptos.get(i).getEncargadoDepto() != null) {
                datos[i][0] = arrDeptos.get(i).getClaveDepto();
                datos[i][1] = arrDeptos.get(i).getNombreDepto();
                datos[i][2] = arrDeptos.get(i).getEncargadoDepto();
            }
        }
        return datos;
    }

    public boolean contieneClave(int clave) {
        if (vacia()) {
            return false;
        } else {
            for (int i = 0; i < getSize(); i++) {
                if (arrDeptos.get(i).getClaveDepto() == clave) {
                    return true;
                }
            }
            return false;
        }
    }

    public boolean contieneNombre(String nom) {
        boolean est = false;
            for (int i = 0; i < getSize(); i++) {
                if (arrDeptos.get(i).getNombreDepto().equalsIgnoreCase(nom)) {
                    est = true;
                    break;
                }
            }
        
        return est;
    }

    public Departamento getDepartamento(int i) {
        return arrDeptos.get(i);
    }

    public void removerDepartamento(int id) {
        if (!vacia()) {
            for (int i = 0; i < getSize(); i++) {
                if (getDepartamento(i).getClaveDepto() == id) {
                    arrDeptos.remove(i);
                    break;
                }
            }
        }
    }

    public ArrayList<Departamento> getArrDeptos() {
        return arrDeptos;
    }

    public boolean contieneEncargados() {
        for (Departamento dep : arrDeptos) {
            if (!dep.getEncargadoDeptoString().equalsIgnoreCase("Indefinido")) {
                return true;
            }
        }
        return false;
    }

}
