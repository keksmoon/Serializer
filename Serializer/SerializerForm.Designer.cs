
namespace Serializer {
    partial class serializerForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serializerForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoBoard = new System.Windows.Forms.StatusStrip();
            this.cntFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.cntFilesInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.cntFolders = new System.Windows.Forms.ToolStripStatusLabel();
            this.cntFoldersInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.infoDirectoryTextBox = new System.Windows.Forms.ListBox();
            this.menu.SuspendLayout();
            this.infoBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(840, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.binaryToolStripMenuItem.Text = "Binary";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem1,
            this.deserializeToolStripMenuItem1});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // serializeToolStripMenuItem1
            // 
            this.serializeToolStripMenuItem1.Name = "serializeToolStripMenuItem1";
            this.serializeToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.serializeToolStripMenuItem1.Text = "Serialize";
            this.serializeToolStripMenuItem1.Click += new System.EventHandler(this.serializeToolStripMenuItem1_Click);
            // 
            // deserializeToolStripMenuItem1
            // 
            this.deserializeToolStripMenuItem1.Name = "deserializeToolStripMenuItem1";
            this.deserializeToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.deserializeToolStripMenuItem1.Text = "Deserialize";
            this.deserializeToolStripMenuItem1.Click += new System.EventHandler(this.deserializeToolStripMenuItem1_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem2,
            this.deserializeToolStripMenuItem2});
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.jSONToolStripMenuItem.Text = "JSON";
            // 
            // serializeToolStripMenuItem2
            // 
            this.serializeToolStripMenuItem2.Name = "serializeToolStripMenuItem2";
            this.serializeToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.serializeToolStripMenuItem2.Text = "Serialize";
            this.serializeToolStripMenuItem2.Click += new System.EventHandler(this.serializeToolStripMenuItem2_Click);
            // 
            // deserializeToolStripMenuItem2
            // 
            this.deserializeToolStripMenuItem2.Name = "deserializeToolStripMenuItem2";
            this.deserializeToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.deserializeToolStripMenuItem2.Text = "Deserialize";
            this.deserializeToolStripMenuItem2.Click += new System.EventHandler(this.deserializeToolStripMenuItem2_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.textColorToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.colorToolStripMenuItem.Text = "Back color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.textColorToolStripMenuItem.Text = "Text color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.textColorToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // infoBoard
            // 
            this.infoBoard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntFiles,
            this.cntFilesInfo,
            this.cntFolders,
            this.cntFoldersInfo,
            this.progress});
            this.infoBoard.Location = new System.Drawing.Point(0, 520);
            this.infoBoard.Name = "infoBoard";
            this.infoBoard.Size = new System.Drawing.Size(840, 22);
            this.infoBoard.TabIndex = 2;
            // 
            // cntFiles
            // 
            this.cntFiles.Name = "cntFiles";
            this.cntFiles.Size = new System.Drawing.Size(120, 17);
            this.cntFiles.Text = "Количество файлов:";
            // 
            // cntFilesInfo
            // 
            this.cntFilesInfo.Name = "cntFilesInfo";
            this.cntFilesInfo.Size = new System.Drawing.Size(13, 17);
            this.cntFilesInfo.Text = "0";
            // 
            // cntFolders
            // 
            this.cntFolders.Name = "cntFolders";
            this.cntFolders.Size = new System.Drawing.Size(111, 17);
            this.cntFolders.Text = "Количество папок:";
            // 
            // cntFoldersInfo
            // 
            this.cntFoldersInfo.Name = "cntFoldersInfo";
            this.cntFoldersInfo.Size = new System.Drawing.Size(13, 17);
            this.cntFoldersInfo.Text = "0";
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progress.Size = new System.Drawing.Size(300, 16);
            this.progress.Tag = "";
            // 
            // infoDirectoryTextBox
            // 
            this.infoDirectoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoDirectoryTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoDirectoryTextBox.FormattingEnabled = true;
            this.infoDirectoryTextBox.HorizontalScrollbar = true;
            this.infoDirectoryTextBox.ItemHeight = 18;
            this.infoDirectoryTextBox.Location = new System.Drawing.Point(0, 24);
            this.infoDirectoryTextBox.Name = "infoDirectoryTextBox";
            this.infoDirectoryTextBox.ScrollAlwaysVisible = true;
            this.infoDirectoryTextBox.Size = new System.Drawing.Size(840, 496);
            this.infoDirectoryTextBox.TabIndex = 4;
            // 
            // serializerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 542);
            this.Controls.Add(this.infoDirectoryTextBox);
            this.Controls.Add(this.infoBoard);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "serializerForm";
            this.Text = "Serializer";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.infoBoard.ResumeLayout(false);
            this.infoBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private System.Windows.Forms.StatusStrip infoBoard;
        private System.Windows.Forms.ToolStripStatusLabel cntFiles;
        private System.Windows.Forms.ToolStripStatusLabel cntFilesInfo;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel cntFolders;
        private System.Windows.Forms.ToolStripStatusLabel cntFoldersInfo;
        private System.Windows.Forms.ListBox infoDirectoryTextBox;
        private System.Windows.Forms.ToolStripProgressBar progress;
    }
}

