namespace trabajo.Interface;

public interface pastelinterface
{
public float CalcularCosto();
public void ListarIngredientes();
public int CantidadIngredientes(); 
public void AgregarIngrediente(string nombre, int cantidad, float precio);
public void ElimarIngrediente(string nombre);

}