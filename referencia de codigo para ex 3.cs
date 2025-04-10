using static System.Console;

int[] Numeros = new int[10];
int[] Par = new int[10];
int[] Impar = new int[10];

for (int i = 0; i < Numeros.Length; i++)
{
    Write($"Digite um valor inteiro, que seja maior que 0 para o item {i + 1}: ");
    Numeros[i] = Convert.ToInt32(ReadLine());
}

for (int i = 0; i < Numeros.Length; i++)
{
    if (Numeros[i] % 2 == 0)
    {
        Par[i] = Numeros[i];
    }
    else
    {
        Impar[i] = Numeros[i];
    }
}

Array.Sort(Numeros);
Array.Sort(Par);
Array.Sort(Impar);

Array.Reverse(Numeros);
Array.Reverse(Impar);
Array.Reverse(Par);

Write("\nO primeiro array possui os valores: ");
for (var i = 0; i < Numeros.Length; i++)
{
    if (Numeros[i] != 0)
    {
        Write(Numeros[i] + " ");
    }
}
Write("\nO array com números pares possui os valores: ");
for (var i = 0; i < Par.Length; i++)
{
    if (Par[i] != 0)
    {
        Write(Par[i] + " ");
    }
}
Write("\nO array com números ímpares possui os valores: ");
for (var i = 0; i < Impar.Length; i++)
{
    if (Impar[i] != 0)
    {
        Write(Impar[i] + " ");
    }
}

ReadLine();
