using WinFormsApp5.DB;
using WinFormsApp5.Models;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataBase.cm();
            DataBase.ReadCarsFromDb();
            listBox1.DataSource = DataBase.cars;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(MarkaRadio.Checked)
            {
                var cars = DataBase.FindCarByMarka(textBox1.Text);
                listBox1.DataSource = cars;
            }
            else 
            {
                var cars = DataBase.FindCarByModel(textBox1.Text);
                listBox1.DataSource = cars;
            }
        }
    }
}
