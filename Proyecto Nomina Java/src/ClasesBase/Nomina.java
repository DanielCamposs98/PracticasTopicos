package ClasesBase;

public class Nomina {

   
 private int idEmpleado, diasLaborados;


 private float sueldoD,bonoEx,total;
 
 public Nomina(int id,int diasL,float sueldo,float bono){
     this.idEmpleado=id;
     this.diasLaborados=diasL;
     this.sueldoD=sueldo;
     this.bonoEx=bono;
     total=calculaTotal();
 }
 
 public float calculaTotal(){
     return ((sueldoD*diasLaborados)+bonoEx);
 }
     public int getIdEmpleado() {
        return idEmpleado;
    }

    public int getDiasLaborados() {
        return diasLaborados;
    }

    public float getSueldoD() {
        return sueldoD;
    }

    public float getBonoEx() {
        return bonoEx;
    }

    public float getTotal() {
        return total;
    }
 
    
}