
namespace IAProiect3
{
    partial class Configuration
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
            this.learningRateNU = new System.Windows.Forms.NumericUpDown();
            this.hiddenLayersNU = new System.Windows.Forms.NumericUpDown();
            this.hiddenLayer1NeuronsNU = new System.Windows.Forms.NumericUpDown();
            this.hiddenLayer2NeuronsNU = new System.Windows.Forms.NumericUpDown();
            this.hiddenLayer3NeuronsNU = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.epsilonNU = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.learningRateNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenLayersNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenLayer1NeuronsNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenLayer2NeuronsNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenLayer3NeuronsNU)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epsilonNU)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Learning Rate";
            // 
            // learningRateNU
            // 
            this.learningRateNU.DecimalPlaces = 5;
            this.learningRateNU.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.learningRateNU.Location = new System.Drawing.Point(106, 26);
            this.learningRateNU.Name = "learningRateNU";
            this.learningRateNU.Size = new System.Drawing.Size(120, 20);
            this.learningRateNU.TabIndex = 1;
            this.learningRateNU.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.learningRateNU.ValueChanged += new System.EventHandler(this.learningRateNU_ValueChanged);
            // 
            // hiddenLayersNU
            // 
            this.hiddenLayersNU.Location = new System.Drawing.Point(106, 146);
            this.hiddenLayersNU.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.hiddenLayersNU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hiddenLayersNU.Name = "hiddenLayersNU";
            this.hiddenLayersNU.Size = new System.Drawing.Size(120, 20);
            this.hiddenLayersNU.TabIndex = 2;
            this.hiddenLayersNU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hiddenLayersNU.ValueChanged += new System.EventHandler(this.hiddenLayersNU_ValueChanged);
            // 
            // hiddenLayer1NeuronsNU
            // 
            this.hiddenLayer1NeuronsNU.Location = new System.Drawing.Point(164, 41);
            this.hiddenLayer1NeuronsNU.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hiddenLayer1NeuronsNU.Name = "hiddenLayer1NeuronsNU";
            this.hiddenLayer1NeuronsNU.Size = new System.Drawing.Size(120, 20);
            this.hiddenLayer1NeuronsNU.TabIndex = 3;
            this.hiddenLayer1NeuronsNU.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hiddenLayer1NeuronsNU.ValueChanged += new System.EventHandler(this.hiddenLayer1NeuronsNU_ValueChanged);
            // 
            // hiddenLayer2NeuronsNU
            // 
            this.hiddenLayer2NeuronsNU.Enabled = false;
            this.hiddenLayer2NeuronsNU.Location = new System.Drawing.Point(164, 116);
            this.hiddenLayer2NeuronsNU.Name = "hiddenLayer2NeuronsNU";
            this.hiddenLayer2NeuronsNU.Size = new System.Drawing.Size(120, 20);
            this.hiddenLayer2NeuronsNU.TabIndex = 4;
            this.hiddenLayer2NeuronsNU.ValueChanged += new System.EventHandler(this.hiddenLayer2NeuronsNU_ValueChanged);
            // 
            // hiddenLayer3NeuronsNU
            // 
            this.hiddenLayer3NeuronsNU.Enabled = false;
            this.hiddenLayer3NeuronsNU.Location = new System.Drawing.Point(164, 191);
            this.hiddenLayer3NeuronsNU.Name = "hiddenLayer3NeuronsNU";
            this.hiddenLayer3NeuronsNU.Size = new System.Drawing.Size(120, 20);
            this.hiddenLayer3NeuronsNU.TabIndex = 5;
            this.hiddenLayer3NeuronsNU.ValueChanged += new System.EventHandler(this.hiddenLayer3NeuronsNU_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.hiddenLayer1NeuronsNU);
            this.panel1.Controls.Add(this.hiddenLayer3NeuronsNU);
            this.panel1.Controls.Add(this.hiddenLayer2NeuronsNU);
            this.panel1.Location = new System.Drawing.Point(16, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 250);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hidden Layer 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hidden Layer 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hidden Layer 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hidden Layers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Desired error";
            // 
            // epsilonNU
            // 
            this.epsilonNU.DecimalPlaces = 5;
            this.epsilonNU.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.epsilonNU.Location = new System.Drawing.Point(106, 67);
            this.epsilonNU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.epsilonNU.Name = "epsilonNU";
            this.epsilonNU.Size = new System.Drawing.Size(120, 20);
            this.epsilonNU.TabIndex = 9;
            this.epsilonNU.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.epsilonNU.ValueChanged += new System.EventHandler(this.epsilonNU_ValueChanged);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 495);
            this.Controls.Add(this.epsilonNU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hiddenLayersNU);
            this.Controls.Add(this.learningRateNU);
            this.Controls.Add(this.label1);
            this.Name = "Configuration";
            this.Text = "Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.learningRateNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenLayersNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenLayer1NeuronsNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenLayer2NeuronsNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenLayer3NeuronsNU)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epsilonNU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown learningRateNU;
        private System.Windows.Forms.NumericUpDown hiddenLayersNU;
        private System.Windows.Forms.NumericUpDown hiddenLayer1NeuronsNU;
        private System.Windows.Forms.NumericUpDown hiddenLayer2NeuronsNU;
        private System.Windows.Forms.NumericUpDown hiddenLayer3NeuronsNU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown epsilonNU;
    }
}