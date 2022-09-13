namespace trabajo.Classes;
using trabajo.Interface;
using System.Collections.Generic;

public class Pastel : pastelinterface{

    public string nombre="";
    private float total =0;
    public bool listaVacia=true;

    //Inicializamos la lista de ingredientes
    List<Ingrediente> ListaIngredientes = new List<Ingrediente>();


 public bool ListaVacio(){
        if(ListaIngredientes.Count !=0)
        {
            return false;
        }
        return true;

    }
    
    public float CalcularCosto(){
         if(ListaVacio())
        {
            Console.WriteLine("No se puede calcular sin Ingredientes \n");
            return 0;
            
        }
        total=0;
        foreach (Ingrediente ingrediente in ListaIngredientes){
                      total= total + ingrediente.price;
                    }   
        return total;
   }

   
    //Recorrer la lista, cada item es una instancia de la clase Ingrediente
    public void ListarIngredientes(){
        if(ListaVacio())
        {
            Console.WriteLine("No hay Ingredientes para listar \n");
        }
        foreach (Ingrediente ingrediente in ListaIngredientes){
            Console.WriteLine("-Ingrediente: "+ingrediente.name +" -Cantidad: "+ingrediente.cantidadIngrediente+" -Precio: "+ ingrediente.price+"\n");
            }

    }

    //Devuelve cuantos items tiene la lista
    public int CantidadIngredientes(){
        if(ListaVacio()){
            Console.WriteLine("No hay Ingredientes \n");
            return 0;
        }
        int count = ListaIngredientes.Count;
        return count;
    }


    //Agregando un ingrediente a la lista
    public void AgregarIngrediente(string nombre, int cantidad, float precio){
        ListaIngredientes.Add(new Ingrediente( nombre.ToUpper(),  cantidad, precio));
        Console.WriteLine("Ingrediente ingresado \n ");

    }

    //Eliminar elemento
    public void ElimarIngrediente(string nombre){
        if(ListaVacio()){
            Console.WriteLine("No hay Ingredientes para eliminar \n");
        }   
        int pos=0;
        for(int i= 0; i < ListaIngredientes.Count; i++){
            if (ListaIngredientes[i].name==nombre.ToUpper()){
                pos = i;
                ListaIngredientes.RemoveAt(pos);
                Console.WriteLine("Ingrediente eliminado \n");

                break;
                }
                
            }
    }

}