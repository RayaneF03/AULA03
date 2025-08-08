internal class Program
{
    private static void Main(string[] args)
    {
        List<string> Lista = new List<string>();
        Lista.Add("Banana");
        Lista.Add("uva");
        Lista.Add("laranja");
        Lista.Add("melancia");

        Console.WriteLine("Imprimir os valores do list na tela ");
        foreach (string item in Lista)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\nImprimir os valores do list na tela ");
        Console.WriteLine($"item na posição 2: {Lista[2]}");

        Console.WriteLine("\nAdicionar um item na posiçao especifica ");
        Lista.Insert(1, "tangerina");

        Console.WriteLine("\nImprimir os valores do list na tela ");
        foreach (string item in Lista)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nAlterar um item na lista específico");
        Lista[4] = "Goiaba";

        Console.WriteLine("\nImprimir os valores do list na tela ");
        foreach (string item in Lista)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\nRemover um item da list na tela ");
        Lista.RemoveAt(4);
        foreach (string item in Lista)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nRemover todos os items da list na tela ");
        Lista.Clear();
        foreach (string item in Lista)
        {
            Console.WriteLine(item);
        }


    }
}