namespace Aplicacion.Dominio;

public class Envio 
{
public Guid idpaquete { get; set; }
public  List<Remitente>Remitentes=new ();
public  List<Destinatario> destinatarios=new();
public List<Sucursal> sucursales=new();
public int nroenvio;
public Envio( int nroenvio)
{
    this.idremitente = new Guid();
    this.iddestiniatario =  new List
    this.nroenvio = nroenvio;
    this.idsucursal = new Guid();
}
}
