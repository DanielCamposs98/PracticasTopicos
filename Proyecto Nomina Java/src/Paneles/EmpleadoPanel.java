package Paneles;

import Botones.BtnCancelar;
import ManejadoresEventos.EmpleadoEventos;
import Colecciones.HashTEmpleado;
import ClasesBase.Departamento;
import Colecciones.ArrayLDepartamentos;
import TextFields.JEnterosField;
import TextFields.JFloatField;
import TextFields.JLetrasField;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.util.ArrayList;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JComboBox;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.SwingConstants;

public class EmpleadoPanel extends JDialog {

    private JLetrasField txtNombre, txtApPat, txtApMat; 
    private JEnterosField  txtClave;
    private JFloatField txtSueldo;
    private JTextField txtDomicilio;
    private JLabel lblNombre, lblApPat, lblApMat, lblDomicilio, lblSueldo, lblClave;
    private JComboBox cmbDepartamentos;
    private HashTEmpleado tablaEmpleado;
    private JButton btnGuardar, btnLimpiar;
    private BtnCancelar btnCancelar;
    private JCheckBox chkEncargado;
    private ArrayLDepartamentos arrDeptos;

    public EmpleadoPanel(JFrame m, HashTEmpleado tablaEmpleado, ArrayLDepartamentos arrDeptos) {
        super(m, "Registro Empleados", true);
        this.tablaEmpleado = tablaEmpleado;
        this.arrDeptos = arrDeptos;
        EmpleadoEventos manejaE= new EmpleadoEventos(this, tablaEmpleado, arrDeptos);
        setLayout(new FlowLayout(SwingConstants.CENTER, 10, 15));

        lblClave = new JLabel("Clave :                  ");
        add(lblClave);
        txtClave = new JEnterosField(10,4);
        add(txtClave);
        revalidate();
        lblNombre = new JLabel("Nombre:                ");
        add(lblNombre);
        txtNombre = new JLetrasField(20, 10);
        add(txtNombre);
        lblApPat = new JLabel("Apellido Paterno:");
        add(lblApPat);
        txtApPat = new JLetrasField(15,10);
        add(txtApPat);

        lblApMat = new JLabel("Apellido Materno:");
        add(lblApMat);
        txtApMat = new JLetrasField(15,10);
        add(txtApMat);

        lblDomicilio = new JLabel("Domicilio:            ");
        add(lblDomicilio);
        txtDomicilio = new JTextField(31);
        add(txtDomicilio);
        
        lblSueldo = new JLabel("Sueldo Diario:    ");
        add(lblSueldo);
        txtSueldo = new JFloatField(7);
        add(txtSueldo);

        cmbDepartamentos = new JComboBox();
        add(new JLabel("Departamentos"));
        ArrayList<Departamento> departamentos = arrDeptos.getArrDeptos();
        for (int i = 0; i < arrDeptos.getSize(); i++) {
            cmbDepartamentos.addItem(departamentos.get(i));
        }
        
         cmbDepartamentos.setMinimumSize(new Dimension(40, 15));
        cmbDepartamentos.setPreferredSize(new Dimension(80,25));
        add(cmbDepartamentos);

        chkEncargado = new JCheckBox("Encargado");
        add(chkEncargado);
        add(new JLabel("      "));
        add(new JLabel("                    "));
        btnGuardar = new JButton("Guardar");
        add(btnGuardar);

        btnLimpiar = new JButton("Limpiar");
        add(btnLimpiar);

        btnCancelar = new BtnCancelar(this,"Cancelar");
        add(btnCancelar);

        txtDomicilio.addKeyListener(new KeyAdapter(){
            public void keyTyped(KeyEvent e) {
                char c = e.getKeyChar();
                if (Character.isLowerCase(c)) {
                    e.setKeyChar(Character.toUpperCase(c));
                }
        } 
        });
        txtDomicilio.setTransferHandler(null);
        btnGuardar.addActionListener(manejaE);
        btnLimpiar.addActionListener(new ManejadorBtnLimpiar(this));
        
        
        setSize(500, 250);
        setLocationRelativeTo(null);
        setVisible(true);
    }

    public JCheckBox getChkEncargado() {
        return chkEncargado;
    }

    public JLetrasField getTxtNombre() {
        return txtNombre;
    }

    public JLetrasField getTxtApPat() {
        return txtApPat;
    }

    public JLetrasField getTxtApMat() {
        return txtApMat;
    }

    public JTextField getTxtDomicilio() {
        return txtDomicilio;
    }

    public JFloatField getTxtSueldo() {
        return txtSueldo;
    }

    public JEnterosField getTxtClave() {
        return txtClave;
    }

    public JLabel getLblNombre() {
        return lblNombre;
    }

    public JLabel getLblApPat() {
        return lblApPat;
    }

    public JLabel getLblApMat() {
        return lblApMat;
    }

    public ArrayLDepartamentos getArrDeptos() {
        return arrDeptos;
    }

    public JLabel getLblDomicilio() {
        return lblDomicilio;
    }

    public JLabel getLblSueldo() {
        return lblSueldo;
    }

    public JLabel getLblClave() {
        return lblClave;
    }

    public JComboBox getCmbDepartamentos() {
        return cmbDepartamentos;
    }

    public HashTEmpleado getTablaEmpleado() {
        return tablaEmpleado;
    }

    public JButton getBtnGuardar() {
        return btnGuardar;
    }

    public JButton getBtnLimpiar() {
        return btnLimpiar;
    }

    public BtnCancelar getBtnCancelar() {
        return btnCancelar;
    }

     private class ManejadorBtnLimpiar implements ActionListener {

        private EmpleadoPanel ventana;

        ManejadorBtnLimpiar(EmpleadoPanel el) {
          this.ventana=el;
        }

        @Override
        public void actionPerformed(ActionEvent e) {
            if (e.getSource() == ventana.getBtnLimpiar()) {
                limpiar();
            }
        }
    
    public void limpiar() {
        ventana.getTxtClave().setText("");
        ventana.getTxtNombre().setText("");
        ventana.getTxtApPat().setText("");
        ventana.getTxtApMat().setText("");
        ventana.getTxtDomicilio().setText("");
        ventana.getTxtSueldo().setText("");
        ventana.getChkEncargado().setSelected(false);
    }
    }
}
