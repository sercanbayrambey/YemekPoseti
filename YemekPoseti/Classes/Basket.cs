using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekPoşeti
{
	class Basket
	{
		public List<ucBasketItem> FoodsInBasket = new List<ucBasketItem>();
		public List<int> foodIDListInBasket = new List<int>();
        private readonly MainScreen ms;
        public Basket(MainScreen ms)
        {
            this.ms = ms;
        }
        public ucBasketItem AddFood(ucFoodItem ucFoodItem)
        {
            int id = CheckID(ucFoodItem.FoodID);
            if (id == -1)
            {
                ucBasketItem basketItem = new ucBasketItem();
                this.foodIDListInBasket.Add(ucFoodItem.FoodID);
                basketItem.Dock = DockStyle.Top;
                basketItem.FoodID = ucFoodItem.FoodID;
                basketItem.Price = ucFoodItem.Price;
                basketItem.FoodName = ucFoodItem.lblFoodName.Text;
                basketItem.FoodDesc = ucFoodItem.lblFoodDesc.Text;
                basketItem.ms = this.ms;
                this.UpdateBasketItem(basketItem);
                this.FoodsInBasket.Add(basketItem);
                this.ms.LoggedUser.CurrentOrder.PrintFoods(this.ms.lboxUrunler);
                this.ms.LoggedUser.CurrentOrder.GetSumBasketPrice();
                this.ms.LoggedUser.CurrentOrder.CheckRestMinPriceStatus();
                return basketItem;
            }
            else
            {
                foreach (Control c in ms.panelBasket.Controls)
                {
                    if (c is ucBasketItem)
                    {
                        if (((ucBasketItem)c).FoodID == id)
                        {
                            ((ucBasketItem)c).QTY++;
                            this.UpdateBasketItem(((ucBasketItem)c));
                        }

                    }
                }
            }
            ms.LoggedUser.CurrentOrder.PrintFoods(ms.lboxUrunler);
            ms.LoggedUser.CurrentOrder.GetSumBasketPrice();
            ms.LoggedUser.CurrentOrder.CheckRestMinPriceStatus();
            return null;
        }

        private int CheckID(int id)
        {
            int foundId = -1;
            foreach (int foodId in this.foodIDListInBasket)
            {
                if (foodId == id)
                {
                    foundId = foodId;
                    break;
                }
            }
            return foundId;
        }

        public void RemoveFood(ucBasketItem basketItem)
        {
            basketItem.QTY--;
            this.UpdateBasketItem(basketItem);
            if (basketItem.QTY == 0)
            {
                this.foodIDListInBasket.Remove(basketItem.FoodID);
                this.FoodsInBasket.Remove(basketItem);
                ms.panelBasket.Controls.Remove(basketItem);
            }
            this.ms.LoggedUser.CurrentOrder.GetSumBasketPrice();
            ms.LoggedUser.CurrentOrder.CheckRestMinPriceStatus();
            ms.lblSumPrice.Text = ms.LoggedUser.CurrentOrder.SumBasketPrice.ToString("0.00") + " TL";
            ms.lblSumDiscount.Text = ms.LoggedUser.CurrentOrder.DiscountPrice.ToString("0.00") + " TL"; ;
            ms.lblFinalSumPrice.Text = (ms.LoggedUser.CurrentOrder.FinalPrice).ToString("0.00") + " TL";
        }


        public void UpdateBasketItem(ucBasketItem basketItem)
        {
            basketItem.SumPrice = basketItem.Price * basketItem.QTY;
            basketItem.lblFoodPrice.Text = basketItem.SumPrice.ToString("0.00") + " TL";
            basketItem.lblFoodName.Text = basketItem.FoodName + " x" + basketItem.QTY;
            basketItem.lblDeleteFood.Location = new Point(basketItem.lblFoodName.Location.X + 5 + basketItem.lblFoodName.Width, basketItem.lblDeleteFood.Location.Y);
            basketItem.lblFoodDesc.Text = basketItem.FoodDesc;
            ms.LoggedUser.CurrentOrder.PrintFoods(ms.lboxUrunler);
        }

    }
}
