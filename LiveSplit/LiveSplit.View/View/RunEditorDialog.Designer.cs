﻿namespace LiveSplit.View
{
    partial class RunEditorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunEditorDialog));
            this.runGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGameName = new System.Windows.Forms.ComboBox();
            this.cbxRunCategory = new System.Windows.Forms.ComboBox();
            this.tbxTimeOffset = new System.Windows.Forms.TextBox();
            this.picGameIcon = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxAttempts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnAddComparison = new System.Windows.Forms.Button();
            this.btnImportComparison = new System.Windows.Forms.Button();
            this.RemoveIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadBoxartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromURLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iRunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSegmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImportComparisonMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSplitsioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.runGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGameIcon)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.RemoveIconMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iRunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSegmentBindingSource)).BeginInit();
            this.ImportComparisonMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // runGrid
            // 
            this.runGrid.AllowUserToAddRows = false;
            this.runGrid.AllowUserToResizeColumns = false;
            this.runGrid.AllowUserToResizeRows = false;
            this.runGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.runGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.runGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.runGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.runGrid, 10);
            this.runGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.runGrid.Location = new System.Drawing.Point(125, 175);
            this.runGrid.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.runGrid.Name = "runGrid";
            this.runGrid.RowHeadersVisible = false;
            this.runGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableLayoutPanel1.SetRowSpan(this.runGrid, 7);
            this.runGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.runGrid.Size = new System.Drawing.Size(549, 296);
            this.runGrid.TabIndex = 0;
            this.runGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.runGrid_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxGameName, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxRunCategory, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxTimeOffset, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.picGameIcon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.runGrid, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxAttempts, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 7, 13);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnActivate, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSettings, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnInsert, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnMoveUp, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnMoveDown, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnAddComparison, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnImportComparison, 0, 12);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 517);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(140, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(140, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Run Category:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(140, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start Timer at:";
            // 
            // cbxGameName
            // 
            this.cbxGameName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbxGameName, 5);
            this.cbxGameName.Location = new System.Drawing.Point(246, 12);
            this.cbxGameName.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.cbxGameName.Name = "cbxGameName";
            this.cbxGameName.Size = new System.Drawing.Size(427, 21);
            this.cbxGameName.TabIndex = 7;
            this.cbxGameName.TextChanged += new System.EventHandler(this.tbxGameName_TextChanged);
            // 
            // cbxRunCategory
            // 
            this.cbxRunCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbxRunCategory, 5);
            this.cbxRunCategory.Location = new System.Drawing.Point(246, 47);
            this.cbxRunCategory.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.cbxRunCategory.Name = "cbxRunCategory";
            this.cbxRunCategory.Size = new System.Drawing.Size(427, 21);
            this.cbxRunCategory.TabIndex = 8;
            this.cbxRunCategory.TextChanged += new System.EventHandler(this.tbxRunCategory_TextChanged);
            // 
            // tbxTimeOffset
            // 
            this.tbxTimeOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbxTimeOffset, 2);
            this.tbxTimeOffset.Location = new System.Drawing.Point(246, 82);
            this.tbxTimeOffset.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.tbxTimeOffset.Name = "tbxTimeOffset";
            this.tbxTimeOffset.Size = new System.Drawing.Size(179, 20);
            this.tbxTimeOffset.TabIndex = 9;
            this.tbxTimeOffset.TextChanged += new System.EventHandler(this.tbxTimeOffset_TextChanged);
            // 
            // picGameIcon
            // 
            this.picGameIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.picGameIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.picGameIcon, 2);
            this.picGameIcon.Image = ((System.Drawing.Image)(resources.GetObject("picGameIcon.Image")));
            this.picGameIcon.Location = new System.Drawing.Point(10, 15);
            this.picGameIcon.Margin = new System.Windows.Forms.Padding(10);
            this.picGameIcon.Name = "picGameIcon";
            this.picGameIcon.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.SetRowSpan(this.picGameIcon, 4);
            this.picGameIcon.Size = new System.Drawing.Size(120, 120);
            this.picGameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGameIcon.TabIndex = 1;
            this.picGameIcon.TabStop = false;
            this.picGameIcon.DoubleClick += new System.EventHandler(this.picGameIcon_DoubleClick);
            this.picGameIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picGameIcon_MouseUp);
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 10);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(125, 148);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 22);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabSelected);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Real Time";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game Time";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxAttempts
            // 
            this.tbxAttempts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbxAttempts, 2);
            this.tbxAttempts.Location = new System.Drawing.Point(494, 82);
            this.tbxAttempts.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.tbxAttempts.Name = "tbxAttempts";
            this.tbxAttempts.Size = new System.Drawing.Size(179, 20);
            this.tbxAttempts.TabIndex = 10;
            this.tbxAttempts.TextChanged += new System.EventHandler(this.tbxAttempts_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Attempts:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOK, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(489, 481);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(195, 36);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(110, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(27, 3);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblDescription, 5);
            this.lblDescription.Location = new System.Drawing.Point(143, 121);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(343, 13);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // btnActivate
            // 
            this.btnActivate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnActivate.Location = new System.Drawing.Point(517, 116);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(75, 23);
            this.btnActivate.TabIndex = 14;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSettings.Location = new System.Drawing.Point(598, 116);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Location = new System.Drawing.Point(10, 173);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(102, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert Above";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(10, 202);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Insert Below";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(10, 231);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Segment";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.Location = new System.Drawing.Point(10, 260);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(102, 23);
            this.btnMoveUp.TabIndex = 16;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveDown.Location = new System.Drawing.Point(10, 289);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(102, 23);
            this.btnMoveDown.TabIndex = 17;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnAddComparison
            // 
            this.btnAddComparison.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddComparison.Location = new System.Drawing.Point(10, 318);
            this.btnAddComparison.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnAddComparison.Name = "btnAddComparison";
            this.btnAddComparison.Size = new System.Drawing.Size(102, 23);
            this.btnAddComparison.TabIndex = 4;
            this.btnAddComparison.Text = "Add Comparison";
            this.btnAddComparison.UseVisualStyleBackColor = true;
            this.btnAddComparison.Click += new System.EventHandler(this.btnAddComparison_Click);
            // 
            // btnImportComparison
            // 
            this.btnImportComparison.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportComparison.Location = new System.Drawing.Point(10, 347);
            this.btnImportComparison.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnImportComparison.Name = "btnImportComparison";
            this.btnImportComparison.Size = new System.Drawing.Size(102, 23);
            this.btnImportComparison.TabIndex = 18;
            this.btnImportComparison.Text = "Import Comparison";
            this.btnImportComparison.UseVisualStyleBackColor = true;
            this.btnImportComparison.Click += new System.EventHandler(this.btnImportComparison_Click);
            // 
            // RemoveIconMenu
            // 
            this.RemoveIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.downloadBoxartToolStripMenuItem,
            this.openFromURLMenuItem,
            this.removeIconToolStripMenuItem});
            this.RemoveIconMenu.Name = "RemoveIconMenu";
            this.RemoveIconMenu.Size = new System.Drawing.Size(170, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem1.Text = "Set Icon...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // downloadBoxartToolStripMenuItem
            // 
            this.downloadBoxartToolStripMenuItem.Name = "downloadBoxartToolStripMenuItem";
            this.downloadBoxartToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.downloadBoxartToolStripMenuItem.Text = "Download Box Art";
            this.downloadBoxartToolStripMenuItem.Click += new System.EventHandler(this.downloadBoxartToolStripMenuItem_Click);
            // 
            // openFromURLMenuItem
            // 
            this.openFromURLMenuItem.Name = "openFromURLMenuItem";
            this.openFromURLMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openFromURLMenuItem.Text = "Open from URL...";
            this.openFromURLMenuItem.Click += new System.EventHandler(this.openFromURLMenuItem_Click);
            // 
            // removeIconToolStripMenuItem
            // 
            this.removeIconToolStripMenuItem.Name = "removeIconToolStripMenuItem";
            this.removeIconToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.removeIconToolStripMenuItem.Text = "Remove Icon";
            this.removeIconToolStripMenuItem.Click += new System.EventHandler(this.removeIconToolStripMenuItem_Click);
            // 
            // iRunBindingSource
            // 
            this.iRunBindingSource.DataSource = typeof(LiveSplit.Model.IRun);
            // 
            // iSegmentBindingSource
            // 
            this.iSegmentBindingSource.DataSource = typeof(LiveSplit.Model.ISegment);
            // 
            // ImportComparisonMenu
            // 
            this.ImportComparisonMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem,
            this.fromURLToolStripMenuItem,
            this.fromSplitsioToolStripMenuItem});
            this.ImportComparisonMenu.Name = "ImportComparisonMenu";
            this.ImportComparisonMenu.Size = new System.Drawing.Size(156, 70);
            // 
            // fromFileToolStripMenuItem
            // 
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.fromFileToolStripMenuItem.Text = "From File...";
            this.fromFileToolStripMenuItem.Click += new System.EventHandler(this.fromFileToolStripMenuItem_Click);
            // 
            // fromURLToolStripMenuItem
            // 
            this.fromURLToolStripMenuItem.Name = "fromURLToolStripMenuItem";
            this.fromURLToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.fromURLToolStripMenuItem.Text = "From URL...";
            this.fromURLToolStripMenuItem.Click += new System.EventHandler(this.fromURLToolStripMenuItem_Click);
            // 
            // fromSplitsioToolStripMenuItem
            // 
            this.fromSplitsioToolStripMenuItem.Name = "fromSplitsioToolStripMenuItem";
            this.fromSplitsioToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.fromSplitsioToolStripMenuItem.Text = "From Splits.io...";
            this.fromSplitsioToolStripMenuItem.Click += new System.EventHandler(this.fromSplitsioToolStripMenuItem_Click);
            // 
            // RunEditorDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(684, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "RunEditorDialog";
            this.Text = "Splits Editor";
            this.Load += new System.EventHandler(this.RunEditorDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.runGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGameIcon)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.RemoveIconMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iRunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSegmentBindingSource)).EndInit();
            this.ImportComparisonMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView runGrid;
        private System.Windows.Forms.BindingSource iSegmentBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picGameIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource iRunBindingSource;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ContextMenuStrip RemoveIconMenu;
        private System.Windows.Forms.ToolStripMenuItem removeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ComboBox cbxGameName;
        private System.Windows.Forms.ComboBox cbxRunCategory;
        private System.Windows.Forms.TextBox tbxTimeOffset;
        private System.Windows.Forms.TextBox tbxAttempts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem downloadBoxartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFromURLMenuItem;
        private System.Windows.Forms.Button btnAddComparison;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnImportComparison;
        private System.Windows.Forms.ContextMenuStrip ImportComparisonMenu;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromSplitsioToolStripMenuItem;
    }
}