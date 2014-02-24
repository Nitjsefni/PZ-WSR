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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.karetki = new System.Windows.Forms.TabPage();
            this.refresh_karetka = new System.Windows.Forms.Button();
            this.dod_karetke = new System.Windows.Forms.Button();
            this.karetki_dataGrid = new System.Windows.Forms.DataGridView();
            this.ID_karetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typ_numer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sklad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wyposazenie_karetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.wypadki = new System.Windows.Forms.TabPage();
            this.wyp_refresh = new System.Windows.Forms.Button();
            this.dod_wyp = new System.Windows.Forms.Button();
            this.wypadki_dataGrid = new System.Windows.Forms.DataGridView();
            this.id_wypadku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejsce_wyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczba_rannych = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typ_wypadku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_zgloszenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numer_zglaszajacego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagi_wypadek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.pacjenci = new System.Windows.Forms.TabPage();
            this.wyszukaj_data_btn = new System.Windows.Forms.Button();
            this.wyszukaj_pacjenta_miejsc_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wyszukaj_pacjenta_date = new System.Windows.Forms.DateTimePicker();
            this.wyszukaj_pacjenta_naz_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wyszukaj_pacjenta_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wyszukaj_pacjenta_btn = new System.Windows.Forms.Button();
            this.odswiezanie = new System.Windows.Forms.Button();
            this.dod_pacj = new System.Windows.Forms.Button();
            this.pacjenci_dataGrid = new System.Windows.Forms.DataGridView();
            this.pesel_pacjenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie_pacjenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko_pacjenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numer_ubezpieczenia_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_przyjecia_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowosc_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod_pocz_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulica_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagi_pacj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lekarz_pacjenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.lekarze = new System.Windows.Forms.TabPage();
            this.odswiez_lekarz_btn = new System.Windows.Forms.Button();
            this.dod_lekarza = new System.Windows.Forms.Button();
            this.lekarze_dataGrid = new System.Windows.Forms.DataGridView();
            this.ID_lekarza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie_lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko_lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanowisko_lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specjalizacja_lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.rClickPacjenciDG = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPacjenci_edytujBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPacjenci_usunBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.rClickLekarzeDG = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuLekarze_EdytujBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLekarze_UsunBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.wyszukaj_wg_lek_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lekarz_cbox2 = new System.Windows.Forms.ComboBox();
            this.rMEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabcontrol.SuspendLayout();
            this.karetki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karetki_dataGrid)).BeginInit();
            this.wypadki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wypadki_dataGrid)).BeginInit();
            this.pacjenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenci_dataGrid)).BeginInit();
            this.lekarze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lekarze_dataGrid)).BeginInit();
            this.rClickPacjenciDG.SuspendLayout();
            this.rClickLekarzeDG.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.karetki);
            this.tabcontrol.Controls.Add(this.wypadki);
            this.tabcontrol.Controls.Add(this.pacjenci);
            this.tabcontrol.Controls.Add(this.lekarze);
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Location = new System.Drawing.Point(0, 1);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1344, 588);
            this.tabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabcontrol.TabIndex = 0;
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
            this.karetki_dataGrid.Size = new System.Drawing.Size(744, 371);
            this.karetki_dataGrid.TabIndex = 3;
            this.karetki_dataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.karetki_dataGrid_CellMouseDown);
            this.karetki_dataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DastaGrid_RightClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista dostępnych karetek";
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
            this.wypadki_dataGrid.Size = new System.Drawing.Size(921, 368);
            this.wypadki_dataGrid.TabIndex = 1;
            this.wypadki_dataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.wypadki_dataGrid_CellMouseDown);
            this.wypadki_dataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DastaGrid_RightClick);
            // 
            // id_wypadku
            // 
            this.id_wypadku.DataPropertyName = "ID_wypadku";
            this.id_wypadku.HeaderText = "ID Wypadku";
            this.id_wypadku.Name = "id_wypadku";
            // 
            // miejsce_wyp
            // 
            this.miejsce_wyp.DataPropertyName = "miejsce_wyp";
            this.miejsce_wyp.HeaderText = "Miejsce wypadku";
            this.miejsce_wyp.Name = "miejsce_wyp";
            // 
            // liczba_rannych
            // 
            this.liczba_rannych.DataPropertyName = "liczba_rannych";
            this.liczba_rannych.HeaderText = "Liczba Poszkodowanych";
            this.liczba_rannych.Name = "liczba_rannych";
            // 
            // typ_wypadku
            // 
            this.typ_wypadku.DataPropertyName = "typ_wypadku";
            this.typ_wypadku.HeaderText = "Typ wypadku";
            this.typ_wypadku.Name = "typ_wypadku";
            this.typ_wypadku.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typ_wypadku.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // data_zgloszenia
            // 
            this.data_zgloszenia.DataPropertyName = "data_zgloszenia";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.data_zgloszenia.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_zgloszenia.HeaderText = "Data i godzina zgłoszenia";
            this.data_zgloszenia.Name = "data_zgloszenia";
            this.data_zgloszenia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data_zgloszenia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // numer_zglaszajacego
            // 
            this.numer_zglaszajacego.DataPropertyName = "numer_zglaszajacego";
            this.numer_zglaszajacego.HeaderText = "Numer tel. zgłaszającego";
            this.numer_zglaszajacego.Name = "numer_zglaszajacego";
            // 
            // uwagi_wypadek
            // 
            this.uwagi_wypadek.DataPropertyName = "uwagi_wypadek";
            this.uwagi_wypadek.HeaderText = "Uwagi";
            this.uwagi_wypadek.Name = "uwagi_wypadek";
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
            // pacjenci
            // 
            this.pacjenci.Controls.Add(this.wyszukaj_data_btn);
            this.pacjenci.Controls.Add(this.wyszukaj_pacjenta_miejsc_box);
            this.pacjenci.Controls.Add(this.label7);
            this.pacjenci.Controls.Add(this.label6);
            this.pacjenci.Controls.Add(this.wyszukaj_pacjenta_date);
            this.pacjenci.Controls.Add(this.wyszukaj_pacjenta_naz_box);
            this.pacjenci.Controls.Add(this.label4);
            this.pacjenci.Controls.Add(this.wyszukaj_pacjenta_box);
            this.pacjenci.Controls.Add(this.label3);
            this.pacjenci.Controls.Add(this.label2);
            this.pacjenci.Controls.Add(this.wyszukaj_pacjenta_btn);
            this.pacjenci.Controls.Add(this.odswiezanie);
            this.pacjenci.Controls.Add(this.dod_pacj);
            this.pacjenci.Controls.Add(this.pacjenci_dataGrid);
            this.pacjenci.Controls.Add(this.label10);
            this.pacjenci.Location = new System.Drawing.Point(4, 22);
            this.pacjenci.Name = "pacjenci";
            this.pacjenci.Padding = new System.Windows.Forms.Padding(3);
            this.pacjenci.Size = new System.Drawing.Size(1336, 562);
            this.pacjenci.TabIndex = 1;
            this.pacjenci.Text = "Pacjenci";
            this.pacjenci.UseVisualStyleBackColor = true;
            // 
            // wyszukaj_data_btn
            // 
            this.wyszukaj_data_btn.Location = new System.Drawing.Point(1104, 387);
            this.wyszukaj_data_btn.Name = "wyszukaj_data_btn";
            this.wyszukaj_data_btn.Size = new System.Drawing.Size(174, 23);
            this.wyszukaj_data_btn.TabIndex = 14;
            this.wyszukaj_data_btn.Text = "Wyszukaj według daty przyjęcia";
            this.wyszukaj_data_btn.UseVisualStyleBackColor = true;
            this.wyszukaj_data_btn.Click += new System.EventHandler(this.wyszukaj_data_btn_Click);
            // 
            // wyszukaj_pacjenta_miejsc_box
            // 
            this.wyszukaj_pacjenta_miejsc_box.Location = new System.Drawing.Point(1156, 198);
            this.wyszukaj_pacjenta_miejsc_box.Name = "wyszukaj_pacjenta_miejsc_box";
            this.wyszukaj_pacjenta_miejsc_box.Size = new System.Drawing.Size(141, 20);
            this.wyszukaj_pacjenta_miejsc_box.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1062, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Miejscowość:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1166, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data przyjęcia:";
            // 
            // wyszukaj_pacjenta_date
            // 
            this.wyszukaj_pacjenta_date.Location = new System.Drawing.Point(1104, 345);
            this.wyszukaj_pacjenta_date.MaxDate = new System.DateTime(2014, 3, 30, 0, 0, 0, 0);
            this.wyszukaj_pacjenta_date.MinDate = new System.DateTime(2013, 1, 10, 0, 0, 0, 0);
            this.wyszukaj_pacjenta_date.Name = "wyszukaj_pacjenta_date";
            this.wyszukaj_pacjenta_date.Size = new System.Drawing.Size(200, 20);
            this.wyszukaj_pacjenta_date.TabIndex = 10;
            this.wyszukaj_pacjenta_date.Value = new System.DateTime(2014, 2, 15, 12, 19, 7, 0);
            // 
            // wyszukaj_pacjenta_naz_box
            // 
            this.wyszukaj_pacjenta_naz_box.Location = new System.Drawing.Point(1156, 149);
            this.wyszukaj_pacjenta_naz_box.Name = "wyszukaj_pacjenta_naz_box";
            this.wyszukaj_pacjenta_naz_box.Size = new System.Drawing.Size(141, 20);
            this.wyszukaj_pacjenta_naz_box.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1077, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nazwisko:";
            // 
            // wyszukaj_pacjenta_box
            // 
            this.wyszukaj_pacjenta_box.Location = new System.Drawing.Point(1156, 98);
            this.wyszukaj_pacjenta_box.Name = "wyszukaj_pacjenta_box";
            this.wyszukaj_pacjenta_box.Size = new System.Drawing.Size(141, 20);
            this.wyszukaj_pacjenta_box.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1097, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pesel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1101, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wyszukiwanie pacjenta";
            // 
            // wyszukaj_pacjenta_btn
            // 
            this.wyszukaj_pacjenta_btn.Location = new System.Drawing.Point(1156, 240);
            this.wyszukaj_pacjenta_btn.Name = "wyszukaj_pacjenta_btn";
            this.wyszukaj_pacjenta_btn.Size = new System.Drawing.Size(75, 23);
            this.wyszukaj_pacjenta_btn.TabIndex = 4;
            this.wyszukaj_pacjenta_btn.Text = "Wyszukaj";
            this.wyszukaj_pacjenta_btn.UseVisualStyleBackColor = true;
            this.wyszukaj_pacjenta_btn.Click += new System.EventHandler(this.wyszukaj_pacjenta_btn_Click);
            // 
            // odswiezanie
            // 
            this.odswiezanie.Location = new System.Drawing.Point(952, 496);
            this.odswiezanie.Name = "odswiezanie";
            this.odswiezanie.Size = new System.Drawing.Size(202, 23);
            this.odswiezanie.TabIndex = 3;
            this.odswiezanie.Text = "Odśwież";
            this.odswiezanie.UseVisualStyleBackColor = true;
            this.odswiezanie.Click += new System.EventHandler(this.odswiezanie_Click);
            // 
            // dod_pacj
            // 
            this.dod_pacj.Location = new System.Drawing.Point(346, 496);
            this.dod_pacj.Name = "dod_pacj";
            this.dod_pacj.Size = new System.Drawing.Size(342, 23);
            this.dod_pacj.TabIndex = 2;
            this.dod_pacj.Text = "Dodaj pacjenta";
            this.dod_pacj.UseVisualStyleBackColor = true;
            this.dod_pacj.Click += new System.EventHandler(this.dod_pacj_Click);
            // 
            // pacjenci_dataGrid
            // 
            this.pacjenci_dataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pacjenci_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.pacjenci_dataGrid.MultiSelect = false;
            this.pacjenci_dataGrid.Name = "pacjenci_dataGrid";
            this.pacjenci_dataGrid.RowHeadersWidth = 15;
            this.pacjenci_dataGrid.Size = new System.Drawing.Size(1042, 472);
            this.pacjenci_dataGrid.TabIndex = 1;
            this.pacjenci_dataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pacjenci_dataGrid_MouseClick);
            // 
            // pesel_pacjenta
            // 
            this.pesel_pacjenta.DataPropertyName = "pesel_pacjenta";
            this.pesel_pacjenta.HeaderText = "Pesel";
            this.pesel_pacjenta.Name = "pesel_pacjenta";
            // 
            // imie_pacjenta
            // 
            this.imie_pacjenta.DataPropertyName = "imie_pacjenta";
            this.imie_pacjenta.HeaderText = "Imię";
            this.imie_pacjenta.Name = "imie_pacjenta";
            // 
            // nazwisko_pacjenta
            // 
            this.nazwisko_pacjenta.DataPropertyName = "nazwisko_pacjenta";
            this.nazwisko_pacjenta.HeaderText = "Nazwisko";
            this.nazwisko_pacjenta.Name = "nazwisko_pacjenta";
            // 
            // numer_ubezpieczenia_pacj
            // 
            this.numer_ubezpieczenia_pacj.DataPropertyName = "numer_ubezpieczenia_pacj";
            this.numer_ubezpieczenia_pacj.HeaderText = "Numer ubezpieczenia";
            this.numer_ubezpieczenia_pacj.Name = "numer_ubezpieczenia_pacj";
            // 
            // data_przyjecia_pacj
            // 
            this.data_przyjecia_pacj.DataPropertyName = "data_przyjecia_pacj";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.data_przyjecia_pacj.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_przyjecia_pacj.HeaderText = "Data przyjęcia";
            this.data_przyjecia_pacj.Name = "data_przyjecia_pacj";
            this.data_przyjecia_pacj.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data_przyjecia_pacj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // miejscowosc_pacj
            // 
            this.miejscowosc_pacj.DataPropertyName = "miejscowosc_pacj";
            this.miejscowosc_pacj.HeaderText = "Miejscowość";
            this.miejscowosc_pacj.Name = "miejscowosc_pacj";
            // 
            // kod_pocz_pacj
            // 
            this.kod_pocz_pacj.DataPropertyName = "kod_pocz_pacj";
            this.kod_pocz_pacj.HeaderText = "Kod pocztowy";
            this.kod_pocz_pacj.Name = "kod_pocz_pacj";
            // 
            // ulica_pacj
            // 
            this.ulica_pacj.DataPropertyName = "ulica_pacj";
            this.ulica_pacj.HeaderText = "Ulica";
            this.ulica_pacj.Name = "ulica_pacj";
            // 
            // opis_pacj
            // 
            this.opis_pacj.DataPropertyName = "opis_pacj";
            this.opis_pacj.HeaderText = "Opis";
            this.opis_pacj.Name = "opis_pacj";
            // 
            // uwagi_pacj
            // 
            this.uwagi_pacj.DataPropertyName = "uwagi_pacj";
            this.uwagi_pacj.HeaderText = "Uwagi";
            this.uwagi_pacj.Name = "uwagi_pacj";
            this.uwagi_pacj.Visible = false;
            // 
            // lekarz_pacjenta
            // 
            this.lekarz_pacjenta.DataPropertyName = "lekarz_pacjenta";
            this.lekarz_pacjenta.HeaderText = "Lekarz prowadzący";
            this.lekarz_pacjenta.Name = "lekarz_pacjenta";
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
            this.lekarze_dataGrid.MultiSelect = false;
            this.lekarze_dataGrid.Name = "lekarze_dataGrid";
            this.lekarze_dataGrid.Size = new System.Drawing.Size(647, 382);
            this.lekarze_dataGrid.TabIndex = 1;
            this.lekarze_dataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lekarze_dataGrid_MouseClick);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Lista lekarzy";
            // 
            // rClickPacjenciDG
            // 
            this.rClickPacjenciDG.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPacjenci_edytujBtn,
            this.menuPacjenci_usunBtn});
            this.rClickPacjenciDG.Name = "rClickPacjenciDG";
            this.rClickPacjenciDG.Size = new System.Drawing.Size(108, 48);
            // 
            // menuPacjenci_edytujBtn
            // 
            this.menuPacjenci_edytujBtn.Name = "menuPacjenci_edytujBtn";
            this.menuPacjenci_edytujBtn.Size = new System.Drawing.Size(107, 22);
            this.menuPacjenci_edytujBtn.Text = "Edytuj";
            this.menuPacjenci_edytujBtn.Click += new System.EventHandler(this.menuPacjenci_edytujBtn_Click);
            // 
            // menuPacjenci_usunBtn
            // 
            this.menuPacjenci_usunBtn.Name = "menuPacjenci_usunBtn";
            this.menuPacjenci_usunBtn.Size = new System.Drawing.Size(107, 22);
            this.menuPacjenci_usunBtn.Text = "Usuń";
            this.menuPacjenci_usunBtn.Click += new System.EventHandler(this.menuPacjenci_usunBtn_Click);
            // 
            // rClickLekarzeDG
            // 
            this.rClickLekarzeDG.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLekarze_EdytujBtn,
            this.MenuLekarze_UsunBtn});
            this.rClickLekarzeDG.Name = "rClickPacjenciDG";
            this.rClickLekarzeDG.Size = new System.Drawing.Size(108, 48);
            // 
            // MenuLekarze_EdytujBtn
            // 
            this.MenuLekarze_EdytujBtn.Name = "MenuLekarze_EdytujBtn";
            this.MenuLekarze_EdytujBtn.Size = new System.Drawing.Size(107, 22);
            this.MenuLekarze_EdytujBtn.Text = "Edytuj";
            this.MenuLekarze_EdytujBtn.Click += new System.EventHandler(this.MenuLekarze_EdytujBtn_Click);
            // 
            // MenuLekarze_UsunBtn
            // 
            this.MenuLekarze_UsunBtn.Name = "MenuLekarze_UsunBtn";
            this.MenuLekarze_UsunBtn.Size = new System.Drawing.Size(107, 22);
            this.MenuLekarze_UsunBtn.Text = "Usuń";
            this.MenuLekarze_UsunBtn.Click += new System.EventHandler(this.MenuLekarze_UsunBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lekarz_cbox2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.wyszukaj_wg_lek_btn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1336, 562);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Wyszukiwania";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // wyszukaj_wg_lek_btn
            // 
            this.wyszukaj_wg_lek_btn.Location = new System.Drawing.Point(1090, 173);
            this.wyszukaj_wg_lek_btn.Name = "wyszukaj_wg_lek_btn";
            this.wyszukaj_wg_lek_btn.Size = new System.Drawing.Size(75, 23);
            this.wyszukaj_wg_lek_btn.TabIndex = 0;
            this.wyszukaj_wg_lek_btn.Text = "Wyszukaj";
            this.wyszukaj_wg_lek_btn.UseVisualStyleBackColor = true;
            this.wyszukaj_wg_lek_btn.Click += new System.EventHandler(this.wyszukaj_wg_lek_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(20, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.Size = new System.Drawing.Size(930, 472);
            this.dataGridView1.TabIndex = 2;
            // 
            // lekarz_cbox2
            // 
            this.lekarz_cbox2.FormattingEnabled = true;
            this.lekarz_cbox2.Location = new System.Drawing.Point(1054, 122);
            this.lekarz_cbox2.Name = "lekarz_cbox2";
            this.lekarz_cbox2.Size = new System.Drawing.Size(148, 21);
            this.lekarz_cbox2.TabIndex = 3;
            // 
            // rMEntitiesBindingSource
            // 
            this.rMEntitiesBindingSource.DataSource = typeof(RM.RMEntities);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1087, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Wybierz lekarza:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1031, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Wyszukiwanie pacjentów danych lekarzy";
            // 
            // oknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 591);
            this.Controls.Add(this.tabcontrol);
            this.Name = "oknoGlowne";
            this.Text = "System wspomagania Ratownictwa Medycznego";
            this.tabcontrol.ResumeLayout(false);
            this.karetki.ResumeLayout(false);
            this.karetki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karetki_dataGrid)).EndInit();
            this.wypadki.ResumeLayout(false);
            this.wypadki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wypadki_dataGrid)).EndInit();
            this.pacjenci.ResumeLayout(false);
            this.pacjenci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenci_dataGrid)).EndInit();
            this.lekarze.ResumeLayout(false);
            this.lekarze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lekarze_dataGrid)).EndInit();
            this.rClickPacjenciDG.ResumeLayout(false);
            this.rClickLekarzeDG.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage karetki;
        private System.Windows.Forms.DataGridView karetki_dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage wypadki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage pacjenci;
        private System.Windows.Forms.TabPage lekarze;
        private System.Windows.Forms.Button dod_wyp;
        private System.Windows.Forms.DataGridView wypadki_dataGrid;
        private System.Windows.Forms.Button dod_pacj;
        private System.Windows.Forms.DataGridView pacjenci_dataGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView lekarze_dataGrid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button dod_lekarza;
        private System.Windows.Forms.Button dod_karetke;
        private System.Windows.Forms.Button odswiezanie;
        private System.Windows.Forms.BindingSource rMEntitiesBindingSource;
        private System.Windows.Forms.Button odswiez_lekarz_btn;
        private System.Windows.Forms.Button refresh_karetka;
        private System.Windows.Forms.Button wyp_refresh;
        private System.Windows.Forms.ContextMenuStrip rClickPacjenciDG;
        private System.Windows.Forms.ToolStripMenuItem menuPacjenci_edytujBtn;
        private System.Windows.Forms.ToolStripMenuItem menuPacjenci_usunBtn;
        private System.Windows.Forms.ContextMenuStrip rClickLekarzeDG;
        private System.Windows.Forms.ToolStripMenuItem MenuLekarze_EdytujBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuLekarze_UsunBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_karetki;
        private System.Windows.Forms.DataGridViewTextBoxColumn typ_numer;
        private System.Windows.Forms.DataGridViewTextBoxColumn sklad;
        private System.Windows.Forms.DataGridViewTextBoxColumn wyposazenie_karetki;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_wypadku;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejsce_wyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczba_rannych;
        private System.Windows.Forms.DataGridViewTextBoxColumn typ_wypadku;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_zgloszenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn numer_zglaszajacego;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagi_wypadek;
        private System.Windows.Forms.TextBox wyszukaj_pacjenta_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button wyszukaj_pacjenta_btn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_lekarza;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie_lekarz;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko_lekarz;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanowisko_lekarz;
        private System.Windows.Forms.DataGridViewTextBoxColumn specjalizacja_lekarz;
        private System.Windows.Forms.TextBox wyszukaj_pacjenta_naz_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker wyszukaj_pacjenta_date;
        private System.Windows.Forms.Button wyszukaj_data_btn;
        private System.Windows.Forms.TextBox wyszukaj_pacjenta_miejsc_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button wyszukaj_wg_lek_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox lekarz_cbox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

