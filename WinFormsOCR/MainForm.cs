using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsOCR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void novaDigitalizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DigitizerForm() { MdiParent = this }.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            novaDigitalizaçãoToolStripMenuItem_Click(sender, e);
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestChangeFont(FontStyle.Bold);
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestChangeFont(FontStyle.Italic);
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestChangeFont(FontStyle.Underline);
        }

        private void tachadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestChangeFont(FontStyle.Strikeout);
        }

        class NoOpenFormException : Exception { }

        DigitizerForm GetOpenDigitizerForm()
        {
            var currentForm = this.ActiveMdiChild as DigitizerForm;
            if (currentForm != null)
            {
                return currentForm;
            }
            else
            {
                throw new NoOpenFormException();
            }
        }


        void RequestChangeFont(FontStyle fontStyle)
        {
            DigitizerForm form;
            try
            {
                form = GetOpenDigitizerForm();
                form.ChangeFont(fontStyle);
            }
            catch (NoOpenFormException)
            {
                return;
            }
        }

        void RequestChangeSize(bool Increase)
        {
            DigitizerForm form;
            try
            {
                form = GetOpenDigitizerForm();
                form.ChangeSize(null, new HandledMouseEventArgs(MouseButtons.None, 0, 0, 0, Increase ? 1 : -1));
            } catch (NoOpenFormException) { return; }
        }

        void RequestChangeAlignment(HorizontalAlignment horizontalAlignment)
        {
            DigitizerForm form;
            try
            {
                form = GetOpenDigitizerForm();
                form.ChangeAlignment(horizontalAlignment);
            }
            catch (NoOpenFormException)
            {
                return;
            }
        }

        private void àEsquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestChangeAlignment(HorizontalAlignment.Left);
        }

        private void aoCentroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestChangeAlignment(HorizontalAlignment.Center);
        }

        private void àDireitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestChangeAlignment(HorizontalAlignment.Right);
        }

        private void aumentarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestChangeSize(true);
        }

        private void diminuirFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestChangeSize(false);
        }
    }
}
