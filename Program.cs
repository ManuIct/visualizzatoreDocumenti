using System;
using System.IO;

class Program
{
    static void Main(string[] args){
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            VisualizzaContenuto(path,0);
    }

    private static void VisualizzaContenuto(string path, int v)
    {
        throw new NotImplementedException();
    }

    static void StampaCartella(string path, int livello)
{
    string indent = new string(' ', livello * 4);
    Console.WriteLine($"{indent}Directory: {Path.GetFileName(path)}");

    foreach (var file in Directory.GetFiles(path))
    {
        Console.WriteLine($"{indent} {Path.GetFileName(file)}");
    }

    foreach (var file in Directory.GetFiles(path))
    {
        StampaFile(file, livello + 1);
    }
}

    private static void StampaFile(string file, int v)
    {
        throw new NotImplementedException();
    }
}





