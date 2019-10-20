namespace Class1_Intro
{
    partial class GetSeedForRand
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
            this.numericUpSeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Accept_B = new System.Windows.Forms.Button();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.Gen_RandomText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpSeed
            // 
            this.numericUpSeed.Location = new System.Drawing.Point(50, 30);
            this.numericUpSeed.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpSeed.Name = "numericUpSeed";
            this.numericUpSeed.Size = new System.Drawing.Size(127, 22);
            this.numericUpSeed.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seed";
            // 
            // Accept_B
            // 
            this.Accept_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Accept_B.Location = new System.Drawing.Point(15, 78);
            this.Accept_B.Name = "Accept_B";
            this.Accept_B.Size = new System.Drawing.Size(71, 28);
            this.Accept_B.TabIndex = 2;
            this.Accept_B.Text = "Accept";
            this.Accept_B.UseVisualStyleBackColor = true;
            this.Accept_B.Click += new System.EventHandler(this.Accept_B_Click);
            // 
            // Cancel_B
            // 
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Location = new System.Drawing.Point(111, 78);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(75, 28);
            this.Cancel_B.TabIndex = 3;
            this.Cancel_B.Text = "Cancel";
            this.Cancel_B.UseVisualStyleBackColor = true;
            // 
            // Gen_RandomText
            // 
            this.Gen_RandomText.Location = new System.Drawing.Point(193, 12);
            this.Gen_RandomText.Name = "Gen_RandomText";
            this.Gen_RandomText.Size = new System.Drawing.Size(77, 76);
            this.Gen_RandomText.TabIndex = 4;
            this.Gen_RandomText.Text = "Random Seed";
            this.Gen_RandomText.UseVisualStyleBackColor = true;
            this.Gen_RandomText.Click += new System.EventHandler(this.Gen_RandomText_Click);
            // 
            // GetSeedForRand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 111);
            this.Controls.Add(this.Gen_RandomText);
            this.Controls.Add(this.Cancel_B);
            this.Controls.Add(this.Accept_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpSeed);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetSeedForRand";
            this.Text = "SeedDialog";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Accept_B;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.Button Gen_RandomText;
    }
}