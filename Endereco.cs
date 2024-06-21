public class Endereco {
    private string Rua;
    private string Numero;
    private string Bairro;
    private string Cidade;

    private string Estado;

    private int Cep;

    public Endereco(string rua, string Numero, String Bairro, string Cidade, string Estado, int Cep) {
        this.Rua = rua;
        this.Numero = Numero;
        this.Bairro = Bairro;
        this.Cidade = Cidade;
        this.Estado = Estado;
        this.Cep = Cep;
    }

    public void setRua(String Rua) {
        this.Rua = Rua;
    }

    public string getRua () {
        return this.Rua;
    }

    public void setNumero(String Numero) {
        this.Numero = Numero;
    }

    public string getNumero () {
        return this.Numero;
    }

    public void setBairro(String Bairro) {
        this.Bairro = Bairro;
    }

    public string getBairro () {
        return this.Bairro;
    }

    public void setCidade(String Cidade) {
        this.Cidade = Cidade;
    }

    public string getCidade () {
        return this.Cidade;
    }

    public void setEstado(String Estado) {
        this.Estado = Estado;
    }

    public string getEstado () {
        return this.Estado;
    }

    public void setCep(int Cep) {
        this.Cep = Cep;
    }

    public int getCep () {
        return this.Cep;
    }

    public void AlterarEndereco (string rua, string Numero, String Bairro, string Cidade, string Estado, int Cep) {
        this.Rua = rua;
        this.Numero = Numero;
        this.Bairro = Bairro;
        this.Cidade = Cidade;
        this.Estado = Estado;
        this.Cep = Cep;
    }
}