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
    public partial class SaveFile : Form
    {
        public string SavePath { get; set; }
        public bool SaveMultipleFiles { get; set; }

        public SaveFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                Title = "Salvar como...",
                Filter = radioButton1.Checked ? "Arquivos de Texto (*.txt)|*.txt|Arquivos RTF (*.rtf)|*.rtf|Arquivos PDF (*.pdf)|*.pdf" : "Arquivos PDF (*.pdf)|*.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK )
            {
                DialogResult = DialogResult.OK;
                SavePath = sfd.FileName;
                SaveMultipleFiles = radioButton1.Checked;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
