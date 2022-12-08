
    Console.WriteLine("Задайте длину массива n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("длина массива равна:" + n);
     int [] array = new int[n];
    
    for (int i = 3; i < n; i++)
      {
        array[i] = i; 
        Console.Write(array[i] + " ");
      }
       int Sum = 0;
      int max =array[0];
      for (int i = 1; i < n -1; i++)
      {
         Sum = array[i-1] + array[i] + array[i+1]; //сумма 3 кустов
         if (Sum > max)
          {
            max = Sum;
          }
      }
          Console.Write("максимальное количество ягод равно: " + max);
      


        