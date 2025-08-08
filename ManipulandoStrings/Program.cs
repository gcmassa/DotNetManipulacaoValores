// See https://aka.ms/new-console-template for more information

using ManipulandoStrings.models;

Pessoa p1 = new Pessoa("Giancarlo", "Massaccesi"); //Instanciando usando técnica de construtor
//p1.Nome = "Giancarlo";
//p1.Sobrenome = "Massaccesi";

Pessoa p2 = new Pessoa(nome:"Eduardo", sobrenome: "Neves Queiroz"); //Instanciado utilizando dos parametros específicos do construtor
//p2.Nome = "Eduardo";
//p2.Sobrenome = "Neves Queiroz";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

