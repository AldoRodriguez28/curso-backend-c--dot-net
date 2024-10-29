using System.Text;

namespace curso_backend_c__dot_net;

interface ISuperHeroe
{
    int Id { get; set;}
    string Nombre { get; set;}
    string IdentidadSecreta { get; set;}

    string InformacionSuperHeroe (){
        StringBuilder sb = new StringBuilder();
        sb.Append($"Nombre: {Nombre}\n");
        sb.Append($"Identidad secreta: {IdentidadSecreta}\n");
        return sb.ToString();
    }



}
