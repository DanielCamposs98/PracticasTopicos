package Tablas;

import ClasesBase.Departamento;
import Colecciones.ArrayLDepartamentos;
import Colecciones.HashTEmpleado;
import java.awt.BorderLayout;
import javax.swing.JDialog;
import javax.swing.JScrollPane;
import javax.swing.JTable;

public class ReporteEmpDeptoTabla extends JDialog {

    private ArrayLDepartamentos arrDeptos;
    private JTable tabla;
    private HashTEmpleado tablaEmpleados;
    private JScrollPane spane;

    public ReporteEmpDeptoTabla(JDialog j, ArrayLDepartamentos arrDeptos, Departamento depto, HashTEmpleado tablaEmpleados) {
        super(j, "Empleados por departamento", true);

        this.arrDeptos = arrDeptos;
        this.tablaEmpleados = tablaEmpleados;
        String[] Columnas = {"CLAVE", "NOMBRE", "AP PATERNO", "AP MATERNO", "DIRECCION", "DEPARTAMENTO", "SUELDO DIARIO", "BONO"};
        Object[][] datos;
        datos = tablaEmpleados.ObtenerDatosDepto(depto);
        tabla = new JTable(datos, Columnas);

        add(tabla.getTableHeader(), BorderLayout.PAGE_START);
        add(tabla, BorderLayout.CENTER);
        spane = new JScrollPane(tabla);

        add(spane);
        spane.setVisible(true);
        setSize(700, 200);
        setLocationRelativeTo(null);

        setVisible(true);
    }

}
