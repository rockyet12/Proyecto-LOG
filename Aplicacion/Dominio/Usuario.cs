namespace Aplicacion.Dominio;

public  class Usuario
{
    public string Apellido;
    public string Nombre  { get; set; }
    public string Direccion;

    public Usuario(string nombre, string apellido, string direccion)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Direccion = direccion;
    }
}
