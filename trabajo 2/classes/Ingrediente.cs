namespace trabajo.Classes;

public class Ingrediente{
    public string name;
    public int cantidadIngrediente;
    public float price;


    public Ingrediente (string name, int cantidadIngrediente, float price){

        this.name = name;
        this.cantidadIngrediente= cantidadIngrediente;
        this.price=price;
    }

    public string Name
    {
        get {return name;}
        set{name=value;}
    }
     public int CantidadIngredientes
    {
        get {return cantidadIngrediente;}
        set{cantidadIngrediente=value;}
    }
     public float Price
    {
        get {return price;}
        set{price=value;}
    }
}