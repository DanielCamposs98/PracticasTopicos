package ManejadoresEventos;

import Paneles.ModificaEmpleado;
import ClasesBase.Empleado;
import Colecciones.ArrayLDias;
import Colecciones.HashTEmpleado;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JOptionPane;

public class ModificaEmpleadoEventos implements ActionListener {

     private ModificaEmpleado ventana;
     private ArrayLDias arrDias;
     private HashTEmpleado tablaEmpleados;

    public ModificaEmpleadoEventos(ModificaEmpleado ventana, ArrayLDias arrDias, HashTEmpleado tabla) {
        this.ventana = ventana;
        this.arrDias = arrDias;
        this.tablaEmpleados = tabla;
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        Empleado emp = (Empleado) ventana.getCmbEmpleados().getSelectedItem();
        if (e.getSource() == ventana.getBtnAgregarBono()) {
                agregarBono(emp);
        }

        if (e.getSource() == ventana.getBtnAgregarDias()) {
            agregaDias(emp);
        }
        
        if(e.getSource()==ventana.getBtnLimpiar()){
            limpiar();
        }
    }

    private void agregarBono(Empleado emp) {
        if (validaDatosBonos(emp)) {
            if (emp.getBonoExtra() != 0) {
                JOptionPane.showMessageDialog(null, "Este empleado ya tiene asignado un bono", "Advertencia", JOptionPane.INFORMATION_MESSAGE);
                limpiar();
            } else {
                emp.setBonoExtra(Float.parseFloat(ventana.getTxtBonos().getText()));
                JOptionPane.showMessageDialog(null, "Bono Agregado", "AVISO", JOptionPane.INFORMATION_MESSAGE);
                limpiar();
            }
        } else {
            return;
        }
    }

    public void agregaDias(Empleado emp) {
        if (validaDatosDias()) {
            Integer id = emp.getClaveEmp();
            Integer dias = Integer.parseInt(ventana.getTxtDias().getText());

            if (arrDias.getArrDias().isEmpty()) {
                arrDias.agregarRegistroDias(id, dias);
                limpiar();
                JOptionPane.showMessageDialog(null, "Se han añadido " + dias + " dias al empleado " + id,"Aviso", JOptionPane.INFORMATION_MESSAGE);
            } else {
                boolean bandera = false;
                for (int i = 0; i < arrDias.getArrDias().size(); i++) {
                    if (id == arrDias.getArrDias().get(i).getClaveEmpleado()) {
                        int auxdias = arrDias.getArrDias().get(i).getDias();
                        if ((auxdias + dias) > 15) {
                            JOptionPane.showMessageDialog(null, "Un empledo no debe tener más de 15 días laborados.\n Empleado: " + id + " tiene " + auxdias + " dias laborado(s).","Aviso", JOptionPane.INFORMATION_MESSAGE);
                            ventana.getTxtDias().setText(null);
                            bandera = true;
                            limpiar();
                            break;
                        }

                        arrDias.getArrDias().remove(i);
                        arrDias.agregarRegistroDias(id, dias + auxdias);
                        JOptionPane.showMessageDialog(null, "Se han añadido " + dias + " dias al empleado " + id + ". Total de días: " + (dias + auxdias),"Aviso", JOptionPane.INFORMATION_MESSAGE);
                        bandera = true;
                        limpiar();
                        break;
                    }
                }
                if (bandera == false) {
                    arrDias.agregarRegistroDias(id, dias);
                    JOptionPane.showMessageDialog(null, "Se han añadido " + dias + " dias al empleado " + id + ". Total de dias: " + dias,"Aviso", JOptionPane.INFORMATION_MESSAGE);
                    limpiar();
                }
            }

        }
    }

    private boolean validaDatosBonos(Empleado emp) {
        String numEmp = String.valueOf(emp.getClaveEmp());
        String bono = ventana.getTxtBonos().getText();
        if (numEmp.length() == 0 || bono.length() == 0) {
            JOptionPane.showMessageDialog(null, "No pueden quedar campos en blanco", "Advertencia", JOptionPane.ERROR_MESSAGE);
            limpiar();
            return false;
        }
        if (Float.parseFloat(bono) == 0) {
            JOptionPane.showMessageDialog(null, "Días laborados debe ser mayor de 0","Error",JOptionPane.ERROR_MESSAGE);
            limpiar();
            return false;
        }
        return true;
    }

    private boolean validaDatosDias() {
        if (ventana.getTxtDias().getText() == "") {
            JOptionPane.showMessageDialog(null, " Dias Laborados no debe estar vacío.", "ERROR", JOptionPane.ERROR_MESSAGE);
            return false;
        }
        if (Integer.parseInt(ventana.getTxtDias().getText()) > 15) {
            JOptionPane.showMessageDialog(null, "Un empleado no puede tener más de 15 días laborados..", "ERROR", JOptionPane.ERROR_MESSAGE);
           limpiar();
            return false;
        }
        return true;
    }

    private void limpiar() {
        ventana.getCmbEmpleados().setSelectedIndex(0);
        ventana.getTxtBonos().setText("");
        ventana.getTxtDias().setText("");
    }

}
