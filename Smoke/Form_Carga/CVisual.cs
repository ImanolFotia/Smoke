using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Windows;
using System.IO;

namespace Vista
{
    public class CVisual
    {
        public void CambioVisual(Form form)
        {
            form.Size = new Size(1024, 768);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.SizeGripStyle = SizeGripStyle.Hide;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.BackColor = System.Drawing.Color.Black;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Text = "Smoke";
            form.Icon = new Icon("icon.ico");
            foreach (Control c in form.Controls)
            {
                UpdateColorControls(c);
            }
        }
        public void UpdateColorControls(Control myControl)
        {
            myControl.BackColor = System.Drawing.Color.Black;
            myControl.ForeColor = System.Drawing.Color.White;
            myControl.Font = new Font("Arial", 8, FontStyle.Bold);
            foreach (Control subC in myControl.Controls)
            {
                UpdateColorControls(subC);
            }
        }
        public string LeerIPWEB()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"IPWEB.txt");
            System.IO.StreamReader myFile = new System.IO.StreamReader(path);
            string IPWEB = myFile.ReadToEnd();
            myFile.Close();
            return IPWEB;
        }
    }
}
