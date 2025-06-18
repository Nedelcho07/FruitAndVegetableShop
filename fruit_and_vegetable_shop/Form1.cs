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
            if (vegan == null)
            {
                MessageBox.Show("Грешка: Липсва запис за зареждане.");
                return;
            }

            txt_id.BackColor = Color.White;
            txt_id.Text = vegan.Id.ToString();
            txt_name.Text = vegan.Name;
            txt_description.Text = vegan.Description;
            txt_price.Text = vegan.Price.ToString();

            if (vegan.VeganTypes != null)
            {
                cmb_type.Text = vegan.VeganTypes.Name;
            }
            else
            {
                cmb_type.Text = "";
            }
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
            this.vegansTableAdapter.Fill(this.fruitAndVegetableStoreDataSet.Vegans);
            List<VeganType> allVeganTypes = veganTypeController.GetAllVeganTypes();
            cmb_type.DataSource = allVeganTypes;
            cmb_type.DisplayMember = "Name";
            cmb_type.ValueMember = "Id";

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txt_id.Text) || !txt_id.Text.All(char.IsDigit))
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
            if (findedVegan == null)
            {
                MessageBox.Show("Няма такъв запис в базата!\nВъведи съществуващо Id за търсене!");
                txt_id.BackColor = Color.Red;
                txt_id.Focus();
                return;
            }
            LoadRecord(findedVegan);
            DialogResult answer = MessageBox.Show("Наистина ли искаш да изтриеш този запис Номер: " + findId + " ?", "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                veganController.Delete(findId);
                MessageBox.Show("Записът е изтрит!");
                this.vegansTableAdapter.Fill(this.fruitAndVegetableStoreDataSet.Vegans);
                ClearScreen();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_description.Text) || string.IsNullOrEmpty(txt_price.Text))
            {
                MessageBox.Show("Не си въвел достатъчно данни!");
                txt_name.Focus();
                return;
            }

            decimal price;
            if (!decimal.TryParse(txt_price.Text, out price))
            {
                MessageBox.Show("Моля, въведете валидна цена!");
                txt_price.Focus();
                return;
            }

            if (cmb_type.SelectedValue == null)
            {
                MessageBox.Show("Моля, изберете тип!");
                cmb_type.Focus();
                return;
            }

            Vegan newVegan = new Vegan();
            newVegan.Price = price;
            newVegan.Name = txt_name.Text;
            newVegan.Description = txt_description.Text;
            newVegan.VeganTypeId = (int)cmb_type.SelectedValue;

            veganController.Create(newVegan);
            MessageBox.Show("Записът е направен!");
            this.vegansTableAdapter.Fill(this.fruitAndVegetableStoreDataSet.Vegans);
            btn_selectAll_Click(sender, e);
        }

        private void btn_selectAll_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}
