namespace MegaDesk_3_MikeSummers
{
    partial class DisplayQuote
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
            this.CancelDisplayQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelDisplayQuote
            // 
            this.CancelDisplayQuote.Location = new System.Drawing.Point(107, 214);
            this.CancelDisplayQuote.Name = "CancelDisplayQuote";
            this.CancelDisplayQuote.Size = new System.Drawing.Size(75, 23);
            this.CancelDisplayQuote.TabIndex = 0;
            this.CancelDisplayQuote.Text = "Cancel";
            this.CancelDisplayQuote.UseVisualStyleBackColor = true;
            this.CancelDisplayQuote.Click += new System.EventHandler(this.CancelDisplayQuote_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CancelDisplayQuote);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelDisplayQuote;
    }
}