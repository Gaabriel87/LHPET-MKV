namespace PET.Models;
public class cliente
{

public int ID { get; set; }
public string Nome { get; set; }
public string Cpf { get; set; }
public string Email { get; set; }
public string Paciente { get; set; }

public cliente(int id, string nome, string cpf,
string email, string paciente)
{
this.ID = id;
this.Nome = nome;
this.Cpf = cpf;
this.Email = email;
this.Paciente = paciente;
}
}