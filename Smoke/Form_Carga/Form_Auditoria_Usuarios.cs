﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_Carga
{
    public partial class Form_Auditoria_Usuarios : Form
    {
        Controladora.C_Usuarios C_Usuarios;
        public Form_Auditoria_Usuarios()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            C_Usuarios = Controladora.C_Usuarios.Obtener_Instancia();
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
            dataGridView1.DataSource = C_Usuarios.Listar_Usuarios();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Auditoria_Usuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
