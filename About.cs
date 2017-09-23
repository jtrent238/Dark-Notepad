using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace MyNotepad {
    public partial class About : Form {
        public About() {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            Close();
        }

        private void controlSimplyGoodCodeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/luisperezphd/NotepadClone");
        }

        private void About_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
            //this.Text = String.Format("About {0}", Title);
            //this.label5.Text = AssemblyProduct;
            //this.label6.Text = String.Format("Version {0}", AssemblyVersion);
            //this.label7.Text = AssemblyCopyright;
            //this.label8.Text = AssemblyCompany;
            //this.textBoxDescription.Text = AssemblyDescription;
        }
    }
}
