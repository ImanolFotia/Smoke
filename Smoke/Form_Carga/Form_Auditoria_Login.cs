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
    public partial class Form_Auditoria_Login : Form
    {
        CONTROLADORA.cLOGIN C_Login;
        public Form_Auditoria_Login()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            C_Login = CONTROLADORA.cLOGIN.obtenerInstancia();
            Armar_Lista();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Form_Auditoria_Login_Load(object sender, EventArgs e)
        {

        }

        public void Armar_Lista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = C_Login.ObtenerAuditoriaLogin();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[1].Name = "Nombre de usuario";
            dataGridView1.Columns[2].Name = "Fecha y hora de login";
            dataGridView1.Columns[3].Name = "Fecha y hora de logout";
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
