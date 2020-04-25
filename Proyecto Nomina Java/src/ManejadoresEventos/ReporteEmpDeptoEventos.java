package ManejadoresEventos;

import Tablas.ReporteEmpDeptoTabla;
import Paneles.ReporteEmpDepto;
import Colecciones.HashTEmpleado;
import ClasesBase.Departamento;
import Colecciones.ArrayLDepartamentos;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JFrame;
import javax.swing.JOptionPane;

public class ReporteEmpDeptoEventos implements ActionListener {

    private ReporteEmpDepto red;
    private HashTEmpleado tablaEmpleados;
    private ArrayLDepartamentos arrDeptos;
    private JFrame f;

    public ReporteEmpDeptoEventos(JFrame m, ReporteEmpDepto reporte, HashTEmpleado tabla, ArrayLDepartamentos arrDeptos) {
        red = reporte;
        f = m;
        tablaEmpleados = tabla;
        this.arrDeptos = arrDeptos;
    }

    public void actionPerformed(ActionEvent ae) {
    
        if (ae.getSource() == red.getBtnOk()) {
            if(tablaEmpleados.contieneEmpleadosDepto( (Departamento) red.getCmbDepartamentos().getSelectedItem())){
                 ReporteEmpDeptoTabla reporteEmpDeptoTabla = new ReporteEmpDeptoTabla(red, arrDeptos,  (Departamento) red.getCmbDepartamentos().getSelectedItem(), tablaEmpleados);
            }else{
                JOptionPane.showMessageDialog(null,"El departamento no tiene empleados asignados.","Error",JOptionPane.ERROR_MESSAGE);
            }
           
        }
    }
}
