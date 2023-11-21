using Aplicacion.Dominio;
namespace Api.Funcionalidades .Usuarios;

public interface IUsuarioService
{
    List<Usuario> GetUsuario();
}
public class UsuarioService: IUsuarioService
{
    public List<Usuario> GetUsuario()
    {
        throw new NotImplementedException();
    }
}
    