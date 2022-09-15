class Alumno
{
    private int Id;
    private string Nombre;
    private string Apellido;
    private int Dni;
    private int Curso;

    public Alumno(int id, string nombre, string apellido, int dni, int curso)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Dni = dni;
        Curso = curso;
    }

    public int Id1 { get => Id; set => Id = value; }
    public string Nombre1 { get => Nombre; set => Nombre = value; }
    public string Apellido1 { get => Apellido; set => Apellido = value; }
    public int Dni1 { get => Dni; set => Dni = value; }
    public int Curso1 { get => Curso; set => Curso = value; }
}