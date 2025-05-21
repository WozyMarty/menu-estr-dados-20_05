Este é um sistema interativo desenvolvido em C# que permite a interação com diferentes estruturas de dados. O programa fornece um menu para que o usuário escolha qual estrutura de dados deseja trabalhar, sendo elas:

  * Vetores (Arrays)

  * Matrizes (Arrays 2D)

  * Listas

  * Filas

  * Pilhas

  * Algoritmos de Pesquisa (não implementado no momento)

Cada estrutura de dados possui um conjunto de funcionalidades básicas como inserção, remoção, exibição e busca de elementos.

//Como rodar o sistema (Passo a Passo)
   - Baixar o código:
   - Faça o download do código-fonte do projeto ou clone o repositório para a sua máquina local.
   - Abrir o projeto no Visual Studio ou qualquer IDE que suporte C#:
   - Abra o Visual Studio ou uma IDE de sua escolha.
   - Selecione a opção para abrir um projeto existente e escolha a pasta onde você baixou ou clonou o código.
   - Compilar e rodar:

      - Compile o projeto (geralmente pressionando Ctrl + Shift + B no Visual Studio).
      - Execute o programa (pressionando Ctrl + F5 ou F5 para rodar o código).

//Interagir com o sistema:

Após iniciar o programa, será exibido um menu no terminal ou console, onde você poderá escolher a estrutura de dados com a qual deseja trabalhar.

Pré-requisitos de execução
  - .NET SDK: Você precisa do .NET SDK instalado em sua máquina para rodar este código. Você pode baixar o SDK do .NET aqui.
  - IDE ou Editor de Texto: Para editar e executar o código, você pode usar o Visual Studio, Visual Studio Code ou qualquer outra IDE que suporte C#.

Exemplos de uso
Iniciar o Programa:

O programa começa com um menu que oferece as opções para escolher a estrutura de dados que você deseja manipular.

Trabalhar com Vetores:

- Você pode inserir, remover, exibir e buscar elementos dentro de um vetor. Por exemplo:
  * Inserir Elemento: O programa solicitará um número e o colocará no vetor.
  * Remover Elemento: Você digita um número e, se encontrado, ele será removido do vetor.
  * Exibir Elementos: Todos os elementos armazenados no vetor serão listados.
  * Buscar Elemento: O programa procura o número fornecido no vetor e informa se ele foi encontrado ou não.


Trabalhar com Matrizes:

- A manipulação de matrizes segue a mesma lógica dos vetores, porém você também pode especificar a linha e a coluna para inserir ou remover elementos.

  * Inserir: Um número será inserido na posição específica da matriz (linha e coluna).
  * Remover: Um número será removido de uma posição específica, substituindo-o por 0.
  * Buscar: A busca pelo número ocorre em toda a matriz, e o programa informará a posição onde o número foi encontrado.

Trabalhar com Listas:

- As listas permitem adicionar e remover elementos de forma dinâmica. O funcionamento é semelhante ao vetor, mas com maior flexibilidade quanto ao tamanho da estrutura.

Trabalhar com Filas:

- A fila segue o princípio FIFO (First In, First Out). Ao inserir um número, ele é adicionado ao final da fila. Quando removido, o número que foi inserido primeiro é removido.

Trabalhar com Pilhas:

- A pilha segue o princípio LIFO (Last In, First Out). O número inserido por último será o primeiro a ser removido.

//Estrutura do Menu e Comandos Disponíveis:
Ao iniciar o programa, o seguinte menu será exibido:

	---MENU INTERATIVO---
	---ESCOLHA COM QUAL ESTRUTURA DE DADOS---
	---PARA TRABALHAR---

	[1] Vetores
	[2] Matrizes
	[3] Trabalhar com Lista
	[4] Trabalhar com Fila
	[5] Trabalhar com Pilha
	[6] Algoritmos de Pesquisa (não "codado")
	[0] Encerrar

Opções do menu:
[1] Vetores:

Trabalhar com vetores (Arrays).

Funções disponíveis: Inserir Elemento, Remover Elemento, Exibir todos os Elementos, Buscar Elemento.

[2] Matrizes:

Trabalhar com Matrizes (Arrays 2D).

Funções disponíveis: Inserir Elemento, Remover Elemento, Exibir todos os Elementos, Buscar Elemento.

[3] Trabalhar com Lista:

Trabalhar com Listas.

Funções disponíveis: Inserir Elemento, Remover Elemento, Exibir todos os Elementos, Buscar Elemento.

[4] Trabalhar com Fila:

Trabalhar com Filas.

Funções disponíveis: Inserir Elemento, Remover Elemento, Exibir todos os Elementos, Buscar Elemento.

[5] Trabalhar com Pilha:

Trabalhar com Pilhas.

Funções disponíveis: Inserir Elemento, Remover Elemento, Exibir todos os Elementos, Buscar Elemento.

[6] Algoritmos de Pesquisa:

Esta opção ainda não está implementada, mas poderia ser usada para incluir funcionalidades como pesquisa binária ou outros algoritmos de busca.

[0] Encerrar:

Encerrar o programa.

Comandos dentro de cada estrutura:
[1] Inserir Elemento: Solicita ao usuário um valor para ser inserido na estrutura de dados.

[2] Remover Elemento: Solicita ao usuário um valor para ser removido da estrutura de dados.

[3] Exibir todos os Elementos: Exibe todos os elementos armazenados na estrutura de dados.

[4] Consultar/buscar Elementos: Solicita ao usuário um valor e verifica se ele existe na estrutura de dados.

[0] Voltar ao Menu Principal: Retorna ao menu principal do programa.

