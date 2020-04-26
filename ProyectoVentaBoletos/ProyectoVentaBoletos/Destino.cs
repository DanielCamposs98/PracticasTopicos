using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVentaBoletos
{
    public class Destino
    {
        private int clave;
        private string nombre;
        private double costo;
        private byte duracion;
        private bool status;

        public Destino(int clave, string nombre,double costo, byte duracion,bool status)
        {
     
            this.nombre = nombre;
            this.costo = costo;
            this.duracion = duracion;
            this.status = status;
        }


        public string pNombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public double pCosto
        {
            set
            {
                costo = value;
            }
            get
            {
                return costo;
            }
        }
        public byte pDuracion
        {
            set
            {
                duracion = value;
            }
            get
            {
                return duracion;
            }
        }
        public bool pStatus
        {
            set
            {
                status = value;
            }
            get
            {
                return status;
            }
        }

        public int pClave
        {
            get
            {
                return clave;
            }
            set
            {
                clave = value;
            }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
