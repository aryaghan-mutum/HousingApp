using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingAndDiningApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void RequisitionBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, you do not have the required permissions to use this feature");
        }

        private void FurnitureBtn_Click(object sender, EventArgs e)
        {
            FurnitureView fv = new FurnitureView();
            fv.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
