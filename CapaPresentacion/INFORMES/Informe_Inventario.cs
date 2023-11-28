using CapaEntidades.ClasesHijas;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace CapaPresentacion.INFORMES
{
    public partial class Informe_Inventario : Form
    {
        public Informe_Inventario()
        {
            InitializeComponent();
            PintarReporte();
        }

        public void PintarReporte()
        {
            ProductoGestion productoGestion = new ProductoGestion();
            foreach (Producto p in productoGestion.lista)
            {
                tabla.Rows.Add(p.IdProducto, p.Nombre, p.Cantidad);
            }
        }

        private void btnVolverInformeOcupacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
