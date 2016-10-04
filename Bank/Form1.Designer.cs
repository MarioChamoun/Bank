namespace Bank
{
    partial class Bank
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
            this.btnVisa = new System.Windows.Forms.Button();
            this.txtPersonmr = new System.Windows.Forms.TextBox();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPersonnummer = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblNamn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(175, 23);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(75, 23);
            this.btnVisa.TabIndex = 0;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // txtPersonmr
            // 
            this.txtPersonmr.Location = new System.Drawing.Point(12, 23);
            this.txtPersonmr.Name = "txtPersonmr";
            this.txtPersonmr.Size = new System.Drawing.Size(157, 20);
            this.txtPersonmr.TabIndex = 1;
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(12, 76);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.ReadOnly = true;
            this.txtNamn.Size = new System.Drawing.Size(105, 20);
            this.txtNamn.TabIndex = 2;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(145, 76);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.ReadOnly = true;
            this.txtAdress.Size = new System.Drawing.Size(105, 20);
            this.txtAdress.TabIndex = 3;
            // 
            // txtPersonnummer
            // 
            this.txtPersonnummer.Location = new System.Drawing.Point(12, 120);
            this.txtPersonnummer.Name = "txtPersonnummer";
            this.txtPersonnummer.ReadOnly = true;
            this.txtPersonnummer.Size = new System.Drawing.Size(105, 20);
            this.txtPersonnummer.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(145, 120);
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = true;
            this.txtMail.Size = new System.Drawing.Size(105, 20);
            this.txtMail.TabIndex = 5;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(91, 171);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(69, 20);
            this.txtSaldo.TabIndex = 6;
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(12, 60);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(35, 13);
            this.lblNamn.TabIndex = 7;
            this.lblNamn.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Personnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Personnummer";
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPersonnummer);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.txtPersonmr);
            this.Controls.Add(this.btnVisa);
            this.Name = "Bank";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Bank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.TextBox txtPersonmr;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPersonnummer;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}

