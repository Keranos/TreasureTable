using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSE_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var choice = comboBox1.SelectedItem.ToString();
            var output = string.Empty;
            foreach (var v in OSE_Treasure.Tables.ParentTreasureTable[choice])
                output += v.Roll();

            output = String.IsNullOrWhiteSpace(output) ? "Monster has nothing" : output.Replace("\n", Environment.NewLine);

            textBox1.Text = output;
        }
    }
}
