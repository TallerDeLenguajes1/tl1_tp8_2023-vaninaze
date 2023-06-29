/*using EspacioTareas;

List<Tarea> ListaPend = new List<Tarea>();
List<Tarea> ListaReal = new List<Tarea>();

Tarea[] tareasPend = new Tarea[3];
Tarea tarea = new Tarea();
string? aux;
int auxNum;

for (int i = 0; i < 3; i++){
    tareasPend[i] = new Tarea();
    tareasPend[i].TareaID = i+1;
    Console.WriteLine("Ingrese descripcion de la tarea "+(i+1)+": ");
    tareasPend[i].Descripcion = Console.ReadLine();
    Console.WriteLine("Ingrese duracion de la tarea "+(i+1)+": ");
    if(int.TryParse(Console.ReadLine(),out auxNum)){
        tareasPend[i].Duracion = auxNum;
    }
}
for (int i = 0; i < 3; i++)
{
    ListaPend.Add(tareasPend[i]); //agrego la tarea a la lista
}
for (int i = 0; i < 3; i++) //muestro las tareas pendientes
{
    Console.WriteLine("-- TAREA ID "+ListaPend[i].TareaID+"--");
    Console.WriteLine("Duracion: "+ListaPend[i].Duracion);
    Console.WriteLine("Descripcion: "+ListaPend[i].Descripcion);
    Console.WriteLine("Realizo la tarea? 1-SI, 0-NO: ");
    int.TryParse(Console.ReadLine(), out auxNum);
    if(auxNum == 1){
        tarea = ListaPend[i];
        ListaReal.Add(tarea);
    }
}
foreach (var item in ListaReal)
{
    ListaPend.Remove(item); //borro las tareas realizadas de pendientes
}
Console.WriteLine("\n\n ---- TAREAS REALIZADAS ----");
for (int i = 0; i < ListaReal.Count; i++) //muestro tareas realizadas
{
    Console.WriteLine("\n --- TAREA ID "+ListaReal[i].TareaID+" ---");
    Console.WriteLine("\n Descripcion: "+ListaReal[i].Descripcion);
    Console.WriteLine("\n Duracion: "+ListaReal[i].Duracion);
}
do{
    Console.WriteLine("Ingrese descripcion de la tarea pendiente a buscar: ");
    aux = Console.ReadLine();
    var tareaEncontrada = ListaPend.Find(t => t.Descripcion == aux);
    if(tareaEncontrada != null){
        Console.WriteLine("\n --- TAREA ENCONTRADA ID "+tareaEncontrada.TareaID+" ---");
        Console.WriteLine("\n Descripcion: "+tareaEncontrada.Descripcion);
        Console.WriteLine("\n Duracion: "+tareaEncontrada.Duracion);
    }
    Console.WriteLine("\n Desea buscar otra tarea? 1-SI, 0-NO");
    int.TryParse(Console.ReadLine(), out auxNum);
}while(auxNum != 0);

//PUNTO 4
var archivo = new StreamWriter("horas.csv");
for (int i = 0; i < ListaReal.Count; i++)
{
    archivo.WriteLine("Duracion,"+ListaReal[i].Duracion);
}
archivo.Close();
*/
using System;
using System.IO;
using System.Collections.Generic;

Console.WriteLine("Ingrese el path de una carpeta: ");
string directorio = Console.ReadLine();

//Guardo los archivos en una lista
List<string> ListArchivos = Directory.GetFiles(directorio).ToList();

Console.WriteLine("Archivos en la carpeta: ");
foreach (string archivo in ListArchivos)
{
    Console.WriteLine("\t"+archivo);
}
if(!File.Exists("index.csv")){ //creo un archivo
    File.Create("index.csv");
}
string? nombre;
string? extension;
string[] linea = new string[ListArchivos.Count];
string directActual = Directory.GetCurrentDirectory();
string RutaArchivo = directActual+@"\index.csv";

for (int i = 0; i < ListArchivos.Count; i++)
{
    FileInfo archivo = new FileInfo(ListArchivos[i]);
    nombre = Path.GetFileNameWithoutExtension(archivo.Name);
    extension = Path.GetExtension(archivo.Name);
    linea[i] = i.ToString()+","+nombre+","+extension;
    Console.WriteLine(linea[i]);

}
//Guardo en archivo index.csv
File.WriteAllLines(RutaArchivo,linea);