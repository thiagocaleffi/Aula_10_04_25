using static System.Console;

string[] nomes = { "Pedro", "Maria", "João", "Beatriz", "Mario" };//criação do array

WriteLine("<<<<<<<<<<< NOMES >>>>>>>>>>>");
WriteLine("Tamanho do array nomes:" + nomes.Length);//verificando o tamanho do array
Array.Sort(nomes);
WriteLine("Os nomes dentro do array são......");
foreach (var item in nomes)
    Write(item + " , ");
WriteLine();
WriteLine("<<<<<<<<<<< ADICIONANDO UM NOME >>>>>>>>>>>");
string novonome = "Kassandra";
List<string> adnome = new List<string>(nomes.ToList());
adnome.Add(novonome);
nomes = adnome.ToArray();
WriteLine("O tamanho do array agora é: " + nomes.Length);
WriteLine("Os nomes dentro do array agora são.....");
foreach (var item in nomes)
{
    WriteLine(item);
}

ReadLine();