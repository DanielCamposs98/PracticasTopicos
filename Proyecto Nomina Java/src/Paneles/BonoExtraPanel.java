package Paneles;

import Botones.BtnCancelar;
import ManejadoresEventos.BonoExtraEventos;
import Colecciones.HashTEmpleado;
import TextFields.JEnterosField;
import TextFields.JFloatField;
import java.awt.FlowLayout;
import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class BonoExtraPanel extends JDialog {

    private JLabel NoEmpleado, bono;
    private JButton btnAceptar,btnLimpiar;
    private BtnCancelar btnCancelar;
    
    private JEnterosField txtNoEmpleado;
    private JFloatField txtBono;
    private HashTEmpleado tablaEmpleados;

    public BonoExtraPanel(JFrame f, HashTEmpleado tablaEmpleados) {
        super(f, "Registro Bonos", true);
        this.tablaEmpleados = tablaEmpleados;
        setLayout(new FlowLayout());
        NoEmpleado = new JLabel("N° Empleado");
        txtNoEmpleado = new JEnterosField(6,4);
        bono = new JLabel("Cantidad a abonar:");
        txtBono = new JFloatField(6);
        btnAceptar = new JButton("Aceptar");
        btnCancelar= new BtnCancelar(this, "Cancelar");
        btnLimpiar= new JButton("Limpiar");
        add(NoEmpleado);
        add(txtNoEmpleado);
        add(bono);
        add(txtBono);
        add(btnAceptar);
        add(btnCancelar);
        add(btnLimpiar);
        
        BonoExtraEventos manejador = new BonoExtraEventos(this, tablaEmpleados, null);
        btnAceptar.addActionListener(manejador);
        btnLimpiar.addActionListener(manejador);
        setSize(250, 150);
        setLocationRelativeTo(null);
        setResizable(false);
        setVisible(true);

    }

    public JButton getBtnLimpiar() {
        return btnLimpiar;
    }

    public JLabel getNoEmpleado() {
        return NoEmpleado;
    }

    public JButton getBtnAceptar() {
        return btnAceptar;
    }

    public JEnterosField getTxtNoEmpleado() {
        return txtNoEmpleado;
    }

    public JLabel getBono() {
        return bono;
    }

    public JFloatField getTxtBono() {
        return txtBono;
    }

    public HashTEmpleado getTablaEmpleados() {
        return tablaEmpleados;
    }

}
