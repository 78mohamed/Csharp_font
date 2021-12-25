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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Show();
            form2.OnGetstyle += this.font_func;
            
        }
        public void font_func(style s) {
            
            textBox1.Font = new Font(s.Font, s.Size , s.s_font()) ;
            textBox1.ForeColor = s.Font_c();
        }
        
    }
}
