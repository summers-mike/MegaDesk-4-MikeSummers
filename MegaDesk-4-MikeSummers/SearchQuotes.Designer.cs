namespace MegaDesk_4_MikeSummers
{
    partial class SearchQuotes
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
            this.CancelSearchQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelSearchQuotes
            // 
            this.CancelSearchQuotes.Location = new System.Drawing.Point(114, 210);
            this.CancelSearchQuotes.Name = "CancelSearchQuotes";
            this.CancelSearchQuotes.Size = new System.Drawing.Size(75, 23);
            this.CancelSearchQuotes.TabIndex = 0;
            this.CancelSearchQuotes.Text = "Cancel";
            this.CancelSearchQuotes.UseVisualStyleBackColor = true;
            this.CancelSearchQuotes.Click += new System.EventHandler(this.CancelSearchQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CancelSearchQuotes);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelSearchQuotes;
    }
}