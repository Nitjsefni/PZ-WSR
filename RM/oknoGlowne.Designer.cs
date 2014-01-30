namespace RM
{
    partial class oknoGlowne
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rMEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lekarze = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.lekarze_dataGrid = new System.Windows.Forms.DataGridView();
            this.dod_lekarza = new System.Windows.Forms.Button();
            this.odswiez_lekarz_btn = new System.Windows.Forms.Button();
            this.pacjenci = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.pacjenci_dataGrid = new System.Windows.Forms.DataGridView();
            this.lekarz_pacjenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagi_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulica_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod_pocz_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowosc_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_przyjecia_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numer_ubezpieczenia_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko_pacjenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie_pacjenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesel_pacjenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dod_pacj = new System.Windows.Forms.Button();
            this.odswiezanie = new System.Windows.Forms.Button();
            this.szukaj_pacjenta_btn = new System.Windows.Forms.Button();
            this.szukaj_pesel_box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.wypadki = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.wypadki_dataGrid = new System.Windows.Forms.DataGridView();
            this.uwagi_wypadek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numer_zglaszajacego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_zgloszenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typ_wypadku = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.liczba_rannych = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejsce_wyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_wypadku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dod_wyp = new System.Windows.Forms.Button();
            this.wyp_refresh = new System.Windows.Forms.Button();
            this.karetki = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.karetki_dataGrid = new System.Windows.Forms.DataGridView();
            this.dod_karetke = new System.Windows.Forms.Button();
            this.refresh_karetka = new System.Windows.Forms.Button();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.ID_lekarza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie_lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko_lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanowisko_lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specjalizacja_lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_karetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typ_numer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sklad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wyposazenie_karetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rMEntitiesBindingSource)).BeginInit();
            this.lekarze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lekarze_dataGrid)).BeginInit();
            this.pacjenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenci_dataGrid)).BeginInit();
            this.wypadki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wypadki_dataGrid)).BeginInit();
            this.karetki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karetki_dataGrid)).BeginInit();
            this.tabcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // rMEntitiesBindingSource
            // 
            this.rMEntitiesBindingSource.DataSource = typeof(RM.RMEntities);
            // 
            // lekarze
            // 
            this.lekarze.Controls.Add(this.odswiez_lekarz_btn);
            this.lekarze.Controls.Add(this.dod_lekarza);
            this.lekarze.Controls.Add(this.lekarze_dataGrid);
            this.lekarze.Controls.Add(this.label11);
            this.lekarze.Location = new System.Drawing.Point(4, 22);
            this.lekarze.Name = "lekarze";
            this.lekarze.Padding = new System.Windows.Forms.Padding(3);
            this.lekarze.Size = new System.Drawing.Size(1336, 562);
            this.lekarze.TabIndex = 2;
            this.lekarze.Text = "Lekarze";
            this.lekarze.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Lista lekarzy";
            // 
            // lekarze_dataGrid
            // 
            this.lekarze_dataGrid.AllowUserToOrderColumns = true;
            this.lekarze_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lekarze_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_lekarza,
            this.imie_lekarz,
            this.nazwisko_lekarz,
            this.stanowisko_lekarz,
            this.specjalizacja_lekarz});
            this.lekarze_dataGrid.Location = new System.Drawing.Point(23, 37);
            this.lekarze_dataGrid.Name = "lekarze_dataGrid";
            this.lekarze_dataGrid.Size = new System.Drawing.Size(647, 382);
            this.lekarze_dataGrid.TabIndex = 1;
            this.lekarze_dataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.lekarze_dataGrid_CellMouseDown);
            this.lekarze_dataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DastaGrid_RightClick);
            // 
            // dod_lekarza
            // 
            this.dod_lekarza.Location = new System.Drawing.Point(222, 440);
            this.dod_lekarza.Name = "dod_lekarza";
            this.dod_lekarza.Size = new System.Drawing.Size(251, 23);
            this.dod_lekarza.TabIndex = 2;
            this.dod_lekarza.Text = "Dodaj lekarza";
            this.dod_lekarza.UseVisualStyleBackColor = true;
            this.dod_lekarza.Click += new System.EventHandler(this.dod_lekarza_Click);
            // 
            // odswiez_lekarz_btn
            // 
            this.odswiez_lekarz_btn.Location = new System.Drawing.Point(503, 439);
            this.odswiez_lekarz_btn.Name = "odswiez_lekarz_btn";
            this.odswiez_lekarz_btn.Size = new System.Drawing.Size(75, 23);
            this.odswiez_lekarz_btn.TabIndex = 5;
            this.odswiez_lekarz_btn.Text = "Odśwież";
            this.odswiez_lekarz_btn.UseVisualStyleBackColor = true;
            this.odswiez_lekarz_btn.Click += new System.EventHandler(this.odswiez_lekarz_btn_Click);
            // 
            // pacjenci
            // 
            this.pacjenci.Controls.Add(this.label13);
            this.pacjenci.Controls.Add(this.label12);
            this.pacjenci.Controls.Add(this.szukaj_pesel_box);
            this.pacjenci.Controls.Add(this.pacjenci_dataGrid);
            this.pacjenci.Controls.Add(this.szukaj_pacjenta_btn);
            this.pacjenci.Controls.Add(this.odswiezanie);
            this.pacjenci.Controls.Add(this.dod_pacj);
            this.pacjenci.Controls.Add(this.label10);
            this.pacjenci.Location = new System.Drawing.Point(4, 22);
            this.pacjenci.Name = "pacjenci";
            this.pacjenci.Padding = new System.Windows.Forms.Padding(3);
            this.pacjenci.Size = new System.Drawing.Size(1336, 562);
            this.pacjenci.TabIndex = 1;
            this.pacjenci.Text = "Pacjenci";
            this.pacjenci.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(626, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Lista pacjentów";
            // 
            // pacjenci_dataGrid
            // 
            this.pacjenci_dataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pacjenci_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pacjenci_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacjenci_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pesel_pacjenta,
            this.imie_pacjenta,
            this.nazwisko_pacjenta,
            this.numer_ubezpieczenia_pacj,
            this.data_przyjecia_pacj,
            this.miejscowosc_pacj,
            this.kod_pocz_pacj,
            this.ulica_pacj,
            this.opis_pacj,
            this.uwagi_pacj,
            this.lekarz_pacjenta});
            this.pacjenci_dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.pacjenci_dataGrid.Location = new System.Drawing.Point(7, 19);
            this.pacjenci_dataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.pacjenci_dataGrid.Name = "pacjenci_dataGrid";
            this.pacjenci_dataGrid.RowHeadersWidth = 15;
            this.pacjenci_dataGrid.Size = new System.Drawing.Size(1024, 472);
            this.pacjenci_dataGrid.TabIndex = 1;
            this.pacjenci_dataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.pacjenci_dataGrid_CellMouseDown);
            this.pacjenci_dataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DastaGrid_RightClick);
            // 
            // lekarz_pacjenta
            // 
            this.lekarz_pacjenta.DataPropertyName = "lekarz_pacjenta";
            this.lekarz_pacjenta.HeaderText = "Lekarz prowadzący";
            this.lekarz_pacjenta.Name = "lekarz_pacjenta";
            // 
            // uwagi_pacj
            // 
            this.uwagi_pacj.DataPropertyName = "uwagi_pacj";
            this.uwagi_pacj.HeaderText = "Uwagi";
            this.uwagi_pacj.Name = "uwagi_pacj";
            this.uwagi_pacj.Visible = false;
            // 
            // opis_pacj
            // 
            this.opis_pacj.DataPropertyName = "opis_pacj";
            this.opis_pacj.HeaderText = "Opis";
            this.opis_pacj.Name = "opis_pacj";
            // 
            // ulica_pacj
            // 
            this.ulica_pacj.DataPropertyName = "ulica_pacj";
            this.ulica_pacj.HeaderText = "Ulica";
            this.ulica_pacj.Name = "ulica_pacj";
            // 
            // kod_pocz_pacj
            // 
            this.kod_pocz_pacj.DataPropertyName = "kod_pocz_pacj";
            this.kod_pocz_pacj.HeaderText = "Kod pocztowy";
            this.kod_pocz_pacj.Name = "kod_pocz_pacj";
            // 
            // miejscowosc_pacj
            // 
            this.miejscowosc_pacj.DataPropertyName = "miejscowosc_pacj";
            this.miejscowosc_pacj.HeaderText = "Miejscowość";
            this.miejscowosc_pacj.Name = "miejscowosc_pacj";
            // 
            // data_przyjecia_pacj
            // 
            this.data_przyjecia_pacj.DataPropertyName = "data_przyjecia_pacj";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.data_przyjecia_pacj.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_przyjecia_pacj.HeaderText = "Data przyjęcia";
            this.data_przyjecia_pacj.Name = "data_przyjecia_pacj";
            this.data_przyjecia_pacj.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data_przyjecia_pacj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // numer_ubezpieczenia_pacj
            // 
            this.numer_ubezpieczenia_pacj.DataPropertyName = "numer_ubezpieczenia_pacj";
            this.numer_ubezpieczenia_pacj.HeaderText = "Numer ubezpieczenia";
            this.numer_ubezpieczenia_pacj.Name = "numer_ubezpieczenia_pacj";
            // 
            // nazwisko_pacjenta
            // 
            this.nazwisko_pacjenta.DataPropertyName = "nazwisko_pacjenta";
            this.nazwisko_pacjenta.HeaderText = "Nazwisko";
            this.nazwisko_pacjenta.Name = "nazwisko_pacjenta";
            // 
            // imie_pacjenta
            // 
            this.imie_pacjenta.DataPropertyName = "imie_pacjenta";
            this.imie_pacjenta.HeaderText = "Imię";
            this.imie_pacjenta.Name = "imie_pacjenta";
            // 
            // pesel_pacjenta
            // 
            this.pesel_pacjenta.DataPropertyName = "pesel_pacjenta";
            this.pesel_pacjenta.HeaderText = "Pesel";
            this.pesel_pacjenta.Name = "pesel_pacjenta";
            // 
            // dod_pacj
            // 
            this.dod_pacj.Location = new System.Drawing.Point(251, 496);
            this.dod_pacj.Name = "dod_pacj";
            this.dod_pacj.Size = new System.Drawing.Size(342, 23);
            this.dod_pacj.TabIndex = 2;
            this.dod_pacj.Text = "Dodaj pacjenta";
            this.dod_pacj.UseVisualStyleBackColor = true;
            this.dod_pacj.Click += new System.EventHandler(this.dod_pacj_Click);
            // 
            // odswiezanie
            // 
            this.odswiezanie.Location = new System.Drawing.Point(643, 496);
            this.odswiezanie.Name = "odswiezanie";
            this.odswiezanie.Size = new System.Drawing.Size(202, 23);
            this.odswiezanie.TabIndex = 3;
            this.odswiezanie.Text = "Odśwież";
            this.odswiezanie.UseVisualStyleBackColor = true;
            this.odswiezanie.Click += new System.EventHandler(this.odswiezanie_Click);
            // 
            // szukaj_pacjenta_btn
            // 
            this.szukaj_pacjenta_btn.Location = new System.Drawing.Point(1085, 96);
            this.szukaj_pacjenta_btn.Name = "szukaj_pacjenta_btn";
            this.szukaj_pacjenta_btn.Size = new System.Drawing.Size(134, 23);
            this.szukaj_pacjenta_btn.TabIndex = 4;
            this.szukaj_pacjenta_btn.Text = "Wyszukaj pacjenta";
            this.szukaj_pacjenta_btn.UseVisualStyleBackColor = true;
            this.szukaj_pacjenta_btn.Click += new System.EventHandler(this.szukaj_pacjenta_btn_Click);
            // 
            // szukaj_pesel_box
            // 
            this.szukaj_pesel_box.Location = new System.Drawing.Point(1122, 63);
            this.szukaj_pesel_box.Name = "szukaj_pesel_box";
            this.szukaj_pesel_box.Size = new System.Drawing.Size(134, 20);
            this.szukaj_pesel_box.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1091, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Wyszukiwanie pacjenta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1066, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Pesel:";
            // 
            // wypadki
            // 
            this.wypadki.Controls.Add(this.wyp_refresh);
            this.wypadki.Controls.Add(this.dod_wyp);
            this.wypadki.Controls.Add(this.wypadki_dataGrid);
            this.wypadki.Controls.Add(this.label5);
            this.wypadki.Location = new System.Drawing.Point(4, 22);
            this.wypadki.Name = "wypadki";
            this.wypadki.Padding = new System.Windows.Forms.Padding(3);
            this.wypadki.Size = new System.Drawing.Size(1336, 562);
            this.wypadki.TabIndex = 3;
            this.wypadki.Text = "Wypadki";
            this.wypadki.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lista zgłoszonych wypadków";
            // 
            // wypadki_dataGrid
            // 
            this.wypadki_dataGrid.AllowUserToOrderColumns = true;
            this.wypadki_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wypadki_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_wypadku,
            this.miejsce_wyp,
            this.liczba_rannych,
            this.typ_wypadku,
            this.data_zgloszenia,
            this.numer_zglaszajacego,
            this.uwagi_wypadek});
            this.wypadki_dataGrid.Location = new System.Drawing.Point(6, 29);
            this.wypadki_dataGrid.Name = "wypadki_dataGrid";
            this.wypadki_dataGrid.Size = new System.Drawing.Size(846, 368);
            this.wypadki_dataGrid.TabIndex = 1;
            this.wypadki_dataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.wypadki_dataGrid_CellMouseDown);
            this.wypadki_dataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DastaGrid_RightClick);
            // 
            // uwagi_wypadek
            // 
            this.uwagi_wypadek.DataPropertyName = "uwagi_wypadek";
            this.uwagi_wypadek.HeaderText = "Uwagi";
            this.uwagi_wypadek.Name = "uwagi_wypadek";
            // 
            // numer_zglaszajacego
            // 
            this.numer_zglaszajacego.DataPropertyName = "numer_zglaszajacego";
            this.numer_zglaszajacego.HeaderText = "Numer tel. zgłaszającego";
            this.numer_zglaszajacego.Name = "numer_zglaszajacego";
            // 
            // data_zgloszenia
            // 
            this.data_zgloszenia.DataPropertyName = "data_zgloszenia";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.data_zgloszenia.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_zgloszenia.HeaderText = "Data i godzina zgłoszenia";
            this.data_zgloszenia.Name = "data_zgloszenia";
            this.data_zgloszenia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data_zgloszenia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // typ_wypadku
            // 
            this.typ_wypadku.DataPropertyName = "typ_wypadku";
            this.typ_wypadku.HeaderText = "Typ wypadku";
            this.typ_wypadku.Name = "typ_wypadku";
            // 
            // liczba_rannych
            // 
            this.liczba_rannych.DataPropertyName = "liczba_rannych";
            this.liczba_rannych.HeaderText = "Liczba Poszkodowanych";
            this.liczba_rannych.Name = "liczba_rannych";
            // 
            // miejsce_wyp
            // 
            this.miejsce_wyp.DataPropertyName = "miejsce_wyp";
            this.miejsce_wyp.HeaderText = "Miejsce wypadku";
            this.miejsce_wyp.Name = "miejsce_wyp";
            // 
            // id_wypadku
            // 
            this.id_wypadku.DataPropertyName = "ID_wypadku";
            this.id_wypadku.HeaderText = "ID Wypadku";
            this.id_wypadku.Name = "id_wypadku";
            // 
            // dod_wyp
            // 
            this.dod_wyp.Location = new System.Drawing.Point(94, 403);
            this.dod_wyp.Name = "dod_wyp";
            this.dod_wyp.Size = new System.Drawing.Size(466, 23);
            this.dod_wyp.TabIndex = 2;
            this.dod_wyp.Text = "Dodaj wypadek";
            this.dod_wyp.UseVisualStyleBackColor = true;
            this.dod_wyp.Click += new System.EventHandler(this.dod_wyp_Click);
            // 
            // wyp_refresh
            // 
            this.wyp_refresh.Location = new System.Drawing.Point(651, 403);
            this.wyp_refresh.Name = "wyp_refresh";
            this.wyp_refresh.Size = new System.Drawing.Size(125, 23);
            this.wyp_refresh.TabIndex = 12;
            this.wyp_refresh.Text = "odśwież";
            this.wyp_refresh.UseVisualStyleBackColor = true;
            this.wyp_refresh.Click += new System.EventHandler(this.wyp_refresh_Click);
            // 
            // karetki
            // 
            this.karetki.Controls.Add(this.refresh_karetka);
            this.karetki.Controls.Add(this.dod_karetke);
            this.karetki.Controls.Add(this.karetki_dataGrid);
            this.karetki.Controls.Add(this.label1);
            this.karetki.Location = new System.Drawing.Point(4, 22);
            this.karetki.Name = "karetki";
            this.karetki.Padding = new System.Windows.Forms.Padding(3);
            this.karetki.Size = new System.Drawing.Size(1336, 562);
            this.karetki.TabIndex = 0;
            this.karetki.Text = "Karetki";
            this.karetki.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista dostępnych karetek";
            // 
            // karetki_dataGrid
            // 
            this.karetki_dataGrid.AllowUserToOrderColumns = true;
            this.karetki_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.karetki_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_karetki,
            this.typ_numer,
            this.sklad,
            this.wyposazenie_karetki,
            this.uwagi});
            this.karetki_dataGrid.Location = new System.Drawing.Point(10, 24);
            this.karetki_dataGrid.Name = "karetki_dataGrid";
            this.karetki_dataGrid.Size = new System.Drawing.Size(545, 371);
            this.karetki_dataGrid.TabIndex = 3;
            this.karetki_dataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.karetki_dataGrid_CellMouseDown);
            this.karetki_dataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DastaGrid_RightClick);
            // 
            // dod_karetke
            // 
            this.dod_karetke.Location = new System.Drawing.Point(93, 411);
            this.dod_karetke.Name = "dod_karetke";
            this.dod_karetke.Size = new System.Drawing.Size(230, 23);
            this.dod_karetke.TabIndex = 10;
            this.dod_karetke.Text = "Dodaj karetkę";
            this.dod_karetke.UseVisualStyleBackColor = true;
            this.dod_karetke.Click += new System.EventHandler(this.dod_karetke_Click);
            // 
            // refresh_karetka
            // 
            this.refresh_karetka.Location = new System.Drawing.Point(366, 411);
            this.refresh_karetka.Name = "refresh_karetka";
            this.refresh_karetka.Size = new System.Drawing.Size(122, 22);
            this.refresh_karetka.TabIndex = 11;
            this.refresh_karetka.Text = "Odśwież";
            this.refresh_karetka.UseVisualStyleBackColor = true;
            this.refresh_karetka.Click += new System.EventHandler(this.refresh_karetka_Click);
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.karetki);
            this.tabcontrol.Controls.Add(this.wypadki);
            this.tabcontrol.Controls.Add(this.pacjenci);
            this.tabcontrol.Controls.Add(this.lekarze);
            this.tabcontrol.Location = new System.Drawing.Point(0, 1);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1344, 588);
            this.tabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabcontrol.TabIndex = 0;
            // 
            // ID_lekarza
            // 
            this.ID_lekarza.DataPropertyName = "ID_lekarz";
            this.ID_lekarza.HeaderText = "ID Lekarza";
            this.ID_lekarza.Name = "ID_lekarza";
            // 
            // imie_lekarz
            // 
            this.imie_lekarz.DataPropertyName = "imie_lekarz";
            this.imie_lekarz.HeaderText = "Imię";
            this.imie_lekarz.Name = "imie_lekarz";
            // 
            // nazwisko_lekarz
            // 
            this.nazwisko_lekarz.DataPropertyName = "nazwisko_lekarz";
            this.nazwisko_lekarz.HeaderText = "Nazwisko";
            this.nazwisko_lekarz.Name = "nazwisko_lekarz";
            // 
            // stanowisko_lekarz
            // 
            this.stanowisko_lekarz.DataPropertyName = "stanowisko_lekarz";
            this.stanowisko_lekarz.HeaderText = "Stanowisko";
            this.stanowisko_lekarz.Name = "stanowisko_lekarz";
            // 
            // specjalizacja_lekarz
            // 
            this.specjalizacja_lekarz.DataPropertyName = "specjalizacja_lekarz";
            this.specjalizacja_lekarz.HeaderText = "Specjalizacja";
            this.specjalizacja_lekarz.Name = "specjalizacja_lekarz";
            // 
            // ID_karetki
            // 
            this.ID_karetki.DataPropertyName = "ID_karetki";
            this.ID_karetki.HeaderText = "ID karetki";
            this.ID_karetki.Name = "ID_karetki";
            // 
            // typ_numer
            // 
            this.typ_numer.DataPropertyName = "typ_numer";
            this.typ_numer.HeaderText = "Typ i numer";
            this.typ_numer.Name = "typ_numer";
            // 
            // sklad
            // 
            this.sklad.DataPropertyName = "sklad";
            this.sklad.HeaderText = "Skład";
            this.sklad.Name = "sklad";
            this.sklad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sklad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // wyposazenie_karetki
            // 
            this.wyposazenie_karetki.DataPropertyName = "wyposazenie_karetki";
            this.wyposazenie_karetki.HeaderText = "Wyposażenie";
            this.wyposazenie_karetki.Name = "wyposazenie_karetki";
            // 
            // uwagi
            // 
            this.uwagi.DataPropertyName = "uwagi";
            this.uwagi.HeaderText = "Uwagi";
            this.uwagi.Name = "uwagi";
            // 
            // oknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 591);
            this.Controls.Add(this.tabcontrol);
            this.Name = "oknoGlowne";
            this.Text = "System wspomagania Ratownictwa Medycznego";
            ((System.ComponentModel.ISupportInitialize)(this.rMEntitiesBindingSource)).EndInit();
            this.lekarze.ResumeLayout(false);
            this.lekarze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lekarze_dataGrid)).EndInit();
            this.pacjenci.ResumeLayout(false);
            this.pacjenci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenci_dataGrid)).EndInit();
            this.wypadki.ResumeLayout(false);
            this.wypadki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wypadki_dataGrid)).EndInit();
            this.karetki.ResumeLayout(false);
            this.karetki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karetki_dataGrid)).EndInit();
            this.tabcontrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource rMEntitiesBindingSource;
        private System.Windows.Forms.TabPage lekarze;
        private System.Windows.Forms.Button odswiez_lekarz_btn;
        private System.Windows.Forms.Button dod_lekarza;
        private System.Windows.Forms.DataGridView lekarze_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_lekarza;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie_lekarz;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko_lekarz;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanowisko_lekarz;
        private System.Windows.Forms.DataGridViewTextBoxColumn specjalizacja_lekarz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage pacjenci;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox szukaj_pesel_box;
        private System.Windows.Forms.DataGridView pacjenci_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesel_pacjenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie_pacjenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko_pacjenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn numer_ubezpieczenia_pacj;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_przyjecia_pacj;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowosc_pacj;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod_pocz_pacj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulica_pacj;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis_pacj;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagi_pacj;
        private System.Windows.Forms.DataGridViewTextBoxColumn lekarz_pacjenta;
        private System.Windows.Forms.Button szukaj_pacjenta_btn;
        private System.Windows.Forms.Button odswiezanie;
        private System.Windows.Forms.Button dod_pacj;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage wypadki;
        private System.Windows.Forms.Button wyp_refresh;
        private System.Windows.Forms.Button dod_wyp;
        private System.Windows.Forms.DataGridView wypadki_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_wypadku;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejsce_wyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczba_rannych;
        private System.Windows.Forms.DataGridViewComboBoxColumn typ_wypadku;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_zgloszenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn numer_zglaszajacego;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagi_wypadek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage karetki;
        private System.Windows.Forms.Button refresh_karetka;
        private System.Windows.Forms.Button dod_karetke;
        private System.Windows.Forms.DataGridView karetki_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_karetki;
        private System.Windows.Forms.DataGridViewTextBoxColumn typ_numer;
        private System.Windows.Forms.DataGridViewTextBoxColumn sklad;
        private System.Windows.Forms.DataGridViewTextBoxColumn wyposazenie_karetki;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabcontrol;
    }
}

