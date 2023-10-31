namespace Aplicacion.Dominio;
public class Sucursal
{
    public Guid  idSucursal { get; set; }= Guid.NewGuid();
    public string Nombre { get; set; }
    public string domicilioSucursal { get; set; }    
    public Sucursal(Guid idSucursal, string Nombre, string Domicilio)
    {
        this.idSucursal=idSucursal;
        this.Nombre=Nombre;
        domicilioSucursal=Domicilio;
    }
}
