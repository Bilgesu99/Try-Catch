using System;
namespace TryCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // Kullanıcıdan bir sayı girmesini istiyoruz.
                    Console.Write("Bir sayı giriniz: ");
                    string input = Console.ReadLine();


                    // Kullanıcının girdiği değeri double türüne dönüştürüyoruz çünkü ileride karesi alınacağı için bir sayı değeri olmalı.
                    double number = Convert.ToDouble(input);

                    double square = number * number; //Karesini hesapladık
                    Console.WriteLine($"Girdiğiniz sayının karesi: {square}");

                    // Geçerli bir giriş yapıldığında döngüden çık
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz bir sayı girdiniz");
                }
                

              
                 
            }
        }
    }
}