using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace font
{
    public class style
    {
        int size;
        public string Font { set; get; }
        public int Size { set; get; }
        
        public bool Bold { set; get; }
        public bool Italic { set; get; }
        public bool Underline { set; get; }


        public bool Radio1 { set; get; }
        public bool Radio2 { set; get; }
        public bool Radio3 { set; get; }
        

        public Color f_color { set; get; }

        public style(string _font, Color _f_color ,int _size = 11, 
            bool _bold = false, bool _italic = false,bool _underline = false,
            bool _radio1 = false , bool _radio2 = false , bool _radio3 = false)
        {
            Font = _font;
            Size = _size;
            Bold = _bold;
            Italic = _italic;
            Underline = _underline;
            Radio1 = _radio1;
            Radio2 = _radio2;
            Radio3 = _radio3;
            f_color = _f_color;

        }
        public FontStyle s_font() {
            FontStyle b = FontStyle.Regular;
            FontStyle i = FontStyle.Regular;
            FontStyle u = FontStyle.Regular;
            if (Bold) { b = FontStyle.Bold; }
            if (Italic) { i = FontStyle.Italic; }
            if (Underline) { u = FontStyle.Underline; }
            return b | i | u;}

        public Color Font_c()
        {
            if (Radio1) { return Color.Red; }
            else if (Radio2) { return Color.Blue; }
            else if (Radio3) { return f_color; }
            return Color.Black;
        }

    }
}
