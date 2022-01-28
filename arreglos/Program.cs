// See https://aka.ms/new-console-template for more informatio
Console.WriteLine("Arreglos");
Console.WriteLine("");

string[] coffeTypes;
float[] coffeValues;

coffeTypes = new string[] {"expresso", "largo", "Filtrado", "Latte"};
coffeValues = new float[] {1.2f,         1.5f,     5.0f,      5.5f};

for (int i = 0; i < coffeTypes.Length; i++){
    Console.WriteLine(coffeTypes[i] + " Coffe  $" + coffeValues[i]);
}