package Paneles;

import Botones.BtnCancelar;
import Colecciones.ArrayLDias;
import Colecciones.HashTEmpleado;
import ManejadoresEventos.ModificaEmpleadoEventos;
import TextFields.JEnterosField;
import TextFields.JFloatField;
import java.awt.Dimension;
import java.awt.FlowLayout;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class ModificaEmpleado extends JDialog {

    private HashTEmpleado tablaEmpleados;
    private ArrayLDias arrDias;
    private JLabel lblEmpleado, lblDias, lblBono;
    private JComboBox cmbEmpleados;
    private JEnterosField txtDias;
    private JFloatField txtBonos;
    private JButton btnAgregarBono, btnAgregarDias, btnLimpiar;
    private BtnCancelar btnCancelar;

    public ModificaEmpleado(JFrame f, HashTEmpleado ht, ArrayLDias arrD) {
        super(f, "Modifica Empleado", true);
        this.tablaEmpleados = ht;
        this.arrDias = arrD;
        setLayout(new FlowLayout());
        lblEmpleado = new JLabel("Empleado:    ");
        add(lblEmpleado);
        cmbEmpleados = new JComboBox(tablaEmpleados.obtenerDatosEmpleados());
        cmbEmpleados.setMinimumSize(new Dimension(65, 30));
        cmbEmpleados.setPreferredSize(new Dimension(200, 30));
        add(cmbEmpleados);

        lblDias = new JLabel("Dias Laborados:");
        add(lblDias);
        txtDias = new JEnterosField(12,2);
        add(txtDias);
        btnAgregarDias = new JButton("Agregar Dias");
        add(btnAgregarDias);
        lblBono = new JLabel("Bono asignado: ");
        add(lblBono);
        txtBonos = new JFloatField(12);
        add(txtBonos);
        btnAgregarBono = new JButton("Agregar Bono");
        add(btnAgregarBono);
        btnCancelar = new BtnCancelar(this,"Cancelar");
        add(btnCancelar);
        btnLimpiar = new JButton("Limpiar");
        add(btnLimpiar);

        ModificaEmpleadoEventos manejaE = new ModificaEmpleadoEventos(this, arrDias, ht);
        btnAgregarBono.addActionListener(manejaE);
        btnAgregarDias.addActionListener(manejaE);
        btnLimpiar.addActionListener(manejaE);
        setSize(380, 170);
        setLocationRelativeTo(null);
        setResizable(false);
        setVisible(true);
    }

    public JButton getBtnAgregarBono() {
        return btnAgregarBono;
    }

    public JButton getBtnAgregarDias() {
        return btnAgregarDias;
    }

    public BtnCancelar getBtnCancelar() {
        return btnCancelar;
    }

    public JButton getBtnLimpiar() {
        return btnLimpiar;
    }

    public JComboBox getCmbEmpleados() {
        return cmbEmpleados;
    }

    public JFloatField getTxtBonos() {
        return txtBonos;
    }

    public JEnterosField getTxtDias() {
        return txtDias;
    }

}
