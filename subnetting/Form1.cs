using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subnetting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcolo_btn_Click(object sender, EventArgs e)
        {
            int host = int.Parse(host_box.Text);
            int sottoreti = int.Parse(sottoreti_box.Text);
            double CDIR = Math.Log(host + 2, 2) + Math.Log(sottoreti, 2);
            if (CDIR <= 8)
            {
                classe_box.Text = ("Classe C");
                CDIR_box.Text = "/8";
            }
            else if (CDIR <= 16)
            {
                classe_box.Text = ("Classe B");
                CDIR_box.Text = "/16";
            }
            else if (CDIR <= 24)
            {
                classe_box.Text = ("Classe A");
                CDIR_box.Text = "/24";
            }
            else if (CDIR > 24)
            {
                classe_box.Text = ("Troppi host");
            }
        }
    }
}
