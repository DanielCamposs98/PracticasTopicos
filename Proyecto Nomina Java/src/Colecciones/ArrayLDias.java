package Colecciones;
import ClasesBase.Dias;
import ClasesBase.Empleado;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Set;


public class ArrayLDias {
    
    private ArrayList<Dias> arrDias;
    private  HashTEmpleado hashEmpleado;

    public ArrayList<Dias> getArrDias() {
        return arrDias;
    }
    
    public ArrayLDias(HashTEmpleado htEmp){
        arrDias= new ArrayList<>();
        this.hashEmpleado= htEmp;
        
    }
    
    public void borraDias(){
        arrDias.clear();
    }
    
    public int retornaDias(int id){
        for(int i=0;i<arrDias.size();i++){
            if(arrDias.get(i).getClaveEmpleado()==id){
                return arrDias.get(i).getDias();
            }
        }
        return 0;
    }
    
    public boolean getStatusDias(int id){
        for(Dias d: arrDias){
            if(d.getClaveEmpleado()==id){
                return true;
            }
        }
        return false;
    }
    
    public void agregarRegistroDias(int id,int dias){
      arrDias.add(new Dias(id,dias));
    }
    
   public Object [] [] obtenerDias(){
       
       Object [][] datos= new Object[hashEmpleado.getTamaño()][6];
       int cont=0;
      
       Set<Integer> set= hashEmpleado.getTabla().keySet();
       Iterator it= set.iterator();
       while(it.hasNext()){
           
           Empleado emp=(Empleado) hashEmpleado.getTabla().get(it.next());
           datos[cont][0]=emp.getClaveEmp();
           datos[cont][1]=emp.getNombre();
           datos[cont][2]=emp.getApPat();
           datos[cont][3]=emp.getApMat();
           datos[cont][4]=emp.getDepto();
           datos[cont][5]=retornaDias(emp.getClaveEmp());
           cont++;
       }
       return datos;
   }
}
