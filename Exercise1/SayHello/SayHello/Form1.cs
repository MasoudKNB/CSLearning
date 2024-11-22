namespace SayHello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtBName_TextChanged(null, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblEntrName_MouseMove(object sender, MouseEventArgs e)
        {
            LblEntrName.ForeColor = Color.Red;
        }

        private void LblEntrName_MouseLeave(object sender, EventArgs e)
        {
            LblEntrName.ForeColor = Color.Black;
        }

        private void BtnSayHello_Click(object sender, EventArgs e)
        {
            lblSayHello.Text = "Hello " + TxtBName.Text + "!";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtBName_TextChanged(object sender, EventArgs e)
        {
            BtnSayHello.Enabled = Convert.ToBoolean(TxtBName.Text.Length);
            BtnClear.Enabled = Convert.ToBoolean(TxtBName.Text.Length);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBName.Text = "";
            lblSayHello.Text = "";
        }

        private void BtnExit_MouseHover(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.Red;
        }
    }
}
