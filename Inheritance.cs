using System;

public class HelloWorld
{
    static public void Main ()
    {
        Console.WriteLine ("Luas Persegi Panjang");
        Console.Write("Masukkan p:");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.Write("Masukkan l:");
        double l= Convert.ToDouble(Console.ReadLine());
      Rumus str = new Rumus();
      Console.Write($"luas persegi panjang dengan p:{p} dan l:{l} adalah");
      Console.WriteLine(str.persegipanjang(p,l));
    }
     class Kalkulator {
         public double kali(double a,  double b){
             return a * b;
         }
     }
     class Rumus:Kalkulator {
         public double persegipanjang(double p, double l){
             return kali(p,l);
         }
     }

}
