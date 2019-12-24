using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekPoşeti
{
    partial class EditFoodScreen :  MetroFramework.Forms.MetroForm
    {
        private Restaurant ownedRestaurant;
        private ucRM_MenuItem foodItem;
        public EditFoodScreen(ucRM_MenuItem foodItem,Restaurant ownedRestaurant)
        {
            InitializeComponent();
            tboxRMFoodName.Text = foodItem.FoodName;
            tboxRMFoodDesc.Text = foodItem.Desc;
            tboxRMFoodPrice.Text = foodItem.Price.ToString("0.00");
            this.foodItem = foodItem;
            this.ownedRestaurant = ownedRestaurant;

        }

        private void btnRMAddFood_Click(object sender, EventArgs e)
        {
            if(ownedRestaurant.EditFood(foodItem.ID, tboxRMFoodName.Text, tboxRMFoodDesc.Text, tboxRMFoodPrice.Text.Replace(',', '.')))
            {
                MessageBox.Show("Değişiklikler başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Değişiklikler kaydedilirken bir hata meydana geldi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
