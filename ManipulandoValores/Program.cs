// See https://aka.ms/new-console-template for more information
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // alterando a localização do Código

int numero1 = 10;
string numero2 = "20";

string resultado = numero1 + numero2;

Console.WriteLine(resultado);

decimal valorMonetario = 1082.40M;

Console.WriteLine(valorMonetario);
Console.WriteLine($"{valorMonetario:C}"); // formantando usando interpolação usando o atributo C para moeda corrente
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // alterando a localização da Cultura
Console.WriteLine(valorMonetario.ToString("C1", CultureInfo.CreateSpecificCulture("pt-BR"))); // Personalizando a formatação onde C1 representa as casas decimais C + quantidade de casas

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P")); // Representando a porcentagem

int numero = 123456;

Console.WriteLine(numero.ToString("##-##-##")); // Outro formato de formação onde ## representa os algarismos

DateTime data = DateTime.Now;
DateTime data1 = DateTime.Parse("08/08/2025 21:00");
DateTime data2;

string dataString = "2022-13-17 18:00";

DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out data2);

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out data2);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! {data2}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}

Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
Console.WriteLine(data1);
Console.WriteLine(data2);
