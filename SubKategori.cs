using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuah_Click(object sender, EventArgs e)
        {
            // Buat instance dari form CaraSimpan
            CaraSimpan formCaraSimpan = new CaraSimpan();

            // Tampilkan form CaraSimpan
            formCaraSimpan.Show();

            // Sembunyikan form SubKategori&Penyimpanan jika perlu
            this.Hide();
        }
    }
}
