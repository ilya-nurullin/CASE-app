namespace WowCaseApp
{
    partial class NewAttributeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isNullableCheckBox = new System.Windows.Forms.CheckBox();
            this.isIndexedCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(53, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(189, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(53, 39);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(189, 24);
            this.typeComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тип";
            // 
            // isNullableCheckBox
            // 
            this.isNullableCheckBox.AutoSize = true;
            this.isNullableCheckBox.Location = new System.Drawing.Point(54, 80);
            this.isNullableCheckBox.Name = "isNullableCheckBox";
            this.isNullableCheckBox.Size = new System.Drawing.Size(169, 21);
            this.isNullableCheckBox.TabIndex = 3;
            this.isNullableCheckBox.Text = "Может быть пустым?";
            this.isNullableCheckBox.UseVisualStyleBackColor = true;
            // 
            // isIndexedCheckBox
            // 
            this.isIndexedCheckBox.AutoSize = true;
            this.isIndexedCheckBox.Location = new System.Drawing.Point(54, 107);
            this.isIndexedCheckBox.Name = "isIndexedCheckBox";
            this.isIndexedCheckBox.Size = new System.Drawing.Size(139, 21);
            this.isIndexedCheckBox.TabIndex = 3;
            this.isIndexedCheckBox.Text = "Индексируется?";
            this.isIndexedCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewAttributeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isIndexedCheckBox);
            this.Controls.Add(this.isNullableCheckBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAttributeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление нового атрибута";
            this.Load += new System.EventHandler(this.NewAttributeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isNullableCheckBox;
        private System.Windows.Forms.CheckBox isIndexedCheckBox;
        private System.Windows.Forms.Button button1;
    }
}