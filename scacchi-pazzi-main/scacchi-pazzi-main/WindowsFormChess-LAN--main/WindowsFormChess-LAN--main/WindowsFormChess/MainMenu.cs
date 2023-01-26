using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sakk_Alkalmazás_2._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
           /* Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            pen.Graphics.DrawLine(pen, 20, 10, 300, 100);*/
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InGameForm inGame = new InGameForm(true, false, false);
            inGame.ShowDialog();
            this.Close();
        }

        private void Connection_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnectionForm connectionForm = new ConnectionForm();
            connectionForm.ShowDialog();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
