//1
if (args.Length % 2 == 0 || args.Length <= 2)
{
    Console.WriteLine("Nem megfelelő argumentumszám!");
}
else
{
    int middleIndex = args.Length / 2;
    int num1 = Convert.ToInt32(args[middleIndex - 1]);
    int num2 = Convert.ToInt32(args[middleIndex + 1]);

    if (num2 > num1)
    {
        Console.WriteLine($"Eredmény:{Math.Pow(num1, num2 / num1)}");
    }
    else
    {
        Console.WriteLine($"Eredmény:{Math.Pow(num2, num1 / num2)}");
    }
}


//2
List < string > szavak= File.ReadAllLines("szavak.txt").ToList();
char[] maganhangzok = ['A','E','I','U','O'];
int szotagok=0;
int szotagokTobbMintNegy = 0;
int legnagyobbszotag = 0;

foreach (var item in szavak)
{
    foreach (var j in maganhangzok)
    {
        if (item.Contains(maganhangzok[j]))
        {
            szotagok += 1;
        }
        if (szotagok>4)
        {
            szotagokTobbMintNegy += 1;
        }
        if (legnagyobbszotag<szotagok)
        {
            legnagyobbszotag = szotagok;
        }
        szotagok = 0;
    }
   
}
Console.WriteLine($"A több mint négy szótagból álló szavak száma: {szotagokTobbMintNegy}");
Console.WriteLine($"A legnagyobb szótagszám: {legnagyobbszotag}");

//3
