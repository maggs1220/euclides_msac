namespace Euclides_MSAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Math.Max(int.Parse(txtnum1.Text), int.Parse(txtnum2.Text));
            int num2 = Math.Min(int.Parse(txtnum1.Text), int.Parse(txtnum2.Text));

            EuclidesRecursivo(num1, num2);

            gv1.AutoResizeColumns();
            gv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void EuclidesRecursivo(int a, int b)
        {
            int rowCount = gv1.Rows.Add();
            gv1.Rows[rowCount].Cells[0].Value = rowCount + 1;
            gv1.Rows[rowCount].Cells[1].Value = a + " dividido entre " + b + " es " + (a / b) + " y sobran " + (a % b);
            gv1.Rows[rowCount].Cells[2].Value = a + " = " + b + " x " + (a / b) + " + " + (a % b);

            if ((a % b) != 0)
            {
                EuclidesRecursivo(b, a % b);
            }
        }

    }
}