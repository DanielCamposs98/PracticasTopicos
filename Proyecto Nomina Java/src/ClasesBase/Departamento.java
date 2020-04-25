package ClasesBase;


public class Departamento {
    
    private int claveDepto;
    private String nombreDepto;
    private Empleado encargadoDepto;

    public Departamento(int clave,String nombreDepto, Empleado encargadoDepto) {
        this.claveDepto=clave;
        this.nombreDepto = nombreDepto;
        this.encargadoDepto=encargadoDepto;
    }

    public int getClaveDepto() {
        return claveDepto;
    }

    public String getNombreDepto() {
        return nombreDepto;
    }

    public void setClaveDepto(int claveDepto) {
        this.claveDepto = claveDepto;
    }

    public void setNombreDepto(String nombreDepto) {
        this.nombreDepto = nombreDepto;
    }

    public void setEncargadoDepto(Empleado encargadoDepto) {
        this.encargadoDepto = encargadoDepto;
    }

    public Empleado getEncargadoDepto() {
        return encargadoDepto;
    }
    
    public String getEncargadoDeptoString(){
        if(encargadoDepto==null){
            return "Indefinido";
        }else{
            return encargadoDepto.getNombre()+" "+encargadoDepto.getApPat();
        }
    }
    
    public String toString(){
        return getNombreDepto();
    }

    
}
