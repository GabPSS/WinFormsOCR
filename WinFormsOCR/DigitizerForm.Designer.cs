namespace WinFormsOCR
{
    partial class DigitizerForm
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
            this.components = new System.ComponentModel.Container();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ImagemTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EscanearBtn = new System.Windows.Forms.Button();
            this.ImagensGroupBox = new System.Windows.Forms.GroupBox();
            this.ImagensTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MensagemFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AddImagensBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LinguagensCbx = new System.Windows.Forms.ComboBox();
            this.ResultadosTabPage = new System.Windows.Forms.TabPage();
            this.ResultadoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultadoGroupBox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.resultadosImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ResultadoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.SalvarArquivoBtn = new System.Windows.Forms.Button();
            this.ImagensFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MainTabControl.SuspendLayout();
            this.ImagemTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ImagensGroupBox.SuspendLayout();
            this.ImagensTableLayoutPanel.SuspendLayout();
            this.MensagemFlowLayoutPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ResultadosTabPage.SuspendLayout();
            this.ResultadoTableLayoutPanel.SuspendLayout();
            this.ResultadoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ImagemTabPage);
            this.MainTabControl.Controls.Add(this.ResultadosTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1005, 596);
            this.MainTabControl.TabIndex = 0;
            // 
            // ImagemTabPage
            // 
            this.ImagemTabPage.Controls.Add(this.tableLayoutPanel1);
            this.ImagemTabPage.Location = new System.Drawing.Point(4, 24);
            this.ImagemTabPage.Name = "ImagemTabPage";
            this.ImagemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ImagemTabPage.Size = new System.Drawing.Size(997, 568);
            this.ImagemTabPage.TabIndex = 0;
            this.ImagemTabPage.Text = "Imagem";
            this.ImagemTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.EscanearBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ImagensGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 562);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tableLayoutPanel1_DragDrop);
            this.tableLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tableLayoutPanel1_DragEnter);
            // 
            // EscanearBtn
            // 
            this.EscanearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EscanearBtn.Enabled = false;
            this.EscanearBtn.Location = new System.Drawing.Point(899, 536);
            this.EscanearBtn.Name = "EscanearBtn";
            this.EscanearBtn.Size = new System.Drawing.Size(89, 23);
            this.EscanearBtn.TabIndex = 2;
            this.EscanearBtn.Text = "Escanear";
            this.EscanearBtn.UseVisualStyleBackColor = true;
            this.EscanearBtn.Click += new System.EventHandler(this.EscanearBtn_Click);
            // 
            // ImagensGroupBox
            // 
            this.ImagensGroupBox.Controls.Add(this.ImagensTableLayoutPanel);
            this.ImagensGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagensGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ImagensGroupBox.Name = "ImagensGroupBox";
            this.ImagensGroupBox.Size = new System.Drawing.Size(985, 452);
            this.ImagensGroupBox.TabIndex = 3;
            this.ImagensGroupBox.TabStop = false;
            this.ImagensGroupBox.Text = "Imagens selecionadas";
            // 
            // ImagensTableLayoutPanel
            // 
            this.ImagensTableLayoutPanel.ColumnCount = 1;
            this.ImagensTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ImagensTableLayoutPanel.Controls.Add(this.MensagemFlowLayoutPanel, 0, 0);
            this.ImagensTableLayoutPanel.Controls.Add(this.AddImagensBtn, 0, 1);
            this.ImagensTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagensTableLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.ImagensTableLayoutPanel.Name = "ImagensTableLayoutPanel";
            this.ImagensTableLayoutPanel.RowCount = 2;
            this.ImagensTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ImagensTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ImagensTableLayoutPanel.Size = new System.Drawing.Size(979, 430);
            this.ImagensTableLayoutPanel.TabIndex = 1;
            // 
            // MensagemFlowLayoutPanel
            // 
            this.MensagemFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MensagemFlowLayoutPanel.AutoScroll = true;
            this.MensagemFlowLayoutPanel.AutoSize = true;
            this.MensagemFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MensagemFlowLayoutPanel.Controls.Add(this.label1);
            this.MensagemFlowLayoutPanel.Controls.Add(this.label2);
            this.MensagemFlowLayoutPanel.Controls.Add(this.button1);
            this.MensagemFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MensagemFlowLayoutPanel.Location = new System.Drawing.Point(337, 156);
            this.MensagemFlowLayoutPanel.Name = "MensagemFlowLayoutPanel";
            this.MensagemFlowLayoutPanel.Size = new System.Drawing.Size(305, 82);
            this.MensagemFlowLayoutPanel.TabIndex = 0;
            this.MensagemFlowLayoutPanel.WrapContents = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arraste imagens até aqui";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ou, se preferir, selecione-as pelo botão abaixo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(86, 50);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Selecionar imagens...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BuscarImagemBtn_Click);
            // 
            // AddImagensBtn
            // 
            this.AddImagensBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddImagensBtn.AutoSize = true;
            this.AddImagensBtn.Location = new System.Drawing.Point(423, 398);
            this.AddImagensBtn.Name = "AddImagensBtn";
            this.AddImagensBtn.Padding = new System.Windows.Forms.Padding(2);
            this.AddImagensBtn.Size = new System.Drawing.Size(132, 29);
            this.AddImagensBtn.TabIndex = 3;
            this.AddImagensBtn.Text = "Adicionar imagens...";
            this.AddImagensBtn.UseVisualStyleBackColor = true;
            this.AddImagensBtn.Visible = false;
            this.AddImagensBtn.Click += new System.EventHandler(this.BuscarImagemBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LinguagensCbx);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Idioma";
            // 
            // LinguagensCbx
            // 
            this.LinguagensCbx.FormattingEnabled = true;
            this.LinguagensCbx.Location = new System.Drawing.Point(77, 29);
            this.LinguagensCbx.Name = "LinguagensCbx";
            this.LinguagensCbx.Size = new System.Drawing.Size(182, 23);
            this.LinguagensCbx.TabIndex = 6;
            this.LinguagensCbx.Text = "Selecione uma linugagem...";
            // 
            // ResultadosTabPage
            // 
            this.ResultadosTabPage.Controls.Add(this.ResultadoTableLayoutPanel);
            this.ResultadosTabPage.Location = new System.Drawing.Point(4, 24);
            this.ResultadosTabPage.Name = "ResultadosTabPage";
            this.ResultadosTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ResultadosTabPage.Size = new System.Drawing.Size(997, 568);
            this.ResultadosTabPage.TabIndex = 1;
            this.ResultadosTabPage.Text = "Resultado";
            this.ResultadosTabPage.UseVisualStyleBackColor = true;
            // 
            // ResultadoTableLayoutPanel
            // 
            this.ResultadoTableLayoutPanel.ColumnCount = 1;
            this.ResultadoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultadoTableLayoutPanel.Controls.Add(this.ResultadoGroupBox, 0, 0);
            this.ResultadoTableLayoutPanel.Controls.Add(this.SalvarArquivoBtn, 0, 1);
            this.ResultadoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultadoTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ResultadoTableLayoutPanel.Name = "ResultadoTableLayoutPanel";
            this.ResultadoTableLayoutPanel.RowCount = 2;
            this.ResultadoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultadoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ResultadoTableLayoutPanel.Size = new System.Drawing.Size(991, 562);
            this.ResultadoTableLayoutPanel.TabIndex = 1;
            // 
            // ResultadoGroupBox
            // 
            this.ResultadoGroupBox.Controls.Add(this.splitContainer1);
            this.ResultadoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultadoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ResultadoGroupBox.Name = "ResultadoGroupBox";
            this.ResultadoGroupBox.Size = new System.Drawing.Size(985, 525);
            this.ResultadoGroupBox.TabIndex = 0;
            this.ResultadoGroupBox.TabStop = false;
            this.ResultadoGroupBox.Text = "Texto obtido";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Enabled = false;
            this.splitContainer1.Location = new System.Drawing.Point(3, 19);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStripContainer1);
            this.splitContainer1.Size = new System.Drawing.Size(979, 503);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AutoArrange = false;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.resultadosImageList;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(153, 503);
            this.listView1.SmallImageList = this.resultadosImageList;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // resultadosImageList
            // 
            this.resultadosImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.resultadosImageList.ImageSize = new System.Drawing.Size(64, 64);
            this.resultadosImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ResultadoRichTextBox);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(822, 478);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(822, 503);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // ResultadoRichTextBox
            // 
            this.ResultadoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultadoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultadoRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.ResultadoRichTextBox.Name = "ResultadoRichTextBox";
            this.ResultadoRichTextBox.Size = new System.Drawing.Size(822, 478);
            this.ResultadoRichTextBox.TabIndex = 0;
            this.ResultadoRichTextBox.Text = "";
            this.ResultadoRichTextBox.SelectionChanged += new System.EventHandler(this.ResultadoRichTextBox_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStripComboBox1,
            this.toolStripSeparator2,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(285, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WinFormsOCR.Properties.Resources.format_bold_FILL0_wght700_GRAD200_opsz48;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Negrito";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WinFormsOCR.Properties.Resources.format_italic_FILL0_wght700_GRAD200_opsz48;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Itálico";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::WinFormsOCR.Properties.Resources.format_underlined_FILL0_wght700_GRAD200_opsz48;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Sublinhado";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::WinFormsOCR.Properties.Resources.strikethrough_s_FILL0_wght700_GRAD200_opsz48;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Tachado";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Image = global::WinFormsOCR.Properties.Resources.format_size_FILL0_wght700_GRAD200_opsz48;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Tamanho do texto";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownWidth = 64;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "22",
            "24",
            "28",
            "32",
            "36",
            "48",
            "72"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextUpdate);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::WinFormsOCR.Properties.Resources.format_align_left_FILL0_wght700_GRAD200_opsz48;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Alinhar à esquerda";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::WinFormsOCR.Properties.Resources.format_align_center_FILL0_wght700_GRAD200_opsz48;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Alinhar ao centro";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::WinFormsOCR.Properties.Resources.format_align_right_FILL0_wght700_GRAD200_opsz48;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Alinhar à direita";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // SalvarArquivoBtn
            // 
            this.SalvarArquivoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalvarArquivoBtn.AutoSize = true;
            this.SalvarArquivoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SalvarArquivoBtn.Enabled = false;
            this.SalvarArquivoBtn.Location = new System.Drawing.Point(854, 534);
            this.SalvarArquivoBtn.Name = "SalvarArquivoBtn";
            this.SalvarArquivoBtn.Size = new System.Drawing.Size(134, 25);
            this.SalvarArquivoBtn.TabIndex = 1;
            this.SalvarArquivoBtn.Text = "Salvar como arquivo...";
            this.SalvarArquivoBtn.UseVisualStyleBackColor = true;
            this.SalvarArquivoBtn.Click += new System.EventHandler(this.SalvarArquivoBtn_Click);
            // 
            // ImagensFlowLayoutPanel
            // 
            this.ImagensFlowLayoutPanel.AutoScroll = true;
            this.ImagensFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagensFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ImagensFlowLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.ImagensFlowLayoutPanel.Name = "ImagensFlowLayoutPanel";
            this.ImagensFlowLayoutPanel.Size = new System.Drawing.Size(979, 430);
            this.ImagensFlowLayoutPanel.TabIndex = 0;
            this.ImagensFlowLayoutPanel.WrapContents = false;
            // 
            // DigitizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1005, 596);
            this.Controls.Add(this.MainTabControl);
            this.MinimumSize = new System.Drawing.Size(634, 261);
            this.Name = "DigitizerForm";
            this.Text = "Nova digitalização";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTabControl.ResumeLayout(false);
            this.ImagemTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ImagensGroupBox.ResumeLayout(false);
            this.ImagensTableLayoutPanel.ResumeLayout(false);
            this.ImagensTableLayoutPanel.PerformLayout();
            this.MensagemFlowLayoutPanel.ResumeLayout(false);
            this.MensagemFlowLayoutPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResultadosTabPage.ResumeLayout(false);
            this.ResultadoTableLayoutPanel.ResumeLayout(false);
            this.ResultadoTableLayoutPanel.PerformLayout();
            this.ResultadoGroupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabControl;
        private TabPage ImagemTabPage;
        private Button EscanearBtn;
        private TabPage ResultadosTabPage;
        private ComboBox LinguagensCbx;
        private TableLayoutPanel ResultadoTableLayoutPanel;
        private GroupBox ResultadoGroupBox;
        private Button SalvarArquivoBtn;
        private RichTextBox ResultadoRichTextBox;
        private FlowLayoutPanel MensagemFlowLayoutPanel;
        private Label label1;
        private Label label2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel ImagensFlowLayoutPanel;
        private GroupBox groupBox1;
        private Label label3;
        private GroupBox ImagensGroupBox;
        private TableLayoutPanel ImagensTableLayoutPanel;
        private Button AddImagensBtn;
        private SplitContainer splitContainer1;
        private ListView listView1;
        private ImageList resultadosImageList;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton5;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
    }
}