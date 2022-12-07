Console.Clear();
Console.WriteLine("Input any positive number n: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
 { 
    double a = Math.Pow(i, 3);
    Console.WriteLine(a);
 }
