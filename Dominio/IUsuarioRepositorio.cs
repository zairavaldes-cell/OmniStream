public interface IUsuarioRepositorio
{
    Usuario ObtenerPorId(int id);
    void Guardar(Usuario usuario);
}