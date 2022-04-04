namespace Praktikum_Quiz_Panda_Elyora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblmasuk = new System.Windows.Forms.Label();
            this.txtboxKalimat = new System.Windows.Forms.TextBox();
            this.lblhuruf = new System.Windows.Forms.Label();
            this.txtboxAwal = new System.Windows.Forms.TextBox();
            this.lblMenjadi = new System.Windows.Forms.Label();
            this.txtboxAkhir = new System.Windows.Forms.TextBox();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmasuk
            // 
            this.lblmasuk.AutoSize = true;
            this.lblmasuk.Location = new System.Drawing.Point(43, 45);
            this.lblmasuk.Name = "lblmasuk";
            this.lblmasuk.Size = new System.Drawing.Size(155, 25);
            this.lblmasuk.TabIndex = 0;
            this.lblmasuk.Text = "Masukkan Kalimat";
            this.lblmasuk.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxKalimat
            // 
            this.txtboxKalimat.Location = new System.Drawing.Point(204, 45);
            this.txtboxKalimat.Name = "txtboxKalimat";
            this.txtboxKalimat.Size = new System.Drawing.Size(403, 31);
            this.txtboxKalimat.TabIndex = 1;
            this.txtboxKalimat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblhuruf
            // 
            this.lblhuruf.AutoSize = true;
            this.lblhuruf.Location = new System.Drawing.Point(43, 103);
            this.lblhuruf.Name = "lblhuruf";
            this.lblhuruf.Size = new System.Drawing.Size(142, 25);
            this.lblhuruf.TabIndex = 2;
            this.lblhuruf.Text = "Masukkan Huruf";
            // 
            // txtboxAwal
            // 
            this.txtboxAwal.Location = new System.Drawing.Point(204, 103);
            this.txtboxAwal.Name = "txtboxAwal";
            this.txtboxAwal.Size = new System.Drawing.Size(136, 31);
            this.txtboxAwal.TabIndex = 3;
            // 
            // lblMenjadi
            // 
            this.lblMenjadi.AutoSize = true;
            this.lblMenjadi.Location = new System.Drawing.Point(418, 106);
            this.lblMenjadi.Name = "lblMenjadi";
            this.lblMenjadi.Size = new System.Drawing.Size(75, 25);
            this.lblMenjadi.TabIndex = 4;
            this.lblMenjadi.Text = "Menjadi";
            // 
            // txtboxAkhir
            // 
            this.txtboxAkhir.Location = new System.Drawing.Point(499, 103);
            this.txtboxAkhir.Name = "txtboxAkhir";
            this.txtboxAkhir.Size = new System.Drawing.Size(108, 31);
            this.txtboxAkhir.TabIndex = 5;
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(276, 185);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(217, 34);
            this.btnKonversi.TabIndex = 6;
            this.btnKonversi.Text = "Konversi!";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(105, 278);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(64, 25);
            this.labelHasil.TabIndex = 7;
            this.labelHasil.Text = "Hasil : ";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(281, 278);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(59, 25);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "label5";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.txtboxAkhir);
            this.Controls.Add(this.lblMenjadi);
            this.Controls.Add(this.txtboxAwal);
            this.Controls.Add(this.lblhuruf);
            this.Controls.Add(this.txtboxKalimat);
            this.Controls.Add(this.lblmasuk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblmasuk;
        private TextBox txtboxKalimat;
        private Label lblhuruf;
        private TextBox txtboxAwal;
        private Label lblMenjadi;
        private TextBox txtboxAkhir;
        private Button btnKonversi;
        private Label labelHasil;
        private Label lblOutput;
    }
}