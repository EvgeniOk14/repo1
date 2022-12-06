Console.Clear();
Console.WriteLine("input five-digit number n: ");
int n = Convert.ToInt32(Console.ReadLine());
    String s = n.ToString();  
       while (n < 10000 || n > 100000)
          {
        Console.WriteLine("You entered not five-digit number!\nInput five-digit number n: "  );
          n = Convert.ToInt32(Console.ReadLine());
          }
           if (s[0] == s[4] && s[1] == s[3])
          {
    Console.WriteLine("YES! This number is a mirror reflection of itself ");
          }
          else
          {
    Console.WriteLine("NO! This number isn't a mirror reflection of itself ");
          
          }
