using System;
using System.Windows.Forms;

namespace ShawarmaOrderApp
{
    public partial class Form3 : Form
    {
        public Form3(OrderDetails orderDetails, string name, string phone)
        {
            InitializeComponent();
            lblOrderDetails.Text = "Ваш заказ:\n";

            foreach (var item in orderDetails.ShawarmaOrders)
            {
                lblOrderDetails.Text += $"{item.Key}: {item.Value} шт.\n";
            }

            lblOrderDetails.Text += $"Имя: {name}\nТелефон: {phone}";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрываем приложение
        }
    }
}