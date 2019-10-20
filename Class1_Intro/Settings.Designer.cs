namespace Class1_Intro
{
    partial class Settings
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
            this.tooltip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UHeight1 = new System.Windows.Forms.NumericUpDown();
            this.UWidth1 = new System.Windows.Forms.NumericUpDown();
            this.Milli = new System.Windows.Forms.NumericUpDown();
            this.UniverseHeight = new System.Windows.Forms.Label();
            this.UniverseWidth = new System.Windows.Forms.Label();
            this.MilliSeconds = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UHeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UWidth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Milli)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tooltip1
            // 
            this.tooltip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-7, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 212);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UHeight1);
            this.tabPage1.Controls.Add(this.UWidth1);
            this.tabPage1.Controls.Add(this.Milli);
            this.tabPage1.Controls.Add(this.UniverseHeight);
            this.tabPage1.Controls.Add(this.UniverseWidth);
            this.tabPage1.Controls.Add(this.MilliSeconds);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // UHeight1
            // 
            this.UHeight1.Location = new System.Drawing.Point(225, 93);
            this.UHeight1.Name = "UHeight1";
            this.UHeight1.Size = new System.Drawing.Size(80, 22);
            this.UHeight1.TabIndex = 12;
            this.UHeight1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // UWidth1
            // 
            this.UWidth1.Location = new System.Drawing.Point(225, 50);
            this.UWidth1.Name = "UWidth1";
            this.UWidth1.Size = new System.Drawing.Size(80, 22);
            this.UWidth1.TabIndex = 11;
            this.UWidth1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Milli
            // 
            this.Milli.Location = new System.Drawing.Point(225, 13);
            this.Milli.Name = "Milli";
            this.Milli.Size = new System.Drawing.Size(80, 22);
            this.Milli.TabIndex = 10;
            this.Milli.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // UniverseHeight
            // 
            this.UniverseHeight.AutoSize = true;
            this.UniverseHeight.Location = new System.Drawing.Point(17, 93);
            this.UniverseHeight.Name = "UniverseHeight";
            this.UniverseHeight.Size = new System.Drawing.Size(174, 17);
            this.UniverseHeight.TabIndex = 9;
            this.UniverseHeight.Text = "Height of Universe in Cells";
            // 
            // UniverseWidth
            // 
            this.UniverseWidth.AutoSize = true;
            this.UniverseWidth.Location = new System.Drawing.Point(17, 52);
            this.UniverseWidth.Name = "UniverseWidth";
            this.UniverseWidth.Size = new System.Drawing.Size(169, 17);
            this.UniverseWidth.TabIndex = 8;
            this.UniverseWidth.Text = "Width of Universe in Cells";
            // 
            // MilliSeconds
            // 
            this.MilliSeconds.AutoSize = true;
            this.MilliSeconds.Location = new System.Drawing.Point(17, 15);
            this.MilliSeconds.Name = "MilliSeconds";
            this.MilliSeconds.Size = new System.Drawing.Size(189, 17);
            this.MilliSeconds.TabIndex = 7;
            this.MilliSeconds.Text = "Timer Interval in Milliseconds";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Live Cell Color";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(28, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(40, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(28, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(40, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(28, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(40, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Background Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grid Color";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "GColor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "BColor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "Lcolor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.Location = new System.Drawing.Point(27, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 30);
            this.button4.TabIndex = 1;
            this.button4.Text = "Ok";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(188, 220);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(108, 30);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 256);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UHeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UWidth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Milli)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip tooltip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown UHeight1;
        private System.Windows.Forms.NumericUpDown UWidth1;
        private System.Windows.Forms.NumericUpDown Milli;
        private System.Windows.Forms.Label UniverseHeight;
        private System.Windows.Forms.Label UniverseWidth;
        private System.Windows.Forms.Label MilliSeconds;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Cancel;
    }
}