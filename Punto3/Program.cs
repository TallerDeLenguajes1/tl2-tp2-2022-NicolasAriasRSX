public static class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    public static void Main()
    {
        List<Alumno>listadoFutbol= new List<Alumno>();
        List<Alumno>listadoVoley= new List<Alumno>();
        List<Alumno>listdoAtletismo= new List<Alumno>();

        int cantidad= 0;
        int dni;
        int id;
        int curso;
        string nombre;
        string apellido;
        string ruta;

        try
        {
            do
            {
                Console.WriteLine("Ingrese la cantidad de alumnos que desea ingresar.");
                cantidad= Convert.ToInt32(Console.ReadLine());
            } while (cantidad < 0);
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
            Logger.Error(ex.Message);
        } 


        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Ingrese el nombre del alumno.");
            nombre= Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del alumno.");
            apellido= Console.ReadLine();
            
            try
            {
                do
                {
                    Console.WriteLine("Ingrese el DNI del alumno.");
                    dni= Convert.ToInt32(Console.ReadLine());
                } while (dni < 0 );
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex.Message);
                break;
            }

            try
            {
                Console.WriteLine("Ingrese el ID del alumno.");
                id= Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex.Message);
                break;
            }

            try
            {
                do
                {
                    Console.WriteLine("Seleccione el curso\n1 - Voley\n2 - Atletismo\n3 - Futbol");
                    curso= Convert.ToInt32(Console.ReadLine());
                } while (curso < 1 && curso > 3);

            }
            catch (System.Exception ex)
            {
                Logger.Error(ex.Message);
                break;
            }

            try
            {
                Alumno nuevoAlumno= new Alumno(id, nombre, apellido, dni, curso);
                switch (nuevoAlumno.Curso1)
                {
                    case 1:
                        listadoVoley.Add(nuevoAlumno);
                        break;
                    case 2:
                        listdoAtletismo.Add(nuevoAlumno);
                        break;
                    case 3:
                        listadoFutbol.Add(nuevoAlumno);
                        break;
                }
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex.Message);
                break;
            }
        }//end for

        try
        {
            metodoCargLimp.cargarAlumnos(listadoFutbol, listdoAtletismo, listadoVoley);
            Logger.Info("Carga correcta");
        }
        catch (System.Exception ex)
        {
            Logger.Error(ex.Message);
        }
        //borrar/limpiar
        int respuesta;
        do
        {
            Console.WriteLine("Desea limpiar algun listado?\n0 - SI\n1 - NO");
            respuesta= Convert.ToInt32(Console.ReadLine());
        } while (respuesta < 0 && respuesta > 3);
        
        if(respuesta == 0)
        {
            Console.WriteLine("Ingrese que archivo desea limpiar.\n1 - Voley\n2 - Futbol\n3 - Atletismo");
            try 
            {
                do
                {
                    respuesta= Convert.ToInt32(Console.ReadLine());
                } while (respuesta < 1 && respuesta > 3);

                switch (respuesta)
                {
                    case 1:
                        ruta= @"E:\P.U\Taller II\Practicas\tp2\tl2-tp2-2022-NicolasAriasRSX\Punto3\Voley.csv";
                        metodoCargLimp.limpiarArchivo(ruta);
                        Console.WriteLine("Se limpio el listado.");
                        break;
                    case 2:
                        ruta= @"E:\P.U\Taller II\Practicas\tp2\tl2-tp2-2022-NicolasAriasRSX\Punto3\Futbol.csv";
                        metodoCargLimp.limpiarArchivo(ruta);
                        Console.WriteLine("Se limpio el listado.");
                        break;
                    case 3:
                        ruta= @"E:\P.U\Taller II\Practicas\tp2\tl2-tp2-2022-NicolasAriasRSX\Punto3\Atletismo.csv";
                        metodoCargLimp.limpiarArchivo(ruta);
                        Console.WriteLine("Se limpio el listado.");
                        break;
                }
            }
            catch(Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }//end if

    }//end main
}


// private static readonly NLog.Logger logger= NLog.LogManager.GetCurrentClassLogger();
// private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();


