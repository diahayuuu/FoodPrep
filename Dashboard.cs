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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnPenyimpanan_Click(object sender, EventArgs e)
        {
            // Buat instance dari form FormPenyimpanan
            FormPenyimpanan formPenyimpanan = new FormPenyimpanan();

            // Tampilkan form FormPenyimpanan
            formPenyimpanan.Show();
        }
    }
}
