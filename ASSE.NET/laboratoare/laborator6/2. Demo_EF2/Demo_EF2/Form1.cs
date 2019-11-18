using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_EF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MyModelContainer())
            {
                var rootCategory1 = new Category
                {
                    Name = "root for food products",
                    Description = "something"
                };

                var rootCategory2 = new Category
                {
                    Name = "root for drinking products",
                    Description = "something2"
                };

                for (int i = 1; i < 10; i++)
                {
                    var childCategory = new Category
                    {
                        Name = "category " + i.ToString(),
                        Description = "description " + i.ToString(),
                        ParentCategory = rootCategory2
                    };
                }

                MessageBox.Show("childer for rootCategory2: " + rootCategory2.Categories.Count.ToString()) ;

                context.Categories.AddObject(rootCategory1);
                context.Categories.AddObject(rootCategory2);

                int howManyAdded = context.SaveChanges();
                MessageBox.Show("Added: " + howManyAdded.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new MyModelContainer())
            {
                var parentcategory = (from category in context.Categories
                                      where category.Name == "root for food products"
                                      select category).Single();

                var product = new Product
                {
                    Name = "demo",
                    Category = parentcategory
                };

                context.Products.AddObject(product);
                context.SaveChanges();

                MessageBox.Show("id for product: " + product.ProductId.ToString());
            }
        }
    }
}
