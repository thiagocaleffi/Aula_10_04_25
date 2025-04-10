using static System.Console;

string[] carros = { "Volvo", "Peugeot", "Nissan"};

carros[1] = "Opel";
string novamarca = "Toyota";
List<string> novocarros = new List<string>(carros.ToList());
novocarros.Add(novamarca);
carros = novocarros.ToArray();  
Array.Sort(carros);

foreach (var item in carros)
{
    WriteLine(item.ToUpper());
}

ReadLine();
