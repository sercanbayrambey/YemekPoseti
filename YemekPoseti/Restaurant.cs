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
    public class Restaurant
    {
        public int ID{ get; set; }

        public int OwnerID { get; set; }

        public string Name { get; set; }
        public int LocationID { get; set; }
        public float Rating { get; set; }
        public string Description { get; set; }
        public float MinOrderPrice { get; set; }


        public ucFoodItem GetFoodList(MySqlDataReader dr,int j)
        {
            
            ucFoodItem ucTempFoodList = new ucFoodItem(dr);
            /* Event Controls */
            /* BG Color */
            if (j % 2 == 0)
                ucTempFoodList.BackColor = Color.FromArgb(255, 245, 255);
            return ucTempFoodList;
        }




    }
}
