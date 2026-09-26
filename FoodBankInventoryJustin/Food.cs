using System;
using System.Collections.Generic;
using System.Text;

namespace FoodBankInventoryJustin
{
    internal class Food
    {
        private int itemID;
        private string? itemName;
        private string? category;
        private int quantity;

        public Food() {
            this.itemID = 0;
            this.itemName = null;
            this.category = null;
            this.quantity = 0;
        }

        public Food(int itemID, string? itemName, string? category, int quantity)
        {
            this.itemID = itemID;
            this.itemName = itemName;
            this.category = category;
            this.quantity = quantity;
        }

        //Properties

        public int ItemID {
            get { return this.itemID; }
            set {
                while (value <= 0) {
                    try
                    {
                        Console.WriteLine($"{value} is not a valid itemID, please re-enter:");
                        string? input = Console.ReadLine();
                    } catch (Exception ex) {
                        Console.WriteLine("Invalid input: " + ex.Message);
                    }
                }
                this.itemID = value;
            
            }
        }

        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                while (value < 0)
                {
                    try
                    {
                        Console.WriteLine($"{value} is not a valid quantity, please re-enter:");
                        string? input = Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid input: " + ex.Message);
                    }
                }
                this.quantity = value;

            }
        }

        public string Display()
        {
            return $"ID: {this.ItemID}\nItem: {this.itemName}\nCategory: {this.category}\nQuantity: {this.Quantity}";
        }
    }
}
