using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPrepApp
{
    // Class Login
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public void Method1()
        {
            Console.WriteLine("Login method executed.");
        }
    }

    // Class Katagori
    public class Katagori
    {
        public Sayur Sayur { get; set; }
        public Buah Buah { get; set; }
        public Daging Daging { get; set; }
        public Ikan Ikan { get; set; }
        public ProdukSusu ProdukSusu { get; set; }
        public ProdukNabati ProdukNabati { get; set; }

        public void Method2()
        {
            Console.WriteLine("Katagori method executed.");
        }
    }

    // Class Sayur
    public class Sayur
    {
        public string Penyimpanan { get; set; }
        public string Pemasakan { get; set; }

        public void Method3()
        {
            Console.WriteLine("Sayur method executed.");
        }
    }

    // Class Buah
    public class Buah
    {
        public string Penyimpanan { get; set; }
        public string Informasi { get; set; }

        public void Method4()
        {
            Console.WriteLine("Buah method executed.");
        }
    }

    // Class Daging
    public class Daging
    {
        public string Penyimpanan { get; set; }
        public string Pemasakan { get; set; }

        public void Method5()
        {
            Console.WriteLine("Daging method executed.");
        }
    }

    // Class Ikan
    public class Ikan
    {
        public string Penyimpanan { get; set; }
        public string Pemasakan { get; set; }

        public void Method6()
        {
            Console.WriteLine("Ikan method executed.");
        }
    }

    // Class ProdukSusu
    public class ProdukSusu
    {
        public string Penyimpanan { get; set; }
        public string Informasi { get; set; }

        public void Method7()
        {
            Console.WriteLine("Produk Susu method executed.");
        }
    }

    // Class ProdukNabati
    public class ProdukNabati
    {
        public string Penyimpanan { get; set; }
        public string Pemasakan { get; set; }

        public void Method8()
        {
            Console.WriteLine("Produk Nabati method executed.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Contoh penggunaan kelas
            Login login = new Login { Email = "user@example.com", Password = "password123" };
            Katagori katagori = new Katagori
            {
                Sayur = new Sayur { Penyimpanan = "Cool", Pemasakan = "Rebus" },
                Buah = new Buah { Penyimpanan = "Kering", Informasi = "Segar" },
                Daging = new Daging { Penyimpanan = "Beku", Pemasakan = "Panggang" },
                Ikan = new Ikan { Penyimpanan = "Dingin", Pemasakan = "Goreng" },
                ProdukSusu = new ProdukSusu { Penyimpanan = "Dingin", Informasi = "Pasteurisasi" },
                ProdukNabati = new ProdukNabati { Penyimpanan = "Kering", Pemasakan = "Tumis" }
            };

            login.Method1();
            katagori.Method2();
            katagori.Sayur.Method3();
            katagori.Buah.Method4();
            katagori.Daging.Method5();
            katagori.Ikan.Method6();
            katagori.ProdukSusu.Method7();
            katagori.ProdukNabati.Method8();

            Console.ReadKey();
        }
    }
}