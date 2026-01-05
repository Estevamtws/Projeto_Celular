# Trilha .NET - Desafio de POO

## Sobre Este Desafio

Este diretório está destinado ao desafio de Programação Orientada a Objetos (POO) da trilha .NET da DIO.

## Status Atual

⚠️ **Esta pasta está atualmente vazia porque foi configurada como um submódulo Git.**

## Como Configurar

### Se você é um estudante tentando acessar este projeto:

Você tem algumas opções:

#### 1. Criar o Projeto do Zero (Recomendado para Aprendizado)

Esta é a melhor opção se você quer fazer o desafio sozinho:

```bash
# Entre na pasta
cd trilha-net-poo-desafio

# Crie um novo projeto console .NET
dotnet new console -o .

# Ou especifique o nome do projeto
dotnet new console -n DesafioPOO
```

#### 2. Usar o Visual Studio

1. Abra o Visual Studio
2. Clique em **File → New → Project**
3. Selecione **Console App** (.NET 6.0 ou superior)
4. Configure:
   - **Project name**: DesafioPOO
   - **Location**: Selecione a pasta `trilha-net-poo-desafio`
5. Clique em **Create**

#### 3. Inicializar o Submódulo (Se Aplicável)

Se este projeto referencia um repositório externo:

```bash
# Volte para a raiz do repositório
cd ..

# Inicialize o submódulo
git submodule init
git submodule update
```

## Estrutura Esperada do Projeto

Após criar o projeto, você deverá ter:

```
trilha-net-poo-desafio/
├── DesafioPOO.csproj    # Arquivo do projeto
├── Program.cs            # Código principal
└── Models/              # Classes do desafio (você criará)
    ├── Smartphone.cs
    ├── Nokia.cs
    └── Iphone.cs
```

## O Desafio

O desafio típico envolve:

1. **Criar uma classe abstrata `Smartphone`** com:
   - Propriedades: Número, Modelo, IMEI, Memória
   - Métodos: Ligar(), ReceberLigacao()
   - Método abstrato: InstalarAplicativo()

2. **Criar classes derivadas** (Nokia, iPhone) que implementam o método abstrato

3. **Demonstrar polimorfismo** criando instâncias e chamando métodos

## Exemplo de Estrutura de Código

```csharp
// Smartphone.cs
public abstract class Smartphone
{
    public string Numero { get; set; }
    // ... outras propriedades
    
    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }
    
    public abstract void InstalarAplicativo(string nomeApp);
}

// Nokia.cs
public class Nokia : Smartphone
{
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando {nomeApp} no Nokia...");
    }
}
```

## Compilar e Executar

```bash
# Compilar
dotnet build

# Executar
dotnet run
```

## Recursos Úteis

- [Documentação .NET](https://learn.microsoft.com/dotnet/)
- [POO em C#](https://learn.microsoft.com/dotnet/csharp/fundamentals/object-oriented/)
- [Classes Abstratas](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/abstract)

## Dúvidas?

Se você encontrou esta pasta vazia, consulte o README.md na raiz do repositório para instruções detalhadas.

Boa sorte com o desafio! 🚀
