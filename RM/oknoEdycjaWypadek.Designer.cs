namespace RM
{
    partial class oknoEdycjaWypadek
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
            this.telefon_zgl_box = new System.Windows.Forms.TextBox();
            this.typ_comboBox = new System.Windows.Forms.ComboBox();
            this.liczba_rannych_box = new System.Windows.Forms.TextBox();
            this.miejsce_box = new System.Windows.Forms.TextBox();
            this.opis_box = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dodaj_wypadek_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_wypadku_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // telefon_zgl_box
            // 
            this.telefon_zgl_box.Location = new System.Drawing.Point(222, 204);
            this.telefon_zgl_box.Name = "telefon_zgl_box";
            this.telefon_zgl_box.Size = new System.Drawing.Size(228, 20);
            this.telefon_zgl_box.TabIndex = 45;
            // 
            // typ_comboBox
            // 
            this.typ_comboBox.FormattingEnabled = true;
            this.typ_comboBox.Items.AddRange(new object[] {
            "Wypadek komunikacyjny",
            "Wypadek przemysłowy",
            "Wypadek mechaniczny",
            "Dziecko",
            "Zatrucie",
            "Nagłe zatrzymanie krążenia",
            "Omdlenie",
            "Atak epilesji",
            "Reakcja alergiczna",
            "Zawał"});
            this.typ_comboBox.Location = new System.Drawing.Point(222, 133);
            this.typ_comboBox.Name = "typ_comboBox";
            this.typ_comboBox.Size = new System.Drawing.Size(228, 21);
            this.typ_comboBox.TabIndex = 44;
            // 
            // liczba_rannych_box
            // 
            this.liczba_rannych_box.Location = new System.Drawing.Point(222, 93);
            this.liczba_rannych_box.Name = "liczba_rannych_box";
            this.liczba_rannych_box.Size = new System.Drawing.Size(228, 20);
            this.liczba_rannych_box.TabIndex = 41;
            // 
            // miejsce_box
            // 
            this.miejsce_box.Location = new System.Drawing.Point(222, 52);
            this.miejsce_box.Name = "miejsce_box";
            this.miejsce_box.Size = new System.Drawing.Size(228, 20);
            this.miejsce_box.TabIndex = 40;
            // 
            // opis_box
            // 
            this.opis_box.Location = new System.Drawing.Point(222, 267);
            this.opis_box.Name = "opis_box";
            this.opis_box.Size = new System.Drawing.Size(228, 96);
            this.opis_box.TabIndex = 39;
            this.opis_box.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 173);
            this.dateTimePicker1.MaxDate = new System.DateTime(2014, 1, 16, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.Value = new System.DateTime(2014, 1, 16, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(164, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Opis";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(92, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "Numer tel\r\nzgłaszającego";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(28, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Liczba poszkodowanych";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(104, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Typ wypadku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(82, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Data zgłoszenia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(77, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Miejsce wypadku";
            // 
            // dodaj_wypadek_button
            // 
            this.dodaj_wypadek_button.Location = new System.Drawing.Point(129, 393);
            this.dodaj_wypadek_button.Name = "dodaj_wypadek_button";
            this.dodaj_wypadek_button.Size = new System.Drawing.Size(321, 41);
            this.dodaj_wypadek_button.TabIndex = 26;
            this.dodaj_wypadek_button.Text = "Dodaj wypadek";
            this.dodaj_wypadek_button.UseVisualStyleBackColor = true;
            this.dodaj_wypadek_button.Click += new System.EventHandler(this.dodaj_wypadek_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(112, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "ID Wypadku";
            // 
            // ID_wypadku_box
            // 
            this.ID_wypadku_box.Location = new System.Drawing.Point(222, 9);
            this.ID_wypadku_box.Name = "ID_wypadku_box";
            this.ID_wypadku_box.Size = new System.Drawing.Size(228, 20);
            this.ID_wypadku_box.TabIndex = 47;
            // 
            // oknoEdycjaWypadek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 449);
            this.Controls.Add(this.ID_wypadku_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefon_zgl_box);
            this.Controls.Add(this.typ_comboBox);
            this.Controls.Add(this.liczba_rannych_box);
            this.Controls.Add(this.miejsce_box);
            this.Controls.Add(this.opis_box);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodaj_wypadek_button);
            this.Name = "oknoEdycjaWypadek";
            this.Text = "Dodaj wypadek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox telefon_zgl_box;
        private System.Windows.Forms.ComboBox typ_comboBox;
        private System.Windows.Forms.TextBox liczba_rannych_box;
        private System.Windows.Forms.TextBox miejsce_box;
        private System.Windows.Forms.RichTextBox opis_box;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodaj_wypadek_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID_wypadku_box;
    }
}