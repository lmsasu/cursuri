using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using DemoValidare.DomainModel;

namespace DemoValidare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create object
            Employee employee = new Employee
            {
                Name = txtName.Text.Trim().Length == 0 ? null : txtName.Text.Trim(),
                PersonalNumericCode = txtCode.Text.Trim().Length == 0? null : txtCode.Text.Trim(),
                AgeAtHiring = int.Parse( txtAge.Text.Trim()),
                OtherProperty = txtOtherProperty.Text.Trim(),
                Gender = txtGender.Text.Trim(),
            };
            //get validation results
            var validationResults = Validation.Validate<Employee>(employee);
            if (!validationResults.IsValid)
            {
                foreach (var result in validationResults)
                {
                    MessageBox.Show("Validation error: " + result.Message);
                }
            }
            else
            {
                MessageBox.Show("The object is valid");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                BuyPrice = new Money { Amount = 3.5m, Currency = "RON" },
                //SellPrice = new Money { Amount = -5m, Currency = "RON" },//negative price + too cheap
                //SellPrice = new Money { Amount = 2m, Currency = "RON" },//too cheap
                //SellPrice = new Money { Amount = 0m, Currency = "RON" },//should be at least 0
                SellPrice = new Money { Amount = 10m, Currency = "RON" },//ok
                //SellPrice = new Money { Amount = 10m, Currency = "£" },//currency not allowed
            };
            var validationResults = Validation.Validate(p);
            if (!validationResults.IsValid)
            {
                foreach (var result in validationResults)
                {
                    MessageBox.Show("Validation error: " + result.Message);
                }
            }
            else
            {
                MessageBox.Show("The object is valid");
            }
        }
    }
}
