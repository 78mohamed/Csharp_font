using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace font
{
    public partial class Form2 : Form
    {
        public delegate void Getstyle(style s);
        public event Getstyle OnGetstyle;
        protected virtual void OnGetstylehappen(style s)
         { if (OnGetstyle != null) { OnGetstyle(s); }  }
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> fonts = new List<string>();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
            }
            comboBox1.DataSource = fonts;
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            
            style s = new style(comboBox1.Text , colorDialog1.Color,
                int.Parse(numericUpDown1.Value.ToString())
                , checkBox1.Checked, checkBox2.Checked, checkBox3.Checked
                , radioButton1.Checked ,radioButton2.Checked ,radioButton3.Checked
                );

            OnGetstylehappen(s);

        }
    }
}
