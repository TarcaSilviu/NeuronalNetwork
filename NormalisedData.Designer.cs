
namespace IAProiect3
{
    partial class NormalisedData
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
            this.normalisedDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.normalisedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // normalisedDataGridView
            // 
            this.normalisedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.normalisedDataGridView.Location = new System.Drawing.Point(13, 13);
            this.normalisedDataGridView.Name = "normalisedDataGridView";
            this.normalisedDataGridView.Size = new System.Drawing.Size(762, 425);
            this.normalisedDataGridView.TabIndex = 0;
            // 
            // NormalisedData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.normalisedDataGridView);
            this.Name = "NormalisedData";
            this.Text = "NormalisedData";
            ((System.ComponentModel.ISupportInitialize)(this.normalisedDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView normalisedDataGridView;
    }
}