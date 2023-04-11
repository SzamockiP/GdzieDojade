using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdzieDojade
{
    public partial class ConnectionNotFoundDisplay : UserControl
    {

        public ConnectionNotFoundDisplay(string exception)
        {
            InitializeComponent();
            lblConnectionNotFound.Text = exception;
        }
    }
}
