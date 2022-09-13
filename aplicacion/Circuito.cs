using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion
{
    class Circuito
    {
        private Monoplaza? monoPlaza;
        private int vueltasPermitidas;
        private string nombreCircuito;
        private static Random aleatorio = new Random();

        public Circuito(int vueltasPermitidas, string nombreCircuito)
        {
            this.vueltasPermitidas = vueltasPermitidas;
            this.nombreCircuito = nombreCircuito;
            monoPlaza = null;

        }

        public int GetVueltasPermitidas()
        {
            return vueltasPermitidas;
        }
       

        public void AgregarMonoplaza(Monoplaza nuevo)
        {
            if (this.monoPlaza == null)
            {
                this.monoPlaza = nuevo;
            }
        }

        public void SacarMonoplaza()
        {
            if (monoPlaza != null)
            {
                monoPlaza = null;
            }
        }

        public void RealizarPrueba(int n)
        {
            int numeroAleatorio;
            int mejorTiempo = 9999999;
            int total = 0;

            if(monoPlaza!=null){
                monoPlaza.Encender();
                monoPlaza.Movimiento();
                for (int i=0; i<n; i++)
                {
                    
                    numeroAleatorio = aleatorio.Next(100000, 1000000);
                    total += numeroAleatorio;
                    Console.WriteLine((i + 1) + " tiempo: " + numeroAleatorio);

                    if(numeroAleatorio<= mejorTiempo)
                    {
                        mejorTiempo = numeroAleatorio;
                    }
                }
                monoPlaza.Detener();
                monoPlaza.Apagar();
                monoPlaza.SetTiempoRealizado(total);
                Console.WriteLine("Mejor tiempo: " + mejorTiempo);
            }
            
        }
    }
}
