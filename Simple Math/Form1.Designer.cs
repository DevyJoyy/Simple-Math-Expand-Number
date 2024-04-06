
namespace Simple_Math
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
            this.closeButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.instLabel = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeButton.Location = new System.Drawing.Point(1102, 23);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(82, 42);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(248, 32);
            this.title.TabIndex = 1;
            this.title.Text = "Expand The Number";
            // 
            // instLabel
            // 
            this.instLabel.AutoSize = true;
            this.instLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.instLabel.Location = new System.Drawing.Point(364, 132);
            this.instLabel.Name = "instLabel";
            this.instLabel.Size = new System.Drawing.Size(396, 28);
            this.instLabel.TabIndex = 2;
            this.instLabel.Text = "Enter The Number You Want To Expand :";
            // 
            // processButton
            // 
            this.processButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.processButton.Image = global::Simple_Math.Properties.Resources.settingsIcon;
            this.processButton.Location = new System.Drawing.Point(519, 274);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(89, 55);
            this.processButton.TabIndex = 5;
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // inputTextbox
            // 
            this.inputTextbox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextbox.Location = new System.Drawing.Point(356, 184);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(415, 30);
            this.inputTextbox.TabIndex = 6;
            this.inputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputTextbox
            // 
            this.outputTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.outputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTextbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextbox.ForeColor = System.Drawing.Color.White;
            this.outputTextbox.Location = new System.Drawing.Point(108, 425);
            this.outputTextbox.Multiline = true;
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ReadOnly = true;
            this.outputTextbox.Size = new System.Drawing.Size(984, 69);
            this.outputTextbox.TabIndex = 7;
            this.outputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(806, 184);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 30);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1210, 596);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.instLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.closeButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple math";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label instLabel;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.TextBox outputTextbox;
        private System.Windows.Forms.Button clearButton;
    }
}

