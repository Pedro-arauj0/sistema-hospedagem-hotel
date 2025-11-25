# 🏨 Sistema de Hospedagem de Hotel

Sistema de gerenciamento de reservas de hotel desenvolvido em C# como parte de um desafio de programação.

## 📋 Descrição

Este projeto implementa um sistema completo para gerenciar reservas de hotel, permitindo cadastrar hóspedes, suítes e criar reservas com validação automática de capacidade e cálculo de valores.

## ⚡ Funcionalidades

- ✅ Cadastro de hóspedes com nome completo
- ✅ Cadastro de suítes com tipo, capacidade e valor da diária
- ✅ Criação de reservas vinculando hóspedes e suítes
- ✅ Validação automática de capacidade da suíte
- ✅ Cálculo automático do valor total da reserva
- ✅ **Desconto de 10% para reservas acima de 10 dias**
- ✅ Exibição de resumo completo da reserva

## 🛠️ Tecnologias Utilizadas

- **C#** (.NET)
- **Programação Orientada a Objetos (POO)**
- Conceitos: Encapsulamento, Classes, Propriedades, Métodos

## 📂 Estrutura do Projeto
```
Projeto hotel/
│
├── Models/
│   ├── Pessoa.cs          # Classe que representa um hóspede
│   ├── Suite.cs           # Classe que representa uma suíte
│   └── Reserva.cs         # Classe que gerencia as reservas
│
└── Program.cs             # Arquivo principal com exemplos de uso
```

## 🚀 Como Executar

### Pré-requisitos
- .NET SDK instalado ([Download aqui](https://dotnet.microsoft.com/download))
- Visual Studio, Visual Studio Code ou qualquer IDE C#

### Passos

1. **Clone o repositório:**
```bash
git clone https://github.com/Pedro-arauj0/sistema-hospedagem-hotel.git
```

2. **Navegue até a pasta do projeto:**
```bash
cd sistema-hospedagem-hotel
```

3. **Execute o projeto:**
```bash
dotnet run
```

## 💡 Exemplos de Uso

### Criando Hóspedes
```csharp
var hospede1 = new Pessoa("João", "Silva");
var hospede2 = new Pessoa("Maria", "Santos");
```

### Criando uma Suíte
```csharp
var suite = new Suite("Premium", 3, 150.00m);
```

### Criando uma Reserva
```csharp
var reserva = new Reserva(12); // 12 dias
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(new List<Pessoa> { hospede1, hospede2 });
```

### Calculando Valor
```csharp
decimal valorTotal = reserva.CalcularValorDiaria();
// Para 12 dias: R$ 1.800,00 - 10% = R$ 1.620,00
```

## 🎯 Regras de Negócio

- A capacidade da suíte deve ser respeitada ao cadastrar hóspedes
- Reservas com **mais de 10 dias** recebem desconto de **10%** automaticamente
- Não é possível cadastrar hóspedes sem antes cadastrar uma suíte

## 👨‍💻 Autor

**Pedro Araújo**

- GitHub: [@Pedro-arauj0](https://github.com/Pedro-arauj0)
- Projeto: [sistema-hospedagem-hotel](https://github.com/Pedro-arauj0/sistema-hospedagem-hotel)

## 📄 Licença

Este projeto foi desenvolvido como parte de um desafio educacional e está disponível para fins de aprendizado.

---

⭐ Se este projeto te ajudou, considere dar uma estrela no repositório!
