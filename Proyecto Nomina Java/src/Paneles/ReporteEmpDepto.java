package Paneles;

import Colecciones.HashTEmpleado;
import Colecciones.ArrayLDepartamentos;
import ManejadoresEventos.ReporteEmpDeptoEventos;
import java.awt.FlowLayout;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class ReporteEmpDepto extends JDialog {

    private JComboBox cmbDepartamentos;
    private JButton btnOk;
    private ArrayLDepartamentos arrDeptos;
    private HashTEmpleado tablaEmpleado;
    private JFrame padre;

 
    public ReporteEmpDepto(JFrame f, HashTEmpleado tablaEmpleado, ArrayLDepartamentos arrDeptos) {
        super(f, "Reporte Departamentos", true);
        padre = f;
        this.arrDeptos = arrDeptos;
        this.tablaEmpleado = tablaEmpleado;
        this.arrDeptos = arrDeptos;
        setLayout(new FlowLayout());

        btnOk = new JButton("OK");

        cmbDepartamentos = new JComboBox();
        add(new JLabel("Departamentos"));
        for (int i = 0; i < arrDeptos.getSize(); i++) {
            cmbDepartamentos.addItem(arrDeptos.getArrDeptos().get(i));
        }

        add(cmbDepartamentos);
        add(btnOk);
        ReporteEmpDeptoEventos rm = new ReporteEmpDeptoEventos(f, this, tablaEmpleado, arrDeptos);
        btnOk.addActionListener(rm);

          setSize(300, 80);
         setLocationRelativeTo(null);       
         setVisible(true);
    }
   public JComboBox getCmbDepartamentos() {
        return cmbDepartamentos;
    }

    public JButton getBtnOk() {
        return btnOk;
    }

    public ArrayLDepartamentos getArrDeptos() {
        return arrDeptos;
    }

    public HashTEmpleado getTablaEmpleado() {
        return tablaEmpleado;
    }


    public JFrame getPadre() {
        return padre;
    }

}
