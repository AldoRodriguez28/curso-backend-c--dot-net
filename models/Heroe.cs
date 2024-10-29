using System.Runtime.CompilerServices;

namespace curso_backend_c__dot_net;

internal abstract class Heroe
{
    public abstract string Nombre { get; set; }
    public abstract string SalvarElMundo();

    public virtual string SalvarKripton(){
        return $"{Nombre} ha salvado Kripton";
    }
}
