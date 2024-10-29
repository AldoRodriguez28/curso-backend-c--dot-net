namespace curso_backend_c__dot_net;

class SuperPoder
{

    public string Nombre {get; set;}
    public string Descripcion {get; set;}
    public NivelPoder Nivel {get; set;}

       public SuperPoder()
    {

    }
        public SuperPoder(string nombre, string descripcion, NivelPoder nivel)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Nivel = nivel;
    }
}
