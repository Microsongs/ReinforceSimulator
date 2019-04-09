using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReinforceSimulator
{
    public partial class Working : Form
    {
        public Working()
        {
            InitializeComponent();
            ReinforceBox.Load(@"../../images/ReinforceImage.gif");
            ReinforceBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
