/*using System;
public class Pessoa
{
    public Pessoa (string nome, string senha, long cpf)
    {
        this.Nome = nome;
        this.senha = senha;
        this.cpf = cpf;
    }

    //public string Nome { get; set; }
    //public decimal Saldo { get; set; }
    //public DateTime DataNascimento { get; set; }
    //public string Senha { get; set; }
    private DateTime dataNascimento;
    public DateTime getDataNascimento()
    {
        return dataNascimento;
    }

    public void setDataNascimento(DateTime value)
    {
        dataNascimento = value;
    }

    public decimal Saldo { get; set; }
    public string Nome;
    private long cpf;
    public string CPF()
    {
        return cpf.ToString("000.000.000-00");
    }
    public void setCPF(string value)
    {
        cpf = long.Parse(
            value.Replace(".", "")
            .Replace("-", ""));*/
    
    /*public string CPF
    {
        get
        {
            return cpf.ToString("000.000.000-00");
        }
        set
        {
            cpf = long.Parse(
                value.Replace(".", "")
                .Replace("-", ""));
            
        }
    }*/

    /*}
    private string senha;
    private string criptografar(string s)
    {
        return s + "oi kkk";
    }
    public string getSenha()
    {
        return senha;
    }

    public void setSenha(string value)
    {
        senha = criptografar(value);
    }
}*/

//Pessoa pessoa = new Pessoa("Edjarma", "Xispita");

//Pessoa pessoa2 = pessoa;
//pessoa2.Saldo = 80;

//Console.WriteLine(pessoa.Saldo);

//DateTime date = new DateTime(2004, 8, 25);
//DateTime date2 = date;
//date2 = date2.AddDays(1);

//Console.WriteLine(date);