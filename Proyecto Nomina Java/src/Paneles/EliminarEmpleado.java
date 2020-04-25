package Paneles;

import Botones.BtnCancelar;
import java.awt.FlowLayout;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JDialog;
import javax.swing.JFrame;
import Colecciones.*;
import ManejadoresEventos.*;
import TextFields.JEnterosField;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class EliminarEmpleado extends JDialog {

    private ArrayLDepartamentos departamentos;
    private HashTEmpleado tablaEmpleados;
    private JButton btnAceptar,btnLimpiar;
    private BtnCancelar btnCancelar;
    private JLabel lblClave;
    private JEnterosField txtClave;

    public EliminarEmpleado(JFrame frame, HashTEmpleado tabla, ArrayLDepartamentos dep, ArrayLDias arrD) {
        super(frame, "Eliminar Empleado", true);
        setLayout(new FlowLayout());
        departamentos = dep;
        tablaEmpleados = tabla;
        EliminarEmpEventos manejador = new EliminarEmpEventos(this, dep, tabla,arrD);
        lblClave = new JLabel("N° Empleado:     ");
        add(lblClave);
        txtClave = new JEnterosField(12,4);
        txtClave.setColumns(10);
        add(txtClave);
//        add(new JLabel("\n"));
        btnAceptar = new JButton("Eliminar");
        add(btnAceptar);
        btnLimpiar = new JButton("Limpiar");
        add(btnLimpiar);
        btnCancelar = new BtnCancelar(this,"Cancelar");
        add(btnCancelar);

        btnAceptar.addActionListener(manejador);
        btnLimpiar.addActionListener(new ManejadorBtnLimpiar(this));

        setSize(250, 130);
        setLocationRelativeTo(null);
        setResizable(false);
        setVisible(true);

    }

    public ArrayLDepartamentos getDepartamentos() {
        return departamentos;
    }

    public void setDepartamentos(ArrayLDepartamentos departamentos) {
        this.departamentos = departamentos;
    }

    public HashTEmpleado getTablaEmpleados() {
        return tablaEmpleados;
    }

    public void setTablaEmpleados(HashTEmpleado tablaEmpleados) {
        this.tablaEmpleados = tablaEmpleados;
    }

    public JButton getBtnAceptar() {
        return btnAceptar;
    }

    public void setBtnAceptar(JButton btnAceptar) {
        this.btnAceptar = btnAceptar;
    }

    public BtnCancelar getBtnCancelar() {
        return btnCancelar;
    }
    
    public JButton getBtnLimpiar() {
        return btnLimpiar;
    }
    public JLabel getLblClave() {
        return lblClave;
    }
    
    public JEnterosField getTxtClave() {
        return txtClave;
    }


    private class ManejadorBtnLimpiar implements ActionListener {

        private EliminarEmpleado ventana;

        ManejadorBtnLimpiar(EliminarEmpleado el) {
          this.ventana=el;
        }

        @Override
        public void actionPerformed(ActionEvent e) {
            if (e.getSource() == ventana.getBtnLimpiar()) {
                limpiar();
            }
        }
    
    public void limpiar() {
        ventana.getTxtClave().setText(null);
    }
    }
}
