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
    public partial class Form_Tablero : Form
    {
        Vista.CVisual CVisual = new Vista.CVisual();
        public Form_Tablero()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            String IPWEB = CVisual.LeerIPWEB();
            webBrowser1.Navigate(IPWEB);

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form_Tablero_Load(object sender, EventArgs e)
        {

        }
    }
}
