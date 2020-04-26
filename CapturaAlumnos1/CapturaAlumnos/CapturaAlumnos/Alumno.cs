using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturaAlumnos
{

    public class Alumno
    {
        private String Nombre;
        private String Domicilio;
        private String Carrera;
        private int Edad;

        //constructor
        public Alumno(String nombre, String domicilio, String carrera, int edad)
        {
            Nombre = nombre;
            Domicilio = domicilio;
            Carrera = carrera;
            Edad = edad;
        }//fin del constructor.

        //creación de propiedades.
        public String pNombre
        {
            set
            {
                Nombre = value;
            }
            get
            {
                return Nombre;
            }
        }

        public String pDomicilio
        {
            set
            {
                Domicilio = value;
            }
            get
            {
                return Domicilio;
            }
        }

        public String pCarrera
        {
            set
            {
                Carrera = value;
            }
            get
            {
                return Carrera;
            }
        }

        public int pEdad
        {
            set
            {
                Edad = value;
            }
            get
            {
                return Edad;
            }
        }
        //fin de las propiedades.
    }
}
