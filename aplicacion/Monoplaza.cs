using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion
{
    class Monoplaza
    {
        private bool encendido;//true -> esta encendido el motor, false->esta apagado motor
        private bool enMovimiento;//true-> esta en movmiento, false->no esta en movimiento
        private string escuderia;
        private int tiemporealizado;
       

        public Monoplaza(string escuderia)
        {
            this.escuderia = escuderia;
            encendido = false;
            enMovimiento = false;
            tiemporealizado = 0;
        }

        public void SetTiempoRealizado(int tiempo)
        {
            tiemporealizado = tiempo;
        }


        public int GetTiempoRealizado()
        {
            return tiemporealizado;
        }

        public string GetEscuderia()
        {
            return escuderia;
        }

        public void Encender()
        {
            if (encendido == false)
            {
                Console.WriteLine("El monoplaza "+escuderia+" está encendido");
                encendido = true;
            }
        }

        public void Apagar()
        {
            if (encendido == true && enMovimiento == false)
            {
                Console.WriteLine("El monoplaza "+ escuderia + " está apagado");
                encendido = false;
            }
        }

        public void Detener()
        {
            if (encendido == true && enMovimiento == true)
            {
                Console.WriteLine("El monoplaza "+escuderia+ "está detenido");
                enMovimiento = false;
            }
        }

        public void Movimiento()
        {
            if (encendido == true && enMovimiento == false)
            {
                Console.WriteLine("El monoplaza "+ escuderia + " está en movimiento");
                enMovimiento = true;
            }
        }


    }
}
