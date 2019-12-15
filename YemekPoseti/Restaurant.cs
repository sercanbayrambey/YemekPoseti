using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace YemekPoşeti
{
    class Restaurant
    {
        public int ID{ get; set; }

        public int OwnerID { get; set; }

        public string Name { get; set; }
        public int LocationID { get; set; }
        public float Rating { get; set; }
        public string Description { get; set; }
        public float MinOrderPrice { get; set; }


        public ucFoodList GetFoodList(MySqlDataReader dr,int j)
        {
            
            ucFoodList ucTemp = new ucFoodList();
            /* Event Controls */
            /*  ucTemp.Click += new EventHandler(Restaurant_Click);
              foreach (Control c in ucTemp.Controls)
              {
                  c.Click += new EventHandler(Restaurant_Click);
              }*/

            /* BG Color */
            if (j % 2 == 0)
                ucTemp.BackColor = Color.FromArgb(255, 245, 255);

            /* Dock Setting */
            ucTemp.Dock = DockStyle.Top;

            /* Set */
            ucTemp.lblFoodName.Text = dr["FoodName"].ToString();
            ucTemp.lblFoodDesc.Text = dr["FoodName"].ToString();
            ucTemp.lblFoodPrice.Text = (Convert.ToSingle(dr["FoodPrice"])).ToString("0.00") + " TL";
            return ucTemp;
        }




    }
}
