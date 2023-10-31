namespace Aplicacion.Dominio;

public class Domicilio
{
    public string calle { get; set; }
    public int altura { get; set; }
    public int codigoPostal { get; set; }
    Domicilio(string calle, int altura, int codigoPostal)
    {
        this.calle = calle;
        this.altura = altura;
        this.codigoPostal = codigoPostal;
    }
}
