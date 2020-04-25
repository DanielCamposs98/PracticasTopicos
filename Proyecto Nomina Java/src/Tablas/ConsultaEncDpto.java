package Tablas;

import java.awt.BorderLayout;
import javax.swing.JDialog;
import Colecciones.ArrayLDepartamentos;
import Colecciones.HashTEmpleado;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;

public class ConsultaEncDpto extends JDialog {

    private JTable MuestraTabla;
    private ArrayLDepartamentos arrDeptos;
    private JScrollPane spane;
    private HashTEmpleado tablaEmpleado;

    public ConsultaEncDpto(JFrame frame, ArrayLDepartamentos arrDeptos) {
        super(frame, "Encargados por Departamento", true);
        this.arrDeptos = arrDeptos;
        String[] Columnas = {"CLAVE", "NOMBRE", "ENCARGADO"};
        Object[][] datos = new Object[0][arrDeptos.getSize()];
        datos = arrDeptos.ObtenerDatos();

        MuestraTabla = new JTable(datos, Columnas);

        add(MuestraTabla.getTableHeader(), BorderLayout.PAGE_START);
        add(MuestraTabla, BorderLayout.CENTER);
        spane = new JScrollPane(MuestraTabla);
        spane.setVisible(true);
        add(spane);

        setSize(400, 200);
        setLocationRelativeTo(null);
        setVisible(true);
    }

    public JTable getMuestraTabla() {
        return MuestraTabla;
    }

    public ArrayLDepartamentos getArrDeptos() {
        return arrDeptos;
    }

    public JScrollPane getSpane() {
        return spane;
    }

    public HashTEmpleado getTablaEmpleado() {
        return tablaEmpleado;
    }

}
