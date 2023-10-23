namespace button._36
{
    partial class Form1
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
            this.lstSebzeler = new System.Windows.Forms.ListBox();
            this.lstTum = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstMeyveler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstSebzeler
            // 
            this.lstSebzeler.FormattingEnabled = true;
            this.lstSebzeler.Items.AddRange(new object[] {
            "BÜŞRA",
            "KELEK",
            "ACUR",
            "HIYAr",
            ""});
            this.lstSebzeler.Location = new System.Drawing.Point(268, 24);
            this.lstSebzeler.Name = "lstSebzeler";
            this.lstSebzeler.Size = new System.Drawing.Size(93, 238);
            this.lstSebzeler.TabIndex = 1;
            // 
            // lstTum
            // 
            this.lstTum.FormattingEnabled = true;
            this.lstTum.Items.AddRange(new object[] {
            "SALATALIK",
            "KIVIRCIK",
            "HAVUÇ",
            "VİŞNE",
            "MUZ",
            "KAVUN"});
            this.lstTum.Location = new System.Drawing.Point(22, 24);
            this.lstTum.Name = "lstTum";
            this.lstTum.Size = new System.Drawing.Size(93, 238);
            this.lstTum.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(22, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 88);
            this.button1.TabIndex = 3;
            this.button1.Text = "AKTARABİLİRSEN AKTAR GEL CPAZArlarıma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstMeyveler
            // 
            this.lstMeyveler.FormattingEnabled = true;
            this.lstMeyveler.Items.AddRange(new object[] {
            "ŞEFTALİ",
            "NEKTARİ",
            "KİRAZ",
            "GARPUX",
            ""});
            this.lstMeyveler.Location = new System.Drawing.Point(144, 24);
            this.lstMeyveler.Name = "lstMeyveler";
            this.lstMeyveler.Size = new System.Drawing.Size(93, 238);
            this.lstMeyveler.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 402);
            this.Controls.Add(this.lstMeyveler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstTum);
            this.Controls.Add(this.lstSebzeler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSebzeler;
        private System.Windows.Forms.ListBox lstTum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstMeyveler;
    }
}

