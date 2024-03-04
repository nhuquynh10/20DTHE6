namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNguoiDung.Text == "Admin" && txtMatKhau.Text == "Admin") {
                MessageBox.Show("Thanh Cong!");
            }
        }

        /*
         * Nguoi xa xam qua toi buon qua
         * trong mot ngay vui phao nhuom duong
         */
    }
}