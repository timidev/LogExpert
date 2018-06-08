namespace LogExpert.Dialogs
{
  partial class RegexHelperDialog
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matchesTextBox = new System.Windows.Forms.TextBox();
            this.caseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.expressionComboBox = new System.Windows.Forms.ComboBox();
            this.testTextComboBox = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(345, 256);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 21);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(264, 256);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 21);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "确定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "正则表达式:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "测试文字:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "匹配:";
            // 
            // matchesTextBox
            // 
            this.matchesTextBox.Location = new System.Drawing.Point(12, 145);
            this.matchesTextBox.Multiline = true;
            this.matchesTextBox.Name = "matchesTextBox";
            this.matchesTextBox.ReadOnly = true;
            this.matchesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.matchesTextBox.Size = new System.Drawing.Size(408, 68);
            this.matchesTextBox.TabIndex = 7;
            // 
            // caseSensitiveCheckBox
            // 
            this.caseSensitiveCheckBox.AutoSize = true;
            this.caseSensitiveCheckBox.Location = new System.Drawing.Point(13, 53);
            this.caseSensitiveCheckBox.Name = "caseSensitiveCheckBox";
            this.caseSensitiveCheckBox.Size = new System.Drawing.Size(84, 16);
            this.caseSensitiveCheckBox.TabIndex = 8;
            this.caseSensitiveCheckBox.Text = "区分大小写";
            this.caseSensitiveCheckBox.UseVisualStyleBackColor = true;
            this.caseSensitiveCheckBox.CheckedChanged += new System.EventHandler(this.caseSensitiveCheckBox_CheckedChanged);
            // 
            // expressionComboBox
            // 
            this.expressionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.expressionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.expressionComboBox.FormattingEnabled = true;
            this.expressionComboBox.Location = new System.Drawing.Point(13, 26);
            this.expressionComboBox.Name = "expressionComboBox";
            this.expressionComboBox.Size = new System.Drawing.Size(407, 20);
            this.expressionComboBox.TabIndex = 10;
            this.expressionComboBox.TextChanged += new System.EventHandler(this.expressionComboBox_TextChanged);
            // 
            // testTextComboBox
            // 
            this.testTextComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.testTextComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.testTextComboBox.FormattingEnabled = true;
            this.testTextComboBox.Location = new System.Drawing.Point(13, 96);
            this.testTextComboBox.Name = "testTextComboBox";
            this.testTextComboBox.Size = new System.Drawing.Size(407, 20);
            this.testTextComboBox.TabIndex = 11;
            this.testTextComboBox.TextChanged += new System.EventHandler(this.testTextComboBox_TextChanged);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "LogExpert.chm";
            // 
            // button1
            // 
            this.helpProvider1.SetHelpKeyword(this.button1, "RegEx.htm");
            this.helpProvider1.SetHelpNavigator(this.button1, System.Windows.Forms.HelpNavigator.Topic);
            this.button1.Location = new System.Drawing.Point(13, 256);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 12;
            this.button1.Text = "帮助";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegexHelperDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(433, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testTextComboBox);
            this.Controls.Add(this.expressionComboBox);
            this.Controls.Add(this.caseSensitiveCheckBox);
            this.Controls.Add(this.matchesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.helpProvider1.SetHelpKeyword(this, "RegEx.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegexHelperDialog";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Regex-Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox matchesTextBox;
    private System.Windows.Forms.CheckBox caseSensitiveCheckBox;
    private System.Windows.Forms.ComboBox expressionComboBox;
    private System.Windows.Forms.ComboBox testTextComboBox;
    private System.Windows.Forms.HelpProvider helpProvider1;
    private System.Windows.Forms.Button button1;
  }
}