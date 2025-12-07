using System;

namespace CSharp
{
    class UserRegistrationExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== User Registration (Throw Example) ====");

            try
            {
                Console.Write("Kullanıcı adı girin: ");
                string username = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(username))
                {
                    throw new ArgumentException("Kullanıcı adı boş olamaz.");
                }

                if (username.Length < 5)
                {
                    throw new ArgumentException("Kullanıcı adı en az 5 karakter uzunluğunda olmalıdır.");
                }

                Console.WriteLine("Kullanıcı kaydı başarılı: " + username);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Hata: Geçersiz kullanıcı adı.");
                Console.WriteLine($"Ayrıntı: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Beklenmeyen bir hata oluştu.");
                Console.WriteLine($"Ayrıntı: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı. Program kapatılıyor...");
            }
        }
    }
}
