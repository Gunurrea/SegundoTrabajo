
namespace aplicacion{
    class Program
    {
         
        static void Main(string[] args)
        {
            List<Monoplaza> monoplazas = new List<Monoplaza>();
            Monoplaza aux;
            monoplazas.Add(new Monoplaza("mclaren"));
            monoplazas.Add(new Monoplaza("ferrari"));
            monoplazas.Add(new Monoplaza("redbull"));

            Circuito circuito = new Circuito(5,"Cicuito full");
            for(int i=0; i<monoplazas.Count; i++)
            {
                Console.WriteLine();
                circuito.AgregarMonoplaza(monoplazas[i]);
                circuito.RealizarPrueba(circuito.GetVueltasPermitidas());
                circuito.SacarMonoplaza();
            }

            for(int i=0; i< monoplazas.Count-1; i++)
            {
                for(int j=i; j<monoplazas.Count; j++)
                {
                    if(monoplazas[i].GetTiempoRealizado()> monoplazas[j].GetTiempoRealizado())
                    {
                        aux = monoplazas[i];
                        monoplazas[i] = monoplazas[j];
                        monoplazas[j] = aux;
                    }
                }
            }

            Console.WriteLine("\nTabla de posiciones");
            for(int i=0; i<monoplazas.Count; i++)
            {
                Console.WriteLine((i+1)+". " +monoplazas[i].GetEscuderia() + ", Tiempo: " + monoplazas[i].GetTiempoRealizado());
            }


            Console.ReadKey();

        }
        
    }
}
            
 



