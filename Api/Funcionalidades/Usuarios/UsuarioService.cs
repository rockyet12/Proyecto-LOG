namespace Api.Funcionalidades .Usuarios;

public interface IUsuarioService
{
    list<Usuario> GetUsuario();
}
public class UsuarioService: IUsuarioService
{
    public List<Usuario> GetUsuario()
    {
        throw new NotImplementedException();
    }
}
    