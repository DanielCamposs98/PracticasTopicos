package ManejadoresEventos;

import Paneles.ModificaEmpleado;
import Paneles.BonoExtraPanel;
import ClasesBase.Empleado;
import Colecciones.HashTEmpleado;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JOptionPane;

public class BonoExtraEventos implements ActionListener {

    private BonoExtraPanel bono;
    
    private HashTEmpleado tablaEmpleados;

    public BonoExtraEventos(BonoExtraPanel bonoExtra, HashTEmpleado tablaEmpleados, ModificaEmpleado mod) {
        bono = bonoExtra;
        this.tablaEmpleados = tablaEmpleados;
        
    }

    public void actionPerformed(ActionEvent e) {

        if (e.getSource() == bono.getBtnAceptar()) {
            if (validarCampos()) {
                AgregarBono(Integer.parseInt(bono.getTxtNoEmpleado().getText()));
            } else {
                return;
            }
        }
        if(e.getSource()==bono.getBtnLimpiar()){
            limpiar();
        }
    }

    public void AgregarBono(int c) {
        int clave = c;
        Empleado empleado = (Empleado) tablaEmpleados.getTabla().get(clave);
        if (!tablaEmpleados.contieneClave(clave)) {
            JOptionPane.showMessageDialog(null, "Clave no existente, por favor inserte otra.", "Advertencia", JOptionPane.ERROR_MESSAGE);
            limpiar();
        } else {
            if (empleado.getBonoExtra() != 0) {
                JOptionPane.showMessageDialog(null, "Este empleado ya tiene asignado un bono", "Advertencia", JOptionPane.INFORMATION_MESSAGE);
                limpiar();
            } else {
                empleado.setBonoExtra(Integer.parseInt(bono.getTxtBono().getText()));
                JOptionPane.showMessageDialog(null, "Bono Agregado", "AVISO", JOptionPane.INFORMATION_MESSAGE);
                limpiar();
            }
        }
    }

    public boolean validarCampos() {
        String numEmp = bono.getTxtNoEmpleado().getText();
        String b = bono.getTxtBono().getText();
        if (numEmp.length() == 0 || b.length() == 0) {
            JOptionPane.showMessageDialog(null, "No pueden quedar campos en blanco", "Advertencia", JOptionPane.ERROR_MESSAGE);
            return false;
        }
        if (Integer.parseInt(b) == 0) {
            JOptionPane.showMessageDialog(null, "Días laborados debe ser mayor de 0", "Error", JOptionPane.ERROR_MESSAGE);
            return false;
        }
        return true;
    }

    private void limpiar() {
        bono.getTxtNoEmpleado().setText("");
        bono.getTxtBono().setText("");
    }
}
