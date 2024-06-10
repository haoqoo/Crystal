namespace LibraryViewer
{
    partial class LMain
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
            components = new System.ComponentModel.Container();
            MainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            ImageList = new ImageList(components);
            LibraryFolderDialog = new FolderBrowserDialog();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            ExportImagesButton = new Button();
            DebugBox = new TextBox();
            checkCenter = new CheckBox();
            checkBackground = new CheckBox();
            HeightLabel = new Label();
            LblHeight = new Label();
            LibNameLabel = new Label();
            LibCountLabel = new Label();
            WidthLabel = new Label();
            LblLibName = new Label();
            LblLibCount = new Label();
            LblWidth = new Label();
            ImageBox = new PictureBox();
            PreviewListView = new CustomFormControl.FixedListView();
            MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.ImageScalingSize = new Size(20, 20);
            MainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Padding = new Padding(9, 3, 0, 3);
            MainMenu.Size = new Size(1294, 30);
            MainMenu.TabIndex = 0;
            MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(70, 24);
            fileToolStripMenuItem.Text = "Folder";
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.Size = new Size(132, 26);
            openMenuItem.Text = "Open";
            openMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // ImageList
            // 
            ImageList.ColorDepth = ColorDepth.Depth32Bit;
            ImageList.ImageSize = new Size(64, 64);
            ImageList.TransparentColor = Color.Transparent;
            // 
            // LibraryFolderDialog
            // 
            LibraryFolderDialog.ShowNewFolderButton = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 30);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(PreviewListView);
            splitContainer1.Size = new Size(1294, 787);
            splitContainer1.SplitterDistance = 388;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4, 5, 4, 5);
            splitContainer2.MinimumSize = new Size(0, 308);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(ExportImagesButton);
            splitContainer2.Panel1.Controls.Add(DebugBox);
            splitContainer2.Panel1.Controls.Add(checkCenter);
            splitContainer2.Panel1.Controls.Add(checkBackground);
            splitContainer2.Panel1.Controls.Add(HeightLabel);
            splitContainer2.Panel1.Controls.Add(LblHeight);
            splitContainer2.Panel1.Controls.Add(LibNameLabel);
            splitContainer2.Panel1.Controls.Add(LibCountLabel);
            splitContainer2.Panel1.Controls.Add(WidthLabel);
            splitContainer2.Panel1.Controls.Add(LblLibName);
            splitContainer2.Panel1.Controls.Add(LblLibCount);
            splitContainer2.Panel1.Controls.Add(LblWidth);
            splitContainer2.Panel1MinSize = 150;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(ImageBox);
            splitContainer2.Panel2MinSize = 250;
            splitContainer2.Size = new Size(1294, 388);
            splitContainer2.SplitterDistance = 259;
            splitContainer2.SplitterWidth = 6;
            splitContainer2.TabIndex = 0;
            // 
            // ExportImagesButton
            // 
            ExportImagesButton.Location = new Point(18, 200);
            ExportImagesButton.Margin = new Padding(4, 5, 4, 5);
            ExportImagesButton.Name = "ExportImagesButton";
            ExportImagesButton.Size = new Size(126, 35);
            ExportImagesButton.TabIndex = 7;
            ExportImagesButton.Text = "Export Images";
            ExportImagesButton.UseVisualStyleBackColor = true;
            ExportImagesButton.Click += ExportImagesButton_Click;
            // 
            // DebugBox
            // 
            DebugBox.Location = new Point(4, 280);
            DebugBox.Margin = new Padding(4, 5, 4, 5);
            DebugBox.Multiline = true;
            DebugBox.Name = "DebugBox";
            DebugBox.ScrollBars = ScrollBars.Both;
            DebugBox.Size = new Size(250, 98);
            DebugBox.TabIndex = 6;
            DebugBox.Visible = false;
            // 
            // checkCenter
            // 
            checkCenter.AutoSize = true;
            checkCenter.Checked = true;
            checkCenter.CheckState = CheckState.Checked;
            checkCenter.Location = new Point(18, 163);
            checkCenter.Margin = new Padding(4, 5, 4, 5);
            checkCenter.Name = "checkCenter";
            checkCenter.Size = new Size(80, 24);
            checkCenter.TabIndex = 5;
            checkCenter.Text = "Center";
            checkCenter.UseVisualStyleBackColor = true;
            checkCenter.CheckedChanged += checkCenter_CheckedChanged;
            // 
            // checkBackground
            // 
            checkBackground.AutoSize = true;
            checkBackground.Checked = true;
            checkBackground.CheckState = CheckState.Checked;
            checkBackground.Location = new Point(18, 128);
            checkBackground.Margin = new Padding(4, 5, 4, 5);
            checkBackground.Name = "checkBackground";
            checkBackground.Size = new Size(118, 24);
            checkBackground.TabIndex = 4;
            checkBackground.Text = "Background";
            checkBackground.UseVisualStyleBackColor = true;
            checkBackground.CheckedChanged += checkBackground_CheckedChanged;
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(84, 89);
            HeightLabel.Margin = new Padding(4, 0, 4, 0);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(102, 20);
            HeightLabel.TabIndex = 3;
            HeightLabel.Text = "<No Image>";
            // 
            // LblHeight
            // 
            LblHeight.AutoSize = true;
            LblHeight.Location = new Point(18, 89);
            LblHeight.Margin = new Padding(4, 0, 4, 0);
            LblHeight.Name = "LblHeight";
            LblHeight.Size = new Size(63, 20);
            LblHeight.TabIndex = 2;
            LblHeight.Text = "Height:";
            // 
            // LibNameLabel
            // 
            LibNameLabel.AutoSize = true;
            LibNameLabel.Location = new Point(88, 37);
            LibNameLabel.Margin = new Padding(4, 0, 4, 0);
            LibNameLabel.Name = "LibNameLabel";
            LibNameLabel.Size = new Size(125, 20);
            LibNameLabel.TabIndex = 1;
            LibNameLabel.Text = "<No Selection>";
            // 
            // LibCountLabel
            // 
            LibCountLabel.AutoSize = true;
            LibCountLabel.Location = new Point(88, 14);
            LibCountLabel.Margin = new Padding(4, 0, 4, 0);
            LibCountLabel.Name = "LibCountLabel";
            LibCountLabel.Size = new Size(18, 20);
            LibCountLabel.TabIndex = 1;
            LibCountLabel.Text = "0";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(84, 69);
            WidthLabel.Margin = new Padding(4, 0, 4, 0);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(102, 20);
            WidthLabel.TabIndex = 1;
            WidthLabel.Text = "<No Image>";
            // 
            // LblLibName
            // 
            LblLibName.AutoSize = true;
            LblLibName.Location = new Point(18, 37);
            LblLibName.Margin = new Padding(4, 0, 4, 0);
            LblLibName.Name = "LblLibName";
            LblLibName.Size = new Size(57, 20);
            LblLibName.TabIndex = 0;
            LblLibName.Text = "Libfile:";
            // 
            // LblLibCount
            // 
            LblLibCount.AutoSize = true;
            LblLibCount.Location = new Point(18, 14);
            LblLibCount.Margin = new Padding(4, 0, 4, 0);
            LblLibCount.Name = "LblLibCount";
            LblLibCount.Size = new Size(77, 20);
            LblLibCount.TabIndex = 0;
            LblLibCount.Text = "Libcount:";
            // 
            // LblWidth
            // 
            LblWidth.AutoSize = true;
            LblWidth.Location = new Point(18, 69);
            LblWidth.Margin = new Padding(4, 0, 4, 0);
            LblWidth.Name = "LblWidth";
            LblWidth.Size = new Size(57, 20);
            LblWidth.TabIndex = 0;
            LblWidth.Text = "Width:";
            // 
            // ImageBox
            // 
            ImageBox.BackColor = Color.White;
            ImageBox.Dock = DockStyle.Fill;
            ImageBox.Location = new Point(0, 0);
            ImageBox.Margin = new Padding(4, 5, 4, 5);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(1029, 388);
            ImageBox.SizeMode = PictureBoxSizeMode.CenterImage;
            ImageBox.TabIndex = 0;
            ImageBox.TabStop = false;
            // 
            // PreviewListView
            // 
            PreviewListView.BackgroundImageTiled = true;
            PreviewListView.Dock = DockStyle.Fill;
            PreviewListView.LargeImageList = ImageList;
            PreviewListView.Location = new Point(0, 0);
            PreviewListView.Margin = new Padding(4, 5, 4, 5);
            PreviewListView.Name = "PreviewListView";
            PreviewListView.ShowItemToolTips = true;
            PreviewListView.Size = new Size(1294, 393);
            PreviewListView.TabIndex = 0;
            PreviewListView.UseCompatibleStateImageBehavior = false;
            PreviewListView.VirtualMode = true;
            PreviewListView.RetrieveVirtualItem += PreviewListView_RetrieveVirtualItem;
            PreviewListView.SelectedIndexChanged += PreviewListView_SelectedIndexChanged;
            // 
            // LMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 817);
            Controls.Add(splitContainer1);
            Controls.Add(MainMenu);
            MainMenuStrip = MainMenu;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LMain";
            Text = "C# Library Viewer";
            Load += LMain_Load;
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.FolderBrowserDialog LibraryFolderDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox checkCenter;
        private System.Windows.Forms.CheckBox checkBackground;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.Label LibCountLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LblLibCount;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.PictureBox ImageBox;
        private CustomFormControl.FixedListView PreviewListView;
        private System.Windows.Forms.Label LibNameLabel;
        private System.Windows.Forms.Label LblLibName;
        private System.Windows.Forms.TextBox DebugBox;
        private System.Windows.Forms.Button ExportImagesButton;
    }
}

