using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigKuraCekimi
{
    public partial class Form1 : Form
    {

        List<Takim> takimlar;

        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> gruplar = new List<ListBox>();

        Takim yenitakim = null;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> secilen_takimlar = new List<int>();
            for (int j = 0; j < 4; j++)
            {
                secilen_takimlar.Clear();
                for (int i = 0; i < 8; i++)
                {
                    int secilen_takim = rnd.Next(0, takimlar.Count / 4);
                    if (secilen_takimlar.Contains(secilen_takim))
                    {
                        i--;
                    }
                    else
                    {
                        secilen_takimlar.Add(secilen_takim);
                    }
                }
                bool ayni_ulkeden_takim_varmi = false;
                for (int k = 0; k < 8; k++)
                {
                    ayni_ulkeden_takim_varmi = Ayni_Ulkeden_Takim_Varmi(gruplar[k], torbalar[j].Items[secilen_takimlar[k]] as Takim);
                    if (ayni_ulkeden_takim_varmi)
                    {
                        break;
                    }
                }
                if (!ayni_ulkeden_takim_varmi)
                {
                    listBox1.Items.Add(torbalar[j].Items[secilen_takimlar[0]] as Takim);
                    listBox2.Items.Add(torbalar[j].Items[secilen_takimlar[1]] as Takim);
                    listBox3.Items.Add(torbalar[j].Items[secilen_takimlar[2]] as Takim);
                    listBox4.Items.Add(torbalar[j].Items[secilen_takimlar[3]] as Takim);
                    listBox5.Items.Add(torbalar[j].Items[secilen_takimlar[4]] as Takim);
                    listBox6.Items.Add(torbalar[j].Items[secilen_takimlar[5]] as Takim);
                    listBox7.Items.Add(torbalar[j].Items[secilen_takimlar[6]] as Takim);
                    listBox8.Items.Add(torbalar[j].Items[secilen_takimlar[7]] as Takim);
                }
                else
                {
                    j--;
                }
            }
        }

        private bool Ayni_Ulkeden_Takim_Varmi(ListBox grup, Takim takim)
        {
            bool durum = false;
            for (int i = 0; i < grup.Items.Count; i++)
            {
                Takim grup_takim = grup.Items[i] as Takim;
                if (grup_takim.TeamCountry == takim.TeamCountry)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<int> secilen_takimlar = new List<int>();
            for (int j = 0; j < takimlar.Count; j++)
            {
                int secilen_takim = rnd.Next(0, takimlar.Count);
                if (secilen_takimlar.Contains(secilen_takim))
                {
                    j--;
                }
                else
                {
                    secilen_takimlar.Add(secilen_takim);
                }
            }
            for (int i = 0; i < secilen_takimlar.Count; i++)
            {
                if (i < 8)
                {
                    trb1.Items.Add(takimlar[secilen_takimlar[i]]);
                }
                else if (i < 16)
                {
                    trb2.Items.Add(takimlar[secilen_takimlar[i]]);
                }
                else if (i < 24)
                {
                    trb3.Items.Add(takimlar[secilen_takimlar[i]]);
                }
                else
                {
                    trb4.Items.Add(takimlar[secilen_takimlar[i]]);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            torbalar.Add(trb1);
            torbalar.Add(trb2);
            torbalar.Add(trb3);
            torbalar.Add(trb4);

            gruplar.Add(listBox1);
            gruplar.Add(listBox2);
            gruplar.Add(listBox3);
            gruplar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);

            takimlar = new List<Takim>();

            yenitakim = new Takim("Tractor FC", "Azerbaycan");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Bayern Münih", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("FC Barselona", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Chelsea", "ingiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Real Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester United", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Arsenal", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Porto", "Portekiz");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Benfica", "Portekiz");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atletico Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Shaktar Donetsk", "Ukrayna");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Milan", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Schalke 04", "Ukrayna");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Marsilya", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("CSKA Moskova", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Parıs-saint Germain", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Juventus", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Zenit", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester City", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Ajax", "Hollanda");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Basel", "İsviçre");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Borussıa Dortmund", "Alamnya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Olympiakos", "Yunanistan");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Galatasaray", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Fenerbahçe", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Napoli", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Celtik", "İskoçya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Victoria Plzen", "Çek Cumhuriyeti");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Austuria Wien", "Avusturya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Roma", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Beşiktaş", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("TrabzonSpor", "Türkiye");
            takimlar.Add(yenitakim);
        }
    }
}
