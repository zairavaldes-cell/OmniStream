using Dominio;
using Infraestructura;

class Program
{
    static void Main()
    {
        IUsuarioRepositorio repo = new UsuarioRepositorioJSON();
        var servicio = new ServicioSuscripcion(repo);

        Console.WriteLine("Ingrese ID:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine(servicio.ActivarPremium(id));
    }
}