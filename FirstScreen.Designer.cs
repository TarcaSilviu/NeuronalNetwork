
namespace IAProiect3
{
    partial class FirstScreen
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
            this.normalisedListBtn = new System.Windows.Forms.Button();
            this.graphBtn = new System.Windows.Forms.Button();
            this.testListBtn = new System.Windows.Forms.Button();
            this.normalisedTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Training List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // normalisedListBtn
            // 
            this.normalisedListBtn.Location = new System.Drawing.Point(340, 13);
            this.normalisedListBtn.Name = "normalisedListBtn";
            this.normalisedListBtn.Size = new System.Drawing.Size(173, 48);
            this.normalisedListBtn.TabIndex = 1;
            this.normalisedListBtn.Text = "Normalised Training List";
            this.normalisedListBtn.UseVisualStyleBackColor = true;
            this.normalisedListBtn.Click += new System.EventHandler(this.normalisedListBtn_Click);
            // 
            // graphBtn
            // 
            this.graphBtn.Location = new System.Drawing.Point(174, 229);
            this.graphBtn.Name = "graphBtn";
            this.graphBtn.Size = new System.Drawing.Size(173, 48);
            this.graphBtn.TabIndex = 2;
            this.graphBtn.Text = "Train";
            this.graphBtn.UseVisualStyleBackColor = true;
            this.graphBtn.Click += new System.EventHandler(this.graphBtn_Click);
            // 
            // testListBtn
            // 
            this.testListBtn.Location = new System.Drawing.Point(14, 115);
            this.testListBtn.Name = "testListBtn";
            this.testListBtn.Size = new System.Drawing.Size(173, 47);
            this.testListBtn.TabIndex = 3;
            this.testListBtn.Text = "Test List";
            this.testListBtn.UseVisualStyleBackColor = true;
            this.testListBtn.Click += new System.EventHandler(this.testListBtn_Click);
            // 
            // normalisedTestBtn
            // 
            this.normalisedTestBtn.Location = new System.Drawing.Point(340, 115);
            this.normalisedTestBtn.Name = "normalisedTestBtn";
            this.normalisedTestBtn.Size = new System.Drawing.Size(173, 47);
            this.normalisedTestBtn.TabIndex = 4;
            this.normalisedTestBtn.Text = "Normalised Test List";
            this.normalisedTestBtn.UseVisualStyleBackColor = true;
            this.normalisedTestBtn.Click += new System.EventHandler(this.normalisedTestBtn_Click);
            // 
            // FirstScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 503);
            this.Controls.Add(this.normalisedTestBtn);
            this.Controls.Add(this.testListBtn);
            this.Controls.Add(this.graphBtn);
            this.Controls.Add(this.normalisedListBtn);
            this.Controls.Add(this.button1);
            this.Name = "FirstScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button normalisedListBtn;
        private System.Windows.Forms.Button graphBtn;
        private System.Windows.Forms.Button testListBtn;
        private System.Windows.Forms.Button normalisedTestBtn;
    }
}

