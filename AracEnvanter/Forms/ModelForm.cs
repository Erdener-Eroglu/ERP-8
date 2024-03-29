﻿using AracEnvanter.Data;
using AracEnvanter.Helpers;
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
    public partial class ModelForm : Form
    {
        public ModelForm()
        {
            InitializeComponent();
        }
        //public List<Marka> Markalar { get; set; } = new();
        //public List<Model> Liste { get; set; } = new();
        public EnvanterContext DataContext { get; set; }

        private void ModelForm_Load(object sender, EventArgs e)
        {
            cmbKasaTipi.DataSource = Enum.GetNames(typeof(KasaTipleri));
            cmbMarka.DataSource = DataContext.Markalar;
            lstListe.DataSource = DataContext.Modeller;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Model model = new Model()
                {
                    Ad = txtAd.Text,
                    KasaTipi = (KasaTipleri)Enum.Parse(typeof(KasaTipleri), cmbKasaTipi.SelectedItem.ToString()),
                    Marka = (Marka)cmbMarka.SelectedItem
                };
                DataContext.Modeller.Add(model);

                lstListe.DataSource = null;
                lstListe.DataSource = DataContext.Modeller;
                DataHelper.Save(DataContext);
                this.FormCleaner(Controls);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstListe.SelectedItem == null) return;
                Model model = (Model)lstListe.SelectedItem;
                model.Ad = txtAd.Text;
                model.KasaTipi = (KasaTipleri)Enum.Parse(typeof(KasaTipleri), cmbKasaTipi.SelectedItem.ToString());
                model.Marka = (Marka)cmbMarka.SelectedItem;
                lstListe.DataSource = null;
                lstListe.DataSource = DataContext.Modeller;
                DataHelper.Save(DataContext);
                this.FormCleaner(Controls);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;
            Model model = (Model)lstListe.SelectedItem;
            txtAd.Text = model.Ad;
            cmbKasaTipi.SelectedItem = Enum.GetName(typeof(KasaTipleri), model.KasaTipi);
            cmbMarka.SelectedItem = DataContext.Markalar.Find(x => x.Id == model.Marka.Id);
            Func<bool, Marka> SearchMarkaFunc = (bool condition) =>
            {
                foreach (var item in DataContext.Markalar)
                {
                    if(condition)
                    {
                        return item;
                    }
                }
                return null;
            };
        }
    }
}
