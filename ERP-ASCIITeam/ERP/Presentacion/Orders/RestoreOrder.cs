using ERP.Dominio.Gestores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Presentacion.Orders
{
    public partial class RestoreOrder : Form
    {
        bool acept;

        public bool Acept
        {
            get
            {
                return acept;
            }

            set
            {
                acept = value;
            }
        }

        public RestoreOrder()
        {
            InitializeComponent();
            acept = false;
            aparienciaBotones(btnCancelar);
            aparienciaBotones(btnConfirmar);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            acept = true;
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Black;
            ((Button)sender).ForeColor = Color.White;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Black;
        }

        public void aparienciaBotones(Button btn)
        {
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.Black;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
