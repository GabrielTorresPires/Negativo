
int numero;

Console.WriteLine("------------------------------------------");
Console.WriteLine("-----Descubra se o número é negativo-----");
Console.WriteLine("------------------------------------------");

Console.Write("Por favor, digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero < 0)

{
    Console.WriteLine($"O número {numero} é negativo." );
}

else

{
    Console.WriteLine($"O número {numero} não é negativo." );
}
