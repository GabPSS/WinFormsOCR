namespace WinFormsOCR
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaDigitalizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarImagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tachadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àEsquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aoCentroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àDireitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aumentarFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diminuirFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.janelasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaDigitalizaçãoToolStripMenuItem,
            this.importarImagensToolStripMenuItem,
            this.toolStripSeparator1,
            this.salvarComoToolStripMenuItem,
            this.toolStripSeparator4,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novaDigitalizaçãoToolStripMenuItem
            // 
            this.novaDigitalizaçãoToolStripMenuItem.Name = "novaDigitalizaçãoToolStripMenuItem";
            this.novaDigitalizaçãoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novaDigitalizaçãoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.novaDigitalizaçãoToolStripMenuItem.Text = "&Nova digitalização";
            this.novaDigitalizaçãoToolStripMenuItem.Click += new System.EventHandler(this.novaDigitalizaçãoToolStripMenuItem_Click);
            // 
            // importarImagensToolStripMenuItem
            // 
            this.importarImagensToolStripMenuItem.Name = "importarImagensToolStripMenuItem";
            this.importarImagensToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.importarImagensToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.importarImagensToolStripMenuItem.Text = "Abrir...";
            this.importarImagensToolStripMenuItem.Click += new System.EventHandler(this.importarImagensToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar como...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(211, 6);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.fecharToolStripMenuItem.Text = "&Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.tachadoToolStripMenuItem,
            this.toolStripSeparator2,
            this.alinhamentoToolStripMenuItem,
            this.toolStripSeparator3,
            this.aumentarFonteToolStripMenuItem,
            this.diminuirFonteToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.editarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // tachadoToolStripMenuItem
            // 
            this.tachadoToolStripMenuItem.Name = "tachadoToolStripMenuItem";
            this.tachadoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tachadoToolStripMenuItem.Text = "Tachado";
            this.tachadoToolStripMenuItem.Click += new System.EventHandler(this.tachadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àEsquerdaToolStripMenuItem,
            this.aoCentroToolStripMenuItem,
            this.àDireitaToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // àEsquerdaToolStripMenuItem
            // 
            this.àEsquerdaToolStripMenuItem.Name = "àEsquerdaToolStripMenuItem";
            this.àEsquerdaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.àEsquerdaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.àEsquerdaToolStripMenuItem.Text = "À esquerda";
            this.àEsquerdaToolStripMenuItem.Click += new System.EventHandler(this.àEsquerdaToolStripMenuItem_Click);
            // 
            // aoCentroToolStripMenuItem
            // 
            this.aoCentroToolStripMenuItem.Name = "aoCentroToolStripMenuItem";
            this.aoCentroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.aoCentroToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aoCentroToolStripMenuItem.Text = "Ao centro";
            this.aoCentroToolStripMenuItem.Click += new System.EventHandler(this.aoCentroToolStripMenuItem_Click);
            // 
            // àDireitaToolStripMenuItem
            // 
            this.àDireitaToolStripMenuItem.Name = "àDireitaToolStripMenuItem";
            this.àDireitaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.àDireitaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.àDireitaToolStripMenuItem.Text = "À direita";
            this.àDireitaToolStripMenuItem.Click += new System.EventHandler(this.àDireitaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(173, 6);
            // 
            // aumentarFonteToolStripMenuItem
            // 
            this.aumentarFonteToolStripMenuItem.Name = "aumentarFonteToolStripMenuItem";
            this.aumentarFonteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aumentarFonteToolStripMenuItem.Text = "Aumentar fonte";
            this.aumentarFonteToolStripMenuItem.Click += new System.EventHandler(this.aumentarFonteToolStripMenuItem_Click);
            // 
            // diminuirFonteToolStripMenuItem
            // 
            this.diminuirFonteToolStripMenuItem.Name = "diminuirFonteToolStripMenuItem";
            this.diminuirFonteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.diminuirFonteToolStripMenuItem.Text = "Diminuir fonte";
            this.diminuirFonteToolStripMenuItem.Click += new System.EventHandler(this.diminuirFonteToolStripMenuItem_Click);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOProgramaToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreOProgramaToolStripMenuItem
            // 
            this.sobreOProgramaToolStripMenuItem.Name = "sobreOProgramaToolStripMenuItem";
            this.sobreOProgramaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.sobreOProgramaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.sobreOProgramaToolStripMenuItem.Text = "&Sobre o programa..";
            this.sobreOProgramaToolStripMenuItem.Click += new System.EventHandler(this.sobreOProgramaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Conversor de Imagem para Texto";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novaDigitalizaçãoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreOProgramaToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem itálicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStripMenuItem tachadoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem àEsquerdaToolStripMenuItem;
        private ToolStripMenuItem aoCentroToolStripMenuItem;
        private ToolStripMenuItem àDireitaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem aumentarFonteToolStripMenuItem;
        private ToolStripMenuItem diminuirFonteToolStripMenuItem;
        private ToolStripMenuItem salvarComoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem importarImagensToolStripMenuItem;
        private ToolStripMenuItem janelasToolStripMenuItem;
    }
}