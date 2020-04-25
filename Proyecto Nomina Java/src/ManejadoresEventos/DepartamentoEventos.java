package ManejadoresEventos;

import ClasesBase.Departamento;
import Colecciones.ArrayLDepartamentos;
import Paneles.DepartamentoPanel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JOptionPane;

public class DepartamentoEventos implements ActionListener {

    private DepartamentoPanel dpto;
    private ArrayLDepartamentos arrDeptos;

    public DepartamentoEventos(DepartamentoPanel dpto, ArrayLDepartamentos arrDeptos) {
        this.dpto = dpto;
        this.arrDeptos = arrDeptos;
    }

    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == dpto.getBtnAceptar()) {
            if (validarCampos()) {
                agregarDepartamento();
                return;
            }
        }
        if (e.getSource() == dpto.getBtnCancelar()) {
            dpto.dispose();
        }
        if (e.getSource() == dpto.getBtnLimpiar()) {
            limpiar();
        }
    }

    public void agregarDepartamento() {
        int clave = Integer.parseInt(dpto.getTxtClaveDep().getText());
        String nombre = dpto.getTxtNombre().getText();
        if (arrDeptos.contieneClave(clave)) {
            JOptionPane.showMessageDialog(null, "Clave existente, por favor inserte otra.", "Advertencia", JOptionPane.ERROR_MESSAGE);
            dpto.getTxtClaveDep().setText(null);
            return;
        }
        if (arrDeptos.contieneNombre(nombre)) {
            JOptionPane.showMessageDialog(null, "Ese nombre de departamento ya está asignado. Inserte otro.", "Advertencia", JOptionPane.ERROR_MESSAGE);
            dpto.getTxtNombre().setText(null);
            return;
        }
        Departamento dep = new Departamento(clave, nombre, null);
        arrDeptos.registraDepartamento(dep);
        JOptionPane.showMessageDialog(null, "Registrado con exito", "Registro", JOptionPane.INFORMATION_MESSAGE);
        limpiar();
    }


public void limpiar() {
        dpto.getTxtClaveDep().setText(null);
        dpto.getTxtNombre().setText(null);
    }

    public boolean validarCampos() {
        String nombre = dpto.getTxtNombre().getText();
        String clave = dpto.getTxtClaveDep().getText();
        if (nombre.length() == 0 || clave.length() == 0) {
            JOptionPane.showMessageDialog(null, "No pueden quedar campos en blanco", "Advertencia", JOptionPane.ERROR_MESSAGE);
            return false;
        }
        return true;
    }


}
