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
    public partial class FormPenyimpanan : Form
    {
        public FormPenyimpanan()
        {
            InitializeComponent();
        }

        private void FormPenyimpanan_Load(object sender, EventArgs e)
        {

        }

        private void btnBuah_Click(object sender, EventArgs e)
        {
            // Buat instance dari form subkategori&penyimpanan (Form1)
            Form1 formSubKategori = new Form1();

            // Tampilkan form Form1
            formSubKategori.Show();

            // Sembunyikan form FormPenyimpanan jika perlu
            this.Hide();
        }
    }
}
