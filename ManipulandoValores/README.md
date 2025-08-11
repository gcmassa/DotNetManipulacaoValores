
---

## 🧠 Visão Geral do Código

Este código demonstra:
- Como configurar a cultura padrão da aplicação.
- Operações com tipos diferentes (int e string).
- Formatação de valores monetários, percentuais e inteiros.
- Manipulação e validação de datas com diferentes formatos.

---

## 🛠️ Explicação por Blocos

### 🌍 Cultura Padrão

```csharp
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
```

- Define a cultura padrão para o thread atual como "en-US" (inglês dos EUA).
- Isso afeta como números, datas e moedas são formatados por padrão.

---

### ➕ Concatenação de Tipos Diferentes

```csharp
int numero1 = 10;
string numero2 = "20";

string resultado = numero1 + numero2;
Console.WriteLine(resultado);
```

- `numero1` é um inteiro e `numero2` é uma string.
- Ao somá-los, ocorre uma **concatenação**, não uma soma aritmética.
- Resultado: `"1020"`

---

### 💰 Formatação Monetária

```csharp
decimal valorMonetario = 1082.40M;

Console.WriteLine(valorMonetario);
Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
Console.WriteLine(valorMonetario.ToString("C1", CultureInfo.CreateSpecificCulture("pt-BR")));
```

- `C` representa o formato de moeda.
- `"en-US"` exibe como `$1,082.40`, enquanto `"pt-BR"` exibe como `R$ 1.082,40`.
- `C1` define uma casa decimal: `R$ 1.082,4`

---

### 📊 Formatação Percentual

```csharp
double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));
```

- `"P"` converte o número para percentual.
- Saída: `34.21%` (com base na cultura atual)

---

### 🔢 Formatação Personalizada de Inteiros

```csharp
int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));
```

- Formata o número como `12-34-56`.
- Cada `#` representa um dígito.

---

### 📅 Manipulação de Datas

```csharp
DateTime data = DateTime.Now;
DateTime data1 = DateTime.Parse("08/08/2025 21:00");
```

- `data` pega a data e hora atual.
- `data1` converte uma string para `DateTime` usando o formato padrão da cultura atual.

---

### 🕵️‍♂️ Validação de Data com Formato Específico

```csharp
string dataString = "2022-13-17 18:00";
DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out data2);
```

- Tenta converter `dataString` para `DateTime` usando um formato exato.
- `"2022-13-17"` é inválido (mês 13 não existe), então `TryParseExact` retorna `false`.

```csharp
if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! {data2}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}
```

- Exibe mensagem de sucesso ou erro com base na conversão.

---

### 🗓️ Exibição de Datas

```csharp
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
Console.WriteLine(data1);
Console.WriteLine(data2);
```

- Exibe a data atual em diferentes formatos:
  - Completo com hora.
  - Apenas data.
  - Apenas hora.
- Também exibe `data1` e `data2` (se válida).

---

## ✅ Conclusão

Esse código é um ótimo exemplo de como trabalhar com:
- Localização e cultura.
- Formatação de dados numéricos e temporais.
- Validação segura de datas com `TryParseExact`.

