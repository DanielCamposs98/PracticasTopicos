package ClasesBase;

public class Empleado {
    private String nombre, apPat,apMat,domicilio;
    private Departamento depto;
    private float sueldoDiario,bonoExtra;
    private int claveEmp;

    public Empleado(int claveEmp,String nombre, String apPat, String apMat, String domicilio, Departamento depto, float sueldoDiario, float bonoExtra) {
        this.nombre = nombre;
        this.apPat = apPat;
        this.apMat = apMat;
        this.domicilio = domicilio;
        this.depto = depto;
        this.sueldoDiario = sueldoDiario;
        this.bonoExtra = 0;
        this.claveEmp=claveEmp;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApPat() {
        return apPat;
    }

    public void setApPat(String apPat) {
        this.apPat = apPat;
    }

    public String getApMat() {
        return apMat;
    }

    public void setApMat(String apMat) {
        this.apMat = apMat;
    }

    public String getDomicilio() {
        return domicilio;
    }

    public void setDomicilio(String domicilio) {
        this.domicilio = domicilio;
    }

    public Departamento getDepto() {
        return depto;
    }

    public void setDepto(Departamento depto) {
        this.depto = depto;
    }

    public float getSueldoDiario() {
        return sueldoDiario;
    }

    public void setSueldoDiario(float sueldoDiario) {
        this.sueldoDiario = sueldoDiario;
    }

    public float getBonoExtra() {
        return bonoExtra;
    }

    public void setBonoExtra(float bonoExtra) {
        this.bonoExtra = bonoExtra;
    }

    public int getClaveEmp() {
        return claveEmp;
    }

    public void setClaveEmp(int claveEmp) {
        this.claveEmp = claveEmp;
    }

    public String toString() {
        return claveEmp + " " + nombre + " " + apPat ;
    }
}
