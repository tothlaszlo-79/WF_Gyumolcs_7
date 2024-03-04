using System.ComponentModel;
using System.Windows.Forms;

namespace WF_Gyumolcs_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var btList = flpPage.Controls.OfType<Button>().ToList();
            foreach (var bt in btList)
            {
                FitImage(bt);
                FitImage(btSettings);

            }
        }
        private void FitImage(Button bt)
        {
            Image imResized = new Bitmap(bt.Image,
                new Size(bt.Width - 5, bt.Height - 5));
            bt.Image = imResized;

        }


        private void btFruit_Click(object sender, EventArgs e)
        {
            if (int.TryParse((sender as Button)?.Text, out int UnitPrice) &&
                float.TryParse(tbWeight.Text, out float Weight))
                tbPrice.Text = (UnitPrice * Weight).ToString();
            else
                tbPrice.Text = " ";


        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            var frmPassword = new frmPassword();
            if (frmPassword.ShowDialog() == DialogResult.OK)
            {
                if (frmPassword.Password == "123456")
                {
                    BindingList<Fruit> blFruitList = new BindingList<Fruit>();
                    var btList = flpPage.Controls.OfType<Button>().ToList();
                    foreach (var bt in btList)
                        blFruitList.Add(
                            new Fruit
                            {
                                FruitName = bt.Tag.ToString(),
                                UnitPrice = bt.GetUnitPrice()
                            });
                    var frmUnitPrices = new frmPrices();
                    frmUnitPrices.DGV.DataSource = blFruitList;
                    frmUnitPrices.DGV.Columns[0].ReadOnly = true;
                    frmUnitPrices.ShowDialog();
                    for (var i = 0; i < btList.Count; i++)
                    {
                        btList[i].SetUnitPrice(blFruitList[i].UnitPrice);
                    }
                }


            }
        }
    }
}
