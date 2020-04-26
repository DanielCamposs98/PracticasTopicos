using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturaAlumnos
{
    public class ManejaAlumno
    {
        static long NCConsecutivo = 1000;

        Dictionary<string, Alumno> dicAlumno = new Dictionary<string, Alumno>();

        public void AgregaAlumnos(String nombre, String domicilio, String carrera, int edad, string NumControl)
        {
            Alumno alumno = new Alumno(nombre, domicilio, carrera, edad);
            dicAlumno.Add(NumControl, alumno);
        }

        public string CalculaNC()
        {
            NCConsecutivo += 1 ;
            int anio = DateTime.Now.Year;
            string NumControl = anio.ToString().Substring(2, 2) + "17" + NCConsecutivo;
            return NumControl;
        }

        public Alumno[] generaAlumnos()
        {
            Alumno[] arrAlumno = new Alumno[dicAlumno.Count];
            int pos = 0;
            foreach (Alumno al in dicAlumno.Values)
            {
                arrAlumno[pos] = al;
                pos++;
            }
            return arrAlumno;
        }

        public string[] generaNC()
        {
            string[] arregloNC = new string[dicAlumno.Count];
            int pos = 0;
            foreach (string nc in dicAlumno.Keys)
            {
                arregloNC[pos] = nc;
                pos++;
            }
            return arregloNC;
        }

        public bool existeAlumno(string nombreAl)
        {
            foreach (Alumno alumno in dicAlumno.Values)
            {
                if (nombreAl.Equals(alumno.pNombre))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        } 
    }
}