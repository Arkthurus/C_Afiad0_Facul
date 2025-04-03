Console.WriteLine("Informe um numero para ser fatorado:");
int n = int.Parse(Console.ReadLine());
int fat = 1;
for (int i = 0; i < n; i++)
{
    fat*=(i+1);
}
Console.WriteLine($"{n}! é = {fat}");