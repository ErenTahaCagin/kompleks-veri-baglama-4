using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KompleksVeriBaglama4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Ogrenciler
        {
            public int Numara { get; set; }
            public string AdSoyad { get; set; }
            public int DersNotu { get; set; }
        }

        List<Ogrenciler> liste = new List<Ogrenciler>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = int.Parse(txtNumara.Text);
            ogrenci.AdSoyad = txtAdSoyad.Text;
            ogrenci.DersNotu = int.Parse(txtDersNotu.Text);
            liste.Add(ogrenci);
            Bagla();
        }

        private void Bagla()
        {
            gndListe.DataSource = null;
            gndListe.DataSource = liste;
        }

        private void gndListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumara.Text = gndListe.CurrentRow.Cells[0].Value.ToString();
            txtAdSoyad.Text = gndListe.CurrentRow.Cells[1].Value.ToString();
            txtDersNotu.Text = gndListe.CurrentRow.Cells[2].Value.ToString();
        }


    }
}
