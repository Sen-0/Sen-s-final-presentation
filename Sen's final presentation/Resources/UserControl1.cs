using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sen_s_final_presentation.Resources
{
    public partial class UserControl1 : UserControl
    {
        private Color bordercolor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinestyle = false;


        public UserControl1()
        {
            InitializeComponent();
        }

        public Color Bordercolor { get => bordercolor; set => bordercolor = value; }
        public int BorderSize { get => borderSize; set => borderSize = value; }
        public bool Underlinestyle { get => underlinestyle; set => underlinestyle = value; }

    }
}
