public class ServicioSuscripcion
{
    private readonly IUsuarioRepositorio _repo;

    public ServicioSuscripcion(IUsuarioRepositorio repo)
    {
        _repo = repo;
    }

    public string ActivarPremium(int id)
    {
        var usuario = _repo.ObtenerPorId(id);

        if (usuario == null)
            return "Usuario no existe";

        if (!usuario.PuedeSerPremium())
            return "No cumple condiciones";

        usuario.EsPremium = true;
        _repo.Guardar(usuario);

        return "Usuario ahora es PREMIUM";
    }
}