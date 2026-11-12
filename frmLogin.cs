namespace Damas_Week06_Work05
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Capibara" && txtPassword.Text == "1234")
            {
                MessageBox.Show("Login successfull!");
                var inventoryForm = new frmInventory();
                inventoryForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invaild username or password");
            }
        }
    }
}
