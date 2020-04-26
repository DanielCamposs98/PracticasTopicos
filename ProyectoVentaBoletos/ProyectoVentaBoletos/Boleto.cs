using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVentaBoletos
{
    class Boleto
    {
        private Destino destino;
        private string pasajero;
        private byte asiento;
        private string tipoBoleto;

        public Boleto(Destino destino,string pasajero,byte asiento, string tipoBoleto)
        {
            this.destino = destino;
            this.pasajero = pasajero;
            this.asiento = asiento;
            this.tipoBoleto = tipoBoleto;
        }

        public Destino pDestino
        {
            get
            {
                return destino;
            }
            set
            {
                destino = value;
            }
        }

        public string pPasajero
        {
            get
            {
                return pasajero;
            }
            set
            {
                pasajero = value;
            }
        }

        public byte pAsiento
        {
            get
            {
                return asiento;
            }
            set
            {
                asiento = value;
            }
        }

        public string pTipoBoleto
        {
            get
            {
                return tipoBoleto;
            }
            set
            {
                tipoBoleto = value;
            }
        }
    }
}
