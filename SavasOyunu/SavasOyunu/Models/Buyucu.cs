using System;

namespace SavasOyunu.Models
{
    public class Buyucu
    {
        public string OyuncuIsmi { get; set; }
        public string Irk { get; set; }
        public string Brans { get; set; }
        public string Silah { get; set; }

        public int SaldiriGucu { get; private set; }

        Random rnd = new Random();

        public void Saldir()
        {
            int minHasar = 20;
            int maxHasar = 30;
            int bonus = 0;
            int kritikSans = 10;

            // Silah etkisi
            switch (Silah)
            {
                case "Ahşap Yelpaze":
                    minHasar = 35;
                    maxHasar = 42;
                    break;

                case "Gümüş Yelpaze":
                    minHasar = 40;
                    maxHasar = 50;
                    break;

                case "Ejder Yelpazesi":
                    minHasar = 45;
                    maxHasar = 60;
                    break;
            }

            // Irk etkisi
            switch (Irk)
            {
                case "İnsan":
                    bonus += 5;
                    break;

                case "Elf":
                    bonus += 8;
                    break;

                case "Ejderkan":
                    bonus += 12;
                    break;
            }

            // 🔥 Branş etkisi
            switch (Brans)
            {
                case "İyilestirmeSinifi":
                    bonus += 3;
                    break;

                case "EjderhaGucuSinifi":
                    bonus += 7;
                    break;
            }

            // Rastgele hasar
            SaldiriGucu = rnd.Next(minHasar, maxHasar + 1) + bonus;

            // Kritik vuruş
            if (rnd.Next(1, 101) <= kritikSans)
            {
                SaldiriGucu += 15;
            }

            // ÜST SINIR (KIRMIZI ÇİZGİ)
            if (SaldiriGucu > 70)
                SaldiriGucu = 70;
        }
    }
}
