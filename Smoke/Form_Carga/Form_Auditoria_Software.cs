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
    public partial class Form_Auditoria_Software : Form
    {
        Controladora.C_Software C_Software;
        public Form_Auditoria_Software()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            C_Software = Controladora.C_Software.Obtener_Instancia();
            Armar_Lista();
        }

        private void Form_Auditoria_Software_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public void Armar_Lista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = C_Software.ObtenerAuditoriaSoftware();
        }
    }
}
