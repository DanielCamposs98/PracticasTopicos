package Paneles;

import Botones.BtnCancelar;
import ManejadoresEventos.DepartamentoEventos;
import Colecciones.ArrayLDepartamentos;
import TextFields.JEnterosField;
import TextFields.JLetrasField;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.SwingConstants;

public class DepartamentoPanel extends JDialog {

    private ArrayLDepartamentos arrDeptos;
    private JEnterosField txtClaveDep;
    private JLetrasField txtNombre;
    private JLabel claveDep, nombre;
    private JButton btnAceptar, btnLimpiar;
    private BtnCancelar btnCancelar;

    public DepartamentoPanel(JFrame m, ArrayLDepartamentos arrDeptos) {
        super(m, "Registro Departamentos", true);
        this.arrDeptos = arrDeptos;
        DepartamentoEventos manejador = new DepartamentoEventos(this, arrDeptos);
        setLayout(new FlowLayout(SwingConstants.CENTER, 10, 7));

        claveDep = new JLabel("Clave de Departamento:     ");
        txtClaveDep = new JEnterosField(12, 4);
        nombre = new JLabel("Nombre de departamento: ");
        txtNombre = new JLetrasField(15, 12);

        btnAceptar = new JButton("Aceptar");
        btnLimpiar = new JButton("Limpiar");
        btnCancelar = new BtnCancelar(this, "Cancelar");

        add(claveDep);
        add(txtClaveDep);
        add(nombre);
        add(txtNombre);
        add(new JLabel("    "));
        add(btnAceptar);
        add(btnLimpiar);
        add(btnCancelar);

        btnAceptar.addActionListener(manejador);
        btnLimpiar.addActionListener(new ManejadorBtnLimpiar(this));

        setSize(320, 130);
        setLocationRelativeTo(null);
        setResizable(false);
        setVisible(true);

    }

    public ArrayLDepartamentos getArrDeptos() {
        return arrDeptos;
    }

    public JEnterosField getTxtClaveDep() {
        return txtClaveDep;
    }

    public JLetrasField getTxtNombre() {
        return txtNombre;
    }

    public JLabel getClaveDep() {
        return claveDep;
    }

    public JLabel getNombre() {
        return nombre;
    }

    public JButton getBtnAceptar() {
        return btnAceptar;
    }

    public JButton getBtnLimpiar() {
        return btnLimpiar;
    }

    public BtnCancelar getBtnCancelar() {
        return btnCancelar;
    }

    private class ManejadorBtnLimpiar implements ActionListener {

        private DepartamentoPanel ventana;

        ManejadorBtnLimpiar(DepartamentoPanel el) {
            this.ventana = el;
        }

        @Override
        public void actionPerformed(ActionEvent e) {
            if (e.getSource() == ventana.getBtnLimpiar()) {
                limpiar();
            }
        }

        public void limpiar() {
            ventana.getTxtClaveDep().setText("");
            ventana.getTxtNombre().setText("");
        }
    }

}
