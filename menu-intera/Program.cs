using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_intera
{
    public static class Program
    {
        public static void Main()
        {
            bool execucao = true;

            while (execucao)
            {
                Console.WriteLine("\n\t---MENU INTERATIVO---");
                Console.WriteLine("\n\t---ESCOLHA COM QUAL ESTRUTURA DE DADOS---");
                Console.WriteLine("\n\t---PARA TRABALHAR---");
                Console.WriteLine("\n\n\t[1] Vetores");
                Console.WriteLine("\t[2] Matrizes");
                Console.WriteLine("\t[3] Trabalhar com Lista");
                Console.WriteLine("\t[4] Trabalhar com Fila");
                Console.WriteLine("\t[5] Trabalhar com Pilha");
                Console.WriteLine("\t[6] Algoritmos de Pesquisa"); //não "codado"
                Console.WriteLine("\t[0] Encerrar\n");
                Console.Write("\tEscolha uma opção: ");
                string opcao = Console.ReadLine();

                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        Vetor.menu();
                        break;
                    case "2":
                        Matriz.menu();
                        break;
                    case "3":
                        Lista.menu();
                        break;
                    case "4":
                        Fila.menu();
                        break;
                    case "5":
                        Pilha.menu();
                        break;
                    case "6":
                        Console.WriteLine("Not Workin'");
                        break;
                    case "0":
                        execucao = false;
                        Console.WriteLine("\tEncerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("\tOpção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }

    public static class Vetor
    {
        public static void menu()
        {
            int[] vetor = new int[100];
            int x = 0;
            
            Console.WriteLine("\n\n\t\t---VETORES---\n");
            Console.WriteLine("\t[1] Inserir Elemento");
            Console.WriteLine("\t[2] Remover Elemento");
            Console.WriteLine("\t[3] Exibir todos os Elementos");
            Console.WriteLine("\t[4] Consultar/buscar Elementos");
            Console.WriteLine("\t[0] Voltar ao Menu Principal");

            string opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    Console.Write("\nDigite o número para inserir: ");
                    int valor = int.Parse(Console.ReadLine());
                    vetor[x] = valor;
                    x++;
                    Console.WriteLine("\nNúmero inserido com sucesso!");
                    Vetor.menu();
                    break;

                case "2":
                    Console.Write("Digite o número para remover: ");
                    int remover = int.Parse(Console.ReadLine());
                    int indiceRemover = -1;

                    for (int i = 0; i < x; i++)
                    {
                        if (vetor[i] == remover)
                        {
                            indiceRemover = i;
                            break;
                        }
                    }

                    if (indiceRemover != -1)
                    {
                        for (int i = indiceRemover; i < x - 1; i++)
                        {
                            vetor[i] = vetor[i + 1];
                        }
                        x--;
                        Console.WriteLine("Número removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Número não encontrado!");
                    }
                    Vetor.menu();
                    break;

                case "3":
                    if (x == 0)
                    {
                        Console.WriteLine("Vetor vazio.");
                    }
                    else
                    {
                        Console.WriteLine("Elementos no vetor:");
                        for (int i = 0; i < x; i++)
                        {
                            Console.WriteLine(vetor[i]);
                        }
                    }
                    Vetor.menu();
                    break;

                case "4":
                    Console.Write("Digite o número para buscar: ");
                    int buscar = int.Parse(Console.ReadLine());
                    bool encontrado = false;

                    for (int i = 0; i < x; i++)
                    {
                        if (vetor[i] == buscar)
                        {
                            encontrado = true;
                            break;
                        }
                    }

                    if (encontrado)
                        Console.WriteLine("Número encontrado no vetor!");
                    else
                        Console.WriteLine("Número não está no vetor.");
                    Vetor.menu();
                    break;

                case "0":
                    Program.Main();
                    break;
                default:
                    Console.WriteLine("\tOpção inválida. Tente novamente.");
                    break;
            }
        }
    }

    public static class Matriz
    {
        public static void menu()
        {
            int[,] matriz = new int[10, 10]; 
            int x = 0;
            Console.WriteLine("\n\n\t\t---MATRIZ---\n");
            Console.WriteLine("\t[1] Inserir Elemento");
            Console.WriteLine("\t[2] Remover Elemento");
            Console.WriteLine("\t[3] Exibir todos os Elementos");
            Console.WriteLine("\t4] Consultar/buscar Elementos");
            Console.WriteLine("\t[0] Voltar ao Menu Principal");

            string opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a linha (0-9): ");
                    int linha = int.Parse(Console.ReadLine());
                    Console.Write("Digite a coluna (0-9): ");
                    int coluna = int.Parse(Console.ReadLine());

                    if (linha < 0 || linha >= matriz.GetLength(0) || coluna < 0 || coluna >= matriz.GetLength(1))
                    {
                        Console.WriteLine("Índices fora do limite da matriz!");
                    }
                    else
                    {
                        Console.Write("Digite o número para inserir: ");
                        int valor = int.Parse(Console.ReadLine());
                        matriz[linha, coluna] = valor; 
                        x++;
                        Console.WriteLine("Número inserido com sucesso!");
                    }
                    Matriz.menu();

                    break;
                case "2":
                    Console.Write("Digite a linha (0-9) do número a ser removido: ");
                    int linhaRemover = int.Parse(Console.ReadLine());
                    Console.Write("Digite a coluna (0-9) do número a ser removido: ");
                    int colunaRemover = int.Parse(Console.ReadLine());

                    if (linhaRemover < 0 || linhaRemover >= matriz.GetLength(0) || colunaRemover < 0 || colunaRemover >= matriz.GetLength(1))
                    {
                        Console.WriteLine("Índices fora do limite da matriz!");
                    }
                    else
                    {
                        matriz[linhaRemover, colunaRemover] = 0; 
                        x--;
                        Console.WriteLine("Número removido com sucesso!");
                    }
                    Matriz.menu();
                    break;

                case "3":
                    Console.WriteLine("Elementos na matriz:");
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            Console.Write(matriz[i, j] + "\t");
                        }
                        Console.WriteLine(); 
                    }
                    Matriz.menu();
                    break;

                case "4":
                    Console.Write("Digite o número para buscar: ");
                    int buscar = int.Parse(Console.ReadLine());
                    bool encontrado = false;

                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            if (matriz[i, j] == buscar)
                            {
                                Console.WriteLine($"Número encontrado na posição [{i}, {j}]!");
                                encontrado = true;
                                break;
                            }
                        }
                        if (encontrado) break;
                    }

                    if (!encontrado)
                        Console.WriteLine("Número não encontrado na matriz.");
                    Matriz.menu();
                    break;

                case "0":
                    Program.Main();
                    break;
                default:
                    Console.WriteLine("\tOpção inválida. Tente novamente.");
                    break;
            }
        }
    }

    public static class Lista
    {
        public static void menu()
        {
            List<int> lista = new List<int>();
            Console.WriteLine("\n\n\t\t---LISTA---\n");
            Console.WriteLine("\t[1] Inserir Elemento");
            Console.WriteLine("\t[2] Remover Elemento");
            Console.WriteLine("\t[3] Exibir todos os Elementos");
            Console.WriteLine("\t[4] Consultar/buscar Elementos");
            Console.WriteLine("\t[0] Voltar ao Menu Principal");

            string opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o número para inserir: ");
                    int valorInserir = int.Parse(Console.ReadLine());
                    lista.Add(valorInserir);
                    Console.WriteLine("Número inserido com sucesso!");
                    Lista.menu();
                    break;

                case "2":
                    Console.Write("Digite o número para remover: ");
                    int valorRemover = int.Parse(Console.ReadLine());
                    if (lista.Remove(valorRemover))
                    {
                        Console.WriteLine("Número removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Número não encontrado!");
                    }
                    Lista.menu();
                    break;

                case "3":
                    if (lista.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia.");
                    }
                    else
                    {
                        Console.WriteLine("Elementos na lista:");
                        foreach (var item in lista)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    Lista.menu();
                    break;

                case "4":
                    Console.Write("Digite o número para buscar: ");
                    int valorBuscar = int.Parse(Console.ReadLine());
                    if (lista.Contains(valorBuscar))
                    {
                        Console.WriteLine("Número encontrado na lista!");
                    }
                    else
                    {
                        Console.WriteLine("Número não encontrado na lista.");
                    }
                    Lista.menu();
                    break;

                case "0":
                    Program.Main();
                    break;
                default:
                    Console.WriteLine("\tOpção inválida. Tente novamente.");
                    break;
            }
        }
    }

    public static class Fila
    {
        public static void menu()
        {
            Queue<int> fila = new Queue<int>();
            Console.WriteLine("\n\n\t\t---FILA---\n");
            Console.WriteLine("\t[1] Inserir Elemento");
            Console.WriteLine("\t[2] Remover Elemento");
            Console.WriteLine("\t[3] Exibir todos os Elementos");
            Console.WriteLine("\t[4] Consultar/buscar Elementos");
            Console.WriteLine("\t[0] Voltar ao Menu Principal");

            string opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o número para inserir na fila: ");
                    int valorInserir = int.Parse(Console.ReadLine());
                    fila.Enqueue(valorInserir);
                    Console.WriteLine("Número inserido na fila com sucesso!");
                    Fila.menu();
                    break;

                case "2":
                    if (fila.Count > 0)
                    {
                        int valorRemover = fila.Dequeue(); 
                        Console.WriteLine($"Número {valorRemover} removido da fila!");
                    }
                    else
                    {
                        Console.WriteLine("A fila está vazia! Não há elementos para remover.");
                    }
                    Fila.menu();
                    break;

                case "3":
                    if (fila.Count == 0)
                    {
                        Console.WriteLine("A fila está vazia.");
                    }
                    else
                    {
                        Console.WriteLine("Elementos na fila:");
                        foreach (var item in fila)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    Fila.menu();
                    break;

                case "4":
                    Console.Write("Digite o número para buscar na fila: ");
                    int valorBuscar = int.Parse(Console.ReadLine());
                    bool encontrado = fila.Contains(valorBuscar); 

                    if (encontrado)
                    {
                        Console.WriteLine("Número encontrado na fila!");
                    }
                    else
                    {
                        Console.WriteLine("Número não encontrado na fila.");
                    }
                    Fila.menu();
                    break;

                case "0":
                    Program.Main();
                    break;
                default:
                    Console.WriteLine("\tOpção inválida. Tente novamente.");
                    break;
            }
        }
    }

    public static class Pilha
    {
        public static void menu()
        {
            Stack<int> pilha = new Stack<int>();
            Console.WriteLine("\n\n\t\t---PILHA---\n");
            Console.WriteLine("\t[1] Inserir Elemento");
            Console.WriteLine("\t[2] Remover Elemento");
            Console.WriteLine("\t[3] Exibir todos os Elementos");
            Console.WriteLine("\t[4] Consultar/buscar Elementos");
            Console.WriteLine("\t[0] Voltar ao Menu Principal");

            string opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o número para inserir na pilha: ");
                    int valorInserir = int.Parse(Console.ReadLine());
                    pilha.Push(valorInserir);
                    Console.WriteLine("Número inserido na pilha com sucesso!");
                    Pilha.menu();
                    break;

                case "2":
                    if (pilha.Count > 0)
                    {
                        int valorRemover = pilha.Pop();
                        Console.WriteLine($"Número {valorRemover} removido da pilha!");
                    }
                    else
                    {
                        Console.WriteLine("A pilha está vazia! Não há elementos para remover.");
                    }
                    Pilha.menu();
                    break;

                case "3":
                    if (pilha.Count == 0)
                    {
                        Console.WriteLine("A pilha está vazia.");
                    }
                    else
                    {
                        Console.WriteLine("Elementos na pilha:");
                        foreach (var item in pilha)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    Pilha.menu();
                    break;

                case "4":
                    Console.Write("Digite o número para buscar na pilha: ");
                    int valorBuscar = int.Parse(Console.ReadLine());
                    bool encontrado = pilha.Contains(valorBuscar);

                    if (encontrado)
                    {
                        Console.WriteLine("Número encontrado na pilha!");
                    }
                    else
                    {
                        Console.WriteLine("Número não encontrado na pilha.");
                    }
                    Pilha.menu();
                    break;

                case "0":
                    Program.Main();
                    break;
                default:
                    Console.WriteLine("\tOpção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
