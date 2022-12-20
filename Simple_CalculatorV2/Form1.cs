namespace Simple_CalculatorV2
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            Text = "Change to Lightmode";
            button1_Click();            
        }
        
    }
}