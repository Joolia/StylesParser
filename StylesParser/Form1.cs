using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StylesParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog viewsSelectDialog = new OpenFileDialog();
            viewsSelectDialog.Filter = @"Views files (*.cshtml)|*.cshtml|All files (*.*)|*.*";
            viewsSelectDialog.InitialDirectory = @"D:\ks\KarriereStart";
            viewsSelectDialog.Multiselect = true;
            viewsSelectDialog.ShowDialog();
        }
    }
}
