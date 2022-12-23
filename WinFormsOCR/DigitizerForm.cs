
using Tesseract;
using Page = Tesseract.Page;

namespace WinFormsOCR
{
    public partial class DigitizerForm : Form
    {
        public SelectionList selectionItems;

        public DigitizerForm()
        {
            InitializeComponent();
            LinguagensCbx.Items.Add(new LanguageItem("Português", "por"));
            LinguagensCbx.Items.Add(new LanguageItem("Inglês", "eng"));
            LinguagensCbx.SelectedIndex = 0;
            selectionItems = new SelectionList(ImagensFlowLayoutPanel);
            toolStripComboBox1.ComboBox.MouseWheel += ChangeSize;
        }

        private void RemoveImageButton(object? sender, EventArgs e)
        {
            Control? ctrl = (Control?)sender;
            if (ctrl != null)
            {
                SelectionItem listItem = (SelectionItem)ctrl.Parent;
                selectionItems.RemoveItem(listItem);
            }
            if (selectionItems.Count == 0)
            {
                ImagensTableLayoutPanel.Controls.Remove(ImagensFlowLayoutPanel);
                ImagensTableLayoutPanel.Controls.Add(MensagemFlowLayoutPanel, 0, 0);
                AddImagensBtn.Visible = false;
                EscanearBtn.Enabled = false;
            }
        }

        private void ScanImages(object sender, EventArgs e)
        {
            resultadosImageList.Images.Clear();
            listView1.Items.Clear();
            ResultadoRichTextBox.Clear();
            previousItem = -1;

            for (int i = 0; i < selectionItems.ItemPaths.Length; i++)
            {
                string path = selectionItems.ItemPaths[i];
                try
                {
                    //Perform OCR operation
                    TesseractEngine ocrengine = new("tessdata", ((LanguageItem)LinguagensCbx.SelectedItem).Name, EngineMode.Default);
                    Pix img = Pix.LoadFromFile(path);
                    Page scanResult = ocrengine.Process(img);
                    string resultText = scanResult.GetText();

                    //Add result image to List View's ImageList
                    try
                    {
                        Image attempt = Image.FromFile(path);
                        resultadosImageList.Images.Add(attempt);
                    }
                    catch
                    {
                        Image b = new Bitmap(resultadosImageList.ImageSize.Width, resultadosImageList.ImageSize.Height); //TODO: Change size later
                        Graphics g = Graphics.FromImage(b);
                        g.FillRectangle(Brushes.DarkGray, 0, 0, 32, 32);
                        resultadosImageList.Images.Add(b);
                    }

                    //Create and add list view item
                    ResultListViewItem resultItem = new()
                    {
                        ScanResult = resultText,
                        ImageIndex = i,
                        Text = path
                    };
                    listView1.Items.Add(resultItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro durante a conversão do item " + (i + 1) + ":\n\"" + ex.Message + "\"Tente novamente com outra imagem, ou entre em contato para obter ajuda");
                }

            }

            MainTabControl.SelectedTab = ResultadosTabPage;
            if (listView1.Items.Count > 0)
            {
                Text = listView1.Items.Count + " ite" + (listView1.Items.Count > 1 ? "ns" : "m") + " escaneado" + (listView1.Items.Count > 1 ? "s" : "");
                listView1.Items[0].Selected = true;
                splitContainer1.Enabled = true;
                SalvarArquivoBtn.Enabled = true;
            }

        }

        #region Image importing and drag drop effects

        private void tableLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;

        }

        private void tableLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] dropList = ((string[])e.Data.GetData(DataFormats.FileDrop)) ?? (Array.Empty<string>());
            foreach (string path in dropList)
            {
                AddImagem(path);
            }
        }

        private void AddImagem(string path)
        {
            if (selectionItems.Count == 0)
            {
                ImagensTableLayoutPanel.Controls.Remove(MensagemFlowLayoutPanel);
                ImagensTableLayoutPanel.Controls.Add(ImagensFlowLayoutPanel, 0, 0);
                AddImagensBtn.Visible = true;
                EscanearBtn.Enabled = true;
            }

            SelectionItem newItem = new(path);
            newItem.RemoveButtonClicked += RemoveImageButton;
            selectionItems.AddItem(newItem);
        }

        public void AddImagem_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Title = "Importar arquivo de imagem",
                Filter = "Arquivos de imagem conhecidos|*.jpg;*.png;*.bmp|Todos os arquivos|*.*",
                Multiselect = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    AddImagem(file);
                }
            }
        }

        #endregion

        #region Viewing items 

        private int previousItem = -1;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If the previous item exists, save its custom RTF to be the current textbox RTF
            if (previousItem != -1)
            {
                ((ResultListViewItem)listView1.Items[previousItem]).CustomRTF = ResultadoRichTextBox.Rtf;
            }
            //If an item has been selected...
            if (listView1.SelectedItems.Count > 0)
            {
                //Set the new selected item as the previous item and get it
                previousItem = listView1.SelectedIndices[0];
                ResultListViewItem selectedItem = (ResultListViewItem)listView1.SelectedItems[0];
                //If the selected item's custom RTF doesn't exist yet
                if (selectedItem.CustomRTF == string.Empty)
                {
                    //Initialize it, set the textbox's text to be the bare
                    //unformatted scan result, which will be converted by
                    //the control as RTF which can later be extracted from
                    //the .Rtf property in the first step when switching
                    //from this onto another item, creating custom RTF which
                    //will be loaded in the else statement of this condition
                    ResultadoRichTextBox.Text = selectedItem.ScanResult;
                }
                else
                {
                    //Load custom RTF if it exists
                    ResultadoRichTextBox.Rtf = selectedItem.CustomRTF;
                }
            }
        }

        #endregion

        #region Saving files

        public enum SaveFormats { TXT, RTF }

        public static SaveFormats GetSaveFormat(string path)
        {
            return path.ToLower().EndsWith(".txt") ? SaveFormats.TXT : SaveFormats.RTF;
        }

        public static string GetAppendedPath(string path, int appendedIndex)
        {
            string suffix = "";
            switch (GetSaveFormat(path))
            {
                case SaveFormats.TXT:
                    suffix = ".txt";
                    break;
                case SaveFormats.RTF:
                    suffix = ".rtf";
                    break;
            }

            string prefix = path[..^suffix.Length];
            return prefix + " (" + appendedIndex + ")" + suffix;
        }

        public void SalvarArquivoBtn_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                //Save the currently selected item index for later
                int currentIndex = listView1.SelectedIndices[0];

                //Actually save the file
                SaveFileDialog sfd = new()
                {
                    Title = "Salvar como...",
                    Filter = "Arquivos de Texto (*.txt)|*.txt|Arquivos RTF (*.rtf)|*.rtf"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //Get all path names
                    string[] savePathNames = new string[listView1.Items.Count];
                    if (listView1.Items.Count == 1)
                    {
                        savePathNames[0] = sfd.FileName;
                    }
                    else
                    {
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            savePathNames[i] = GetAppendedPath(sfd.FileName, i + 1);
                        }
                    }

                    //Save files according to format
                    switch (GetSaveFormat(sfd.FileName))
                    {
                        case SaveFormats.TXT:
                            for (int i = 0; i < listView1.Items.Count; i++)
                            {
                                listView1.Items[i].Selected = true;
                                File.WriteAllLines(savePathNames[i], ResultadoRichTextBox.Lines);
                            }
                            break;
                        case SaveFormats.RTF:
                            for (int i = 0; i < listView1.Items.Count; i++)
                            {
                                listView1.Items[i].Selected = true;
                                File.WriteAllText(savePathNames[i], ((ResultListViewItem)listView1.Items[i]).CustomRTF);
                            }
                            break;
                    }
                }
                //Set currently selected item as the previously selected item
                listView1.Items[currentIndex].Selected = true;
            }
        }

        #endregion

        #region RichTextBox style editing

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChangeFont(FontStyle.Bold);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ChangeFont(FontStyle.Italic);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ChangeFont(FontStyle.Underline);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ChangeFont(FontStyle.Strikeout);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ChangeAlignment(HorizontalAlignment.Left);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            ChangeAlignment(HorizontalAlignment.Center);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            ChangeAlignment(HorizontalAlignment.Right);
        }

        private void ResultadoRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            RefreshFontButtons();
            RefreshSize();
            RefreshAlignmentButtons();
        }

        public void ChangeFont(FontStyle toAdd)
        {
            int newStyle = 0;
            if (ResultadoRichTextBox.SelectionFont.Bold == (toAdd != FontStyle.Bold))
                newStyle += (int)FontStyle.Bold;
            if (ResultadoRichTextBox.SelectionFont.Italic == (toAdd != FontStyle.Italic))
                newStyle += (int)FontStyle.Italic;
            if (ResultadoRichTextBox.SelectionFont.Underline == (toAdd != FontStyle.Underline))
                newStyle += (int)FontStyle.Underline;
            if (ResultadoRichTextBox.SelectionFont.Strikeout == (toAdd != FontStyle.Strikeout))
                newStyle += (int)FontStyle.Strikeout;

            ResultadoRichTextBox.SelectionFont = new Font(ResultadoRichTextBox.SelectionFont, (FontStyle)newStyle);
            RefreshFontButtons();
        }

        public void ChangeSize(object? sender, MouseEventArgs e)
        {
            HandledMouseEventArgs hE = (HandledMouseEventArgs)e;
            hE.Handled = true;
            try
            {
                if (e.Delta < 0)
                {
                    toolStripComboBox1.SelectedIndex--;
                }
                else
                {
                    toolStripComboBox1.SelectedIndex++;
                }
            }
            catch { }
        }

        public void ChangeAlignment(HorizontalAlignment newAligment)
        {
            ResultadoRichTextBox.SelectionAlignment = newAligment;
            RefreshAlignmentButtons();
        }

        private void RefreshFontButtons()
        {
            toolStripButton1.Checked = ResultadoRichTextBox.SelectionFont.Bold;
            toolStripButton2.Checked = ResultadoRichTextBox.SelectionFont.Italic;
            toolStripButton3.Checked = ResultadoRichTextBox.SelectionFont.Underline;
            toolStripButton4.Checked = ResultadoRichTextBox.SelectionFont.Strikeout;
        }

        private void RefreshSize()
        {
            IgnoreUpdate = true;
            toolStripComboBox1.Text = ResultadoRichTextBox.SelectionFont.Size.ToString();
            IgnoreUpdate = false;
        }

        private void RefreshAlignmentButtons()
        {
            toolStripButton6.Checked = ResultadoRichTextBox.SelectionAlignment == HorizontalAlignment.Left;
            toolStripButton7.Checked = ResultadoRichTextBox.SelectionAlignment == HorizontalAlignment.Center;
            toolStripButton8.Checked = ResultadoRichTextBox.SelectionAlignment == HorizontalAlignment.Right;
        }

        private bool IgnoreUpdate = false;

        private void toolStripComboBox1_TextUpdate(object sender, EventArgs e)
        {
            if (!IgnoreUpdate)
            {
                float newSize;
                try
                {
                    newSize = Convert.ToSingle(toolStripComboBox1.Text);
                    ResultadoRichTextBox.SelectionFont = new Font(ResultadoRichTextBox.SelectionFont.FontFamily, newSize, ResultadoRichTextBox.SelectionFont.Style);
                }
                catch
                {
                    RefreshSize();
                }
            }
        }


        #endregion
    }

    /// <summary>
    /// Defines a list containing <seealso cref="SelectionItem"/> objects that updates dynamically with an associated <seealso cref="FlowLayoutPanel"/>
    /// </summary>
    public class SelectionList : List<SelectionItem>
    {
        #region Property definitions
        public string[] ItemPaths
        {
            get
            {
                string[] result = new string[Count];
                for (int i = 0; i < Count; i++)
                {
                    SelectionItem selectionitem = this[i];
                    result[i] = selectionitem.SelectionPath;
                }
                return result;
            }
        }
        public FlowLayoutPanel AssociatedPanel { get; set; }

        public SelectionList(FlowLayoutPanel associatedPanel)
        {
            AssociatedPanel = associatedPanel;
        }
        #endregion

        /// <summary>
        /// Adds an item to this List
        /// </summary>
        public void AddItem(SelectionItem item)
        {
            AssociatedPanel.Controls.Add(item);
            Add(item);
            OnListUpdate();
        }

        /// <summary>
        /// Removes an item from this list
        /// </summary>
        public void RemoveItem(SelectionItem item)
        {
            AssociatedPanel.Controls.Remove(item);
            Remove(item);
            OnListUpdate();
        }

        /// <summary>
        /// Removes the item in the specified index
        /// </summary>
        public void RemoveItemAt(int index)
        {
            AssociatedPanel.Controls.RemoveAt(index);
            RemoveAt(index);
            OnListUpdate();
        }

        #region ListUpdate event

        public event EventHandler? ListUpdate;
        protected virtual void OnListUpdate()
        {
            ListUpdate?.Invoke(this, EventArgs.Empty);
        }
        #endregion
    }

    public class SelectionItem : TableLayoutPanel
    {
        public Image? SelectionImage { get { try { return Image.FromFile(SelectionPath); } catch { return null; } } }
        public string SelectionPath { get; set; }
        private readonly int ItemHeight = 30;

        private readonly PictureBox Icon;
        private readonly Label FilePathLabel;
        private readonly Button RemoveButton;

        public SelectionItem(string selectionPath)
        {
            //Set class properties
            SelectionPath = selectionPath;

            //Set up tablelayoutpanel
            ColumnCount = 3;
            ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            RowCount = 1;
            RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            //Set up Button
            RemoveButton = new()
            {
                Text = "Remover",
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Anchor = AnchorStyles.None
            };
            RemoveButton.Click += RemoveButton_Click;
            Controls.Add(RemoveButton, 2, 0);

            //Set up Label
            FilePathLabel = new()
            {
                Text = SelectionPath,
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };
            Controls.Add(FilePathLabel, 1, 0);

            //Set up icon
            Icon = new()
            {
                Image = SelectionImage,
                BackColor = Color.LightGray,
                Width = ItemHeight,
                Height = ItemHeight,
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Controls.Add(Icon, 0, 0);


        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            return new Size(Parent.ClientRectangle.Width - (Parent.Padding.Left + Parent.Padding.Right) - (Margin.Left + Margin.Right) - 3, ItemHeight);
        }

        private void RemoveButton_Click(object? sender, EventArgs e)
        {
            OnRemoveButtonClicked(sender);
        }

        public event EventHandler? RemoveButtonClicked;
        protected virtual void OnRemoveButtonClicked(object? sender)
        {
            RemoveButtonClicked?.Invoke(sender, EventArgs.Empty);
        }

    }

    public class LanguageItem
    {
        public string DisplayText { get; set; }
        public string Name { get; set; }

        public LanguageItem(string displayText, string name)
        {
            DisplayText = displayText;
            Name = name;
        }

        public override string ToString()
        {
            return DisplayText;
        }
    }

    public class ResultListViewItem : ListViewItem
    {
        public string ScanResult { get; set; } = string.Empty;
        public string CustomRTF { get; set; } = string.Empty;
    }
}
