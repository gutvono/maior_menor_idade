string idade1 = "", idade2 = "", idade3 = "", idade4 = "", idade5 = "", idade6 = "", idade7 = "", idade8 = "", idade9 = "", idade10 = "", maior = "Maiores de idade: ", menor = "Menores de idade: ";

Console.WriteLine("ESTE PROGRAMA IRÁ MOSTRAR QUAIS IDADES SAO MAIORES OU MENORES QUE 18 ANOS.");
Console.WriteLine("As idades que serão informadas precisam ser maiores que 0!");
Console.WriteLine();

do
{   
    Console.Write("Informe a 1ª idade: ");
    idade1 = Console.ReadLine();
    Console.WriteLine();

    if (0 < int.Parse(idade1) && int.Parse(idade1) < 18)
    {
        menor += $"{idade1} ";
    }

    if (int.Parse(idade1) > 18)
    {
        maior += $"{idade1} ";
    }
} while (int.Parse(idade1) <= 0);

do
{
    Console.Write("Informe a 2ª idade: ");
    idade2 = Console.ReadLine();
    Console.WriteLine();

    if (0 < int.Parse(idade2) && int.Parse(idade2) < 18)
    {
        menor += $"{idade2} ";
    }

    if (int.Parse(idade2) > 18)
    {
        maior += $"{idade2} ";
    }
} while (int.Parse(idade2) <= 0);

do
{
    Console.Write("Informe a 3ª idade: ");
    idade3 = Console.ReadLine();
    Console.WriteLine();

    if (0 < int.Parse(idade3) && int.Parse(idade3) < 18)
    {
        menor += $"{idade3} ";
    }

    if (int.Parse(idade3) > 18)
    {
        maior += $"{idade3} ";
    }
} while (int.Parse(idade3) <= 0);

do
{
    Console.Write("Informe a 4ª idade: ");
    idade4 = Console.ReadLine();
    Console.WriteLine();

    if (0 < int.Parse(idade4) && int.Parse(idade4) < 18)
    {
        menor += $"{idade4} ";
    }

    if (int.Parse(idade4) > 18)
    {
        maior += $"{idade4} ";
    }
} while (int.Parse(idade4) <= 0);

do
{
    Console.Write("Informe a 5ª idade: ");
    idade5 = Console.ReadLine();
    Console.WriteLine();

    if (0 < int.Parse(idade5) && int.Parse(idade5) < 18)
    {
        menor += $"{idade5} ";
    }

    if (int.Parse(idade5) > 18)
    {
        maior += $"{idade5} ";
    }
} while (int.Parse(idade5) <= 0);

do
{
    Console.Write("Informe a 6ª idade: ");
    idade6 = Console.ReadLine();
    Console.WriteLine();

    if (0 < int.Parse(idade6) && int.Parse(idade6) < 18)
    {
        menor += $"{idade6} ";
    }

    if (int.Parse(idade6) > 18)
    {
        maior += $"{idade6} ";
    }
} while (int.Parse(idade6) <= 0);

do
{
    Console.Write("Informe a 7ª idade: ");
    idade7 = Console.ReadLine();
    Console.WriteLine();

    if (0 < int.Parse(idade7) && int.Parse(idade7) < 18)
    {
        menor += $"{idade7} ";
    }

    if (int.Parse(idade7) > 18)
    {
        maior += $"{idade7} ";
    }
} while (int.Parse(idade7) <= 0);

do
{
    Console.Write("Informe a 8ª idade: ");
    idade8 = Console.ReadLine();
    Console.WriteLine();

    if (0 < int.Parse(idade8) && int.Parse(idade8) < 18)
    {
        menor += $"{idade8} ";
    }

    if (int.Parse(idade8) > 18)
    {
        maior += $"{idade8} ";
    }
} while (int.Parse(idade8) <= 0);

do
{
    Console.Write("Informe a 9ª idade: ");
    idade9 = Console.ReadLine();
    Console.WriteLine();

    if (0 < int.Parse(idade9) && int.Parse(idade9) < 18)
    {
        menor += $"{idade9} ";
    }

    if (int.Parse(idade9) > 18)
    {
        maior += $"{idade9} ";
    }
} while (int.Parse(idade9) <= 0);

do
{
    Console.Write("Informe a 10ª idade: ");
    idade10 = Console.ReadLine();
    Console.WriteLine();

    if (0 < int.Parse(idade10) && int.Parse(idade10) < 18)
    {
        menor += $"{idade10} ";
    }

    if (int.Parse(idade10) > 18)
    {
        maior += $"{idade10} ";
    }
} while (int.Parse(idade10) <= 0);

Console.WriteLine(maior);
Console.WriteLine(menor);

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para encerrar o programa...");