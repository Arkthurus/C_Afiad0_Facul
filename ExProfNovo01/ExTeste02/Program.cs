Console.WriteLine("Informe o primeiro Numero:");
int n1= int.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo Numero:");
int n2= int.Parse(Console.ReadLine());

if (n1>n2){
    Console.WriteLine($"{n1} é maior q {n2}");
}
if (n1<n2){
    Console.WriteLine($"{n2} é maior q {n1}");
}
if (n1==n2){
    Console.WriteLine($"{n1} é igual a {n2}");
}