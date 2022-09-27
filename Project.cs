while (true)
{
 Console.WriteLine("Если вы хотите закончить работу, то введите 'exit', если хотети воспользоваться калькулятором, то 'culc'");
 string inp = Console.ReadLine();

 if (inp == "culc")
 {
 Console.WriteLine("Введите математичскую операцию. Доступные: '+', '-', '*', '/', '^n', 'sqrt', '1%', 'n!'");
 string znak = Console.ReadLine();

 if (znak == "+")
 {
 Console.WriteLine("Введите первое число");
 int f = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число");
 int s = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(f + s);
 }
 else if (znak == "-")
 {
 Console.WriteLine("Введите первое число");
 int f = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число");
 int s = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(f - s);
 }
 else if (znak == "*")
 {
 Console.WriteLine("Введите первое число");
 int f = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число");
 int s = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(f * s);
 }
 else if (znak == "/")
 {
 Console.WriteLine("Введите первое число");
 int f = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число");
 int s = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(f / s);
 }
 else if (znak == "^n")
 {
 Console.WriteLine("Введите число");
 int f = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите степень, в которую хотите возвести");
 int st = Convert.ToInt32(Console.ReadLine());
 int s = f;

 for (int i = 1; i < st; i++)
 {
 f *= s;
 }
 Console.WriteLine(f);
 }
 else if (znak == "sqrt")
 {
 Console.WriteLine("Введите число из которого нужно найти корень");
 int f = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine(Math.Sqrt(f));
 }
 else if (znak == "1%")
 {
 Console.WriteLine("Введите число из которого нужно найти 1%");
 int f = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine(f / 100);
 }
 else if (znak == "n!")
 {
 Console.WriteLine("Введите число из которого нужно найти факториал");
 int f = Convert.ToInt32(Console.ReadLine());
 int fact = 1;

 for (int i = 1; i <= f; i++)
 {
 fact *= i;
 }
 Console.WriteLine(fact);
 }
 else
 {
 Console.WriteLine("Такой операции нету");
 }
 }

 else if (inp == "exit")
 {
 break;
 }

}
