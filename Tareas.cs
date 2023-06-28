namespace EspacioTareas;

public class Tarea{
    private int tareaID; //Numerado en ciclo iterativo
    private string? descripcion; //
    private int duracion; // entre 10 – 100

    public int Duracion { get => duracion; set => duracion = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int TareaID { get => tareaID; set => tareaID = value; }
}