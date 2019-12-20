using System;
using System.Collections.Generic;
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
        private MainScreen ms;
        public ucBasketItem AddFood(ucFoodItem ucFoodItem, MainScreen ms)
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
                basketItem.ms = ms;
                basketItem.UpdateBasketItem();
                this.ms = ms;
                this.FoodsInBasket.Add(basketItem);
                ms.CurrentOrder.PrintFoods(ms.lboxUrunler);
                ms.CurrentOrder.GetSumBasketPrice();
                ms.CurrentOrder.CheckRestMinPriceStatus();
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
                            ((ucBasketItem)c).UpdateBasketItem();
                        }

                    }
                }

            }
            ms.CurrentOrder.PrintFoods(ms.lboxUrunler);
            ms.CurrentOrder.GetSumBasketPrice();
            ms.CurrentOrder.CheckRestMinPriceStatus();
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
            basketItem.UpdateBasketItem();
            if (basketItem.QTY == 0)
            {
                this.foodIDListInBasket.Remove(basketItem.FoodID);
                this.FoodsInBasket.Remove(basketItem);
                ms.panelBasket.Controls.Remove(basketItem);
            }
            this.ms.CurrentOrder.GetSumBasketPrice();
            ms.CurrentOrder.CheckRestMinPriceStatus();
            ms.lblSumPrice.Text = ms.CurrentOrder.SumBasketPrice.ToString("0.00") + " TL";
            ms.lblSumDiscount.Text = ms.CurrentOrder.DiscountPrice.ToString("0.00") + " TL"; ;
            ms.lblFinalSumPrice.Text = (ms.CurrentOrder.FinalPrice).ToString("0.00") + " TL";
        }

    }
}
