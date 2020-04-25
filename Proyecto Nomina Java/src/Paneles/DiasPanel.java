package Paneles;

import Botones.BtnCancelar;
import ManejadoresEventos.DiasEventos;
import Colecciones.ArrayLDias;
import Colecciones.HashTEmpleado;
import TextFields.JEnterosField;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class DiasPanel extends JDialog {

    private JLabel lblNumEmp, lblDiasLab;
    private JEnterosField txtNumEmp, txtDiasLab;
    private JButton btnAceptar, btnLimpiar;
    private BtnCancelar btnCancelar;

    private ArrayLDias arrDias;

    public DiasPanel(JFrame frame, ArrayLDias arrDias, HashTEmpleado tablaEmpleado) {
        super(frame, "Registro de Dias", true);
        setLayout(new FlowLayout(FlowLayout.CENTER, 5, 8));
        this.arrDias = arrDias;
        DiasEventos manejador = new DiasEventos(this, arrDias, tablaEmpleado);
        lblNumEmp = new JLabel("ID Empleado:       ");
        txtNumEmp = new JEnterosField(12, 4);
        lblDiasLab = new JLabel("Días Laborados:");
        txtDiasLab = new JEnterosField(12, 2);
        btnAceptar = new JButton("Aceptar");
        btnLimpiar = new JButton("Limpiar");
        btnCancelar = new BtnCancelar(this, "Cancelar");
        add(lblNumEmp);
        add(txtNumEmp);
        add(lblDiasLab);
        add(txtDiasLab);
        add(btnAceptar);
        add(btnLimpiar);
        add(btnCancelar);
        btnAceptar.addActionListener(manejador);
        btnLimpiar.addActionListener(new ManejadorBtnLimpiar(this));
        setSize(300, 150);
        setLocationRelativeTo(null);

        setVisible(true);
        ;

    }

    public JLabel getLblNumEmp() {
        return lblNumEmp;
    }

    public JLabel getLblDiasLab() {
        return lblDiasLab;
    }

    public JEnterosField getTxtNumEmp() {
        return txtNumEmp;
    }

    public JEnterosField getTxtDiasLab() {
        return txtDiasLab;
    }

    public JButton getBtnAceptar() {
        return btnAceptar;
    }

    public JButton getBtnLimpiar() {
        return btnLimpiar;
    }

    private class ManejadorBtnLimpiar implements ActionListener {

        private DiasPanel ventana;

        ManejadorBtnLimpiar(DiasPanel el) {
            this.ventana = el;
        }

        @Override
        public void actionPerformed(ActionEvent e) {
            if (e.getSource() == ventana.getBtnLimpiar()) {
                limpiar();
            }
        }

        public void limpiar() {
            ventana.getTxtNumEmp().setText("");
            ventana.getTxtDiasLab().setText("");
        }
    }
}
