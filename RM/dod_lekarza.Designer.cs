namespace RM
{
    partial class dod_lekarza
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
            this.nazw_box = new System.Windows.Forms.TextBox();
            this.imie_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dod_lekarza_okno = new System.Windows.Forms.Button();
            this.stanowisko_box = new System.Windows.Forms.TextBox();
            this.specj_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nazw_box
            // 
            this.nazw_box.Location = new System.Drawing.Point(165, 96);
            this.nazw_box.Name = "nazw_box";
            this.nazw_box.Size = new System.Drawing.Size(228, 20);
            this.nazw_box.TabIndex = 56;
            // 
            // imie_box
            // 
            this.imie_box.Location = new System.Drawing.Point(165, 55);
            this.imie_box.Name = "imie_box";
            this.imie_box.Size = new System.Drawing.Size(228, 20);
            this.imie_box.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(73, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(60, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Stanowisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(45, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Specjalizacja";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(107, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Imię";
            // 
            // dod_lekarza_okno
            // 
            this.dod_lekarza_okno.Location = new System.Drawing.Point(63, 243);
            this.dod_lekarza_okno.Name = "dod_lekarza_okno";
            this.dod_lekarza_okno.Size = new System.Drawing.Size(332, 41);
            this.dod_lekarza_okno.TabIndex = 46;
            this.dod_lekarza_okno.Text = "Dodaj lekarza";
            this.dod_lekarza_okno.UseVisualStyleBackColor = true;
            this.dod_lekarza_okno.Click += new System.EventHandler(this.dod_lekarza_okno_Click);
            // 
            // stanowisko_box
            // 
            this.stanowisko_box.Location = new System.Drawing.Point(165, 137);
            this.stanowisko_box.Name = "stanowisko_box";
            this.stanowisko_box.Size = new System.Drawing.Size(228, 20);
            this.stanowisko_box.TabIndex = 59;
            // 
            // specj_box
            // 
            this.specj_box.Location = new System.Drawing.Point(164, 179);
            this.specj_box.Name = "specj_box";
            this.specj_box.Size = new System.Drawing.Size(228, 20);
            this.specj_box.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(121, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "ID";
            // 
            // ID_box
            // 
            this.ID_box.Location = new System.Drawing.Point(164, 18);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(228, 20);
            this.ID_box.TabIndex = 62;
            // 
            // dod_lekarza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 317);
            this.Controls.Add(this.ID_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specj_box);
            this.Controls.Add(this.stanowisko_box);
            this.Controls.Add(this.nazw_box);
            this.Controls.Add(this.imie_box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dod_lekarza_okno);
            this.Name = "dod_lekarza";
            this.Text = "Dodaj lekarza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nazw_box;
        private System.Windows.Forms.TextBox imie_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dod_lekarza_okno;
        private System.Windows.Forms.TextBox stanowisko_box;
        private System.Windows.Forms.TextBox specj_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID_box;
    }
}