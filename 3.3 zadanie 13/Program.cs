Console.Write("Введите значение x: ");
double x = double.Parse(Console.ReadLine());

double sum = 0;
double term = (x - 1) / (x + 1);
double power = term;
double epsilon = 1e-6; // задаем точность

Console.WriteLine("введите n:");
int n = int.Parse(Console.ReadLine());
while (Math.Abs(term) > epsilon)
{
    sum += term;
    power *= Math.Pow(term, 2);
    term = (1.0 / (2 * n + 1)) * power;
    n++;
}
Console.WriteLine("Результат: " + sum);


