namespace XmlDovizApp
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
            this.lstvDovizler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDovizGetir = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstvDovizler
            // 
            this.lstvDovizler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvDovizler.FullRowSelect = true;
            this.lstvDovizler.GridLines = true;
            this.lstvDovizler.Location = new System.Drawing.Point(12, 49);
            this.lstvDovizler.Name = "lstvDovizler";
            this.lstvDovizler.Size = new System.Drawing.Size(553, 282);
            this.lstvDovizler.TabIndex = 0;
            this.lstvDovizler.UseCompatibleStateImageBehavior = false;
            this.lstvDovizler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Alış Fiyatı";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Satış Fiyatı";
            this.columnHeader3.Width = 120;
            // 
            // btnDovizGetir
            // 
            this.btnDovizGetir.Location = new System.Drawing.Point(13, 13);
            this.btnDovizGetir.Name = "btnDovizGetir";
            this.btnDovizGetir.Size = new System.Drawing.Size(75, 23);
            this.btnDovizGetir.TabIndex = 1;
            this.btnDovizGetir.Text = "Döviz Getir";
            this.btnDovizGetir.UseVisualStyleBackColor = true;
            this.btnDovizGetir.Click += new System.EventHandler(this.btnDovizGetir_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(113, 13);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 24);
            this.lblTarih.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 343);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnDovizGetir);
            this.Controls.Add(this.lstvDovizler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doviz Kurları v1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvDovizler;
        private System.Windows.Forms.Button btnDovizGetir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblTarih;
    }
}

