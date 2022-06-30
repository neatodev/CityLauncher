using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLauncher
{
    public partial class InputForm : Form
    {
        public InputForm(Button InputButton)
        {
            InitializeComponent();
            Focus();
            this.KeyPress += Key_Pressed;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            Focus();
        }

        private void Key_Pressed(object sender, EventArgs e)
        {

        }
    }
}
