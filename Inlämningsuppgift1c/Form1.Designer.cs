namespace Inlämningsuppgift1c
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEpost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPostnummer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.txtSokRuta = new System.Windows.Forms.TextBox();
            this.buttonSpara = new System.Windows.Forms.Button();
            this.buttonSok = new System.Windows.Forms.Button();
            this.buttonVisa = new System.Windows.Forms.Button();
            this.buttonRadera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(379, 260);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(556, 33);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(326, 22);
            this.txtNamn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adress";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(556, 74);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(326, 22);
            this.txtAdress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(556, 117);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(326, 22);
            this.txtTelefon.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Epost";
            // 
            // txtEpost
            // 
            this.txtEpost.Location = new System.Drawing.Point(556, 162);
            this.txtEpost.Name = "txtEpost";
            this.txtEpost.Size = new System.Drawing.Size(326, 22);
            this.txtEpost.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Postnummer";
            // 
            // txtPostnummer
            // 
            this.txtPostnummer.Location = new System.Drawing.Point(556, 207);
            this.txtPostnummer.Name = "txtPostnummer";
            this.txtPostnummer.Size = new System.Drawing.Size(326, 22);
            this.txtPostnummer.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ort";
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(556, 251);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(326, 22);
            this.txtOrt.TabIndex = 11;
            // 
            // txtSokRuta
            // 
            this.txtSokRuta.Location = new System.Drawing.Point(446, 349);
            this.txtSokRuta.Name = "txtSokRuta";
            this.txtSokRuta.Size = new System.Drawing.Size(518, 22);
            this.txtSokRuta.TabIndex = 13;
            // 
            // buttonSpara
            // 
            this.buttonSpara.Location = new System.Drawing.Point(556, 293);
            this.buttonSpara.Name = "buttonSpara";
            this.buttonSpara.Size = new System.Drawing.Size(75, 31);
            this.buttonSpara.TabIndex = 14;
            this.buttonSpara.Text = "Spara";
            this.buttonSpara.UseVisualStyleBackColor = true;
            this.buttonSpara.Click += new System.EventHandler(this.buttonSpara_Click);
            // 
            // buttonSok
            // 
            this.buttonSok.Location = new System.Drawing.Point(446, 388);
            this.buttonSok.Name = "buttonSok";
            this.buttonSok.Size = new System.Drawing.Size(75, 29);
            this.buttonSok.TabIndex = 15;
            this.buttonSok.Text = "Sök";
            this.buttonSok.UseVisualStyleBackColor = true;
            this.buttonSok.Click += new System.EventHandler(this.buttonSok_Click);
            // 
            // buttonVisa
            // 
            this.buttonVisa.Location = new System.Drawing.Point(12, 292);
            this.buttonVisa.Name = "buttonVisa";
            this.buttonVisa.Size = new System.Drawing.Size(152, 32);
            this.buttonVisa.TabIndex = 16;
            this.buttonVisa.Text = "Visa Adresslista";
            this.buttonVisa.UseVisualStyleBackColor = true;
            this.buttonVisa.Click += new System.EventHandler(this.buttonVisa_Click);
            // 
            // buttonRadera
            // 
            this.buttonRadera.Location = new System.Drawing.Point(239, 292);
            this.buttonRadera.Name = "buttonRadera";
            this.buttonRadera.Size = new System.Drawing.Size(152, 32);
            this.buttonRadera.TabIndex = 17;
            this.buttonRadera.Text = "Radera Uppgifter";
            this.buttonRadera.UseVisualStyleBackColor = true;
            this.buttonRadera.Click += new System.EventHandler(this.buttonRadera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 474);
            this.Controls.Add(this.buttonRadera);
            this.Controls.Add(this.buttonVisa);
            this.Controls.Add(this.buttonSok);
            this.Controls.Add(this.buttonSpara);
            this.Controls.Add(this.txtSokRuta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPostnummer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEpost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Adressbok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEpost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPostnummer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.TextBox txtSokRuta;
        private System.Windows.Forms.Button buttonSpara;
        private System.Windows.Forms.Button buttonSok;
        private System.Windows.Forms.Button buttonVisa;
        private System.Windows.Forms.Button buttonRadera;
    }
}

