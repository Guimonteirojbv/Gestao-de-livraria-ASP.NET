namespace Gestão_de_Livraria.Communication.Request;

public class RequestCreateBookJson
{
    public string Titulo { get; set; } = string.Empty;

    public string Genero { get; set; } = string.Empty;

    public string Autor { get; set; } = string.Empty;

    public double Preco { get; set; }

    public int Estoque { get; set; }

}
