﻿namespace RM
{
    partial class oknoEdycjaKaretki
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
            this.typ_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uwagi_box = new System.Windows.Forms.RichTextBox();
            this.dodaj_karetke_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_karetki_box = new System.Windows.Forms.TextBox();
            this.ID_skladu_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wyposazenie_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // typ_box
            // 
            this.typ_box.Location = new System.Drawing.Point(208, 57);
            this.typ_box.Name = "typ_box";
            this.typ_box.Size = new System.Drawing.Size(228, 20);
            this.typ_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Typ/Numer karetki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(62, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wyposażenie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(113, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Uwagi";
            // 
            // uwagi_box
            // 
            this.uwagi_box.Location = new System.Drawing.Point(208, 180);
            this.uwagi_box.Name = "uwagi_box";
            this.uwagi_box.Size = new System.Drawing.Size(228, 73);
            this.uwagi_box.TabIndex = 5;
            this.uwagi_box.Text = "";
            // 
            // dodaj_karetke_button
            // 
            this.dodaj_karetke_button.Location = new System.Drawing.Point(116, 274);
            this.dodaj_karetke_button.Name = "dodaj_karetke_button";
            this.dodaj_karetke_button.Size = new System.Drawing.Size(232, 42);
            this.dodaj_karetke_button.TabIndex = 6;
            this.dodaj_karetke_button.Text = "Dodaj";
            this.dodaj_karetke_button.UseVisualStyleBackColor = true;
            this.dodaj_karetke_button.Click += new System.EventHandler(this.dodaj_karetke_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(89, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Karetki";
            // 
            // ID_karetki_box
            // 
            this.ID_karetki_box.Location = new System.Drawing.Point(208, 21);
            this.ID_karetki_box.Name = "ID_karetki_box";
            this.ID_karetki_box.Size = new System.Drawing.Size(228, 20);
            this.ID_karetki_box.TabIndex = 8;
            // 
            // ID_skladu_box
            // 
            this.ID_skladu_box.Location = new System.Drawing.Point(208, 98);
            this.ID_skladu_box.Name = "ID_skladu_box";
            this.ID_skladu_box.Size = new System.Drawing.Size(228, 20);
            this.ID_skladu_box.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(88, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID składu";
            // 
            // wyposazenie_box
            // 
            this.wyposazenie_box.Location = new System.Drawing.Point(208, 135);
            this.wyposazenie_box.Name = "wyposazenie_box";
            this.wyposazenie_box.Size = new System.Drawing.Size(228, 20);
            this.wyposazenie_box.TabIndex = 11;
            // 
            // oknoEdycjaKaretki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 349);
            this.Controls.Add(this.wyposazenie_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ID_skladu_box);
            this.Controls.Add(this.ID_karetki_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dodaj_karetke_button);
            this.Controls.Add(this.uwagi_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typ_box);
            this.Name = "oknoEdycjaKaretki";
            this.Text = "oknoEdycjaKaretki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox typ_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox uwagi_box;
        private System.Windows.Forms.Button dodaj_karetke_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID_karetki_box;
        private System.Windows.Forms.TextBox ID_skladu_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wyposazenie_box;
    }
}