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

        public float price{ get; set; }
        public int ID{ get; set; }
        public string name{ get; set; }
        public string desc{ get; set; }
        private Restaurant ownedRest;
        public ucRM_MenuItem(MySqlDataReader dr,Restaurant ownedRest)
        {
            InitializeComponent();
            this.ownedRest = ownedRest;
            this.Dock = DockStyle.Top;
            this.name = dr["FoodName"].ToString();
            this.desc = dr["FoodDesc"].ToString();
            this.lblFoodName.Text = this.name;
            this.lblFoodDesc.Text = this.desc;
            this.ID = Convert.ToInt32(dr["FoodID"]);
            this.price = (Convert.ToSingle(dr["FoodPrice"]));
            this.lblFoodPrice.Text = this.price.ToString("0.00") + " TL";
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
           /* if (this.ownedRest.EditFood(this))
                MessageBox.Show("Silme işlemi başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Silme işlemi sırasında bir hata meydana geldi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
        }
    }
}
