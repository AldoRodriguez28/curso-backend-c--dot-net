namespace curso_backend_c__dot_net;

internal class ImprimirInfo
{
    public void ImprimirSuperHeroe(ISuperHeroe superHeroe){
        // Console.WriteLine($"Id: {superHeroe.Id}");
        // Console.WriteLine($"Nombre: {superHeroe.Nombre}");
        // Console.WriteLine($"Identidad Secreta: {superHeroe.IdentidadSecreta}");

        Console.WriteLine(superHeroe.InformacionSuperHeroe());
    }
}
