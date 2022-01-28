// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<string> tacoShopping = new List<string>();
tacoShopping.Add("dos Pastor");
tacoShopping.Add("Cuatro Tacos de barbacoa");
tacoShopping.Add("Cuatro Tacos de suadero ");

for (int i = 0; i < tacoShopping.Count; i++){
    Console.WriteLine(tacoShopping[i]);
}

//tacoShopping.Remove("dos Pastor");
tacoShopping.RemoveAt(0);

Console.WriteLine(" ");
Console.WriteLine("Lista final de pedidos ");

for (int i = 0; i < tacoShopping.Count; i++)
{
    Console.WriteLine(tacoShopping[i]);
}

//tacoShopping.RemoveAll(0);