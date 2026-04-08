using Dominio;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

public class UsuarioRepositorioJSON : IUsuarioRepositorio
{
  private string archivo = @"C:\Users\Danie\OmniStream\PresentacionCLI\usuarios.json";
public Usuario ObtenerPorId(int id)
{
    Console.WriteLine("Ruta: " + Path.GetFullPath(archivo));
    Console.WriteLine("Existe: " + File.Exists(archivo));

    if (!File.Exists(archivo))
        return null;

    var lista = JsonConvert.DeserializeObject<List<Usuario>>(File.ReadAllText(archivo));
    return lista.FirstOrDefault(u => u.Id == id);
}

    public void Guardar(Usuario usuario)
    {
        List<Usuario> lista;

        if (File.Exists(archivo))
            lista = JsonConvert.DeserializeObject<List<Usuario>>(File.ReadAllText(archivo));
        else
            lista = new List<Usuario>();

        var existente = lista.FirstOrDefault(u => u.Id == usuario.Id);

        if (existente != null)
            existente.EsPremium = usuario.EsPremium;
        else
            lista.Add(usuario);

        File.WriteAllText(archivo, JsonConvert.SerializeObject(lista, Formatting.Indented));
    }
}