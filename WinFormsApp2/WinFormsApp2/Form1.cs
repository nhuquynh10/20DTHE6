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
         * đâu biết lần đi một lỡ làng
         * dưới trời đau khổ chết yêu đương
         */

    }
}