class metodoCargLimp
{
    public static void cargarAlumnos(List<Alumno>futbol, List<Alumno>atletismo, List<Alumno>voley)
    {
        List<string>cadenaF= new List<string>();
        List<string>cadenaV= new List<string>();
        List<string>cadenaA= new List<string>();

        string ruta= @"E:\P.U\Taller II\Practicas\tp2\tl2-tp2-2022-NicolasAriasRSX\Punto3";

        foreach (var fut in futbol)
        {
            cadenaF.Add("Nombre y apellido: " + fut.Nombre1 + " " + fut.Apellido1);
        }
        foreach (var vol in voley)
        {
            cadenaV.Add("Nombre y apellido: " + vol.Nombre1 + " " + vol.Apellido1);
        }
        foreach (var atle in atletismo)
        {
            cadenaA.Add("Nombre y apellido: " + atle.Nombre1 + " " + atle.Apellido1);
        }

        File.AppendAllLines(ruta+@"\Atletismo.csv", cadenaA);
        File.AppendAllLines(ruta+@"\Voley.csv", cadenaV);
        File.AppendAllLines(ruta+@"\Futbol.csv", cadenaF);
    }

    public static void limpiarArchivo(string path){
        List<string>limpiar=new List<string>();
        string path1=@"E:\P.U\Taller II\Practicas\tp2\tl2-tp2-2022-NicolasAriasRSX\Punto3";
        limpiar.Add(" ");
        File.WriteAllLines(path,limpiar);
    }
}