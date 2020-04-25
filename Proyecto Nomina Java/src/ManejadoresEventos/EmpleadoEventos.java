package ManejadoresEventos;

import Colecciones.HashTEmpleado;
import ClasesBase.Empleado;
import ClasesBase.Departamento;
import Colecciones.ArrayLDepartamentos;
import Paneles.EmpleadoPanel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JOptionPane;

public class EmpleadoEventos implements ActionListener {

     private HashTEmpleado tablaEmpleados;
    private  EmpleadoPanel ventana;
     private ArrayLDepartamentos arrDeptos;

    public EmpleadoEventos(EmpleadoPanel ventana, HashTEmpleado tablaEmpleados, ArrayLDepartamentos arrDeptos) {
        this.ventana = ventana;
        this.tablaEmpleados = tablaEmpleados;
        this.arrDeptos = arrDeptos;
    }

    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == ventana.getBtnGuardar()) {
            if (validarCampos()) {
                if (!ventana.getChkEncargado().isSelected()) {
                    agregarEmpleado();
                 
                    } else {
                       if (validarEncargado()) {
                        agregarEmpleado();
                       
                       }
            }
        }
        }
        if (e.getSource() == ventana.getBtnCancelar()) {
            ventana.dispose();
        }
    }
 

    public void agregarEmpleado() {
        if (!validarCampos()) {
            return;
        } else {
            int clave = Integer.parseInt(ventana.getTxtClave().getText());
            String nombre = ventana.getTxtNombre().getText().toUpperCase();
            String apPat = ventana.getTxtApPat().getText().toUpperCase();
            String apMat = ventana.getTxtApMat().getText().toUpperCase();
            String domicilio = ventana.getTxtDomicilio().getText().toUpperCase();
            float sueldo = Float.parseFloat(ventana.getTxtSueldo().getText());
            Departamento dep = (Departamento) ventana.getCmbDepartamentos().getSelectedItem();

            if (tablaEmpleados.contieneClave(Integer.parseInt(ventana.getTxtClave().getText()))) {
                JOptionPane.showMessageDialog(null, "Clave existente, por favor inserte otra", "Advertencia", JOptionPane.ERROR_MESSAGE);
                ventana.getTxtClave().setText(null);
            } else {
                Empleado emp = new Empleado(clave, nombre, apPat, apMat, domicilio, dep, sueldo, 0);
                tablaEmpleados.agregarEmpleado(clave, emp);
                limpiar();
                JOptionPane.showMessageDialog(null, "Empleado Añadido Correctamente", "Alta Empleado", JOptionPane.INFORMATION_MESSAGE);
            }
        }
    }

    public void limpiar() {
        ventana.getTxtNombre().setText(null);
        ventana.getTxtApPat().setText(null);
        ventana.getTxtApMat().setText(null);
        ventana.getTxtDomicilio().setText(null);
        ventana.getTxtSueldo().setText(null);
        ventana.getTxtClave().setText(null);
        ventana.getChkEncargado().setSelected(false);
    }

    public boolean validarEncargado() {
        int clave = Integer.parseInt(ventana.getTxtClave().getText());
        String nombre = ventana.getTxtNombre().getText().toUpperCase();
        String apPat = ventana.getTxtApPat().getText().toUpperCase();
        String apMat = ventana.getTxtApMat().getText().toUpperCase();
        String domicilio = ventana.getTxtDomicilio().getText().toUpperCase();
        float sueldo = Float.parseFloat(ventana.getTxtSueldo().getText());
        Departamento dep = (Departamento) ventana.getCmbDepartamentos().getSelectedItem();

        if (!dep.getEncargadoDeptoString().equalsIgnoreCase("Indefinido")) {
            JOptionPane.showMessageDialog(null, "Este departamento ya tiene encargado, por favor seleccione otro, o desmarque la opcion", "Advertencia", JOptionPane.ERROR_MESSAGE);
            ventana.getChkEncargado().setSelected(false);
            return false;
        } else {
            Empleado encargado = new Empleado(clave, nombre, apPat, apMat, domicilio, dep, sueldo, 0);
            for (int i = 0; i < arrDeptos.getSize(); i++) {
                Departamento depto = (Departamento) arrDeptos.getDepartamento(i);
                if (depto.getClaveDepto() == dep.getClaveDepto()) {
                    depto.setEncargadoDepto(encargado);
                    break;
                }
            }
            arrDeptos.removerDepartamento(dep.getClaveDepto());
            arrDeptos.registraDepartamento(new Departamento(dep.getClaveDepto(), dep.getNombreDepto(), encargado));
        }
        return true;
    }

    public boolean validarCampos() {
        String clave = ventana.getTxtClave().getText();
        String nombre = ventana.getTxtNombre().getText();
        String apPat = ventana.getTxtApPat().getText();
        String domicilio = ventana.getTxtDomicilio().getText();
        String sueldo = ventana.getTxtSueldo().getText();

        if (nombre.length() == 0 || apPat.length() == 0 || domicilio.length() == 0 || sueldo.length() == 0 || clave.length() == 0) {
            JOptionPane.showMessageDialog(null, "No pueden quedar campos en blanco", "Advertencia", JOptionPane.ERROR_MESSAGE);
            return false;
        }
        return true;
    }

 

}
