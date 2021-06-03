using System;

namespace txtedit1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cut2 = new System.Windows.Forms.ToolStripMenuItem();
            this.copy2 = new System.Windows.Forms.ToolStripMenuItem();
            this.paste2 = new System.Windows.Forms.ToolStripMenuItem();
            this.font2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItem1, this.edit1, this.format1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.new1, this.open1, this.save1, this.saveAs1, this.toolStripSeparator5, this.exit1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // new1
            // 
            this.new1.Name = "new1";
            this.new1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.new1.Size = new System.Drawing.Size(167, 24);
            this.new1.Text = "New";
            this.new1.Click += new System.EventHandler(this.new1_Click);
            // 
            // open1
            // 
            this.open1.Name = "open1";
            this.open1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open1.Size = new System.Drawing.Size(167, 24);
            this.open1.Text = "Open";
            this.open1.Click += new System.EventHandler(this.open1_Click);
            // 
            // save1
            // 
            this.save1.Name = "save1";
            this.save1.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save1.Size = new System.Drawing.Size(167, 24);
            this.save1.Text = "Save";
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // saveAs1
            // 
            this.saveAs1.Name = "saveAs1";
            this.saveAs1.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.saveAs1.Size = new System.Drawing.Size(167, 24);
            this.saveAs1.Text = "Save as";
            this.saveAs1.Click += new System.EventHandler(this.saveAs1_Click);
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
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
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
            this.format1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.bold1, this.italic1, this.underline1, this.toolStripSeparator1, this.leftJustify1, this.center1, this.rightJustify1, this.toolStripSeparator2, this.colorsToolStripMenuItem, this.font1});
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
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 422);
            this.textBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.cut2, this.copy2, this.paste2, this.font2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 122);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cut2
            // 
            this.cut2.Name = "cut2";
            this.cut2.Size = new System.Drawing.Size(152, 24);
            this.cut2.Text = "Cut";
            this.cut2.Click += new System.EventHandler(this.cut1_Click);
            // 
            // copy2
            // 
            this.copy2.Name = "copy2";
            this.copy2.Size = new System.Drawing.Size(152, 24);
            this.copy2.Text = "Copy";
            this.copy2.Click += new System.EventHandler(this.cut1_Click);
            // 
            // paste2
            // 
            this.paste2.Name = "paste2";
            this.paste2.Size = new System.Drawing.Size(152, 24);
            this.paste2.Text = "Paste";
            this.paste2.Click += new System.EventHandler(this.paste1_Click);
            // 
            // font2
            // 
            this.font2.Name = "font2";
            this.font2.Size = new System.Drawing.Size(152, 24);
            this.font2.Text = "Font";
            this.font2.Click += new System.EventHandler(this.font1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text files|*.txt";
            this.saveFileDialog1.Title = "Сохранение файла";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Text files|*.txt";
            this.openFileDialog1.Title = "Открытие файла";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}