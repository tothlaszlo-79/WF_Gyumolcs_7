namespace WF_Gyumolcs_7
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flpPage = new FlowLayoutPanel();
            btApple = new Button();
            btPear = new Button();
            btBanana = new Button();
            btOrange = new Button();
            tbWeight = new TextBox();
            label1 = new Label();
            tbPrice = new TextBox();
            label2 = new Label();
            btSettings = new Button();
            flpPage.SuspendLayout();
            SuspendLayout();
            // 
            // flpPage
            // 
            flpPage.Controls.Add(btApple);
            flpPage.Controls.Add(btPear);
            flpPage.Controls.Add(btBanana);
            flpPage.Controls.Add(btOrange);
            flpPage.Dock = DockStyle.Top;
            flpPage.Location = new Point(0, 0);
            flpPage.Margin = new Padding(3, 4, 3, 4);
            flpPage.Name = "flpPage";
            flpPage.Size = new Size(544, 621);
            flpPage.TabIndex = 0;
            // 
            // btApple
            // 
            btApple.Image = (Image)resources.GetObject("btApple.Image");
            btApple.Location = new Point(3, 4);
            btApple.Margin = new Padding(3, 4, 3, 4);
            btApple.Name = "btApple";
            btApple.Size = new Size(265, 257);
            btApple.TabIndex = 0;
            btApple.Tag = "Apple";
            btApple.Text = "500";
            btApple.UseVisualStyleBackColor = true;
            btApple.Click += btFruit_Click;
            // 
            // btPear
            // 
            btPear.Image = (Image)resources.GetObject("btPear.Image");
            btPear.Location = new Point(274, 4);
            btPear.Margin = new Padding(3, 4, 3, 4);
            btPear.Name = "btPear";
            btPear.Size = new Size(265, 257);
            btPear.TabIndex = 1;
            btPear.Tag = "Pear";
            btPear.Text = "699";
            btPear.UseVisualStyleBackColor = true;
            btPear.Click += btFruit_Click;
            // 
            // btBanana
            // 
            btBanana.Image = (Image)resources.GetObject("btBanana.Image");
            btBanana.Location = new Point(3, 269);
            btBanana.Margin = new Padding(3, 4, 3, 4);
            btBanana.Name = "btBanana";
            btBanana.Size = new Size(265, 257);
            btBanana.TabIndex = 2;
            btBanana.Tag = "Banana";
            btBanana.Text = "300";
            btBanana.UseVisualStyleBackColor = true;
            btBanana.Click += btFruit_Click;
            // 
            // btOrange
            // 
            btOrange.Image = (Image)resources.GetObject("btOrange.Image");
            btOrange.Location = new Point(274, 269);
            btOrange.Margin = new Padding(3, 4, 3, 4);
            btOrange.Name = "btOrange";
            btOrange.Size = new Size(265, 257);
            btOrange.TabIndex = 3;
            btOrange.Tag = "Orange";
            btOrange.Text = "350";
            btOrange.UseVisualStyleBackColor = true;
            btOrange.Click += btFruit_Click;
            // 
            // tbWeight
            // 
            tbWeight.Location = new Point(14, 645);
            tbWeight.Margin = new Padding(3, 4, 3, 4);
            tbWeight.Name = "tbWeight";
            tbWeight.PlaceholderText = "Enter weight";
            tbWeight.Size = new Size(222, 27);
            tbWeight.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 652);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 2;
            label1.Text = "Kg";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(298, 645);
            tbPrice.Margin = new Padding(3, 4, 3, 4);
            tbPrice.Name = "tbPrice";
            tbPrice.ReadOnly = true;
            tbPrice.Size = new Size(114, 27);
            tbPrice.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 652);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 4;
            label2.Text = "Ft";
            // 
            // btSettings
            // 
            btSettings.Image = (Image)resources.GetObject("btSettings.Image");
            btSettings.Location = new Point(464, 645);
            btSettings.Margin = new Padding(3, 4, 3, 4);
            btSettings.Name = "btSettings";
            btSettings.Size = new Size(66, 73);
            btSettings.TabIndex = 5;
            btSettings.UseVisualStyleBackColor = true;
            btSettings.Click += btSettings_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 788);
            Controls.Add(btSettings);
            Controls.Add(label2);
            Controls.Add(tbPrice);
            Controls.Add(label1);
            Controls.Add(tbWeight);
            Controls.Add(flpPage);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            flpPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpPage;
        private Button btApple;
        private Button btPear;
        private Button btBanana;
        private Button btOrange;
        private TextBox tbWeight;
        private Label label1;
        private TextBox tbPrice;
        private Label label2;
        private Button btSettings;
    }
}
