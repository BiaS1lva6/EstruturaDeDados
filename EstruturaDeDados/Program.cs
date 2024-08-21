using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //Trabalhando com lista (list)

        /* Crinado uma lista*/
        List<string> frutas = new List<string>();

        /*Adicionar itens na Lista*/
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");


        /* Imprimindo os itens da Lista */
        Console.WriteLine();
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);

        /* Imprimir elemento na indice especifica*/
        Console.WriteLine("Fruta na indice 2:" + frutas[2]);

        /* Inserir um elemento no indice especifico*/
        frutas.Insert(1, "Maracuja");

        /* Imprimindo a lista novamente*/
        Console.WriteLine();
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);

        /* Alterar um elemento no indice especifico*/
        frutas[4] = "Pera";
        /* Imprimindo os itens da Lista */
        Console.WriteLine();
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);

        //Remove elemento da lista
        frutas.RemoveAt(3);

        //remove elementos pelo valor do conteudo 
        frutas.Remove("Morango");

        /* Imprimindo a lista novamente*/
        Console.WriteLine();
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);

        /* Apagar todos os elementos da lista */
        frutas.Clear();

        // Trabalhando com o Dicionario()

        /* Criando um Dicionario de Dados*/
        Dictionary<int, string> carros = new Dictionary<int, string>();
        /* Adicionar Dados a um Dicionario*/
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        Console.WriteLine(); //pula linha
        Console.WriteLine(); //pula linha
        Console.WriteLine(); //pula linha

        Console.WriteLine("Meu dicionario de carros ");
        /* Imprimir um dicionario de dados */
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} {carro.Value}");
        }

        Console.WriteLine(); //pula linha
        Console.WriteLine("========================================");
        Console.WriteLine(); //pula linha

        //Trabalhando com fila //
        /* Criar um fila  (queue) */
        Queue<string> filaBanco = new Queue<string>();

        /* Adicionar Elementos em uma Fila*/
        filaBanco.Enqueue("André");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Maria");
        filaBanco.Enqueue("Bia");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // retirar o primeiro elemento de uma fila
        filaBanco.Dequeue();

        Console.WriteLine(); //pula linha
        Console.WriteLine("========================================");
        Console.WriteLine(); //pula linha
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }


        bool achou = filaBanco.Contains("Bia");

        //Verificar se existe um elemento na fila
        if (achou == true)
        {
            Console.WriteLine("A pessoa está na fila");
        }
        else
        {
            Console.WriteLine("A pessoa não está na fila");
        }

        Console.WriteLine(); //pula linha
        Console.WriteLine("========================================");
        Console.WriteLine(); //pula linha

        //TRABALHANDO COM PILHA(STACK)
        /* Criando uma Pilha*/
        Stack<string> livros = new Stack<string>();

        /*Adicionar elementos em uma pilha*/
        livros.Push("Chapeuzinho Vermelho");
        livros.Push("Branca de neve e o sete anoes");
        livros.Push("Bela Fera");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine(); //pula linha
        Console.WriteLine("========================================");
        Console.WriteLine(); //pula linha

        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine(); //pula linha
        Console.WriteLine("========================================");
        Console.WriteLine(); //pula linha
    }
}