
package Tablas;

import Colecciones.HashTEmpleado;
import java.awt.BorderLayout;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;

public class BonosConsulta extends JDialog{
    
   private JTable tabla;
    private HashTEmpleado hashEmpleados;
    private JScrollPane spane;
    
    public BonosConsulta(JFrame f,HashTEmpleado ht){
        super(f,"Consulta de Bonos Extras",true);
        this.hashEmpleados=ht;
        
        String[] columnas={"ID EMPLEADO","NOMBRE","AP. PATERNO","AP. MATERNO","DEPTO.","BONO ASIGNADO"};
        Object[][] datos= new Object[0][hashEmpleados.getTamaño()];
        datos=hashEmpleados.ObtenerDatosBonos();
        
        tabla= new JTable(datos,columnas);
        tabla.setEnabled(false);
        add(tabla.getTableHeader(),BorderLayout.PAGE_START);
        add(tabla,BorderLayout.CENTER);
        spane= new JScrollPane(tabla);
        spane.setVisible(true);
        add(spane);
        setSize(700, 200);
        setLocationRelativeTo(null);
       
        setVisible(true);
    }
}
