Console.WriteLine("Informe o nuemro da tabuada que deseja ver:");
int tabuada = int.Parse(Console.ReadLine());
Console.WriteLine("-----------------------------");

for (int i = 0; i < 10; i++)
{
    int mod = tabuada*(i+1);
    Console.WriteLine($"{tabuada} x {i+1} = {mod}");
}