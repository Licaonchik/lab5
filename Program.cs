Console.WriteLine("Введите а");
 double a = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Введите b");
   double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите c");
     double c = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введите d");
       double d = Convert.ToDouble(Console.ReadLine());
        double s = 0;
         if (a <= b && b <= c && c <= d)
          {
           for (double i = c; i >= c && i <= d; i += 2)
            {
             s += i;

              }
               Console.WriteLine(s);
                }
                 else
                  {
                   Console.WriteLine("Некорректные числа");
                        }
