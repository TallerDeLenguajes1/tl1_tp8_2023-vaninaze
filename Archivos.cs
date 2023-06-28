string[] files = Directory.GetFiles(@"C:\File", "*.txt");//archivos solo txt
string[] files = Directory.GetFiles(@"C:\File", "*.txt", SearchOption.AllDirectories); //archivos y archivos de subdirectorios}
// el @ omite el uso de la doble \ 
string[] Discos = Directory.GetLogicalDrives(); //lista discos rigidos
foreach (var file in files)
{
    Console.WriteLine(file);
}

//Listar carpetas del disco C
List<string> listaCarpetas = Directory.GetDirectories(@"C:\").ToList();

