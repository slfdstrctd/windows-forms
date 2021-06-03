using System;

namespace txtedit2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file1 = new System.Windows.Forms.ToolStripMenuItem();
            this.new1 = new System.Windows.Forms.ToolStripMenuItem();
            this.open1 = new System.Windows.Forms.ToolStripMenuItem();
            this.save1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exit1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edit1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cut1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copy1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paste1 = new System.Windows.Forms.ToolStripMenuItem();
            this.delete1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAll1 = new System.Windows.Forms.ToolStripMenuItem();
            this.format1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bold1 = new System.Windows.Forms.ToolStripMenuItem();
            this.italic1 = new System.Windows.Forms.ToolStripMenuItem();
            this.underline1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.leftJustify1 = new System.Windows.Forms.ToolStripMenuItem();
            this.center1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rightJustify1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColor1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColor1 = new System.Windows.Forms.ToolStripMenuItem();
            this.font1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paragraph1 = new System.Windows.Forms.ToolStripMenuItem();
            this.view1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cut2 = new System.Windows.Forms.ToolStripMenuItem();
            this.copy2 = new System.Windows.Forms.ToolStripMenuItem();
            this.paste2 = new System.Windows.Forms.ToolStripMenuItem();
            this.font2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.new10 = new System.Windows.Forms.ToolStripButton();
            this.open10 = new System.Windows.Forms.ToolStripButton();
            this.save10 = new System.Windows.Forms.ToolStripButton();
            this.cut10 = new System.Windows.Forms.ToolStripButton();
            this.copy10 = new System.Windows.Forms.ToolStripButton();
            this.paste10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bold10 = new System.Windows.Forms.ToolStripButton();
            this.italic10 = new System.Windows.Forms.ToolStripButton();
            this.underline10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.leftJustify10 = new System.Windows.Forms.ToolStripButton();
            this.center10 = new System.Windows.Forms.ToolStripButton();
            this.rightJustify10 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cap1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.num1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.modified1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.position1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.hint1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.file1, this.edit1, this.format1, this.view1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MenuActivate += new System.EventHandler(this.new1_MouseLeave);
            this.menuStrip1.MenuDeactivate += new System.EventHandler(this.menuStrip1_MenuDeactivate);
            // 
            // file1
            // 
            this.file1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.new1, this.open1, this.save1, this.saveAs1, this.toolStripSeparator5, this.exit1});
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(44, 24);
            this.file1.Text = "File";
            // 
            // new1
            // 
            this.new1.Name = "new1";
            this.new1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.new1.Size = new System.Drawing.Size(167, 24);
            this.new1.Text = "New";
            this.new1.ToolTipText = "Создать новый документ";
            this.new1.Click += new System.EventHandler(this.new1_Click);
            this.new1.MouseEnter += new System.EventHandler(this.new1_MouseEnter);
            this.new1.MouseLeave += new System.EventHandler(this.new1_MouseLeave);
            // 
            // open1
            // 
            this.open1.Name = "open1";
            this.open1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open1.Size = new System.Drawing.Size(167, 24);
            this.open1.Text = "Open";
            this.open1.ToolTipText = "Открыть документ";
            this.open1.Click += new System.EventHandler(this.open1_Click);
            this.open1.MouseEnter += new System.EventHandler(this.new1_MouseEnter);
            this.open1.MouseLeave += new System.EventHandler(this.new1_MouseLeave);
            // 
            // save1
            // 
            this.save1.Name = "save1";
            this.save1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save1.Size = new System.Drawing.Size(167, 24);
            this.save1.Text = "Save";
            this.save1.ToolTipText = "Сохранить документ";
            this.save1.Click += new System.EventHandler(this.save1_Click);
            this.save1.MouseEnter += new System.EventHandler(this.new1_MouseEnter);
            this.save1.MouseLeave += new System.EventHandler(this.new1_MouseLeave);
            // 
            // saveAs1
            // 
            this.saveAs1.Name = "saveAs1";
            this.saveAs1.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.saveAs1.Size = new System.Drawing.Size(167, 24);
            this.saveAs1.Text = "Save as";
            this.saveAs1.ToolTipText = "Сохранить под новым именем";
            this.saveAs1.Click += new System.EventHandler(this.saveAs1_Click);
            this.saveAs1.MouseEnter += new System.EventHandler(this.new1_MouseEnter);
            this.saveAs1.MouseLeave += new System.EventHandler(this.new1_MouseLeave);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(164, 6);
            // 
            // exit1
            // 
            this.exit1.Name = "exit1";
            this.exit1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit1.Size = new System.Drawing.Size(167, 24);
            this.exit1.Text = "Exit";
            this.exit1.ToolTipText = "Выйти";
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
            this.exit1.MouseEnter += new System.EventHandler(this.new1_MouseEnter);
            this.exit1.MouseLeave += new System.EventHandler(this.new1_MouseLeave);
            // 
            // edit1
            // 
            this.edit1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.undo1, this.toolStripSeparator3, this.cut1, this.copy1, this.paste1, this.delete1, this.toolStripSeparator4, this.selectAll1});
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(47, 24);
            this.edit1.Text = "Edit";
            this.edit1.DropDownOpening += new System.EventHandler(this.edit1_Click);
            // 
            // undo1
            // 
            this.undo1.Name = "undo1";
            this.undo1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undo1.Size = new System.Drawing.Size(192, 24);
            this.undo1.Text = "Undo";
            this.undo1.Click += new System.EventHandler(this.undo1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(189, 6);
            // 
            // cut1
            // 
            this.cut1.Name = "cut1";
            this.cut1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cut1.Size = new System.Drawing.Size(192, 24);
            this.cut1.Text = "Cut";
            this.cut1.Click += new System.EventHandler(this.cut1_Click);
            // 
            // copy1
            // 
            this.copy1.Name = "copy1";
            this.copy1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy1.Size = new System.Drawing.Size(192, 24);
            this.copy1.Text = "Copy";
            this.copy1.Click += new System.EventHandler(this.copy1_Click);
            // 
            // paste1
            // 
            this.paste1.Name = "paste1";
            this.paste1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste1.Size = new System.Drawing.Size(192, 24);
            this.paste1.Text = "Paste";
            this.paste1.Click += new System.EventHandler(this.paste1_Click);
            // 
            // delete1
            // 
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(192, 24);
            this.delete1.Text = "Delete";
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(189, 6);
            // 
            // selectAll1
            // 
            this.selectAll1.Name = "selectAll1";
            this.selectAll1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAll1.Size = new System.Drawing.Size(192, 24);
            this.selectAll1.Text = "Select All";
            this.selectAll1.Click += new System.EventHandler(this.selectAll1_Click);
            // 
            // format1
            // 
            this.format1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.bold1, this.italic1, this.underline1, this.toolStripSeparator1, this.leftJustify1, this.center1, this.rightJustify1, this.toolStripSeparator2, this.colorsToolStripMenuItem, this.font1, this.paragraph1});
            this.format1.Name = "format1";
            this.format1.Size = new System.Drawing.Size(68, 24);
            this.format1.Text = "Format";
            // 
            // bold1
            // 
            this.bold1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bold1.Name = "bold1";
            this.bold1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bold1.Size = new System.Drawing.Size(207, 24);
            this.bold1.Text = "Bold";
            this.bold1.Click += new System.EventHandler(this.bold1_Click);
            // 
            // italic1
            // 
            this.italic1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.italic1.Name = "italic1";
            this.italic1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italic1.Size = new System.Drawing.Size(207, 24);
            this.italic1.Text = "Italic";
            this.italic1.Click += new System.EventHandler(this.bold1_Click);
            // 
            // underline1
            // 
            this.underline1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.underline1.Name = "underline1";
            this.underline1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underline1.Size = new System.Drawing.Size(207, 24);
            this.underline1.Text = "Underline";
            this.underline1.Click += new System.EventHandler(this.bold1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // leftJustify1
            // 
            this.leftJustify1.Checked = true;
            this.leftJustify1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.leftJustify1.Name = "leftJustify1";
            this.leftJustify1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.leftJustify1.Size = new System.Drawing.Size(207, 24);
            this.leftJustify1.Text = "Left justify";
            this.leftJustify1.Click += new System.EventHandler(this.leftJustify1_Click);
            // 
            // center1
            // 
            this.center1.Name = "center1";
            this.center1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.center1.Size = new System.Drawing.Size(207, 24);
            this.center1.Text = "Center";
            this.center1.Click += new System.EventHandler(this.leftJustify1_Click);
            // 
            // rightJustify1
            // 
            this.rightJustify1.Name = "rightJustify1";
            this.rightJustify1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rightJustify1.Size = new System.Drawing.Size(207, 24);
            this.rightJustify1.Text = "Right justify";
            this.rightJustify1.Click += new System.EventHandler(this.leftJustify1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fontColor1, this.backgroundColor1});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // fontColor1
            // 
            this.fontColor1.Name = "fontColor1";
            this.fontColor1.Size = new System.Drawing.Size(204, 24);
            this.fontColor1.Text = "Font color...";
            this.fontColor1.Click += new System.EventHandler(this.fontColor1_Click);
            // 
            // backgroundColor1
            // 
            this.backgroundColor1.Name = "backgroundColor1";
            this.backgroundColor1.Size = new System.Drawing.Size(204, 24);
            this.backgroundColor1.Text = "Background color...";
            this.backgroundColor1.Click += new System.EventHandler(this.backgroundColor1_Click);
            // 
            // font1
            // 
            this.font1.Name = "font1";
            this.font1.Size = new System.Drawing.Size(207, 24);
            this.font1.Text = "Font";
            this.font1.Click += new System.EventHandler(this.font1_Click);
            // 
            // paragraph1
            // 
            this.paragraph1.Name = "paragraph1";
            this.paragraph1.Size = new System.Drawing.Size(207, 24);
            this.paragraph1.Text = "Paragraph";
            this.paragraph1.Click += new System.EventHandler(this.paragraph1_Click);
            // 
            // view1
            // 
            this.view1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolBar1, this.statusBar1});
            this.view1.Name = "view1";
            this.view1.Size = new System.Drawing.Size(53, 24);
            this.view1.Text = "View";
            // 
            // toolBar1
            // 
            this.toolBar1.Checked = true;
            this.toolBar1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(140, 24);
            this.toolBar1.Text = "Toolbar";
            this.toolBar1.Click += new System.EventHandler(this.toolBar1_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Checked = true;
            this.statusBar1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(140, 24);
            this.statusBar1.Text = "Statusbar";
            this.statusBar1.Click += new System.EventHandler(this.statusBar1_Click);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.EnableAutoDragDrop = true;
            this.textBox1.Location = new System.Drawing.Point(0, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 370);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "";
            this.textBox1.SelectionChanged += new System.EventHandler(this.textBox1_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.cut2, this.copy2, this.paste2, this.font2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 100);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cut2
            // 
            this.cut2.Name = "cut2";
            this.cut2.Size = new System.Drawing.Size(112, 24);
            this.cut2.Text = "Cut";
            this.cut2.Click += new System.EventHandler(this.cut1_Click);
            // 
            // copy2
            // 
            this.copy2.Name = "copy2";
            this.copy2.Size = new System.Drawing.Size(112, 24);
            this.copy2.Text = "Copy";
            this.copy2.Click += new System.EventHandler(this.cut1_Click);
            // 
            // paste2
            // 
            this.paste2.Name = "paste2";
            this.paste2.Size = new System.Drawing.Size(112, 24);
            this.paste2.Text = "Paste";
            this.paste2.Click += new System.EventHandler(this.paste1_Click);
            // 
            // font2
            // 
            this.font2.Name = "font2";
            this.font2.Size = new System.Drawing.Size(112, 24);
            this.font2.Text = "Font";
            this.font2.Click += new System.EventHandler(this.font1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "rtf";
            this.saveFileDialog1.Filter = "RTF files|*.rtf|Text files|*.txt|All files|*.*";
            this.saveFileDialog1.Title = "Сохранение файла";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "rtf";
            this.openFileDialog1.Filter = "RTF files|*.rtf|Text files|*.txt|All files|*.*";
            this.openFileDialog1.Title = "Открытие файла";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.new10, this.open10, this.save10, this.cut10, this.copy10, this.paste10, this.toolStripSeparator6, this.bold10, this.italic10, this.underline10, this.toolStripSeparator7, this.leftJustify10, this.center10, this.rightJustify10});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // new10
            // 
            this.new10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.new10.Image = ((System.Drawing.Image) (resources.GetObject("new10.Image")));
            this.new10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.new10.Name = "new10";
            this.new10.Size = new System.Drawing.Size(23, 24);
            this.new10.Text = "toolStripButton1";
            this.new10.ToolTipText = "New";
            this.new10.Click += new System.EventHandler(this.new1_Click);
            // 
            // open10
            // 
            this.open10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.open10.Image = ((System.Drawing.Image) (resources.GetObject("open10.Image")));
            this.open10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open10.Name = "open10";
            this.open10.Size = new System.Drawing.Size(23, 24);
            this.open10.Text = "toolStripButton1";
            this.open10.ToolTipText = "Open";
            this.open10.Click += new System.EventHandler(this.open1_Click);
            // 
            // save10
            // 
            this.save10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save10.Image = ((System.Drawing.Image) (resources.GetObject("save10.Image")));
            this.save10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save10.Name = "save10";
            this.save10.Size = new System.Drawing.Size(23, 24);
            this.save10.Text = "toolStripButton1";
            this.save10.ToolTipText = "Save";
            this.save10.Click += new System.EventHandler(this.save1_Click);
            // 
            // cut10
            // 
            this.cut10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cut10.Image = ((System.Drawing.Image) (resources.GetObject("cut10.Image")));
            this.cut10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cut10.Name = "cut10";
            this.cut10.Size = new System.Drawing.Size(23, 24);
            this.cut10.Text = "toolStripButton3";
            this.cut10.ToolTipText = "Cut";
            this.cut10.Click += new System.EventHandler(this.cut1_Click);
            // 
            // copy10
            // 
            this.copy10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copy10.Image = ((System.Drawing.Image) (resources.GetObject("copy10.Image")));
            this.copy10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copy10.Name = "copy10";
            this.copy10.Size = new System.Drawing.Size(23, 24);
            this.copy10.Text = "toolStripButton2";
            this.copy10.ToolTipText = "Copy";
            this.copy10.Click += new System.EventHandler(this.copy1_Click);
            // 
            // paste10
            // 
            this.paste10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paste10.Image = ((System.Drawing.Image) (resources.GetObject("paste10.Image")));
            this.paste10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paste10.Name = "paste10";
            this.paste10.Size = new System.Drawing.Size(23, 24);
            this.paste10.Text = "toolStripButton1";
            this.paste10.ToolTipText = "Paste";
            this.paste10.Click += new System.EventHandler(this.paste1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // bold10
            // 
            this.bold10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bold10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bold10.Image = ((System.Drawing.Image) (resources.GetObject("bold10.Image")));
            this.bold10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bold10.Name = "bold10";
            this.bold10.Size = new System.Drawing.Size(23, 24);
            this.bold10.Text = "B";
            this.bold10.ToolTipText = "Bold";
            this.bold10.Click += new System.EventHandler(this.bold10_Click);
            // 
            // italic10
            // 
            this.italic10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italic10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.italic10.Image = ((System.Drawing.Image) (resources.GetObject("italic10.Image")));
            this.italic10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italic10.Name = "italic10";
            this.italic10.Size = new System.Drawing.Size(23, 24);
            this.italic10.Text = "I";
            this.italic10.ToolTipText = "Italic";
            this.italic10.Click += new System.EventHandler(this.italic10_Click);
            // 
            // underline10
            // 
            this.underline10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underline10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.underline10.Image = ((System.Drawing.Image) (resources.GetObject("underline10.Image")));
            this.underline10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underline10.Name = "underline10";
            this.underline10.Size = new System.Drawing.Size(23, 24);
            this.underline10.Text = "U";
            this.underline10.ToolTipText = "Underline";
            this.underline10.Click += new System.EventHandler(this.underline10_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // leftJustify10
            // 
            this.leftJustify10.Checked = true;
            this.leftJustify10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftJustify10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.leftJustify10.Image = ((System.Drawing.Image) (resources.GetObject("leftJustify10.Image")));
            this.leftJustify10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftJustify10.Name = "leftJustify10";
            this.leftJustify10.Size = new System.Drawing.Size(23, 24);
            this.leftJustify10.Text = "<";
            this.leftJustify10.ToolTipText = "Left justify";
            this.leftJustify10.Click += new System.EventHandler(this.leftJustify10_Click);
            // 
            // center10
            // 
            this.center10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.center10.Image = ((System.Drawing.Image) (resources.GetObject("center10.Image")));
            this.center10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.center10.Name = "center10";
            this.center10.Size = new System.Drawing.Size(23, 24);
            this.center10.Text = "=";
            this.center10.ToolTipText = "Center";
            this.center10.Click += new System.EventHandler(this.center10_Click);
            // 
            // rightJustify10
            // 
            this.rightJustify10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rightJustify10.Image = ((System.Drawing.Image) (resources.GetObject("rightJustify10.Image")));
            this.rightJustify10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightJustify10.Name = "rightJustify10";
            this.rightJustify10.Size = new System.Drawing.Size(23, 24);
            this.rightJustify10.Text = ">";
            this.rightJustify10.ToolTipText = "Right justify";
            this.rightJustify10.Click += new System.EventHandler(this.rightJustify10_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.cap1, this.num1, this.modified1, this.position1, this.hint1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cap1
            // 
            this.cap1.AutoSize = false;
            this.cap1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides) ((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.cap1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.cap1.Name = "cap1";
            this.cap1.Size = new System.Drawing.Size(40, 20);
            this.cap1.Text = "CAP";
            // 
            // num1
            // 
            this.num1.AutoSize = false;
            this.num1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides) ((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.num1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(40, 20);
            this.num1.Text = "NUM";
            // 
            // modified1
            // 
            this.modified1.AutoSize = false;
            this.modified1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides) ((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.modified1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.modified1.Name = "modified1";
            this.modified1.Size = new System.Drawing.Size(70, 20);
            this.modified1.Text = "Modified";
            // 
            // position1
            // 
            this.position1.AutoSize = false;
            this.position1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides) ((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.position1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.position1.Name = "position1";
            this.position1.Size = new System.Drawing.Size(60, 20);
            this.position1.Text = "1 : 1";
            // 
            // hint1
            // 
            this.hint1.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.hint1.Name = "hint1";
            this.hint1.Size = new System.Drawing.Size(50, 20);
            this.hint1.Text = "Ready";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripStatusLabel position1;

        private System.Windows.Forms.ToolStripMenuItem paragraph1;

        private System.Windows.Forms.ToolStripMenuItem file1;

        private System.Windows.Forms.ToolStripMenuItem statusBar1;
        private System.Windows.Forms.ToolStripMenuItem toolBar1;
        private System.Windows.Forms.ToolStripMenuItem view1;

        private System.Windows.Forms.ToolStripStatusLabel hint1;
        private System.Windows.Forms.ToolStripStatusLabel modified1;
        private System.Windows.Forms.ToolStripStatusLabel num1;

        private System.Windows.Forms.ToolStripStatusLabel cap1;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.ToolStripButton rightJustify10;

        private System.Windows.Forms.ToolStripButton center10;

        private System.Windows.Forms.ToolStripButton leftJustify10;

        private System.Windows.Forms.ToolStripButton italic10;
        private System.Windows.Forms.ToolStripButton underline10;

        private System.Windows.Forms.ToolStripButton bold10;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

        private System.Windows.Forms.ToolStripButton copy10;
        private System.Windows.Forms.ToolStripButton cut10;
        private System.Windows.Forms.ToolStripButton new10;
        private System.Windows.Forms.ToolStripButton paste10;
        private System.Windows.Forms.ToolStripButton save10;

        private System.Windows.Forms.ToolStripButton open10;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.ToolStripMenuItem copy2;
        private System.Windows.Forms.ToolStripMenuItem cut2;
        private System.Windows.Forms.ToolStripMenuItem font2;
        private System.Windows.Forms.ToolStripMenuItem paste2;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        private System.Windows.Forms.ToolStripMenuItem delete1;
        private System.Windows.Forms.ToolStripMenuItem selectAll1;

        private System.Windows.Forms.ToolStripMenuItem paste1;

        private System.Windows.Forms.ToolStripMenuItem copy1;

        private System.Windows.Forms.ToolStripMenuItem cut1;

        private System.Windows.Forms.ToolStripMenuItem undo1;

        private System.Windows.Forms.ToolStripMenuItem edit1;

        private System.Windows.Forms.ToolStripMenuItem font1;
        private System.Windows.Forms.FontDialog fontDialog1;

        private System.Windows.Forms.ToolStripMenuItem backgroundColor1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem fontColor1;

        private System.Windows.Forms.ToolStripMenuItem center1;
        private System.Windows.Forms.ToolStripMenuItem leftJustify1;
        private System.Windows.Forms.ToolStripMenuItem rightJustify1;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripMenuItem bold1;
        private System.Windows.Forms.ToolStripMenuItem italic1;
        private System.Windows.Forms.ToolStripMenuItem underline1;

        private System.Windows.Forms.ToolStripMenuItem format1;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private System.Windows.Forms.ToolStripMenuItem exit1;

        private System.Windows.Forms.ToolStripMenuItem saveAs1;

        private System.Windows.Forms.ToolStripMenuItem save1;

        private System.Windows.Forms.ToolStripMenuItem new1;
        private System.Windows.Forms.ToolStripMenuItem open1;

        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox textBox1;

        #endregion
    }
}