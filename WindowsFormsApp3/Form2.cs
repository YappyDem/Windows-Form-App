using System;
using System.Windows.Forms;

namespace ShawarmaOrderApp
{
    public partial class Form2 : Form
    {
        private OrderDetails orderDetails;

        public Form2(OrderDetails orderDetails)
        {
            InitializeComponent();
            this.orderDetails = orderDetails;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Отображаем детали заказа
            lblOrderDetails.Text = ""; // Очищаем текст перед добавлением новых данных
            decimal totalPrice = 0;

            foreach (var item in orderDetails.ShawarmaOrders)
            {
                string shawarmaName = item.Key;
                int quantity = item.Value;
                decimal price = orderDetails.ShawarmaPrices[shawarmaName];
                decimal itemTotal = price * quantity;

                lblOrderDetails.Text += $"{shawarmaName}: {quantity} шт. по {price} руб. (Итого: {itemTotal} руб.)\n";
                totalPrice += itemTotal;
            }

            lblOrderDetails.Text += $"\nОбщая стоимость: {totalPrice} руб.";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;

            // Создаем и показываем форму подтверждения
            Form3 form3 = new Form3(orderDetails, name, phone);
            form3.Show();
            this.Hide();
        }
    }
}