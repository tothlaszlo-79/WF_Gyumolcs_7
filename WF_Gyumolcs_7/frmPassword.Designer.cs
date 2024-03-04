namespace WF_Gyumolcs_7
{
    partial class frmPassword
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
            tbPassword = new TextBox();
            btOk = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(36, 36);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Enter password here";
            tbPassword.Size = new Size(299, 23);
            tbPassword.TabIndex = 0;
            // 
            // btOk
            // 
            btOk.DialogResult = DialogResult.OK;
            btOk.Location = new Point(77, 82);
            btOk.Name = "btOk";
            btOk.Size = new Size(75, 23);
            btOk.TabIndex = 1;
            btOk.Text = "Ok";
            btOk.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(215, 82);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 141);
            Controls.Add(button2);
            Controls.Add(btOk);
            Controls.Add(tbPassword);
            Name = "frmPassword";
            Text = "Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPassword;
        private Button btOk;
        private Button button2;
    }
}