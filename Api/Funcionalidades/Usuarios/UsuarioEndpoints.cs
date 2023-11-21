namespace Api.Funcionalidades .Usuarios;

public class UsuarioEndpoints
{
    public static void addUsuarioEndpoints(this WebApplication app)
    {
        app.MapGet("/api/Usuario",(UsuarioService usuarioService )=>
        {
            return Results.Ok(UsuarioService.GetUsuario());
        });
    }
}
