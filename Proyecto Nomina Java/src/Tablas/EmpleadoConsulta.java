
package Tablas;

import Colecciones.HashTEmpleado;
import java.awt.BorderLayout;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;

public class EmpleadoConsulta extends JDialog {
   private   JTable MuestraTabla;
    private HashTEmpleado Etabla;
    private JScrollPane spane;
 
    public EmpleadoConsulta(JFrame frame,HashTEmpleado tabla){
         super(frame,"Empleados",false);
     
     this.Etabla = tabla;
     String []Columnas ={"CLAVE","NOMBRE","AP PATERNO","AP MATERNO","DIRECCION","DEPARTAMENTO","SUELDO","BONO"};
     Object [][]datos = new Object[0][Etabla.getTamaño()];
     datos = Etabla.ObtenerDatos();
     
     
     MuestraTabla = new JTable(datos,Columnas);
     MuestraTabla.setEnabled(false);
     add(MuestraTabla.getTableHeader(),BorderLayout.PAGE_START);
     add(MuestraTabla, BorderLayout.CENTER);
     spane = new JScrollPane(MuestraTabla);
     spane.setVisible(true);
     add(spane);
     
      
      setSize(700,200);
        setLocationRelativeTo(null);
     setVisible(true); 
    }
}
