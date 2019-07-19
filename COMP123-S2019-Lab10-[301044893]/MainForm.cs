using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10__301044893_
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Program.endform.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
