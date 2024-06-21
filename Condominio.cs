using System.Security.Cryptography.X509Certificates;

public class Condominio {
    private int id; 
    private string nome;
    private Endereco EnderecoCondominio;

    public Condominio(int id, string nome, Endereco EnderecoCondominio) {
        this.id = id;
        this.nome = nome;
        this.EnderecoCondominio = EnderecoCondominio;
    }

    public int getId() {
        return id;
    }

    public string getNome() {
        return nome;
    }

    public void setNome(string nome) {
        this.nome = nome;
    }

    public Endereco getEnderecoCondominio () {
        return EnderecoCondominio;
    }

    public void setEnderecoCondominio (Endereco EnderecoCondominio) {
        this.EnderecoCondominio = EnderecoCondominio;
    }

}