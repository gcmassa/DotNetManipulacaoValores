
---

## 🧑 Classe `Pessoa`

### 🔹 Construtores
- **Construtor padrão**:
  ```csharp
  public Pessoa() { }
  ```
  Permite instanciar um objeto `Pessoa` sem fornecer nome ou sobrenome inicialmente.

- **Construtor com parâmetros**:
  ```csharp
  public Pessoa(string nome, string sobrenome)
  ```
  Permite criar uma pessoa já com nome e sobrenome definidos. Comentário destaca que:
  > "Todo Construtor tem o mesmo nome de sua Classe e não tem tipo de retorno"

### 🔹 Propriedades privadas
- `_nome` e `_idade` são campos privados usados para encapsular a lógica de validação nas propriedades públicas.

### 🔹 Propriedade `Nome`
- Utiliza expressão lambda para retornar o nome em maiúsculas:
  ```csharp
  get => _nome.ToUpper();
  ```
- Validação no `set` impede que o nome seja vazio:
  ```csharp
  if (value == "") throw new ArgumentException("O nome não pode ser vazio");
  ```

### 🔹 Propriedade `Sobrenome`
- Propriedade automática sem validação:
  ```csharp
  public string Sobrenome { get; set; }
  ```

### 🔹 Propriedade `NomeCompleto`
- Usa interpolação de string:
  ```csharp
  public string NomeCompleto => $"{Nome} {Sobrenome}";
  ```

### 🔹 Propriedade `Idade`
- Valida se a idade é negativa:
  ```csharp
  if (value < 0) throw new ArgumentException("A idade não pode ser menor que zero");
  ```

### 🔹 Método `Apresentar`
- Exibe nome completo e idade em maiúsculas:
  ```csharp
  Console.WriteLine($"Nome: {NomeCompleto.ToUpper()}, Idade: {Idade}");
  ```

---

## 📚 Classe `Curso`

### 🔹 Propriedades
- `Nome`: nome do curso.
- `Alunos`: lista de objetos `Pessoa` representando os alunos matriculados.

### 🔹 Método `AdicionarAluno`
- Adiciona um aluno à lista:
  ```csharp
  Alunos.Add(aluno);
  ```

### 🔹 Método `ObterQuantidadeDeAlunosMatriculados`
- Retorna o número de alunos:
  ```csharp
  int quantidade = Alunos.Count;
  return quantidade;
  ```

### 🔹 Método `RemoverAluno`
- Remove um aluno da lista:
  ```csharp
  return Alunos.Remove(aluno);
  ```

### 🔹 Método `ListarAlunos`
- Exibe os alunos matriculados usando duas técnicas de formatação de string:

#### 1. 🔸 Concatenação de String
```csharp
string texto = "N. " + exibicao + " - " + Alunos[count].NomeCompleto.ToUpper();
```
Comentário explica:
> "Concatenando a string, caracterizado pelo sinal + com a variável"

#### 2. 🔸 Interpolação de String
```csharp
string texto = $"N. {count+1} - {Alunos[count].NomeCompleto.ToUpper()}";
```
Comentário explica:
> "Interpolando a string, caracterizado pelo sinal $ e entre chaves {} à variável"

---

## 🧾 Programa Principal (`Program.cs`)

### 🔹 Instanciando objetos `Pessoa`
- Com construtor direto:
  ```csharp
  Pessoa p1 = new Pessoa("Giancarlo", "Massaccesi");
  ```
- Com nome dos parâmetros:
  ```csharp
  Pessoa p2 = new Pessoa(nome:"Eduardo", sobrenome: "Neves Queiroz");
  ```

### 🔹 Criando e configurando o curso
```csharp
Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();
```

### 🔹 Adicionando alunos ao curso
```csharp
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
```

### 🔹 Listando alunos
```csharp
cursoDeIngles.ListarAlunos();
```

---

## 🧠 Considerações Finais

- O código demonstra boas práticas de encapsulamento, validação e uso de técnicas de formatação de strings.
- Os comentários ajudam a entender a diferença entre concatenação e interpolação.
- A estrutura está clara e modular, facilitando manutenção e expansão.
