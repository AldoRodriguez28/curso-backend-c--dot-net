using System.Data.SqlTypes;

namespace curso_backend_c__dot_net;

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}
class Program
{
    static void Main(string[] args)
    {
        var poderVolar = new SuperPoder();
        var imprimirInfo = new ImprimirInfo();

        poderVolar.Nombre = "Volar";
        poderVolar.Descripcion = "Poder para volar";
        poderVolar.Nivel = NivelPoder.NivelDos;

        var superFuerza = new SuperPoder();
        superFuerza.Nombre = "Super Fuerza";
        superFuerza.Descripcion = "Poder para tener super fuerza";
        superFuerza.Nivel = NivelPoder.NivelTres;

        var inteligencia = new SuperPoder();
        inteligencia.Nombre = "Inteligencia";
        inteligencia.Descripcion = "Poder para tener inteligencia superior";
        inteligencia.Nivel = NivelPoder.NivelUno;

        var visionRX = new SuperPoder();
        visionRX.Nombre = "Visión RX";
        visionRX.Descripcion = "Poder para tener visión de rayos X";
        visionRX.Nivel = NivelPoder.NivelDos;

        var millonario = new SuperPoder();
        millonario.Nombre = "Millonario";
        millonario.Descripcion = "Poder para tener una gran cantidad de dinero";
        millonario.Nivel = NivelPoder.NivelTres;



        SuperHero superman = new SuperHero();
        SuperHero batman = new SuperHero();

        superman.Id = 1;
        superman.Nombre = "Superman";
        superman.IdentidadSecreta = "Clark Kent";
        superman.Ciudad = "Metropolis";
        imprimirInfo.ImprimirSuperHeroe(superman);


        List<SuperPoder> poderesSuperman = new List<SuperPoder>();
        poderesSuperman.Add(poderVolar);
        poderesSuperman.Add(superFuerza);
        poderesSuperman.Add(visionRX);

        superman.SuperPoderes = poderesSuperman;
        superman.PuedeVolar = true;
        superman.UsarSuperPoderes();
        string hope = superman.SalvarKripton();
        Console.WriteLine(hope);



        batman.Id = 2;
        batman.Nombre = "Batman";
        batman.IdentidadSecreta = "Bruce Wayne";
        batman.Ciudad = "Gotham";

        imprimirInfo.ImprimirSuperHeroe(batman);
        List<SuperPoder> poderesBatman = new List<SuperPoder>();
        poderesBatman.Add(inteligencia);
        poderesBatman.Add(millonario);
        batman.SuperPoderes = poderesBatman;
        batman.PuedeVolar = false;

        batman.UsarSuperPoderes();

        string resultSalvarElMundo = batman.SalvarElMundo();
        Console.WriteLine(resultSalvarElMundo);
    }
}
