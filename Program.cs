using static System.Console;

string[] carros = { "Volvo", "Peugeot", "Nissan"};

carros[1] = "Opel";
Array.Sort(carros);

foreach (var item in carros)
{
    WriteLine(item.ToUpper());
}

ReadLine();
