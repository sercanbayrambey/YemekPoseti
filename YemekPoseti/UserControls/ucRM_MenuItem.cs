using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace YemekPoşeti
{
    partial class ucRM_MenuItem : UserControl
    {

        public float Price{ get; set; }
        public int ID{ get; set; }
        public string FoodName{ get; set; }
        public string Desc{ get; set; }
        private Restaurant ownedRest;
        public ucRM_MenuItem(MySqlDataReader dr,Restaurant ownedRest)
        {
            InitializeComponent();
            this.ownedRest = ownedRest;
            this.Dock = DockStyle.Top;
            this.FoodName = dr["FoodName"].ToString();
            this.Desc = dr["FoodDesc"].ToString();
            this.lblFoodName.Text = this.FoodName;
            this.lblFoodDesc.Text = this.Desc;
            this.ID = Convert.ToInt32(dr["FoodID"]);
            this.Price = (Convert.ToSingle(dr["FoodPrice"]));
            this.lblFoodPrice.Text = this.Price.ToString("0.00") + " TL";
        }

        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            if (this.ownedRest.DeleteFood(this.ID))
                MessageBox.Show("Silme işlemi başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Silme işlemi sırasında bir hata meydana geldi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            EditFoodScreen editFoodScreen = new EditFoodScreen(this,ownedRest);
            editFoodScreen.ShowDialog();


        }
    }
}
