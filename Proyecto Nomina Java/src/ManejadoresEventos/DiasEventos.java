package ManejadoresEventos;

import Colecciones.ArrayLDias;
import Colecciones.HashTEmpleado;
import Paneles.DiasPanel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import javax.swing.JOptionPane;

public class DiasEventos  implements ActionListener {

    private DiasPanel ventana;
    private ArrayLDias arrDias;
    private HashTEmpleado tablaEmpleados;

    public DiasEventos(DiasPanel ventana, ArrayLDias arrDias, HashTEmpleado tablaEmpleados) {
        this.ventana = ventana;
        this.arrDias = arrDias;
        this.tablaEmpleados = tablaEmpleados;

    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == ventana.getBtnAceptar()) {
            if (validaDatos()) {
                Integer id = Integer.parseInt(ventana.getTxtNumEmp().getText());
                Integer dias = Integer.parseInt(ventana.getTxtDiasLab().getText());
                if (tablaEmpleados.contieneClave(id)) {
                    if (arrDias.getArrDias().isEmpty()) {
                        arrDias.agregarRegistroDias(id, dias);
                        limpiar();
                        JOptionPane.showMessageDialog(null, "Se han añadido " + dias + " dias al empleado " + id);
                    } else {
                        boolean bandera = false;
                        for (int i = 0; i < arrDias.getArrDias().size(); i++) {
                            if (id == arrDias.getArrDias().get(i).getClaveEmpleado()) {
                                int auxdias = arrDias.getArrDias().get(i).getDias();
                                if ((auxdias + dias) > 15) {
                                    JOptionPane.showMessageDialog(null, "Un empledo no debe tener más de 15 días laborados.\n Empleado: " + id + " tiene " + auxdias + " dias laborado(s).","Error",JOptionPane.ERROR_MESSAGE);
                                    ventana.getTxtDiasLab().setText(null);
                                    bandera = true;
                                    limpiar();
                                    break;
                                }

                                arrDias.getArrDias().remove(i);
                                arrDias.agregarRegistroDias(id, dias + auxdias);
                                JOptionPane.showMessageDialog(null, "Se han añadido " + dias + " dias al empleado " + id + ". Total de días: " + (dias + auxdias),"Aviso",JOptionPane.INFORMATION_MESSAGE);
                                bandera = true;
                                limpiar();
                                break;
                            }
                        }
                        if (bandera == false) {
                            arrDias.agregarRegistroDias(id, dias);
                            JOptionPane.showMessageDialog(null, "Se han añadido " + dias + " dias al empleado " + id + ". Total de dias: " + dias,"Aviso",JOptionPane.INFORMATION_MESSAGE);
                            limpiar();
                        }
                    }
                } else {
                    JOptionPane.showMessageDialog(null, "ID inexistente.", "Error", JOptionPane.ERROR_MESSAGE);
                    limpiar();
                }
            }
        }
        if (e.getSource() == ventana.getBtnLimpiar()) {
            limpiar();
        }
    }

    private boolean validaDatos() {
        if (ventana.getTxtDiasLab().getText() == null || ventana.getTxtNumEmp().getText() == null) {
            JOptionPane.showMessageDialog(null, "ID Empleado y Dias Laborados no deben estar vacíos.", "ERROR", JOptionPane.ERROR_MESSAGE);
            return false;
        }
        if (Integer.parseInt(ventana.getTxtDiasLab().getText()) > 15) {
            JOptionPane.showMessageDialog(null, "Un empleado no puede tener más de 15 días laborados..", "ERROR", JOptionPane.ERROR_MESSAGE);
           ventana.getTxtDiasLab().setText("");
            return false;
        }
        return true;
    }

    public void limpiar() {
        ventana.getTxtDiasLab().setText("");
        ventana.getTxtNumEmp().setText("");
    }
}
