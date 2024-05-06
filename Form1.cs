using Microsoft.Data.SqlClient;

namespace LoginApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIPALI\\SQLEXPRESS;Initial Catalog=Loginapp01;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM Loginapp01 WHERE username=@username AND password= @password AND email= @email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("login success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("error in login");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //string text = textBox3.Text;
           // MessageBox.Show("you entered :  " + text);
        }
    }
}
