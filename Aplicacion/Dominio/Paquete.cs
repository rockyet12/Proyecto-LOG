namespace Aplicacion.Dominio;

public class Paquete
{
    public Guid idPaquete { get; set; } =Guid.NewGuid();
    public int Peso { get; set; }
    public float altura { get; set; }
    public float ancho { get; set; }
    public float largo { get; set; }
    public Paquete(Guid idPaquete, int Peso, float altura,float ancho, float largo)
    {
        this.idPaquete=idPaquete = new Guid();
        this.altura=altura;
        this.ancho=ancho;
        this.largo=largo;

    }
}
