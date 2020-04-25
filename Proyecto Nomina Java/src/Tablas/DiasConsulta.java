
package Tablas;

import Colecciones.ArrayLDias;
import java.awt.BorderLayout;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;


public class DiasConsulta extends JDialog {
    
   private  JTable tabla;
    private ArrayLDias arrDias;
    private JScrollPane spane;
    
    public DiasConsulta(JFrame f,ArrayLDias arr){
        super(f,"Consulta de Dias Laborados",true);
        this.arrDias=arr;
        
        String[] columnas={"ID EMPLEADO","NOMBRE","AP. PATERNO","AP. MATERNO","DEPTO.","DIAS LABORADOS"};
        Object[][] datos= new Object[0][arrDias.getArrDias().size()];
        datos=arrDias.obtenerDias();
        
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
