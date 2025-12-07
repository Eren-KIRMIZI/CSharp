using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class ExceptionHandlingExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Exception Handling Demo ====");

            try
            {
                Console.Write("Bir sayi girin: ");
                string input = Console.ReadLine();

                // FormatException ihtimali
                int number = int.Parse(input);

                // DivideByZeroException ihtimali 
                int result = 100 / number;

                Console.WriteLine($"Sonuc: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Hata: Sıfıra bölme işlemi yapamazsınız.");
                Console.WriteLine($"Ayrıntı: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Hata: Geçerli bir tam sayı girmelisiniz.");
                Console.WriteLine($"Ayrıntı: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Beklenmeyen bir hata oluştu.");
                Console.WriteLine($"Ayrıntı:  {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program sona erdi. Kaynaklar serbest bırakıldı.");
            }
        }
    }
}
