﻿namespace LogExpert.Dialogs
{
  partial class HilightDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HilightDialog));
            this.hilightListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.searchStringTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.customForeColorButton = new System.Windows.Forms.Button();
            this.customBackColorButton = new System.Windows.Forms.Button();
            this.regexCheckBox = new System.Windows.Forms.CheckBox();
            this.caseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.ledCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.noBackgroundCheckBox = new System.Windows.Forms.CheckBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.wordMatchCheckBox = new System.Windows.Forms.CheckBox();
            this.foregroundColorBox = new LogExpert.Dialogs.ColorComboBox();
            this.backgroundColorBox = new LogExpert.Dialogs.ColorComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bookmarkCommentButton = new System.Windows.Forms.Button();
            this.pluginButton = new System.Windows.Forms.Button();
            this.pluginCheckBox = new System.Windows.Forms.CheckBox();
            this.stopTailCheckBox = new System.Windows.Forms.CheckBox();
            this.bookmarkCheckBox = new System.Windows.Forms.CheckBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupDownButton = new System.Windows.Forms.Button();
            this.groupUpButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.copyGroupButton = new System.Windows.Forms.Button();
            this.delGroupButton = new System.Windows.Forms.Button();
            this.newGroupButton = new System.Windows.Forms.Button();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // hilightListBox
            // 
            this.hilightListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hilightListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hilightListBox.FormattingEnabled = true;
            this.hilightListBox.Location = new System.Drawing.Point(21, 96);
            this.hilightListBox.Name = "hilightListBox";
            this.hilightListBox.Size = new System.Drawing.Size(293, 160);
            this.hilightListBox.TabIndex = 0;
            this.hilightListBox.SelectedIndexChanged += new System.EventHandler(this.hilightListBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(320, 131);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(92, 21);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "添加";
            this.toolTip1.SetToolTip(this.addButton, "Create a new hilight item from information below");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(320, 158);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 21);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "删除";
            this.toolTip1.SetToolTip(this.deleteButton, "Delete the current hilight");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveUpButton.Location = new System.Drawing.Point(320, 96);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(45, 21);
            this.moveUpButton.TabIndex = 3;
            this.moveUpButton.Text = "上移";
            this.toolTip1.SetToolTip(this.moveUpButton, "Move the current hilight one position up");
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // moveDownButton
            // 
            this.moveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveDownButton.Location = new System.Drawing.Point(367, 96);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(45, 21);
            this.moveDownButton.TabIndex = 4;
            this.moveDownButton.Text = "下移";
            this.toolTip1.SetToolTip(this.moveDownButton, "Move the current hilight one position down");
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "前景色";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "背景色";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(266, 510);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 21);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(351, 510);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 21);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // searchStringTextBox
            // 
            this.searchStringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchStringTextBox.Location = new System.Drawing.Point(6, 33);
            this.searchStringTextBox.Name = "searchStringTextBox";
            this.searchStringTextBox.Size = new System.Drawing.Size(394, 21);
            this.searchStringTextBox.TabIndex = 11;
            this.searchStringTextBox.TextChanged += new System.EventHandler(this.searchStringTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "匹配的字符串:";
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Enabled = false;
            this.applyButton.Image = global::LogExpert.Properties.Resources.AdvancedIcon2;
            this.applyButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.applyButton.Location = new System.Drawing.Point(320, 185);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(92, 21);
            this.applyButton.TabIndex = 13;
            this.applyButton.Text = "应用";
            this.toolTip1.SetToolTip(this.applyButton, "Apply changes below to current hiligth");
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // customForeColorButton
            // 
            this.customForeColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customForeColorButton.Location = new System.Drawing.Point(132, 36);
            this.customForeColorButton.Name = "customForeColorButton";
            this.customForeColorButton.Size = new System.Drawing.Size(52, 21);
            this.customForeColorButton.TabIndex = 14;
            this.customForeColorButton.Text = "自定义";
            this.toolTip1.SetToolTip(this.customForeColorButton, "Pick a custom foreground color");
            this.customForeColorButton.UseVisualStyleBackColor = true;
            this.customForeColorButton.Click += new System.EventHandler(this.customForeColorButton_Click);
            // 
            // customBackColorButton
            // 
            this.customBackColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customBackColorButton.Location = new System.Drawing.Point(132, 82);
            this.customBackColorButton.Name = "customBackColorButton";
            this.customBackColorButton.Size = new System.Drawing.Size(52, 21);
            this.customBackColorButton.TabIndex = 15;
            this.customBackColorButton.Text = "自定义";
            this.toolTip1.SetToolTip(this.customBackColorButton, "Pick a custom background color");
            this.customBackColorButton.UseVisualStyleBackColor = true;
            this.customBackColorButton.Click += new System.EventHandler(this.customBackColorButton_Click);
            // 
            // regexCheckBox
            // 
            this.regexCheckBox.AutoSize = true;
            this.regexCheckBox.Location = new System.Drawing.Point(120, 57);
            this.regexCheckBox.Name = "regexCheckBox";
            this.regexCheckBox.Size = new System.Drawing.Size(108, 16);
            this.regexCheckBox.TabIndex = 16;
            this.regexCheckBox.Text = "使用正则表达式";
            this.toolTip1.SetToolTip(this.regexCheckBox, "Whether the string is a regular expresion");
            this.regexCheckBox.UseVisualStyleBackColor = true;
            this.regexCheckBox.CheckedChanged += new System.EventHandler(this.regexCheckBox_CheckedChanged);
            this.regexCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.regexCheckBox_MouseUp);
            // 
            // caseSensitiveCheckBox
            // 
            this.caseSensitiveCheckBox.AutoSize = true;
            this.caseSensitiveCheckBox.Location = new System.Drawing.Point(9, 57);
            this.caseSensitiveCheckBox.Name = "caseSensitiveCheckBox";
            this.caseSensitiveCheckBox.Size = new System.Drawing.Size(84, 16);
            this.caseSensitiveCheckBox.TabIndex = 17;
            this.caseSensitiveCheckBox.Text = "区分大小写";
            this.toolTip1.SetToolTip(this.caseSensitiveCheckBox, "Whether the string will match uppercases and lowercases");
            this.caseSensitiveCheckBox.UseVisualStyleBackColor = true;
            this.caseSensitiveCheckBox.CheckedChanged += new System.EventHandler(this.caseSensitiveCheckBox_CheckedChanged);
            // 
            // ledCheckBox
            // 
            this.ledCheckBox.AutoSize = true;
            this.ledCheckBox.Location = new System.Drawing.Point(10, 23);
            this.ledCheckBox.Name = "ledCheckBox";
            this.ledCheckBox.Size = new System.Drawing.Size(138, 16);
            this.ledCheckBox.TabIndex = 18;
            this.ledCheckBox.Text = "Don\'t lit dirty LED";
            this.toolTip1.SetToolTip(this.ledCheckBox, "When matching a line, don\'t mark the page as \"dirty\"");
            this.ledCheckBox.UseVisualStyleBackColor = true;
            this.ledCheckBox.CheckedChanged += new System.EventHandler(this.ledCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.searchStringTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.regexCheckBox);
            this.groupBox1.Controls.Add(this.caseSensitiveCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 81);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "行匹配条件";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.noBackgroundCheckBox);
            this.groupBox2.Controls.Add(this.boldCheckBox);
            this.groupBox2.Controls.Add(this.wordMatchCheckBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.foregroundColorBox);
            this.groupBox2.Controls.Add(this.customForeColorButton);
            this.groupBox2.Controls.Add(this.customBackColorButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.backgroundColorBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 172);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "颜色配置";
            // 
            // noBackgroundCheckBox
            // 
            this.noBackgroundCheckBox.AutoSize = true;
            this.noBackgroundCheckBox.Enabled = false;
            this.noBackgroundCheckBox.Location = new System.Drawing.Point(94, 144);
            this.noBackgroundCheckBox.Name = "noBackgroundCheckBox";
            this.noBackgroundCheckBox.Size = new System.Drawing.Size(60, 16);
            this.noBackgroundCheckBox.TabIndex = 18;
            this.noBackgroundCheckBox.Text = "无背景";
            this.toolTip1.SetToolTip(this.noBackgroundCheckBox, "Don\'t set the background color");
            this.noBackgroundCheckBox.UseVisualStyleBackColor = true;
            this.noBackgroundCheckBox.CheckedChanged += new System.EventHandler(this.noBackgroundCheckBox_CheckedChanged);
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Location = new System.Drawing.Point(6, 123);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(48, 16);
            this.boldCheckBox.TabIndex = 17;
            this.boldCheckBox.Text = "粗体";
            this.toolTip1.SetToolTip(this.boldCheckBox, "Display the line in bold characters");
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.boldCheckBox_CheckedChanged);
            // 
            // wordMatchCheckBox
            // 
            this.wordMatchCheckBox.AutoSize = true;
            this.wordMatchCheckBox.Location = new System.Drawing.Point(6, 144);
            this.wordMatchCheckBox.Name = "wordMatchCheckBox";
            this.wordMatchCheckBox.Size = new System.Drawing.Size(72, 16);
            this.wordMatchCheckBox.TabIndex = 16;
            this.wordMatchCheckBox.Text = "文字模式";
            this.toolTip1.SetToolTip(this.wordMatchCheckBox, "Don\'t highlight the whole line but only the matching keywords");
            this.wordMatchCheckBox.UseVisualStyleBackColor = true;
            this.wordMatchCheckBox.CheckedChanged += new System.EventHandler(this.wordMatchCheckBox_CheckedChanged);
            // 
            // foregroundColorBox
            // 
            this.foregroundColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foregroundColorBox.CustomColor = System.Drawing.Color.Black;
            this.foregroundColorBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.foregroundColorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foregroundColorBox.FormattingEnabled = true;
            this.foregroundColorBox.Items.AddRange(new object[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Black,
            System.Drawing.Color.White,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DarkGray,
            System.Drawing.Color.Blue,
            System.Drawing.Color.LightBlue,
            System.Drawing.Color.DarkBlue,
            System.Drawing.Color.Green,
            System.Drawing.Color.LightGreen,
            System.Drawing.Color.DarkGreen,
            System.Drawing.Color.Olive,
            System.Drawing.Color.Red,
            System.Drawing.Color.Pink,
            System.Drawing.Color.Purple,
            System.Drawing.Color.IndianRed,
            System.Drawing.Color.DarkCyan,
            System.Drawing.Color.Yellow});
            this.foregroundColorBox.Location = new System.Drawing.Point(5, 38);
            this.foregroundColorBox.Name = "foregroundColorBox";
            this.foregroundColorBox.Size = new System.Drawing.Size(121, 22);
            this.foregroundColorBox.TabIndex = 5;
            this.foregroundColorBox.SelectedIndexChanged += new System.EventHandler(this.foregroundColorBox_SelectedIndexChanged);
            // 
            // backgroundColorBox
            // 
            this.backgroundColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundColorBox.CustomColor = System.Drawing.Color.Black;
            this.backgroundColorBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.backgroundColorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backgroundColorBox.FormattingEnabled = true;
            this.backgroundColorBox.Items.AddRange(new object[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.Black,
            System.Drawing.Color.White,
            System.Drawing.Color.Gray,
            System.Drawing.Color.DarkGray,
            System.Drawing.Color.Blue,
            System.Drawing.Color.LightBlue,
            System.Drawing.Color.DarkBlue,
            System.Drawing.Color.Green,
            System.Drawing.Color.LightGreen,
            System.Drawing.Color.DarkGreen,
            System.Drawing.Color.Olive,
            System.Drawing.Color.Red,
            System.Drawing.Color.Pink,
            System.Drawing.Color.Purple,
            System.Drawing.Color.IndianRed,
            System.Drawing.Color.DarkCyan,
            System.Drawing.Color.Yellow});
            this.backgroundColorBox.Location = new System.Drawing.Point(6, 84);
            this.backgroundColorBox.Name = "backgroundColorBox";
            this.backgroundColorBox.Size = new System.Drawing.Size(121, 22);
            this.backgroundColorBox.TabIndex = 7;
            this.backgroundColorBox.SelectedIndexChanged += new System.EventHandler(this.backgroundColorBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.bookmarkCommentButton);
            this.groupBox3.Controls.Add(this.pluginButton);
            this.groupBox3.Controls.Add(this.pluginCheckBox);
            this.groupBox3.Controls.Add(this.stopTailCheckBox);
            this.groupBox3.Controls.Add(this.bookmarkCheckBox);
            this.groupBox3.Controls.Add(this.ledCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(218, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 117);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "触发动作";
            // 
            // bookmarkCommentButton
            // 
            this.bookmarkCommentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookmarkCommentButton.Location = new System.Drawing.Point(140, 42);
            this.bookmarkCommentButton.Name = "bookmarkCommentButton";
            this.bookmarkCommentButton.Size = new System.Drawing.Size(54, 27);
            this.bookmarkCommentButton.TabIndex = 23;
            this.bookmarkCommentButton.Text = "文字";
            this.bookmarkCommentButton.UseVisualStyleBackColor = true;
            this.bookmarkCommentButton.Click += new System.EventHandler(this.bookmarkCommentButton_Click);
            // 
            // pluginButton
            // 
            this.pluginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pluginButton.Location = new System.Drawing.Point(140, 86);
            this.pluginButton.Name = "pluginButton";
            this.pluginButton.Size = new System.Drawing.Size(54, 18);
            this.pluginButton.TabIndex = 22;
            this.pluginButton.Text = "选择";
            this.pluginButton.UseVisualStyleBackColor = true;
            this.pluginButton.Click += new System.EventHandler(this.pluginButton_Click);
            // 
            // pluginCheckBox
            // 
            this.pluginCheckBox.AutoSize = true;
            this.pluginCheckBox.Location = new System.Drawing.Point(10, 89);
            this.pluginCheckBox.Name = "pluginCheckBox";
            this.pluginCheckBox.Size = new System.Drawing.Size(48, 16);
            this.pluginCheckBox.TabIndex = 21;
            this.pluginCheckBox.Text = "插件";
            this.toolTip1.SetToolTip(this.pluginCheckBox, "When matching a line, call a keyword action plugin");
            this.pluginCheckBox.UseVisualStyleBackColor = true;
            this.pluginCheckBox.CheckedChanged += new System.EventHandler(this.pluginCheckBox_CheckedChanged);
            // 
            // stopTailCheckBox
            // 
            this.stopTailCheckBox.AutoSize = true;
            this.stopTailCheckBox.Location = new System.Drawing.Point(10, 66);
            this.stopTailCheckBox.Name = "stopTailCheckBox";
            this.stopTailCheckBox.Size = new System.Drawing.Size(108, 16);
            this.stopTailCheckBox.TabIndex = 20;
            this.stopTailCheckBox.Text = "停止刷新末尾行";
            this.toolTip1.SetToolTip(this.stopTailCheckBox, "When matching a line, stop automatic scrolling");
            this.stopTailCheckBox.UseVisualStyleBackColor = true;
            this.stopTailCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // bookmarkCheckBox
            // 
            this.bookmarkCheckBox.AutoSize = true;
            this.bookmarkCheckBox.Location = new System.Drawing.Point(10, 44);
            this.bookmarkCheckBox.Name = "bookmarkCheckBox";
            this.bookmarkCheckBox.Size = new System.Drawing.Size(72, 16);
            this.bookmarkCheckBox.TabIndex = 19;
            this.bookmarkCheckBox.Text = "设置书签";
            this.toolTip1.SetToolTip(this.bookmarkCheckBox, "When matching a line, create a new bookmark for it");
            this.bookmarkCheckBox.UseVisualStyleBackColor = true;
            this.bookmarkCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "LogExpert.chm";
            this.helpProvider1.Tag = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.groupDownButton);
            this.groupBox4.Controls.Add(this.groupUpButton);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.copyGroupButton);
            this.groupBox4.Controls.Add(this.delGroupButton);
            this.groupBox4.Controls.Add(this.newGroupButton);
            this.groupBox4.Controls.Add(this.groupComboBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(414, 78);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "分组";
            // 
            // groupDownButton
            // 
            this.groupDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDownButton.Location = new System.Drawing.Point(355, 45);
            this.groupDownButton.Name = "groupDownButton";
            this.groupDownButton.Size = new System.Drawing.Size(45, 21);
            this.groupDownButton.TabIndex = 6;
            this.groupDownButton.Text = "下移";
            this.toolTip1.SetToolTip(this.groupDownButton, "Move the current hilight group one position down");
            this.groupDownButton.UseVisualStyleBackColor = true;
            this.groupDownButton.Click += new System.EventHandler(this.groupDownButton_Click);
            // 
            // groupUpButton
            // 
            this.groupUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupUpButton.Location = new System.Drawing.Point(308, 45);
            this.groupUpButton.Name = "groupUpButton";
            this.groupUpButton.Size = new System.Drawing.Size(45, 21);
            this.groupUpButton.TabIndex = 5;
            this.groupUpButton.Text = "上移";
            this.toolTip1.SetToolTip(this.groupUpButton, "Move the current hilight group one position up");
            this.groupUpButton.UseVisualStyleBackColor = true;
            this.groupUpButton.Click += new System.EventHandler(this.groupUpButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "在【设置】里，您可将分组应用到特定文件中";
            // 
            // copyGroupButton
            // 
            this.copyGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyGroupButton.Location = new System.Drawing.Point(355, 18);
            this.copyGroupButton.Name = "copyGroupButton";
            this.copyGroupButton.Size = new System.Drawing.Size(45, 21);
            this.copyGroupButton.TabIndex = 3;
            this.copyGroupButton.Text = "复制";
            this.toolTip1.SetToolTip(this.copyGroupButton, "Copy the current hilight group into a new one");
            this.copyGroupButton.UseVisualStyleBackColor = true;
            this.copyGroupButton.Click += new System.EventHandler(this.copyGroupButton_Click);
            // 
            // delGroupButton
            // 
            this.delGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delGroupButton.Location = new System.Drawing.Point(308, 18);
            this.delGroupButton.Name = "delGroupButton";
            this.delGroupButton.Size = new System.Drawing.Size(45, 21);
            this.delGroupButton.TabIndex = 2;
            this.delGroupButton.Text = "删除";
            this.toolTip1.SetToolTip(this.delGroupButton, "Delete the current hilight group");
            this.delGroupButton.UseVisualStyleBackColor = true;
            this.delGroupButton.Click += new System.EventHandler(this.delGroupButton_Click);
            // 
            // newGroupButton
            // 
            this.newGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newGroupButton.Location = new System.Drawing.Point(264, 18);
            this.newGroupButton.Name = "newGroupButton";
            this.newGroupButton.Size = new System.Drawing.Size(42, 21);
            this.newGroupButton.TabIndex = 1;
            this.newGroupButton.Text = "新组";
            this.toolTip1.SetToolTip(this.newGroupButton, "Create a new empty hilight group");
            this.newGroupButton.UseVisualStyleBackColor = true;
            this.newGroupButton.Click += new System.EventHandler(this.newGroupButton_Click);
            // 
            // groupComboBox
            // 
            this.groupComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupComboBox.DisplayMember = "GroupName";
            this.groupComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.groupComboBox.Location = new System.Drawing.Point(9, 19);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(238, 22);
            this.groupComboBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.groupComboBox, "Choose a group to create different highlight settings. Type in a name to change i" +
        "n the name of a group.");
            this.groupComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.groupComboBox_DrawItem);
            this.groupComboBox.SelectionChangeCommitted += new System.EventHandler(this.groupComboBox_SelectionChangeCommitted);
            this.groupComboBox.TextUpdate += new System.EventHandler(this.groupComboBox_TextUpdate);
            // 
            // HilightDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(439, 547);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.hilightListBox);
            this.DoubleBuffered = true;
            this.helpProvider1.SetHelpKeyword(this, "Highlighting.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this, "");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(447, 582);
            this.Name = "HilightDialog";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "高亮设置";
            this.Shown += new System.EventHandler(this.HilightDialog_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox hilightListBox;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button deleteButton;
    private System.Windows.Forms.Button moveUpButton;
    private System.Windows.Forms.Button moveDownButton;
    private ColorComboBox foregroundColorBox;
    private System.Windows.Forms.Label label1;
    private ColorComboBox backgroundColorBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.TextBox searchStringTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button applyButton;
    private System.Windows.Forms.Button customForeColorButton;
    private System.Windows.Forms.Button customBackColorButton;
    private System.Windows.Forms.CheckBox regexCheckBox;
    private System.Windows.Forms.CheckBox caseSensitiveCheckBox;
    private System.Windows.Forms.CheckBox ledCheckBox;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.CheckBox bookmarkCheckBox;
    private System.Windows.Forms.CheckBox stopTailCheckBox;
    private System.Windows.Forms.HelpProvider helpProvider1;
    private System.Windows.Forms.CheckBox pluginCheckBox;
    private System.Windows.Forms.Button pluginButton;
    private System.Windows.Forms.Button bookmarkCommentButton;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.ComboBox groupComboBox;
    private System.Windows.Forms.Button delGroupButton;
    private System.Windows.Forms.Button newGroupButton;
    private System.Windows.Forms.Button copyGroupButton;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button groupUpButton;
    private System.Windows.Forms.Button groupDownButton;
    private System.Windows.Forms.CheckBox wordMatchCheckBox;
    private System.Windows.Forms.CheckBox boldCheckBox;
    private System.Windows.Forms.CheckBox noBackgroundCheckBox;
  }
}