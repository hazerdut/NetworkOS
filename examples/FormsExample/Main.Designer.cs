namespace Demo
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelMousePosition = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.tb_New = new System.Windows.Forms.ToolStripButton();
            this.tb_Open = new System.Windows.Forms.ToolStripButton();
            this.tb_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Cut = new System.Windows.Forms.ToolStripButton();
            this.tb_Copy = new System.Windows.Forms.ToolStripButton();
            this.tb_Paste = new System.Windows.Forms.ToolStripButton();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mM_File = new System.Windows.Forms.ToolStripMenuItem();
            this.file_New = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.file_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.file_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mM_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mM_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.tools_Customise = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_go = new System.Windows.Forms.Button();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_ZoomFactor = new System.Windows.Forms.ToolStripStatusLabel();
            this.openWork = new System.Windows.Forms.OpenFileDialog();
            this.saveWork = new System.Windows.Forms.SaveFileDialog();
            this.rcMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rc_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.rc_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlweb = new System.Windows.Forms.Panel();
            this.Document = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.Tools.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.rcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMousePosition.AutoSize = true;
            this.labelMousePosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMousePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMousePosition.Location = new System.Drawing.Point(136, 14);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(125, 13);
            this.labelMousePosition.TabIndex = 2;
            this.labelMousePosition.Text = "x={0:####}; y={1:####}";
            this.labelMousePosition.Click += new System.EventHandler(this.labelMousePosition_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.labelMousePosition);
            this.groupBox2.Controls.Add(this.clearLogButton);
            this.groupBox2.Controls.Add(this.Tools);
            this.groupBox2.Controls.Add(this.textBoxLog);
            this.groupBox2.Controls.Add(this.mainMenu);
            this.groupBox2.Controls.Add(this.txt_url);
            this.groupBox2.Controls.Add(this.btn_go);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, -6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1347, 68);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(1050, 15);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogButton.TabIndex = 16;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // Tools
            // 
            this.Tools.Dock = System.Windows.Forms.DockStyle.None;
            this.Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_New,
            this.tb_Open,
            this.tb_Save,
            this.toolStripSeparator,
            this.tb_Cut,
            this.tb_Copy,
            this.tb_Paste});
            this.Tools.Location = new System.Drawing.Point(9, 36);
            this.Tools.Name = "Tools";
            this.Tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Tools.Size = new System.Drawing.Size(147, 25);
            this.Tools.TabIndex = 1;
            this.Tools.Text = "toolStrip1";
            // 
            // tb_New
            // 
            this.tb_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_New.Image = ((System.Drawing.Image)(resources.GetObject("tb_New.Image")));
            this.tb_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_New.Name = "tb_New";
            this.tb_New.Size = new System.Drawing.Size(23, 22);
            this.tb_New.Text = "&New";
            this.tb_New.Click += new System.EventHandler(this.tb_New_Click);
            // 
            // tb_Open
            // 
            this.tb_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Open.Image = ((System.Drawing.Image)(resources.GetObject("tb_Open.Image")));
            this.tb_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Open.Name = "tb_Open";
            this.tb_Open.Size = new System.Drawing.Size(23, 22);
            this.tb_Open.Text = "&Open";
            this.tb_Open.Click += new System.EventHandler(this.tb_Open_Click_1);
            // 
            // tb_Save
            // 
            this.tb_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Save.Image = ((System.Drawing.Image)(resources.GetObject("tb_Save.Image")));
            this.tb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Save.Name = "tb_Save";
            this.tb_Save.Size = new System.Drawing.Size(23, 22);
            this.tb_Save.Text = "&Save";
            this.tb_Save.Click += new System.EventHandler(this.tb_Save_Click_1);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Cut
            // 
            this.tb_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Cut.Image = ((System.Drawing.Image)(resources.GetObject("tb_Cut.Image")));
            this.tb_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Cut.Name = "tb_Cut";
            this.tb_Cut.Size = new System.Drawing.Size(23, 22);
            this.tb_Cut.Text = "C&ut";
            this.tb_Cut.Click += new System.EventHandler(this.tb_Cut_Click_1);
            // 
            // tb_Copy
            // 
            this.tb_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Copy.Image = ((System.Drawing.Image)(resources.GetObject("tb_Copy.Image")));
            this.tb_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Copy.Name = "tb_Copy";
            this.tb_Copy.Size = new System.Drawing.Size(23, 22);
            this.tb_Copy.Text = "&Copy";
            this.tb_Copy.Click += new System.EventHandler(this.tb_Copy_Click_1);
            // 
            // tb_Paste
            // 
            this.tb_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Paste.Image = ((System.Drawing.Image)(resources.GetObject("tb_Paste.Image")));
            this.tb_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Paste.Name = "tb_Paste";
            this.tb_Paste.Size = new System.Drawing.Size(23, 22);
            this.tb_Paste.Text = "&Paste";
            this.tb_Paste.Click += new System.EventHandler(this.tb_Paste_Click_1);
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.White;
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog.Location = new System.Drawing.Point(324, 15);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(720, 20);
            this.textBoxLog.TabIndex = 17;
            this.textBoxLog.WordWrap = false;
            this.textBoxLog.TextChanged += new System.EventHandler(this.textBoxLog_TextChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mM_File,
            this.mM_Edit,
            this.mM_Tools});
            this.mainMenu.Location = new System.Drawing.Point(2, 8);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(131, 24);
            this.mainMenu.TabIndex = 18;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mM_File
            // 
            this.mM_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_New,
            this.file_Open,
            this.toolStripSeparator11,
            this.file_Save,
            this.toolStripSeparator13,
            this.file_Exit});
            this.mM_File.Name = "mM_File";
            this.mM_File.Size = new System.Drawing.Size(37, 20);
            this.mM_File.Text = "&File";
            this.mM_File.Click += new System.EventHandler(this.mM_File_Click);
            // 
            // file_New
            // 
            this.file_New.Image = ((System.Drawing.Image)(resources.GetObject("file_New.Image")));
            this.file_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_New.Name = "file_New";
            this.file_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.file_New.Size = new System.Drawing.Size(146, 22);
            this.file_New.Text = "&New";
            // 
            // file_Open
            // 
            this.file_Open.Image = ((System.Drawing.Image)(resources.GetObject("file_Open.Image")));
            this.file_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_Open.Name = "file_Open";
            this.file_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.file_Open.Size = new System.Drawing.Size(146, 22);
            this.file_Open.Text = "&Open";
            this.file_Open.Click += new System.EventHandler(this.file_Open_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(143, 6);
            // 
            // file_Save
            // 
            this.file_Save.Image = ((System.Drawing.Image)(resources.GetObject("file_Save.Image")));
            this.file_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_Save.Name = "file_Save";
            this.file_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.file_Save.Size = new System.Drawing.Size(146, 22);
            this.file_Save.Text = "&Save";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(143, 6);
            // 
            // file_Exit
            // 
            this.file_Exit.Name = "file_Exit";
            this.file_Exit.Size = new System.Drawing.Size(146, 22);
            this.file_Exit.Text = "E&xit";
            // 
            // mM_Edit
            // 
            this.mM_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_Undo,
            this.edit_Redo,
            this.toolStripSeparator14,
            this.edit_Cut,
            this.edit_Copy,
            this.edit_Paste,
            this.toolStripSeparator15,
            this.edit_SelectAll});
            this.mM_Edit.Name = "mM_Edit";
            this.mM_Edit.Size = new System.Drawing.Size(39, 20);
            this.mM_Edit.Text = "&Edit";
            // 
            // edit_Undo
            // 
            this.edit_Undo.Name = "edit_Undo";
            this.edit_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.edit_Undo.Size = new System.Drawing.Size(144, 22);
            this.edit_Undo.Text = "&Undo";
            // 
            // edit_Redo
            // 
            this.edit_Redo.Name = "edit_Redo";
            this.edit_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.edit_Redo.Size = new System.Drawing.Size(144, 22);
            this.edit_Redo.Text = "&Redo";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(141, 6);
            // 
            // edit_Cut
            // 
            this.edit_Cut.Image = ((System.Drawing.Image)(resources.GetObject("edit_Cut.Image")));
            this.edit_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Cut.Name = "edit_Cut";
            this.edit_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.edit_Cut.Size = new System.Drawing.Size(144, 22);
            this.edit_Cut.Text = "Cu&t";
            // 
            // edit_Copy
            // 
            this.edit_Copy.Image = ((System.Drawing.Image)(resources.GetObject("edit_Copy.Image")));
            this.edit_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Copy.Name = "edit_Copy";
            this.edit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.edit_Copy.Size = new System.Drawing.Size(144, 22);
            this.edit_Copy.Text = "&Copy";
            // 
            // edit_Paste
            // 
            this.edit_Paste.Image = ((System.Drawing.Image)(resources.GetObject("edit_Paste.Image")));
            this.edit_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Paste.Name = "edit_Paste";
            this.edit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.edit_Paste.Size = new System.Drawing.Size(144, 22);
            this.edit_Paste.Text = "&Paste";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(141, 6);
            // 
            // edit_SelectAll
            // 
            this.edit_SelectAll.Name = "edit_SelectAll";
            this.edit_SelectAll.Size = new System.Drawing.Size(144, 22);
            this.edit_SelectAll.Text = "Select &All";
            // 
            // mM_Tools
            // 
            this.mM_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools_Customise});
            this.mM_Tools.Name = "mM_Tools";
            this.mM_Tools.Size = new System.Drawing.Size(47, 20);
            this.mM_Tools.Text = "&Tools";
            // 
            // tools_Customise
            // 
            this.tools_Customise.Name = "tools_Customise";
            this.tools_Customise.Size = new System.Drawing.Size(130, 22);
            this.tools_Customise.Text = "&Customize";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(541, 48);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(584, 20);
            this.txt_url.TabIndex = 11;
            // 
            // btn_go
            // 
            this.btn_go.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_go.Location = new System.Drawing.Point(486, 45);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(46, 23);
            this.btn_go.TabIndex = 10;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(928, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // status_ZoomFactor
            // 
            this.status_ZoomFactor.Name = "status_ZoomFactor";
            this.status_ZoomFactor.Size = new System.Drawing.Size(23, 23);
            // 
            // openWork
            // 
            this.openWork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.openWork.Title = "Open Work";
            // 
            // saveWork
            // 
            this.saveWork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.saveWork.Title = "Save Work";
            // 
            // rcMenu
            // 
            this.rcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rc_Undo});
            this.rcMenu.Name = "rcMenu";
            this.rcMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // rc_Undo
            // 
            this.rc_Undo.Name = "rc_Undo";
            this.rc_Undo.Size = new System.Drawing.Size(103, 22);
            this.rc_Undo.Text = "Undo";
            this.rc_Undo.Click += new System.EventHandler(this.rc_Undo_Click);
            // 
            // rc_Redo
            // 
            this.rc_Redo.Name = "rc_Redo";
            this.rc_Redo.Size = new System.Drawing.Size(103, 22);
            this.rc_Redo.Text = "Redo";
            this.rc_Redo.Click += new System.EventHandler(this.rc_Redo_Click);
            // 
            // rc_Cut
            // 
            this.rc_Cut.Name = "rc_Cut";
            this.rc_Cut.Size = new System.Drawing.Size(103, 22);
            this.rc_Cut.Text = "Cut";
            this.rc_Cut.Click += new System.EventHandler(this.rc_Cut_Click);
            // 
            // rc_Copy
            // 
            this.rc_Copy.Name = "rc_Copy";
            this.rc_Copy.Size = new System.Drawing.Size(103, 22);
            this.rc_Copy.Text = "Copy";
            this.rc_Copy.Click += new System.EventHandler(this.rc_Copy_Click);
            // 
            // rc_Paste
            // 
            this.rc_Paste.Name = "rc_Paste";
            this.rc_Paste.Size = new System.Drawing.Size(103, 22);
            this.rc_Paste.Text = "Paste";
            this.rc_Paste.Click += new System.EventHandler(this.rc_Paste_Click);
            // 
            // pnlweb
            // 
            this.pnlweb.Location = new System.Drawing.Point(541, 68);
            this.pnlweb.Name = "pnlweb";
            this.pnlweb.Size = new System.Drawing.Size(584, 505);
            this.pnlweb.TabIndex = 10;
            // 
            // Document
            // 
            this.Document.ContextMenuStrip = this.rcMenu;
            this.Document.Location = new System.Drawing.Point(2, 68);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(530, 505);
            this.Document.TabIndex = 3;
            this.Document.Text = "";
            this.Document.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Document_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 580);
            this.Controls.Add(this.Document);
            this.Controls.Add(this.pnlweb);
            this.Controls.Add(this.groupBox2);
            this.Name = "Main";
            this.Text = "Mouse and Keyboard Hooks Demo";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.rcMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;

        #endregion
        private System.Windows.Forms.Label labelMousePosition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Panel pnlweb;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.RichTextBox Document;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripButton tb_New;
        private System.Windows.Forms.ToolStripButton tb_Open;
        private System.Windows.Forms.ToolStripButton tb_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tb_Cut;
        private System.Windows.Forms.ToolStripButton tb_Copy;
        private System.Windows.Forms.ToolStripButton tb_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel charCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel status_ZoomFactor;
        private System.Windows.Forms.ContextMenuStrip rcMenu;
        private System.Windows.Forms.ToolStripMenuItem rc_Undo;
        private System.Windows.Forms.ToolStripMenuItem rc_Redo;
        private System.Windows.Forms.ToolStripMenuItem rc_Cut;
        private System.Windows.Forms.ToolStripMenuItem rc_Copy;
        private System.Windows.Forms.ToolStripMenuItem rc_Paste;
        private System.Windows.Forms.ToolStripMenuItem mM_Edit;
        private System.Windows.Forms.ToolStripMenuItem edit_Undo;
        private System.Windows.Forms.ToolStripMenuItem edit_Redo;
        private System.Windows.Forms.ToolStripMenuItem edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem edit_Paste;
        private System.Windows.Forms.ToolStripMenuItem edit_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem mM_Tools;
        private System.Windows.Forms.ToolStripMenuItem tools_Customise;
        private System.Windows.Forms.ToolStripMenuItem mM_File;
        private System.Windows.Forms.ToolStripMenuItem file_New;
        private System.Windows.Forms.ToolStripMenuItem file_Open;
        private System.Windows.Forms.ToolStripMenuItem file_Save;
        private System.Windows.Forms.ToolStripMenuItem file_Exit;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.OpenFileDialog openWork;
        private System.Windows.Forms.SaveFileDialog saveWork;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

