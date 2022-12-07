Console.Clear();
Console.WriteLine("Input fist coordinate x1:  ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input fist coordinate y1:  ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second coordinate x2:  ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second coordinate y2:  ");
double y2 = Convert.ToDouble(Console.ReadLine());
     while (x1 == 0 && y1 == 0 && x2 == 0 && y2 == 0) 
 {
  Console.WriteLine("You entered the coordinates are equal null!\n Input coordinates more then zero");
  Console.WriteLine("Input fist coordinate x1:  ");
   x1 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Input fist coordinate y1:  ");
   y1 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Input second coordinate x2:  ");
   x2 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Input second coordinate y2:  ");
   y2 = Convert.ToDouble(Console.ReadLine()); 
 }
  double S = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2));
  Console.WriteLine("The distance between of the two coordinates equals: " +S);