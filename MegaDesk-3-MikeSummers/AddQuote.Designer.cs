namespace MegaDesk_3_MikeSummers
{
    partial class AddQuote
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
            this.CancelAddQuote = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.GetQuoteBtn = new System.Windows.Forms.Button();
            this.widthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelAddQuote
            // 
            this.CancelAddQuote.Location = new System.Drawing.Point(12, 226);
            this.CancelAddQuote.Name = "CancelAddQuote";
            this.CancelAddQuote.Size = new System.Drawing.Size(75, 23);
            this.CancelAddQuote.TabIndex = 0;
            this.CancelAddQuote.Text = "Cancel";
            this.CancelAddQuote.UseVisualStyleBackColor = true;
            this.CancelAddQuote.Click += new System.EventHandler(this.CancelAddQuote_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date:";
            this.dateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(12, 37);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(67, 13);
            this.clientNameLabel.TabIndex = 2;
            this.clientNameLabel.Text = "Client Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desk Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Desk Depth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Material:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Drawers:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rush Days:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 8;
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(85, 60);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(186, 20);
            this.widthInput.TabIndex = 9;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.validatingWidth);
            this.widthInput.Validated += new System.EventHandler(this.validatedWidth);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateDepth);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.listBox1.Location = new System.Drawing.Point(85, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 17);
            this.listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.listBox2.Location = new System.Drawing.Point(85, 139);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(187, 17);
            this.listBox2.TabIndex = 12;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "14 (default - no rush)",
            "7",
            "5",
            "3"});
            this.listBox3.Location = new System.Drawing.Point(85, 162);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(187, 17);
            this.listBox3.TabIndex = 13;
            // 
            // GetQuoteBtn
            // 
            this.GetQuoteBtn.Location = new System.Drawing.Point(197, 226);
            this.GetQuoteBtn.Name = "GetQuoteBtn";
            this.GetQuoteBtn.Size = new System.Drawing.Size(75, 23);
            this.GetQuoteBtn.TabIndex = 14;
            this.GetQuoteBtn.Text = "Get Quote";
            this.GetQuoteBtn.UseVisualStyleBackColor = true;
            // 
            // widthErrorProvider
            // 
            this.widthErrorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.GetQuoteBtn);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.CancelAddQuote);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelAddQuote;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button GetQuoteBtn;
        private System.Windows.Forms.ErrorProvider widthErrorProvider;
    }
}