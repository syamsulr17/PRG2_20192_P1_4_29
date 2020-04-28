using System;

namespace PRG2_20192_P1_4_29
{
    class Program
    {
        public static double alas, tinggi, luas = 0;
        public static double hipotenusa, keliling = 0;
        static void Main(string[] args)
        {
            //Deklarasi
            int pilih;

            // Algoritma
            do
            {
                Console.Clear();
                Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
                Console.WriteLine("a. Hitung Luas");
                Console.WriteLine("b. Hitung Hipotenusa");
                Console.WriteLine("c. Hitung Keliling");
                Console.WriteLine("d. Keluar\n");
                Console.Write("Menu Pilihan : "); pilih = Convert.ToInt32(Console.ReadLine()); // Masukkan pilihan
                Console.Clear();
                switch (pilih)
                {
                    case 1: Luas(); break;
                    case 2: Hipotenusa(); break;
                    case 3: Keliling(); break;
                    case 4: Console.WriteLine("Terima Kasih"); break;
                    default:Console.WriteLine("Tolong isi yang benar, angka 1-4 !"); Console.ReadLine(); break;
                }
            } while (pilih != 4);
        }

        static void Luas()
        {
            //Deklarasi

            //Algoritma
            Console.WriteLine("LUAS SEGITIGA");
            Console.Write("Masukkan alas : "); alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi : "); tinggi = Convert.ToDouble(Console.ReadLine());
            luas = alas * tinggi / 2;
            Console.WriteLine("Luas segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, Math.Round(luas,2));
            Console.ReadLine();
        }

        static void Hipotenusa()
        {
            //Deklarasi

            //Algoritma
            Console.WriteLine("HIPOTENUSA SEGITIGA");
            Console.Write("Masukkan alas : "); alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi : "); tinggi = Convert.ToDouble(Console.ReadLine());
            hipotenusa = Math.Sqrt((alas * alas) + (tinggi * tinggi));
            Console.WriteLine("Hipotenusa segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, Math.Round(hipotenusa,2));
            Console.ReadLine();
        }

        static void Keliling()
        {
            //Deklarasi

            //Algoritma
            Console.WriteLine("KELILING SEGITIGA");
            Console.Write("Masukkan alas : "); alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi : "); tinggi = Convert.ToDouble(Console.ReadLine());
            hipotenusa = Math.Sqrt((alas * alas) + (tinggi * tinggi));
            keliling = alas + tinggi + hipotenusa;
            Console.WriteLine("Keliling segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, Math.Round(keliling,2));
            Console.ReadLine();
        }
    }
}
