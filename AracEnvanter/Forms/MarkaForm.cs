using AracEnvanter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracEnvanter.Forms
{
    public partial class MarkaForm : Form
    {
        public MarkaForm()
        {
            InitializeComponent();
        }
        private List<Marka> _liste = new();
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                Marka marka = new Marka()
                {
                    Ad = txtAd.Text
                };
                if(pbResim.Image != null ) 
                {
                    marka.Logo = (byte[])(new ImageConverter().ConvertTo(pbResim.Image, typeof(byte[])));
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
