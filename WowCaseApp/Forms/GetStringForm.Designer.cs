namespace WowCaseApp.Forms
{
    partial class GetStringForm
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
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(52, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 17);
            this.label.TabIndex = 0;
            this.label.Text = "label";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(55, 43);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(225, 22);
            this.textBox.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(111, 84);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(103, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // GetStringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 121);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GetStringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonOk;
    }
}