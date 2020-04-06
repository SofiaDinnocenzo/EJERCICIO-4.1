using System;

class MainClass {
  public static void Main (string[] args) {
    string r1,r2,r3;
    int num1,num2,num3;
    Console.WriteLine("Ingrese tres números:");
    r1=Console.ReadLine();
    r2=Console.ReadLine();
    r3=Console.ReadLine();
    num1=int.Parse(r1);
    num2=int.Parse(r2);
    num3=int.Parse(r3);
    Console.WriteLine("Primer número:" + num1);
    Console.WriteLine("Segundo número:" + num2);
    Console.WriteLine("Tercer número:" + num3);

    if((num2<num1) && (num1<num3))
    {Console.WriteLine("El intermedio es:" + num1);
    }
    if((num2>num1) && (num1>num3))
    {Console.WriteLine("El intermedio es:" + num1);
    }
    if((num1<num2) && (num2<num3))
    {Console.WriteLine("El intermedio es:" + num2);
    }
    if((num1>num2) && (num2>num3))
    {Console.WriteLine("El intermedio es:" + num2);
    }
    if((num1<num3) && (num3<num2))
    {Console.WriteLine("El intermedio es:" + num3);
    }
    if((num1>num3) && (num3>num2))
    {Console.WriteLine("El intermedio es:" + num3);
    }
  }
}