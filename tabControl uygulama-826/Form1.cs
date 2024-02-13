using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabControl_uygulama_826
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                decimal hesap = 0;
                String mesaj = $"ad soyad:{txtAdSoyad.Text}\r\n" +
                    $"telefon:{txtTel.Text}\r\n" +
                $"adres:{txtAdres.Text}\r\n\r\n";
                if (nCorba.Value > 0)
                {
                    hesap += nCorba.Value * 60;
                    mesaj += $"Çorba =      {nCorba.Value * 60}\r\n";

                    if(nSalata.Value > 0)
                    {
                        hesap += nSalata.Value * 30;
                        mesaj += $"yemek=       {nSalata.Value * 30}\r\n"; ;
                        if(nYemek.Value > 0)
                        {
                            hesap  += nYemek.Value * 100;
                            mesaj += $"yemek =      {nYemek.Value*100}\r\n";
                            if(nTatli.Value > 0)
                            {
                                hesap += nTatli.Value * 50;
                                mesaj += $"tatlı =   {nTatli.Value * 50}\r\n";
                            }
                            mesaj += $"***************************\r\n";
                            mesaj += $"odenecek tutar    : {hesap}";

                            txtBilgi.Text = mesaj;
                        }
                    }

                }
            }
            
        }
    }
}
