namespace AbstractFactory
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbUIControls = new System.Windows.Forms.TextBox();
            this.cbOSControls = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbUIControls
            // 
            this.tbUIControls.Location = new System.Drawing.Point(12, 69);
            this.tbUIControls.Multiline = true;
            this.tbUIControls.Name = "tbUIControls";
            this.tbUIControls.Size = new System.Drawing.Size(337, 227);
            this.tbUIControls.TabIndex = 1;
            // 
            // cbOSControls
            // 
            this.cbOSControls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOSControls.FormattingEnabled = true;
            this.cbOSControls.Items.AddRange(new object[] {
            "Linux UI",
            "Windows UI"});
            this.cbOSControls.Location = new System.Drawing.Point(389, 69);
            this.cbOSControls.Name = "cbOSControls";
            this.cbOSControls.Size = new System.Drawing.Size(175, 21);
            this.cbOSControls.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbOSControls);
            this.Controls.Add(this.tbUIControls);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbUIControls;
        private System.Windows.Forms.ComboBox cbOSControls;
    }
}

