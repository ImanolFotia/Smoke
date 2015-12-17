using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_Carga
{
    public partial class Form_Auditoria_Pagos : Form
    {
        Controladora.C_Pagos C_Pagos;
        public Form_Auditoria_Pagos()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            C_Pagos = Controladora.C_Pagos.Obtener_Instancia();
            Armar_Lista();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public void Armar_Lista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = C_Pagos.ObtenerAuditoriaPagoMensualMonto();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
