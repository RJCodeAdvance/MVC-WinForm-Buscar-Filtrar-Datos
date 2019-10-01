using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultasMVC.Models.Dao;
using ConsultasMVC.Models.Dto;
using ConsultasMVC.Views;

namespace ConsultasMVC.Controllers
{
    class ClienteController
    {
        ClienteView Vista;
        //Constructor
        public ClienteController(ClienteView View) {
            Vista = View;
            //inicializar eventos
            Vista.Load += new EventHandler(ClientList);
            Vista.btnBuscar.Click += new EventHandler(ClientList );
            Vista.txtBuscar.TextChanged += new EventHandler(ClientList );
        }

        private void ClientList(object sender, EventArgs e)
        {
            ClienteDao db = new ClienteDao();
            Vista.TablaCliente.DataSource =
                db.VerRegistros(Vista.txtBuscar.Text);
        }

    }
}
