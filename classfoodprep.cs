using System;

namespace FoodPrepApp
{
    // Class Login
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public void LoginMethod(string email, string password)
        {
            Console.WriteLine($"Login method executed for email: {email}");
        }

        // Asosiasi dengan Register untuk proses daftar
        public void Daftar(Register register)
        {
            Console.WriteLine($"Daftar pengguna baru dengan nama: {register.Nama}");
        }
    }

    // Class Register
    public class Register
    {
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void RegisterMethod()
        {
            Console.WriteLine($"Pengguna {Nama} telah terdaftar dengan email {Email}.");
        }
    }

    // Kelas Kategori sebagai superclass
    public class Kategori
    {
        public string Penyimpanan { get; set; }
        public string Pemasakan { get; set; }

        public virtual void Tampilandetail()
        {
            Console.WriteLine("Menampilkan detail kategori.");
        }
    }

    // Kelas Sayur turunan dari Kategori
    public class Sayur : Kategori
    {
        public override void Tampilandetail()
        {
            Console.WriteLine("Menampilkan detail Sayur.");
        }
    }

    // Kelas Buah turunan dari Kategori
    public class Buah : Kategori
    {
        public override void Tampilandetail()
        {
            Console.WriteLine("Menampilkan detail Buah.");
        }
    }

    // Kelas Daging turunan dari Kategori
    public class Daging : Kategori
    {
        public override void Tampilandetail()
        {
            Console.WriteLine("Menampilkan detail Daging.");
        }
    }

    // Kelas Ikan turunan dari Kategori
    public class Ikan : Kategori
    {
        public override void Tampilandetail()
        {
            Console.WriteLine("Menampilkan detail Ikan.");
        }
    }

    // Kelas ProdukSusu turunan dari Kategori
    public class ProdukSusu : Kategori
    {
        public override void Tampilandetail()
        {
            Console.WriteLine("Menampilkan detail Produk Susu.");
        }
    }

    // Kelas ProdukNabati turunan dari Kategori
    public class ProdukNabati : Kategori
    {
        public override void Tampilandetail()
        {
            Console.WriteLine("Menampilkan detail Produk Nabati.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Pengguna mendaftar terlebih dahulu
            Register register = new Register { Nama = "John Doe", Email = "johndoe@example.com", Password = "password456" };
            register.RegisterMethod();

            // Setelah mendaftar, bisa menggunakan login
            Login login = new Login { Email = "johndoe@example.com", Password = "password456" };
            login.Daftar(register); // Mengasosiasikan login dengan register
            login.LoginMethod(login.Email, login.Password);

            // Contoh penggunaan inheritance untuk kategori
            Sayur sayur = new Sayur { Penyimpanan = "Cool", Pemasakan = "Rebus" };
            sayur.Tampilandetail(); // Akan menampilkan detail sayur

            Buah buah = new Buah { Penyimpanan = "Kering", Pemasakan = "Makan langsung" };
            buah.Tampilandetail(); // Akan menampilkan detail buah

            Daging daging = new Daging { Penyimpanan = "Beku", Pemasakan = "Panggang" };
            daging.Tampilandetail(); // Akan menampilkan detail daging

            Ikan ikan = new Ikan { Penyimpanan = "Dingin", Pemasakan = "Goreng" };
            ikan.Tampilandetail(); // Akan menampilkan detail ikan

            ProdukSusu produkSusu = new ProdukSusu { Penyimpanan = "Dingin", Pemasakan = "Konsumsi langsung" };
            produkSusu.Tampilandetail(); // Akan menampilkan detail produk susu

            ProdukNabati produkNabati = new ProdukNabati { Penyimpanan = "Kering", Pemasakan = "Tumis" };
            produkNabati.Tampilandetail(); // Akan menampilkan detail produk nabati

            Console.ReadKey();
        }
    }
}
