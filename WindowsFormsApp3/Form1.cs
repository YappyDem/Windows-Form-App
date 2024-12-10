using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShawarmaOrderApp
{
    public partial class Form1 : Form
    {
        // Цены на шаурму
        private const decimal PriceChicken = 180m;
        private const decimal PriceBeef = 200m;
        private const decimal PriceVegetarian = 170m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Создаем объект для хранения заказов
            var orderDetails = new OrderDetails();

            // Проверяем, выбраны ли виды шаурмы и добавляем их в заказ
            if (cbChicken.Checked)
            {
                orderDetails.ShawarmaOrders.Add("Куриная шаурма", (int)numericChicken.Value);
                orderDetails.ShawarmaPrices.Add("Куриная шаурма", PriceChicken);
            }
            if (cbBeef.Checked)
            {
                orderDetails.ShawarmaOrders.Add("Говяжья шаурма", (int)numericBeef.Value);
                orderDetails.ShawarmaPrices.Add("Говяжья шаурма", PriceBeef);
            }
            if (cbVegetarian.Checked)
            {
                orderDetails.ShawarmaOrders.Add("Вегетарианская шаурма", (int)numericVegetarian.Value);
                orderDetails.ShawarmaPrices.Add("Вегетарианская шаурма", PriceVegetarian);
            }

            // Передаем детали заказа в следующую форму
            Form2 form2 = new Form2(orderDetails);
            form2.Show();
            this.Hide();
        }
    }

    // Класс для хранения деталей заказа
    public class OrderDetails
    {
        public Dictionary<string, int> ShawarmaOrders { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, decimal> ShawarmaPrices { get; set; } = new Dictionary<string, decimal>();
    }
}