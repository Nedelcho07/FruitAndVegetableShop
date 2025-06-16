using fruit_and_vegetable_shop.Controllers;
using fruit_and_vegetable_shop.Data;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruit_and_vegetable_shop
{
    public partial class Form1 : Form
    {
        VeganTypeController veganTypeController = new VeganTypeController();
        VeganController veganController = new VeganController();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadRecord(Vegan vegan)
        {
            txt_id.BackColor = Color.White;
            txt_id.Text = vegan.Id.ToString();
            txt_name.Text = vegan.Name;
            txt_description.Text = vegan.Description;
            txt_price.Text = vegan.Price.ToString();
            cmb_type.Text = vegan.VeganTypes.Name;
        }
        private void ClearScreen()
        {
            txt_id.BackColor = Color.White;
            txt_id.Clear();
            txt_name.Clear();
            txt_price.Clear();
            txt_description.Clear();
            cmb_type.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'fruitAndVegetableStoreDataSet.Vegans' table. You can move, or remove it, as needed.
            this.vegansTableAdapter.Fill(this.fruitAndVegetableStoreDataSet.Vegans);
            List<Vegan> allVeganTypes = veganTypeController.GetAllVeganTypes();
            cmb_type.DataSource = allVeganTypes;
            cmb_type.DisplayMember = "Name";
            cmb_type.ValueMember = "Id";

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txt_id.Text)||!txt_id.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведи Id за търсене!");
                txt_id.BackColor = Color.Red;
                txt_id.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txt_id.Text);
            }
            Vegan findedVegan = veganController.Get(findId);
            if(findedVegan == null)
            {
                MessageBox.Show("Няма такъв запис в базата! /n Въведи съществуващо Id за тръсене!");
                txt_id.BackColor = Color.Red;
                txt_id.Focus();
                return;
            }
            LoadRecord(findedVegan);
            DialogResult answear = MessageBox.Show("Наистина ли искаш да изтриеш този запис Номер: " + findId + " ?", "PROMP", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(answear == DialogResult.Yes)
            {
                veganController.Delete(findId);
            }
  
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) || txt_description.Text == "" || txt_price.Text == "")
            {
                MessageBox.Show("Не си въвел достатъчно данни!");
                txt_name.Focus();
                return;
            }
            Vegan newVegan = new Vegan();
            newVegan.Price = int.Parse(txt_price.Text);
            newVegan.Name = txt_name.Text;
            newVegan.VeganTypeId = (int)cmb_type.SelectedValue;

            veganController.Create(newVegan);
            MessageBox.Show("Записа е направен!");
            ClearScreen();
            btn_selectAll_Click(sender, e);
        }

        private void btn_selectAll_Click(object sender, EventArgs e)
        {
            List<Vegan> allVegans = veganController.GetAll();
            lsb_allInfo.Items.Clear();
            foreach(var item in allVegans)
            {
                lsb_allInfo.Items.Add($"{item.Id}. {item.Name} -{item.Price} Порода:{item.VeganTypes}");
            }
        }


    }
}
