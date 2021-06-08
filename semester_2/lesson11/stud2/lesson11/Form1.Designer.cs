
namespace lesson11
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file1 = new System.Windows.Forms.ToolStripMenuItem();
            this.new1 = new System.Windows.Forms.ToolStripMenuItem();
            this.open1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.subject1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.avrLevel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id2 = new System.Windows.Forms.ToolStripMenuItem();
            this.surname2 = new System.Windows.Forms.ToolStripMenuItem();
            this.course2 = new System.Windows.Forms.ToolStripMenuItem();
            this.avrLevel2 = new System.Windows.Forms.ToolStripMenuItem();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.birthDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.group1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.scholarship1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.find1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1,
            this.surname1,
            this.gender1,
            this.birthDate1,
            this.course1,
            this.group1,
            this.scholarship1,
            this.avrLevel1});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "studXml";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Student data files|*.studXml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "studXml";
            this.saveFileDialog1.Filter = "Student data files|*.studXml";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file1,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file1
            // 
            this.file1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new1,
            this.open1,
            this.saveAs1});
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(46, 24);
            this.file1.Text = "File";
            this.file1.DropDownOpening += new System.EventHandler(this.file1_DropDownOpening);
            // 
            // new1
            // 
            this.new1.Name = "new1";
            this.new1.Size = new System.Drawing.Size(141, 26);
            this.new1.Text = "New";
            this.new1.Click += new System.EventHandler(this.new1_Click);
            // 
            // open1
            // 
            this.open1.Name = "open1";
            this.open1.Size = new System.Drawing.Size(141, 26);
            this.open1.Text = "Open";
            this.open1.Click += new System.EventHandler(this.open1_Click);
            // 
            // saveAs1
            // 
            this.saveAs1.Name = "saveAs1";
            this.saveAs1.Size = new System.Drawing.Size(141, 26);
            this.saveAs1.Text = "Save as";
            this.saveAs1.Click += new System.EventHandler(this.saveAs1_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 423);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 27);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 395);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оценки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject1,
            this.level1});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(786, 337);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView2_CurrentCellDirtyStateChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // subject1
            // 
            this.subject1.DataPropertyName = "Subject";
            this.subject1.FillWeight = 300F;
            this.subject1.HeaderText = "Предмет";
            this.subject1.MinimumWidth = 6;
            this.subject1.Name = "subject1";
            // 
            // level1
            // 
            this.level1.DataPropertyName = "Level";
            this.level1.HeaderText = "Оценка";
            this.level1.MinimumWidth = 6;
            this.level1.Name = "level1";
            this.level1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.level1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // avrLevel1
            // 
            this.avrLevel1.HeaderText = "Средний балл";
            this.avrLevel1.MinimumWidth = 6;
            this.avrLevel1.Name = "avrLevel1";
            this.avrLevel1.ReadOnly = true;
            this.avrLevel1.Width = 125;
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByToolStripMenuItem,
            this.find1});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.id2,
            this.surname2,
            this.course2,
            this.avrLevel2});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sortByToolStripMenuItem.Text = "Sort by...";
            // 
            // id2
            // 
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(224, 26);
            this.id2.Text = "Id";
            this.id2.Click += new System.EventHandler(this.id2_Click);
            // 
            // surname2
            // 
            this.surname2.Name = "surname2";
            this.surname2.Size = new System.Drawing.Size(224, 26);
            this.surname2.Text = "Surname";
            this.surname2.Click += new System.EventHandler(this.id2_Click);
            // 
            // course2
            // 
            this.course2.Name = "course2";
            this.course2.Size = new System.Drawing.Size(224, 26);
            this.course2.Text = "Course+Group";
            this.course2.Click += new System.EventHandler(this.id2_Click);
            // 
            // avrLevel2
            // 
            this.avrLevel2.Name = "avrLevel2";
            this.avrLevel2.Size = new System.Drawing.Size(224, 26);
            this.avrLevel2.Text = "Average Level";
            this.avrLevel2.Click += new System.EventHandler(this.id2_Click);
            // 
            // id1
            // 
            this.id1.DataPropertyName = "Id";
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            this.id1.DefaultCellStyle = dataGridViewCellStyle2;
            this.id1.HeaderText = "№";
            this.id1.MinimumWidth = 6;
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            this.id1.Width = 125;
            // 
            // surname1
            // 
            this.surname1.DataPropertyName = "Surname";
            this.surname1.FillWeight = 300F;
            this.surname1.HeaderText = "Фамилия";
            this.surname1.MinimumWidth = 6;
            this.surname1.Name = "surname1";
            this.surname1.Width = 125;
            // 
            // gender1
            // 
            this.gender1.DataPropertyName = "Gender";
            this.gender1.HeaderText = "Пол";
            this.gender1.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.gender1.MinimumWidth = 6;
            this.gender1.Name = "gender1";
            this.gender1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gender1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gender1.Width = 125;
            // 
            // birthDate1
            // 
            this.birthDate1.DataPropertyName = "BirthDate";
            this.birthDate1.FillWeight = 150F;
            this.birthDate1.HeaderText = "Дата рождения";
            this.birthDate1.MinimumWidth = 6;
            this.birthDate1.Name = "birthDate1";
            this.birthDate1.Width = 125;
            // 
            // course1
            // 
            this.course1.DataPropertyName = "Course";
            this.course1.HeaderText = "Курс";
            this.course1.MinimumWidth = 6;
            this.course1.Name = "course1";
            this.course1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.course1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.course1.Width = 125;
            // 
            // group1
            // 
            this.group1.DataPropertyName = "Group";
            this.group1.HeaderText = "Группа";
            this.group1.MinimumWidth = 6;
            this.group1.Name = "group1";
            this.group1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.group1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.group1.Width = 125;
            // 
            // scholarship1
            // 
            this.scholarship1.DataPropertyName = "Scholarship";
            this.scholarship1.HeaderText = "Стипендия";
            this.scholarship1.MinimumWidth = 6;
            this.scholarship1.Name = "scholarship1";
            this.scholarship1.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(lesson11.Student);
            // 
            // find1
            // 
            this.find1.Name = "find1";
            this.find1.Size = new System.Drawing.Size(224, 26);
            this.find1.Text = "Find...";
            this.find1.Click += new System.EventHandler(this.find1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bindingNavigator1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file1;
        private System.Windows.Forms.ToolStripMenuItem new1;
        private System.Windows.Forms.ToolStripMenuItem open1;
        private System.Windows.Forms.ToolStripMenuItem saveAs1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname1;
        private System.Windows.Forms.DataGridViewComboBoxColumn gender1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate1;
        private System.Windows.Forms.DataGridViewComboBoxColumn course1;
        private System.Windows.Forms.DataGridViewComboBoxColumn group1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn scholarship1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject1;
        private System.Windows.Forms.DataGridViewComboBoxColumn level1;
        private System.Windows.Forms.DataGridViewTextBoxColumn avrLevel1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem id2;
        private System.Windows.Forms.ToolStripMenuItem surname2;
        private System.Windows.Forms.ToolStripMenuItem course2;
        private System.Windows.Forms.ToolStripMenuItem avrLevel2;
        private System.Windows.Forms.ToolStripMenuItem find1;
    }
}

