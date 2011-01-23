namespace NFOApplication
{
    partial class NFOEditor
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
            this.BaseFolderTextBox = new System.Windows.Forms.TextBox();
            this.SeriesTextBox = new System.Windows.Forms.TextBox();
            this.SeasonUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RatingUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.EpisodeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.PlotTextBox = new System.Windows.Forms.TextBox();
            this.NFOFilename = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MediaFilename = new System.Windows.Forms.Label();
            this.MediaExtensionTextBox = new System.Windows.Forms.TextBox();
            this.NextEpisodeButton = new System.Windows.Forms.Button();
            this.ExistingNFOListBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ExtrasTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.EditNFOButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.OriginalNFOFileName = new System.Windows.Forms.Label();
            this.ClearOriginalButton = new System.Windows.Forms.Button();
            this.NewSeriesFolderButton = new System.Windows.Forms.Button();
            this.NewExtrasFolderButton = new System.Windows.Forms.Button();
            this.NewSeasonFolderButton = new System.Windows.Forms.Button();
            this.PasteTitleButton = new System.Windows.Forms.Button();
            this.PasteSeriesNameButton = new System.Windows.Forms.Button();
            this.PastePlotButton = new System.Windows.Forms.Button();
            this.FolderButton = new System.Windows.Forms.Button();
            this.MediaFilenameCopyButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tagGridView = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.actorsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SeasonUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatingUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpisodeUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseFolderTextBox
            // 
            this.BaseFolderTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseFolderTextBox.Location = new System.Drawing.Point(157, 13);
            this.BaseFolderTextBox.Name = "BaseFolderTextBox";
            this.BaseFolderTextBox.Size = new System.Drawing.Size(307, 26);
            this.BaseFolderTextBox.TabIndex = 1;
            this.toolTip.SetToolTip(this.BaseFolderTextBox, "Main folder for TV shows");
            this.BaseFolderTextBox.TextChanged += new System.EventHandler(this.BaseFolderTextBox_TextChanged);
            this.BaseFolderTextBox.Leave += new System.EventHandler(this.BaseFolderTextBox_Leave);
            // 
            // SeriesTextBox
            // 
            this.SeriesTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeriesTextBox.Location = new System.Drawing.Point(157, 43);
            this.SeriesTextBox.Name = "SeriesTextBox";
            this.SeriesTextBox.Size = new System.Drawing.Size(201, 26);
            this.SeriesTextBox.TabIndex = 4;
            this.toolTip.SetToolTip(this.SeriesTextBox, "The name of the TV Series");
            this.SeriesTextBox.TextChanged += new System.EventHandler(this.SeriesTextBox_TextChanged);
            this.SeriesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RemoveInvalidFilenameChars_KeyPress);
            // 
            // SeasonUpDown
            // 
            this.SeasonUpDown.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeasonUpDown.Location = new System.Drawing.Point(157, 107);
            this.SeasonUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SeasonUpDown.Name = "SeasonUpDown";
            this.SeasonUpDown.Size = new System.Drawing.Size(120, 26);
            this.SeasonUpDown.TabIndex = 11;
            this.toolTip.SetToolTip(this.SeasonUpDown, "Season for this title");
            this.SeasonUpDown.ValueChanged += new System.EventHandler(this.SeasonUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Media Folder";
            this.toolTip.SetToolTip(this.label1, "Main folder for TV shows");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "TV Series Name";
            this.toolTip.SetToolTip(this.label2, "The name of the TV Series");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Season";
            this.toolTip.SetToolTip(this.label3, "Season for this title");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rating";
            this.toolTip.SetToolTip(this.label4, "Rating from 0-10");
            // 
            // RatingUpDown1
            // 
            this.RatingUpDown1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingUpDown1.Location = new System.Drawing.Point(157, 139);
            this.RatingUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RatingUpDown1.Name = "RatingUpDown1";
            this.RatingUpDown1.Size = new System.Drawing.Size(120, 26);
            this.RatingUpDown1.TabIndex = 17;
            this.toolTip.SetToolTip(this.RatingUpDown1, "Rating from 0-10");
            this.RatingUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Episode";
            this.toolTip.SetToolTip(this.label5, "The episode number goes here");
            // 
            // EpisodeUpDown
            // 
            this.EpisodeUpDown.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EpisodeUpDown.Location = new System.Drawing.Point(157, 171);
            this.EpisodeUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.EpisodeUpDown.Name = "EpisodeUpDown";
            this.EpisodeUpDown.Size = new System.Drawing.Size(120, 26);
            this.EpisodeUpDown.TabIndex = 19;
            this.toolTip.SetToolTip(this.EpisodeUpDown, "The episode number goes here");
            this.EpisodeUpDown.ValueChanged += new System.EventHandler(this.EpisodeUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Plot";
            this.toolTip.SetToolTip(this.label6, "Details of the plot go her");
            // 
            // PlotTextBox
            // 
            this.PlotTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotTextBox.Location = new System.Drawing.Point(156, 203);
            this.PlotTextBox.Multiline = true;
            this.PlotTextBox.Name = "PlotTextBox";
            this.PlotTextBox.Size = new System.Drawing.Size(340, 137);
            this.PlotTextBox.TabIndex = 22;
            this.toolTip.SetToolTip(this.PlotTextBox, "Details of the plot go here");
            // 
            // NFOFilename
            // 
            this.NFOFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NFOFilename.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NFOFilename.Location = new System.Drawing.Point(519, 37);
            this.NFOFilename.Name = "NFOFilename";
            this.NFOFilename.Size = new System.Drawing.Size(429, 26);
            this.NFOFilename.TabIndex = 30;
            this.NFOFilename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.NFOFilename, "The filename of the NFO file that will be saved");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "NFO Filename";
            this.toolTip.SetToolTip(this.label7, "The filename of the NFO file that will be saved");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(556, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Filename";
            this.toolTip.SetToolTip(this.label8, "The filename of the episode\'s media file");
            // 
            // MediaFilename
            // 
            this.MediaFilename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MediaFilename.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaFilename.Location = new System.Drawing.Point(519, 143);
            this.MediaFilename.Name = "MediaFilename";
            this.MediaFilename.Size = new System.Drawing.Size(429, 26);
            this.MediaFilename.TabIndex = 35;
            this.MediaFilename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.MediaFilename, "The filename of the episode\'s media file");
            // 
            // MediaExtensionTextBox
            // 
            this.MediaExtensionTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaExtensionTextBox.Location = new System.Drawing.Point(517, 114);
            this.MediaExtensionTextBox.MaxLength = 3;
            this.MediaExtensionTextBox.Name = "MediaExtensionTextBox";
            this.MediaExtensionTextBox.Size = new System.Drawing.Size(36, 26);
            this.MediaExtensionTextBox.TabIndex = 33;
            this.MediaExtensionTextBox.Text = "MKV";
            this.toolTip.SetToolTip(this.MediaExtensionTextBox, "The extension used by your media files");
            // 
            // NextEpisodeButton
            // 
            this.NextEpisodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextEpisodeButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextEpisodeButton.Location = new System.Drawing.Point(283, 171);
            this.NextEpisodeButton.Name = "NextEpisodeButton";
            this.NextEpisodeButton.Size = new System.Drawing.Size(63, 26);
            this.NextEpisodeButton.TabIndex = 20;
            this.NextEpisodeButton.TabStop = false;
            this.NextEpisodeButton.Text = "Next";
            this.toolTip.SetToolTip(this.NextEpisodeButton, "Skip to the next open episode number");
            this.NextEpisodeButton.UseVisualStyleBackColor = true;
            this.NextEpisodeButton.Click += new System.EventHandler(this.NextEpisodeButton_Click);
            // 
            // ExistingNFOListBox
            // 
            this.ExistingNFOListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingNFOListBox.FormattingEnabled = true;
            this.ExistingNFOListBox.ItemHeight = 18;
            this.ExistingNFOListBox.Location = new System.Drawing.Point(517, 212);
            this.ExistingNFOListBox.Name = "ExistingNFOListBox";
            this.ExistingNFOListBox.Size = new System.Drawing.Size(464, 454);
            this.ExistingNFOListBox.TabIndex = 37;
            this.ExistingNFOListBox.SelectedIndexChanged += new System.EventHandler(this.ExistingNFOListBox_SelectedIndexChanged);
            this.ExistingNFOListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ExistingNFOListBox_MouseDoubleClick);
            this.ExistingNFOListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExistingNFOListBox_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(519, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "Existing NFO Files";
            // 
            // ExtrasTextBox
            // 
            this.ExtrasTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtrasTextBox.Location = new System.Drawing.Point(363, 107);
            this.ExtrasTextBox.Name = "ExtrasTextBox";
            this.ExtrasTextBox.Size = new System.Drawing.Size(101, 26);
            this.ExtrasTextBox.TabIndex = 14;
            this.toolTip.SetToolTip(this.ExtrasTextBox, "Subdirectory for season extras");
            this.ExtrasTextBox.TextChanged += new System.EventHandler(this.ExtrasTextBox_TextChanged);
            this.ExtrasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RemoveInvalidFilenameChars_KeyPress);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(421, 675);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 26);
            this.SaveButton.TabIndex = 28;
            this.SaveButton.TabStop = false;
            this.SaveButton.Text = "Save";
            this.toolTip.SetToolTip(this.SaveButton, "Save this NFO");
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Title";
            this.toolTip.SetToolTip(this.label9, "The title of this episode");
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(157, 75);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(201, 26);
            this.TitleTextBox.TabIndex = 8;
            this.toolTip.SetToolTip(this.TitleTextBox, "The title of this episode");
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            this.TitleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RemoveInvalidFilenameChars_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(312, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Extras";
            this.toolTip.SetToolTip(this.label11, "Subdirectory for season extra");
            // 
            // EditNFOButton
            // 
            this.EditNFOButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditNFOButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditNFOButton.Location = new System.Drawing.Point(517, 675);
            this.EditNFOButton.Name = "EditNFOButton";
            this.EditNFOButton.Size = new System.Drawing.Size(75, 26);
            this.EditNFOButton.TabIndex = 38;
            this.EditNFOButton.TabStop = false;
            this.EditNFOButton.Text = "Edit";
            this.toolTip.SetToolTip(this.EditNFOButton, "Edit selected NFO");
            this.EditNFOButton.UseVisualStyleBackColor = true;
            this.EditNFOButton.Click += new System.EventHandler(this.EditNFOButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(517, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Original NFO Filename";
            this.toolTip.SetToolTip(this.label12, "The filename of the NFO being edited");
            // 
            // OriginalNFOFileName
            // 
            this.OriginalNFOFileName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OriginalNFOFileName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalNFOFileName.Location = new System.Drawing.Point(519, 85);
            this.OriginalNFOFileName.Name = "OriginalNFOFileName";
            this.OriginalNFOFileName.Size = new System.Drawing.Size(429, 26);
            this.OriginalNFOFileName.TabIndex = 32;
            this.OriginalNFOFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.OriginalNFOFileName, "The filename of the NFO being edited");
            this.OriginalNFOFileName.TextChanged += new System.EventHandler(this.OriginalNFOFileName_TextChanged);
            // 
            // ClearOriginalButton
            // 
            this.ClearOriginalButton.AutoSize = true;
            this.ClearOriginalButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearOriginalButton.Enabled = false;
            this.ClearOriginalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearOriginalButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearOriginalButton.Image = global::NFOApplication.Properties.Resources.Clear;
            this.ClearOriginalButton.Location = new System.Drawing.Point(955, 85);
            this.ClearOriginalButton.Name = "ClearOriginalButton";
            this.ClearOriginalButton.Size = new System.Drawing.Size(26, 26);
            this.ClearOriginalButton.TabIndex = 37;
            this.ClearOriginalButton.TabStop = false;
            this.toolTip.SetToolTip(this.ClearOriginalButton, "Save should not remove original");
            this.ClearOriginalButton.UseVisualStyleBackColor = true;
            this.ClearOriginalButton.Click += new System.EventHandler(this.ClearOriginalButton_Click);
            // 
            // NewSeriesFolderButton
            // 
            this.NewSeriesFolderButton.AutoSize = true;
            this.NewSeriesFolderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewSeriesFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewSeriesFolderButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSeriesFolderButton.Image = global::NFOApplication.Properties.Resources.NewFolder;
            this.NewSeriesFolderButton.Location = new System.Drawing.Point(396, 42);
            this.NewSeriesFolderButton.Name = "NewSeriesFolderButton";
            this.NewSeriesFolderButton.Size = new System.Drawing.Size(26, 26);
            this.NewSeriesFolderButton.TabIndex = 6;
            this.NewSeriesFolderButton.TabStop = false;
            this.toolTip.SetToolTip(this.NewSeriesFolderButton, "Create Folder with this Name");
            this.NewSeriesFolderButton.UseVisualStyleBackColor = true;
            this.NewSeriesFolderButton.Visible = false;
            this.NewSeriesFolderButton.Click += new System.EventHandler(this.NewSeriesFolderButton_Click);
            // 
            // NewExtrasFolderButton
            // 
            this.NewExtrasFolderButton.AutoSize = true;
            this.NewExtrasFolderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewExtrasFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewExtrasFolderButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewExtrasFolderButton.Image = global::NFOApplication.Properties.Resources.NewFolder;
            this.NewExtrasFolderButton.Location = new System.Drawing.Point(470, 107);
            this.NewExtrasFolderButton.Name = "NewExtrasFolderButton";
            this.NewExtrasFolderButton.Size = new System.Drawing.Size(26, 26);
            this.NewExtrasFolderButton.TabIndex = 15;
            this.NewExtrasFolderButton.TabStop = false;
            this.toolTip.SetToolTip(this.NewExtrasFolderButton, "Create Folder with this Name");
            this.NewExtrasFolderButton.UseVisualStyleBackColor = true;
            this.NewExtrasFolderButton.Visible = false;
            this.NewExtrasFolderButton.Click += new System.EventHandler(this.NewExtrasFolderButton_Click);
            // 
            // NewSeasonFolderButton
            // 
            this.NewSeasonFolderButton.AutoSize = true;
            this.NewSeasonFolderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewSeasonFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewSeasonFolderButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSeasonFolderButton.Image = global::NFOApplication.Properties.Resources.NewFolder;
            this.NewSeasonFolderButton.Location = new System.Drawing.Point(283, 107);
            this.NewSeasonFolderButton.Name = "NewSeasonFolderButton";
            this.NewSeasonFolderButton.Size = new System.Drawing.Size(26, 26);
            this.NewSeasonFolderButton.TabIndex = 12;
            this.NewSeasonFolderButton.TabStop = false;
            this.toolTip.SetToolTip(this.NewSeasonFolderButton, "Create Folder with this Name");
            this.NewSeasonFolderButton.UseVisualStyleBackColor = true;
            this.NewSeasonFolderButton.Visible = false;
            this.NewSeasonFolderButton.Click += new System.EventHandler(this.NewSeasonFolderButton_Click);
            // 
            // PasteTitleButton
            // 
            this.PasteTitleButton.AutoSize = true;
            this.PasteTitleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PasteTitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PasteTitleButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteTitleButton.Image = global::NFOApplication.Properties.Resources.Paste;
            this.PasteTitleButton.Location = new System.Drawing.Point(364, 75);
            this.PasteTitleButton.Name = "PasteTitleButton";
            this.PasteTitleButton.Size = new System.Drawing.Size(26, 26);
            this.PasteTitleButton.TabIndex = 9;
            this.PasteTitleButton.TabStop = false;
            this.toolTip.SetToolTip(this.PasteTitleButton, "Paste Title");
            this.PasteTitleButton.UseVisualStyleBackColor = true;
            this.PasteTitleButton.Click += new System.EventHandler(this.PasteTitleButton_Click);
            // 
            // PasteSeriesNameButton
            // 
            this.PasteSeriesNameButton.AutoSize = true;
            this.PasteSeriesNameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PasteSeriesNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PasteSeriesNameButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteSeriesNameButton.Image = global::NFOApplication.Properties.Resources.Paste;
            this.PasteSeriesNameButton.Location = new System.Drawing.Point(364, 42);
            this.PasteSeriesNameButton.Name = "PasteSeriesNameButton";
            this.PasteSeriesNameButton.Size = new System.Drawing.Size(26, 26);
            this.PasteSeriesNameButton.TabIndex = 5;
            this.PasteSeriesNameButton.TabStop = false;
            this.toolTip.SetToolTip(this.PasteSeriesNameButton, "Paste TV Series Name");
            this.PasteSeriesNameButton.UseVisualStyleBackColor = true;
            this.PasteSeriesNameButton.Click += new System.EventHandler(this.PasteSeriesNameButton_Click);
            // 
            // PastePlotButton
            // 
            this.PastePlotButton.AutoSize = true;
            this.PastePlotButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PastePlotButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PastePlotButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastePlotButton.Image = global::NFOApplication.Properties.Resources.Paste;
            this.PastePlotButton.Location = new System.Drawing.Point(124, 314);
            this.PastePlotButton.Name = "PastePlotButton";
            this.PastePlotButton.Size = new System.Drawing.Size(26, 26);
            this.PastePlotButton.TabIndex = 23;
            this.PastePlotButton.TabStop = false;
            this.toolTip.SetToolTip(this.PastePlotButton, "Paste Plot");
            this.PastePlotButton.UseVisualStyleBackColor = true;
            this.PastePlotButton.Click += new System.EventHandler(this.PastePlotButton_Click);
            // 
            // FolderButton
            // 
            this.FolderButton.AutoSize = true;
            this.FolderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FolderButton.Image = global::NFOApplication.Properties.Resources.Folder;
            this.FolderButton.Location = new System.Drawing.Point(470, 12);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(26, 26);
            this.FolderButton.TabIndex = 2;
            this.FolderButton.TabStop = false;
            this.toolTip.SetToolTip(this.FolderButton, "Browse Folders");
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // MediaFilenameCopyButton
            // 
            this.MediaFilenameCopyButton.AutoSize = true;
            this.MediaFilenameCopyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MediaFilenameCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MediaFilenameCopyButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaFilenameCopyButton.Image = global::NFOApplication.Properties.Resources.Copy;
            this.MediaFilenameCopyButton.Location = new System.Drawing.Point(955, 143);
            this.MediaFilenameCopyButton.Name = "MediaFilenameCopyButton";
            this.MediaFilenameCopyButton.Size = new System.Drawing.Size(26, 26);
            this.MediaFilenameCopyButton.TabIndex = 27;
            this.MediaFilenameCopyButton.TabStop = false;
            this.toolTip.SetToolTip(this.MediaFilenameCopyButton, "Copy the generated media filename");
            this.MediaFilenameCopyButton.UseVisualStyleBackColor = true;
            this.MediaFilenameCopyButton.Click += new System.EventHandler(this.MediaFilenameCopyButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(993, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tagGridView
            // 
            this.tagGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagGridView.Location = new System.Drawing.Point(15, 520);
            this.tagGridView.Name = "tagGridView";
            this.tagGridView.Size = new System.Drawing.Size(481, 146);
            this.tagGridView.TabIndex = 27;
            this.toolTip.SetToolTip(this.tagGridView, "Other miscellaneous tags");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 499);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Tags";
            this.toolTip.SetToolTip(this.label13, "Other miscellaneous tags");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 18);
            this.label14.TabIndex = 24;
            this.label14.Text = "Actors";
            this.toolTip.SetToolTip(this.label14, "List of actors");
            // 
            // actorsGridView
            // 
            this.actorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorsGridView.Location = new System.Drawing.Point(15, 353);
            this.actorsGridView.Name = "actorsGridView";
            this.actorsGridView.Size = new System.Drawing.Size(481, 146);
            this.actorsGridView.TabIndex = 25;
            this.toolTip.SetToolTip(this.actorsGridView, "List of actors");
            // 
            // NFOEditor
            // 
            this.AcceptButton = this.SaveButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 726);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.actorsGridView);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tagGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ClearOriginalButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.OriginalNFOFileName);
            this.Controls.Add(this.NewSeriesFolderButton);
            this.Controls.Add(this.NewExtrasFolderButton);
            this.Controls.Add(this.NewSeasonFolderButton);
            this.Controls.Add(this.EditNFOButton);
            this.Controls.Add(this.PasteTitleButton);
            this.Controls.Add(this.PasteSeriesNameButton);
            this.Controls.Add(this.PastePlotButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExtrasTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ExistingNFOListBox);
            this.Controls.Add(this.NextEpisodeButton);
            this.Controls.Add(this.MediaFilenameCopyButton);
            this.Controls.Add(this.MediaExtensionTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MediaFilename);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NFOFilename);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PlotTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EpisodeUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RatingUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeasonUpDown);
            this.Controls.Add(this.SeriesTextBox);
            this.Controls.Add(this.BaseFolderTextBox);
            this.Name = "NFOEditor";
            this.Text = "TV Series NFO Editor";
            this.toolTip.SetToolTip(this, "Can create and edit NFO files for TV Series");
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.NFOEditor_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.NFOEditor_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.SeasonUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatingUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpisodeUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BaseFolderTextBox;
        private System.Windows.Forms.TextBox SeriesTextBox;
        private System.Windows.Forms.NumericUpDown SeasonUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RatingUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown EpisodeUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PlotTextBox;
        private System.Windows.Forms.Label NFOFilename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MediaFilename;
        private System.Windows.Forms.TextBox MediaExtensionTextBox;
        private System.Windows.Forms.Button MediaFilenameCopyButton;
        private System.Windows.Forms.Button NextEpisodeButton;
        private System.Windows.Forms.ListBox ExistingNFOListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ExtrasTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button PastePlotButton;
        private System.Windows.Forms.Button PasteSeriesNameButton;
        private System.Windows.Forms.Button PasteTitleButton;
        private System.Windows.Forms.Button EditNFOButton;
        private System.Windows.Forms.Button NewSeasonFolderButton;
        private System.Windows.Forms.Button NewExtrasFolderButton;
        private System.Windows.Forms.Button NewSeriesFolderButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label OriginalNFOFileName;
        private System.Windows.Forms.Button ClearOriginalButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.DataGridView tagGridView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView actorsGridView;
    }
}

