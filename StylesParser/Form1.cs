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
        private string[] viewsFiles;
        private string[] cssFiles;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog viewsSelectDialog = new OpenFileDialog
            {
                Filter = @"Views files (*.cshtml)|*.cshtml|All files (*.*)|*.*",
                InitialDirectory = @"D:\ks\KarriereStart",
                Multiselect = true
            };
            viewsSelectDialog.ShowDialog();
            viewsFiles = viewsSelectDialog.FileNames;

            foreach (var viewsFile in viewsFiles)
            {
                listBox1.Items.Add(viewsFile);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog stylesSelectDialog = new OpenFileDialog
            {
                Filter = @"Minimized css files (*.min.css)|*.min.css|All files (*.*)|*.*",
                InitialDirectory = @"D:\ks\KarriereStart",
                Multiselect = true
            };
            stylesSelectDialog.ShowDialog();
            cssFiles = stylesSelectDialog.FileNames;

            foreach (var cssFile in cssFiles)
            {
                listBox1.Items.Add(cssFile);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser(viewsFiles, cssFiles);
            var intersectionList = parser.GetIntersection();

            listBox3.Items.AddRange(intersectionList.ToArray());
        }
    }
}
