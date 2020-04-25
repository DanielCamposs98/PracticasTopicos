package ManejadoresEventos;

import ClasesBase.Empleado;
import Colecciones.ArrayLDepartamentos;
import Colecciones.ArrayLDias;
import Colecciones.HashTEmpleado;
import Paneles.EliminarEmpleado;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JOptionPane;

public class EliminarEmpEventos implements ActionListener {

    private EliminarEmpleado ventana;
    private ArrayLDepartamentos departamentos;
    private HashTEmpleado tabla;
    private ArrayLDias arrD;

    public EliminarEmpEventos(Paneles.EliminarEmpleado f, Colecciones.ArrayLDepartamentos dep, Colecciones.HashTEmpleado t, ArrayLDias arrD) {
        ventana = f;
        departamentos = dep;
        tabla = t;
        this.arrD = arrD;
    }

    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == ventana.getBtnAceptar()) {
            if (validarCampos()) {
                eliminar();
            }
        }
        if (e.getSource() == ventana.getBtnCancelar()) {
            ventana.dispose();
        }
    }

    public void limpiar() {
        ventana.getTxtClave().setText("");
    }

    public void eliminar() {
        Integer clave = Integer.parseInt(ventana.getTxtClave().getText());
        if (arrD.getStatusDias(clave)) {
            limpiar();
            JOptionPane.showMessageDialog(null, "El empleado tiene dias laborados. Imposible eliminarlo.", "Advertencia", JOptionPane.ERROR_MESSAGE);
        } else {
            Empleado emp = (Empleado) tabla.getTabla().get(clave);

            for (int i = 0; i < departamentos.getSize(); i++) {

                if (departamentos.getArrDeptos().get(i).getEncargadoDepto() != null) {
                    if (departamentos.getArrDeptos().get(i).getEncargadoDepto().getClaveEmp() == emp.getClaveEmp()) {
                        departamentos.getArrDeptos().get(i).setEncargadoDepto(null);
                        break;
                    }
                }
            }
            tabla.getTabla().remove(clave);
            limpiar();
            JOptionPane.showMessageDialog(null, "Se ha eliminado el empleado correctamente", "Aviso", JOptionPane.INFORMATION_MESSAGE);
        }
    }

    public boolean validarCampos() {
        String clave = ventana.getTxtClave().getText();
        if (clave.length() == 0) {
            JOptionPane.showMessageDialog(null, "No pueden quedar campos en blanco", "Advertencia", JOptionPane.ERROR_MESSAGE);
            return false;
        }
        return true;
    }
}
