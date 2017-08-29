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
                listBox2.Items.Add(cssFile);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectorsComparer selectorsComparer = new SelectorsComparer(viewsFiles, cssFiles);
            var intersectionList = selectorsComparer.GetIntersection();
            for (int i = 0; i < intersectionList.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cellName = new DataGridViewTextBoxCell();
                cellName.Value = intersectionList[i].Item1;
                row.Cells.Add(cellName);

                DataGridViewCell cellUsage = new DataGridViewTextBoxCell();
                cellUsage.Value = intersectionList[i].Item2;
                row.Cells.Add(cellUsage);

                dataGridView1.Rows.Add(row);
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
