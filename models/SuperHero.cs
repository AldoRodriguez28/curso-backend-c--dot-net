namespace curso_backend_c__dot_net;

class SuperHero : Heroe, ISuperHeroe
{
    private string _Nombre;

public int Id {get; set;}
 public override string Nombre 
 {
    get{
        return _Nombre;
    } 
    set{
        if (value.Length > 0)
        {
            _Nombre = value.Trim();
        }
    }
 } 
 public string NombreEIdentidadSecreta{
    get{
        return $"{Nombre} ({IdentidadSecreta})";
    }
 }

 public string IdentidadSecreta {get; set;}
 public string Ciudad {get; set;}
 public List<SuperPoder> SuperPoderes = new List<SuperPoder>();
 public bool PuedeVolar {get; set;}


  public SuperHero()
    {   
       
    }

     public SuperHero(int id, string nombre, string identidadSecreta, string ciudad, List<SuperPoder> superPoderes, bool puedeVolar)
    {
        Id = id;
        Nombre = nombre;
        IdentidadSecreta = identidadSecreta;
        Ciudad = ciudad;
        SuperPoderes = superPoderes;
        PuedeVolar = puedeVolar;
    }

    public void UsarSuperPoderes(){
        foreach ( var item in SuperPoderes ){
            Console.WriteLine($"{NombreEIdentidadSecreta} está usando el poder {item.Nombre}!!");
        }
    }

    public override string SalvarElMundo()
    {
        return $"{NombreEIdentidadSecreta} ha salvado el mundo";
    }

    public override string SalvarKripton()
    {
        //return base.SalvarKripton();
        return $"{NombreEIdentidadSecreta} ha salvado Krypton";
    }


}
