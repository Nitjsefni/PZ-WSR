namespace RM
{
    partial class oknoEdycjaPacjenta
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
            this.dod_pacjentaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.data_przyj_pick = new System.Windows.Forms.DateTimePicker();
            this.opis_box = new System.Windows.Forms.RichTextBox();
            this.pesel_box = new System.Windows.Forms.TextBox();
            this.imie_box = new System.Windows.Forms.TextBox();
            this.nazwisko_box = new System.Windows.Forms.TextBox();
            this.nr_ubez_box = new System.Windows.Forms.TextBox();
            this.kod_pocz_box = new System.Windows.Forms.TextBox();
            this.ulica_box = new System.Windows.Forms.TextBox();
            this.miejscowosc_box = new System.Windows.Forms.TextBox();
            this.lekarz_box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dod_pacjentaBtn
            // 
            this.dod_pacjentaBtn.Location = new System.Drawing.Point(64, 539);
            this.dod_pacjentaBtn.Name = "dod_pacjentaBtn";
            this.dod_pacjentaBtn.Size = new System.Drawing.Size(332, 41);
            this.dod_pacjentaBtn.TabIndex = 0;
            this.dod_pacjentaBtn.Text = "Dodaj pacjenta";
            this.dod_pacjentaBtn.UseVisualStyleBackColor = true;
            this.dod_pacjentaBtn.Click += new System.EventHandler(this.dodajPacjenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(91, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesel*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(20, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numer\r\nubezpieczenia*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(60, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nazwisko*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(101, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Imię*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(21, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data przyjęcia*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(35, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Miejscowość*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(95, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ulica*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(25, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kod pocztowy*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(41, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 40);
            this.label8.TabIndex = 14;
            this.label8.Text = "Lekarz\r\nprowadzący";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(91, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Opis";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // data_przyj_pick
            // 
            this.data_przyj_pick.Location = new System.Drawing.Point(161, 209);
            this.data_przyj_pick.MaxDate = new System.DateTime(2014, 1, 30, 23, 18, 41, 486);
            this.data_przyj_pick.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.data_przyj_pick.Name = "data_przyj_pick";
            this.data_przyj_pick.Size = new System.Drawing.Size(228, 20);
            this.data_przyj_pick.TabIndex = 17;
            this.data_przyj_pick.Value = new System.DateTime(2014, 1, 16, 0, 0, 0, 0);
            // 
            // opis_box
            // 
            this.opis_box.Location = new System.Drawing.Point(161, 437);
            this.opis_box.Name = "opis_box";
            this.opis_box.Size = new System.Drawing.Size(228, 96);
            this.opis_box.TabIndex = 18;
            this.opis_box.Text = "";
            // 
            // pesel_box
            // 
            this.pesel_box.Location = new System.Drawing.Point(161, 27);
            this.pesel_box.Name = "pesel_box";
            this.pesel_box.Size = new System.Drawing.Size(228, 20);
            this.pesel_box.TabIndex = 19;
            // 
            // imie_box
            // 
            this.imie_box.Location = new System.Drawing.Point(161, 65);
            this.imie_box.Name = "imie_box";
            this.imie_box.Size = new System.Drawing.Size(228, 20);
            this.imie_box.TabIndex = 20;
            // 
            // nazwisko_box
            // 
            this.nazwisko_box.Location = new System.Drawing.Point(161, 103);
            this.nazwisko_box.Name = "nazwisko_box";
            this.nazwisko_box.Size = new System.Drawing.Size(228, 20);
            this.nazwisko_box.TabIndex = 21;
            // 
            // nr_ubez_box
            // 
            this.nr_ubez_box.Location = new System.Drawing.Point(161, 156);
            this.nr_ubez_box.Name = "nr_ubez_box";
            this.nr_ubez_box.Size = new System.Drawing.Size(228, 20);
            this.nr_ubez_box.TabIndex = 22;
            // 
            // kod_pocz_box
            // 
            this.kod_pocz_box.Location = new System.Drawing.Point(161, 304);
            this.kod_pocz_box.Name = "kod_pocz_box";
            this.kod_pocz_box.Size = new System.Drawing.Size(228, 20);
            this.kod_pocz_box.TabIndex = 24;
            // 
            // ulica_box
            // 
            this.ulica_box.Location = new System.Drawing.Point(161, 349);
            this.ulica_box.Name = "ulica_box";
            this.ulica_box.Size = new System.Drawing.Size(228, 20);
            this.ulica_box.TabIndex = 25;
            // 
            // miejscowosc_box
            // 
            this.miejscowosc_box.Location = new System.Drawing.Point(161, 260);
            this.miejscowosc_box.Name = "miejscowosc_box";
            this.miejscowosc_box.Size = new System.Drawing.Size(228, 20);
            this.miejscowosc_box.TabIndex = 26;
            // 
            // lekarz_box
            // 
            this.lekarz_box.Location = new System.Drawing.Point(161, 396);
            this.lekarz_box.Name = "lekarz_box";
            this.lekarz_box.Size = new System.Drawing.Size(228, 20);
            this.lekarz_box.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 588);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "* - pola wymagane";
            // 
            // oknoEdycjaPacjenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 610);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lekarz_box);
            this.Controls.Add(this.miejscowosc_box);
            this.Controls.Add(this.ulica_box);
            this.Controls.Add(this.kod_pocz_box);
            this.Controls.Add(this.nr_ubez_box);
            this.Controls.Add(this.nazwisko_box);
            this.Controls.Add(this.imie_box);
            this.Controls.Add(this.pesel_box);
            this.Controls.Add(this.opis_box);
            this.Controls.Add(this.data_przyj_pick);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dod_pacjentaBtn);
            this.Name = "oknoEdycjaPacjenta";
            this.Text = "Dodaj pacjenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dod_pacjentaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker data_przyj_pick;
        private System.Windows.Forms.RichTextBox opis_box;
        private System.Windows.Forms.TextBox pesel_box;
        private System.Windows.Forms.TextBox imie_box;
        private System.Windows.Forms.TextBox nazwisko_box;
        private System.Windows.Forms.TextBox nr_ubez_box;
        private System.Windows.Forms.TextBox kod_pocz_box;
        private System.Windows.Forms.TextBox ulica_box;
        private System.Windows.Forms.TextBox miejscowosc_box;
        private System.Windows.Forms.TextBox lekarz_box;
        private System.Windows.Forms.Label label11;
    }
}