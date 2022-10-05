namespace Windows_Forms_Application
{
    public partial class Form1 : Form
    {
        private string num;
        public Form1()
        {
            InitializeComponent();
            num = "";
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num= textBox1.Text;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(
                "�� ����� ����� " + Convert.ToInt32(num), 
                "�����������",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                textBox1.Clear();
            }
            catch
            {
                MessageBox.Show(
                "�� ����� �� ����� ",
                "�����������",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                textBox1.Clear();
            }
        }

        
    }
}