using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class BaseClass
    {
        public string PublicVar = "Public: Her yerden erişilebilir.";
        private string PrivateVar = "Private: Sadece aynı sınıf içinden erişilebilir.";
        protected string ProtectedVar = "Protected: Bu sınıf + Miras Alanlar";
        internal string InternalVar = "Internal: Aynı derleme (proje) içinden erişilebilir.";
        protected internal string ProtectedInternalVar = "Protected Internal: Aynı derleme içinden veya miras alan sınıflardan erişilebilir.";
        private protected string PrivateProtectedVar = "Private Protected: Aynı sınıf veya miras alan sınıflardan erişilebilir, ancak sadece aynı derleme içinde.";

        public void ShowVariables()
        {
            // Hepsine erişilebilir çünkü kendi sınıfı
            Console.WriteLine(PublicVar);
            Console.WriteLine(PrivateVar);
            Console.WriteLine(ProtectedVar);
            Console.WriteLine(InternalVar);
            Console.WriteLine(ProtectedInternalVar);
            Console.WriteLine(PrivateProtectedVar);
        }
    }
    public class DerivedClass : BaseClass
    {
        public void ShowAccessible()
        {
            Console.WriteLine(PublicVar); // Erişilebilir
            // Console.WriteLine(PrivateVar); // Erişilemez
            Console.WriteLine(ProtectedVar); // Erişilebilir (Miras olduğu için)
            Console.WriteLine(InternalVar); // Erişilebilir (Aynı derleme (proje) içinde)
            Console.WriteLine(ProtectedInternalVar); // Erişilebilir (Aynı derleme içinde veya miras alan sınıf)
            Console.WriteLine(PrivateProtectedVar); // Erişilebilir (Miras olduğu için ve aynı derleme içinde)
        }
    }

    // Bu sınıf aynı proje içinde ama miras almıyor

    public class OtherClass
    {
        public void Test()
        {
            BaseClass baseObj = new BaseClass();
            Console.WriteLine(baseObj.PublicVar); // Erişilebilir
            // Console.WriteLine(baseObj.PrivateVar); // Erişilemez
            // Console.WriteLine(baseObj.ProtectedVar); // Erişilemez (Miras alınmadığı için)
            Console.WriteLine(baseObj.InternalVar); // Erişilebilir (Aynı derleme (proje) içinde)
            Console.WriteLine(baseObj.ProtectedInternalVar); // Erişilebilir (Aynı derleme içinde)
            // Console.WriteLine(baseObj.PrivateProtectedVar); // Erişilemez
        }
    }

    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("BaseClass içinden erişim:");
            BaseClass baseObj = new BaseClass();
            baseObj.ShowVariables();

            Console.WriteLine("\nDerivedClass içinden erişim:");
            DerivedClass derivedObj = new DerivedClass();
            derivedObj.ShowAccessible();

            Console.WriteLine("\nOtherClass içinden erişim:");
            OtherClass otherObj = new OtherClass();
            otherObj.Test();
        }
    }
}
