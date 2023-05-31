var A = new double[8];
for (int i = 0; i < 8; i++)
{
    A[i] = Convert.ToDouble (Console.ReadLine());   
}
Console.WriteLine(string.Join(", ", A));