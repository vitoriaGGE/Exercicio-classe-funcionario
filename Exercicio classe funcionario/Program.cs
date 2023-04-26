using Exercicio_classe_funcionario;
using System.Globalization;


Funcionario func1, func2;


func1 = new Funcionario();
func2 = new Funcionario();

Console.Write("Informe aqui os dados do primeiro funcionario:  \r\nNome: ");
func1.Nome = Console.ReadLine();
Console.Write("Salario: ");
func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Informe aqui os dados do segundo funcionario:  \r\nNome: ");
func2.Nome = Console.ReadLine();
Console.Write("Salario: ");
func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = ((func2.Salario + func1.Salario) / 2);

Console.WriteLine("A média dos salarios é: " + media.ToString("F2", CultureInfo.InvariantCulture));