package Tablas;

import Colecciones.HashTEmpleado;
import Colecciones.ArrayLNomina;
import java.awt.BorderLayout;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;

public class NominaConsulta extends JDialog {

    private ArrayLNomina arrNom;

    private HashTEmpleado hashEmpleados;

    public NominaConsulta(JFrame padre, ArrayLNomina arr, HashTEmpleado ht) {

        super(padre, "Nomina", true);

        this.arrNom = arr;
        this.hashEmpleados = ht;

        if (hashEmpleados.vacia()) {
            JOptionPane.showMessageDialog(null, "No hay empleados añadidos.", "Error", JOptionPane.ERROR_MESSAGE);
        } else {
            arrNom.getArrayNomina().clear();
            final String[] columnas = {"ID Empleado", "Días Laborados", "Sueldo Diario", "Bono Extra", "Total a pagar"};
            Object[][] datos = new Object[0][arrNom.getSize()];
            datos = arrNom.getDatos();

            JTable tabla = new JTable(datos, columnas);

            add(tabla.getTableHeader(), BorderLayout.PAGE_START);
            add(tabla, BorderLayout.CENTER);
            tabla.setEnabled(false);

            JScrollPane spane = new JScrollPane(tabla);
            spane.setVisible(true);

            add(spane);
            JTextField txtTotal = new JTextField("Total a pagar: " + String.valueOf(arrNom.getTotalNomina()));
            txtTotal.setEditable(false);
            add(txtTotal, BorderLayout.SOUTH);
            
          setSize(700,200);
            setLocationRelativeTo(null);
            setVisible(true);
        }
    }

}
