# 🚗 Projeto Sistema de Estacionamento

Este é um projeto de console application desenvolvido em C# que simula um sistema de gerenciamento de estacionamento. O objetivo foi aplicar e solidificar conceitos fundamentais do C# e da lógica de programação.

O sistema é um desafio de projeto comum para demonstrar a capacidade de manipular dados, criar estruturas lógicas e tratar exceções de entrada do usuário, garantindo que o programa seja robusto e à prova de falhas.

## ✨ Funcionalidades

O sistema é executado em um loop de menu interativo que permite ao usuário:

* **💲 Definir Preços:** O usuário define um preço inicial fixo e um preço por hora para o estacionamento.
* **➕ Cadastrar Veículo:** Adiciona um veículo à lista do estacionamento usando sua placa.
* **➖ Remover Veículo:** Remove um veículo com base na placa.
* **🧾 Calcular Taxa:** Ao remover, o sistema solicita o número de horas que o veículo permaneceu estacionado e calcula o valor total a ser pago com base no preço inicial e no preço por hora.
* **📄 Listar Veículos:** Exibe uma lista de todas as placas dos veículos atualmente estacionados.
* **🔒 Validação Robusta:** O sistema possui um forte tratamento de erros:
    * Não aceita valores vazios ou nulos para placas (usando `string.IsNullOrWhiteSpace`).
    * Não aceita valores inválidos (texto ou vazio) para preços ou horas (usando `double.TryParse` em loop).
    * Verifica se um veículo existe (`List.Contains`) antes de tentar removê-lo.
    * Permite ao usuário cancelar uma ação (como "Remover") e voltar ao menu principal.

## 🛠️ Tecnologias Utilizadas

* **.NET** (Plataforma)
* **C#** (Linguagem)
* **Console Application** (Tipo de Projeto)

## 🧠 Conceitos Aplicados e Aprendizados

Este projeto foi um ótimo exercício para praticar:

* **Programação Orientada a Objetos (POO):** Criação de classes (`Estacionamento`) e métodos para organizar o código.
* **Manipulação de Listas:** Uso de `List<string>` para adicionar (`.Add`), remover (`.Remove`) e verificar (`.Contains`) itens.
* **Laços de Repetição (`while`):** Uso do `while(true)` para criar o menu principal e para insistir que o usuário digite uma entrada válida.
* **Estruturas Condicionais (`if`/`else`):** Validação de toda a lógica de negócios.
* **Estrutura de Seleção (`switch case`):** Gerenciamento da navegação do menu.
* **Conversão Segura de Tipos:** Uso intensivo de `double.TryParse` e do parâmetro `out` para evitar que o programa quebre com entradas inválidas.
* **Depuração de Lógica:** Resolução de bugs complexos, como loops infinitos e a importância de loops aninhados (como no caso de validar as horas *depois* de validar a placa).
* **Experiência do Usuário (UX):** Pensar em casos de uso reais, como um usuário que esquece a placa e precisa voltar ao menu.

## 🚀 Como Executar o Projeto

Você precisará ter o [.NET SDK](https://dotnet.microsoft.com/en-us/download) instalado em sua máquina.

1.  Clone o repositório:
    ```bash
    git clone [https://github.com/CalebeXimenes07/programa-estacionamento-csharp.git](https://github.com/CalebeXimenes07/programa-estacionamento-csharp.git)
    ```

2.  Navegue até a pasta do projeto:
    ```bash
    cd programa-estacionamento-csharp
    ```

3.  Execute o projeto:
    ```bash
    dotnet run
    ```

O programa será iniciado no seu terminal, exibindo o menu principal.
# programa-estacionamento-csharp
