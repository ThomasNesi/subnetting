using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subnetting
{
    public partial class SM_box : Form
    {
        public SM_box()
        {
            InitializeComponent();
        }

        private void calcolo_btn_Click(object sender, EventArgs e)
        {
            indirizzi.Items.Clear();
            int subnetBits = SubnetBits(int.Parse(host_box.Text));
            string subnetMask = CalcoloSubnetMask(subnetBits);
            char Classe = Classeindirizzo(subnetBits);
            string cdir = $"/{subnetBits}";
            indirizzi.Items.Add("Subnet mask: " + subnetMask + "  CDIR: " + cdir + "  Classe: " + Classe);
        }
        private int SubnetBits(int numHosts)
        {
            int bits = 0;
            while ((int)Math.Pow(2, bits) - 2 < numHosts)
            {
                bits++;
            }
            return bits+8;
        }
        private string CalcoloSubnetMask(int subnetBits)
        {
            int[] maskParts = new int[4];
            for (int i = 0; i < 4; i++)
            {
                if (subnetBits >= 8)
                {
                    maskParts[i] = 255;
                    subnetBits -= 8;
                }
                else
                {
                    maskParts[i] = (int)(255 - (Math.Pow(2, 8 - subnetBits) - 1));
                    subnetBits = 0;
                }
            }
            return $"{maskParts[0]}.{maskParts[1]}.{maskParts[2]}.{maskParts[3]}";
        }
        static char Classeindirizzo(int subnetBits)
        {
            if (subnetBits >= 24)
            {
                return 'C';
            }
            else if (subnetBits >= 16)
            {
                return 'B';
            }
            else if (subnetBits >= 8)
            {
                return 'A';
            }
            else
            {
                return 'A';
            }
        }
    }
}