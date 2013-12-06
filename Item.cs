﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p.o.s
{
    public class Item
    {
        public string Name { get; private set; }
        public decimal Price {get; set;}
        public Item()
        {
        Name = "None";
}       public Item(string name) {this.Name = name;}

        public string FullName
        {
            get
            {
                return Name + " - " + Price.ToString("F2");
            }
        }
    }

    public class Cart
    {
        public List<Item> Items {get; private set;}

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public decimal ComputeTotal()
        {
            decimal total = 0m;
            foreach (Item item in Items)
                total +=  item.Price;
                return total;
        }
    }

    // fake data
    public class Inventory
    {
        public List<ProductLine> ProductLines;

        public Inventory() {
            ProductLines = new List<ProductLine>();
            ProductLines.Add(new ProductLine("hp pavilion",150));
            ProductLines.Add(new ProductLine("Mac osx",2000));
            ProductLines.Add(new ProductLine("Toshiba",100));
            ProductLines.Add(new ProductLine("accer",155));
        }

    }

    public class ProductLine
    {
        public Item item;
        public int Qty { get; private set; }
        public ProductLine(string name, decimal price)
        {
            item = new Item(name);
            item.Price = price;
        }
    }
}
    