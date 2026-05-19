# Sistema de Hospedagem - .NET MAUI

## Sobre o Projeto

Este aplicativo foi desenvolvido utilizando .NET MAUI com o objetivo de simular um sistema de contratação de hospedagem para um hotel.

O usuário pode:

* Realizar cadastro
* Fazer login
* Escolher uma suíte
* Informar quantidade de adultos e crianças
* Selecionar datas de check-in e check-out
* Calcular o valor total da hospedagem

O aplicativo também possui controle de autenticação utilizando armazenamento seguro do dispositivo.

---

## Funcionalidades do Aplicativo

### Cadastro de Usuário

O usuário pode criar uma conta informando:

* Nome
* E-mail
* Senha

### Login

O sistema realiza autenticação verificando:

* E-mail
* Senha

Após login realizado, o usuário permanece autenticado utilizando `SecureStorage`.

### Contratação de Hospedagem

O usuário pode:

* Escolher a suíte desejada
* Selecionar quantidade de adultos e crianças
* Definir período da hospedagem

O sistema calcula automaticamente:

* Quantidade de diárias
* Valor total da hospedagem

### Resumo da Hospedagem

Ao finalizar a contratação, o aplicativo exibe:

* Tipo da suíte
* Quantidade de hóspedes
* Datas da estadia
* Valor total

---

## Conteúdos Aprendidos

Durante o desenvolvimento deste projeto foram aprendidos os seguintes conceitos:

### Interface gráfica com XAML

Uso de componentes como:

* Label
* Entry
* Button
* Picker
* Stepper
* DatePicker
* Grid
* Border
* StackLayout

### Programação em C#

* Programação orientada a objetos
* Criação de classes e propriedades
* Encapsulamento
* Tratamento de exceções (`try/catch`)
* Estruturas condicionais
* Manipulação de eventos
* Coleções (`List`)
* LINQ (`Any`)
* Navegação entre páginas

### Desenvolvimento Mobile com .NET MAUI

* Associação entre XAML e código C#
* Data Binding
* Navegação entre telas
* Validação de dados
* Armazenamento seguro com `SecureStorage`

### Personalização Visual

O projeto também utilizou:

* Fonte personalizada (`Bangers-Regular`)
  
---

## Cálculo da Hospedagem

O valor total é calculado considerando:

* Quantidade de adultos
* Quantidade de crianças
* Valor da diária
* Quantidade de dias hospedados

valorAdultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;

valorCriancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

ValorTotal = (valorAdultos + valorCriancas) * Estadia

---

## Estrutura do Projeto

### Models

* `Usuario.cs`
* `Quarto.cs`
* `Hospedagem.cs`

Responsáveis pelas regras de negócio e armazenamento das informações.

### Views

* `Cadastro.xaml`
* `Login.xaml`
* `ContratacaoHospedagem.xaml`
* `HospedagemContratada.xaml`

Responsáveis pela interface gráfica do aplicativo.

---

## Recursos Implementados

* Cadastro de usuários
* Sistema de login
* Persistência de sessão
* Escolha de quartos
* Cálculo automático da hospedagem
* Validação de dados
* Navegação entre telas
* Interface personalizada
* Fonte customizada

---

## Como Executar o Projeto

1. Clone o repositório
2. Abra o projeto no Visual Studio 2026
3. Restaure os pacotes necessários
4. Execute o projeto em um emulador Android ou Windows

---

## Estrutura dos Arquivos

* `Models/` → Classes de dados e regras de negócio
* `Views/` → Interfaces gráficas do aplicativo
* `MauiProgram.cs` → Configuração da aplicação e fontes

---

Projeto desenvolvido para a disciplina de Programação para Dispositivos Móveis II com .NET MAUI.
