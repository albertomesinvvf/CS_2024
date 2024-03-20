namespace BMI
{
    public partial class Form1 : Form
    {
        private BmiApp app;
        public Form1()
        {
            InitializeComponent();

            this.app = new BmiApp(this.weightTextBox, this.heightTextBox, this.resultTextBox);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            this.app.calculateResult();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.app.reset();
        }
    }
}
