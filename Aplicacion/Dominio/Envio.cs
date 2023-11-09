
namespace Aplicacion.Dominio;


public class Envio 
{
public Guid idpaquete { get; set; }=Guid.NewGuid();
public  List<Remitente>Remitentes=new ();
public  List<Destinatario> destinatarios=new();
public List<Sucursal> sucursales=new();
public int nroenvio;
public Envio( int nroenvio)
{
    this.nroenvio = nroenvio;
    this.Remitentes=new List<Remitente>();
    this.destinatarios=new List<Destinatario>();
    this.sucursales=new List<Sucursal>();
}
}
