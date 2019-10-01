using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultasMVC.Controllers;

namespace ConsultasMVC.Views
{
    public partial class ClienteView : Form
    {
        public ClienteView()
        {
            InitializeComponent();
            ClienteController ctrl = new ClienteController(this);
        }
    }
}
