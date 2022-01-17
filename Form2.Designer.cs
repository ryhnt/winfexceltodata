
namespace winfexcel
{
    partial class Form2
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
            this.datag = new System.Windows.Forms.DataGridView();
            this.secim = new System.Windows.Forms.Button();
            this.aktar = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.datag)).BeginInit();
            this.SuspendLayout();
            // 
            // datag
            // 
            this.datag.AllowUserToAddRows = false;
            this.datag.AllowUserToDeleteRows = false;
            this.datag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datag.Location = new System.Drawing.Point(97, 48);
            this.datag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datag.Name = "datag";
            this.datag.ReadOnly = true;
            this.datag.RowHeadersWidth = 51;
            this.datag.Size = new System.Drawing.Size(795, 332);
            this.datag.TabIndex = 0;
            this.datag.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // secim
            // 
            this.secim.Location = new System.Drawing.Point(455, 452);
            this.secim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.secim.Name = "secim";
            this.secim.Size = new System.Drawing.Size(100, 28);
            this.secim.TabIndex = 1;
            this.secim.Text = "Seçim";
            this.secim.UseVisualStyleBackColor = true;
            this.secim.Click += new System.EventHandler(this.Aktar_Click);
            // 
            // aktar
            // 
            this.aktar.Location = new System.Drawing.Point(597, 452);
            this.aktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aktar.Name = "aktar";
            this.aktar.Size = new System.Drawing.Size(100, 28);
            this.aktar.TabIndex = 2;
            this.aktar.Text = "Aktar";
            this.aktar.UseVisualStyleBackColor = true;
            this.aktar.Click += new System.EventHandler(this.aktar_Click_1);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(751, 452);
            this.cikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(100, 28);
            this.cikis.TabIndex = 3;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.aktar);
            this.Controls.Add(this.secim);
            this.Controls.Add(this.datag);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datag;
        private System.Windows.Forms.Button secim;
        private System.Windows.Forms.Button aktar;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}