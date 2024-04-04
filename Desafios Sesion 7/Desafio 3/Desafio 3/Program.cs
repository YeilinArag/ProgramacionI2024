using System;
using System.Collections.Generic;
using System.IO;

class Auto
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    public List<string> HistoriaDeReparaciones { get; set; }

    public Auto(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
        HistoriaDeReparaciones = new List<string>();
    }

    public virtual void Reparar(string descripcion)
    {
        HistoriaDeReparaciones.Add(descripcion);
    }
}

class BMW : Auto
{
    private const string ArchivoReparaciones = "reparaciones.txt";
    public BMW(string modelo, int año) : base("BMW", modelo, año)
    {
    }

    public override void Reparar(string descripcion)
    {
        base.Reparar(descripcion);
        File.AppendAllText(ArchivoReparaciones, $"{DateTime.Now}: {descripcion}{Environment.NewLine}");
    }

    public void ImprimirHistoriaDeReparaciones()
    {
        if (File.Exists(ArchivoReparaciones))
        {
            string[] lineas = File.ReadAllLines(ArchivoReparaciones);
            foreach (string linea in lineas) 
            {
                HistoriaDeReparaciones.Add(linea);
            }
        }

        Console.WriteLine("Historia de reparaciones:");
        foreach (string reparacion in HistoriaDeReparaciones)
        {
            Console.WriteLine(reparacion);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BMW miAuto = new BMW("X5", 2022);
        miAuto.Reparar("Cambio de aceite");
        miAuto.Reparar("Reparación de frenos");

        miAuto.ImprimirHistoriaDeReparaciones();

        Console.ReadLine();
    }
}
    
