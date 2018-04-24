using OOPSinav;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSinav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            txtTcKimlikNo.Text = txtAd.Text = txtSoyad.Text = dtDogumTarihi.Text = txtTelefon.Text = txtEmail.Text = txtAdres.Text = dtIseGirisTarihi.Text = cmbUnvan.Text = txtresimYol.Text = "";
            pbresim.Image = null;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            string yol = @"Resimler";
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "Resim Seçiniz..!";
            dosya.ShowDialog();
            var islem = Path.Combine(yol, Path.GetFileName(dosya.FileName));
            File.Copy(dosya.FileName, islem);
            txtresimYol.Text = islem.ToString();
            pbresim.ImageLocation = txtresimYol.Text;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.KimlikNo = txtTcKimlikNo.Text;
            personel.Ad = txtAd.Text;
            personel.Soyad = txtSoyad.Text;
            personel.dogumTarihi = DateTime.Parse(dtDogumTarihi.Text);
            personel.Telefon = txtTelefon.Text;
            personel.Email = txtEmail.Text;
            personel.Adres = txtAdres.Text;
            personel.İsGiris = DateTime.Parse(dtIseGirisTarihi.Text);
            personel.Unvan = cmbUnvan.Text;
            personel.ResimYolu = txtresimYol.Text;

            string[] row = { personel.KimlikNo, personel.Ad, personel.Soyad, personel.dogumTarihi.ToString(), personel.Telefon, personel.Email, personel.Adres, personel.İsGiris.ToString(), personel.Unvan.ToString(), personel.ResimYolu };
            lstPersonel.Items.Add(new ListViewItem(row));
            Temizle();
        }

        private void lstPersonel_DoubleClick(object sender, EventArgs e)
        {
            txtTcKimlikNo.Text = lstPersonel.SelectedItems[0].SubItems[0].Text;
            txtAd.Text = lstPersonel.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = lstPersonel.SelectedItems[0].SubItems[2].Text;
            dtDogumTarihi.Text = lstPersonel.SelectedItems[0].SubItems[3].Text;
            txtTelefon.Text = lstPersonel.SelectedItems[0].SubItems[4].Text;
            txtEmail.Text = lstPersonel.SelectedItems[0].SubItems[5].Text;
            txtAdres.Text = lstPersonel.SelectedItems[0].SubItems[6].Text;
            dtIseGirisTarihi.Text = lstPersonel.SelectedItems[0].SubItems[7].Text;
            cmbUnvan.Text = lstPersonel.SelectedItems[0].SubItems[8].Text;
            txtresimYol.Text = lstPersonel.SelectedItems[0].SubItems[9].Text;
            pbresim.ImageLocation = txtresimYol.Text;
            lstPersonel.Items.RemoveAt(lstPersonel.SelectedIndices[0]);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"{txtAd.Text} {txtSoyad.Text} Kişisini gerçekten silmek istiyor musunuz..!", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                lstPersonel.Items.RemoveAt(lstPersonel.SelectedIndices[0]);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.KimlikNo = txtTcKimlikNo.Text;
            personel.Ad = txtAd.Text;
            personel.Soyad = txtSoyad.Text;
            personel.dogumTarihi = DateTime.Parse(dtDogumTarihi.Text);
            personel.Telefon = txtTelefon.Text;
            personel.Email = txtEmail.Text;
            personel.Adres = txtAdres.Text;
            personel.İsGiris = DateTime.Parse(dtIseGirisTarihi.Text);
            personel.Unvan = cmbUnvan.Text;
            personel.ResimYolu = txtresimYol.Text;

            string[] row = { personel.KimlikNo, personel.Ad, personel.Soyad, personel.dogumTarihi.ToString(), personel.Telefon, personel.Email, personel.Adres, personel.İsGiris.ToString(), personel.Unvan.ToString(), personel.ResimYolu };
            lstPersonel.Items.Add(new ListViewItem(row));
            Temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUnvan.Items.Clear();
            cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Departman)));
        }
    }
}