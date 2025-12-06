using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteMensagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Deletado certo";
            var result = RJMessageBox.Show("Arquivo Deletado Com Sucesso.",
                "OK Button",
                MessageBoxButtons.OK);
            labelDialogResult.Text = result.ToString() + " Selected";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of an Yes, No, Cancel Button Message Box.",
                "Yes-No-Cancel Button",
                MessageBoxButtons.YesNoCancel);
            labelDialogResult.Text = result.ToString() + " Selected";
        }
    }
}
