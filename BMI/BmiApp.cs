
namespace BMI
{
    internal class BmiApp
    {
        private TextBox weigth, heigth, result;
        private double w, h, r;
        public BmiApp( TextBox w, TextBox h, TextBox r ) {
            this.weigth = w;
            this.heigth = h;
            this.result = r;

            this.reset();

            this.result.ReadOnly = true;
        }

        public void reset() {
            this.weigth.Text = this.heigth.Text = this.result.Text = "";
            this.w = this.h = this.r = 0;
        }

        public void calculateResult() {
            //this.reset();
            if (this.readInputs()) {
                this.calculatePmi();
                this.showResult();
            }
        }

        private void showResult() {
            this.result.Text = this.r.ToString();
        }

        private void  calculatePmi() {
            this.r = this.w / (this.h * this.h);
        }

        private bool readInputs() {
            try {
                this.w = Double.Parse( this.weigth.Text );
                this.h = Double.Parse( this.heigth.Text );
                return true;
            } catch( Exception e ) {
                MessageBox.Show("Invalid Inputs");
                return false;
            }
        }
    }
}
