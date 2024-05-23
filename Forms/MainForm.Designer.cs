namespace WinForms_Filmoteka
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            buttonSearch = new Button();
            buttonAddFilm = new Button();
            NameBox = new TextBox();
            YearBox = new TextBox();
            GenreBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            LocationBox = new TextBox();
            ActorBox = new TextBox();
            DirectorBox = new TextBox();
            ResultListBox = new ListBox();
            filmBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            loadFromToolStripMenuItem = new ToolStripMenuItem();
            saveSearchResultToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            seenToolStripMenuItem = new ToolStripMenuItem();
            wantToToolStripMenuItem = new ToolStripMenuItem();
            shareSeenToolStripMenuItem = new ToolStripMenuItem();
            shareWantToToolStripMenuItem = new ToolStripMenuItem();
            инструментыToolStripMenuItem = new ToolStripMenuItem();
            ClearFormToolStripMenuItem = new ToolStripMenuItem();
            deleteLibraryToolStripMenuItem = new ToolStripMenuItem();
            filmLibraryBindingSource = new BindingSource(components);
            label7 = new Label();
            RatingBox = new TextBox();
            label8 = new Label();
            SummaryBox = new TextBox();
            label9 = new Label();
            SizeBox = new TextBox();
            label10 = new Label();
            StudioBox = new TextBox();
            buttonLikeThis = new Button();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filmLibraryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(562, 248);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(215, 57);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAddFilm
            // 
            buttonAddFilm.Location = new Point(562, 374);
            buttonAddFilm.Name = "buttonAddFilm";
            buttonAddFilm.Size = new Size(215, 57);
            buttonAddFilm.TabIndex = 1;
            buttonAddFilm.Text = "Внести новий фільм";
            buttonAddFilm.UseVisualStyleBackColor = true;
            buttonAddFilm.Click += buttonAddFilm_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(143, 45);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(254, 27);
            NameBox.TabIndex = 2;
            // 
            // YearBox
            // 
            YearBox.Location = new Point(143, 78);
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(254, 27);
            YearBox.TabIndex = 3;
            YearBox.KeyPress += YearBox_KeyPress;
            // 
            // GenreBox
            // 
            GenreBox.Location = new Point(143, 111);
            GenreBox.Name = "GenreBox";
            GenreBox.Size = new Size(254, 27);
            GenreBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 52);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 5;
            label1.Text = "Назва";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 85);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 6;
            label2.Text = "Рік виходу";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 118);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 7;
            label3.Text = "Жанр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 118);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 13;
            label4.Text = "Сервіси";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(419, 85);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 12;
            label5.Text = "Актори";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(419, 52);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 11;
            label6.Text = "Режисер";
            // 
            // LocationBox
            // 
            LocationBox.Location = new Point(523, 111);
            LocationBox.Name = "LocationBox";
            LocationBox.Size = new Size(254, 27);
            LocationBox.TabIndex = 10;
            // 
            // ActorBox
            // 
            ActorBox.Location = new Point(523, 78);
            ActorBox.Name = "ActorBox";
            ActorBox.Size = new Size(254, 27);
            ActorBox.TabIndex = 9;
            // 
            // DirectorBox
            // 
            DirectorBox.Location = new Point(523, 45);
            DirectorBox.Name = "DirectorBox";
            DirectorBox.Size = new Size(254, 27);
            DirectorBox.TabIndex = 8;
            // 
            // ResultListBox
            // 
            ResultListBox.DataSource = filmBindingSource;
            ResultListBox.DisplayMember = "Title";
            ResultListBox.FormattingEnabled = true;
            ResultListBox.Location = new Point(36, 248);
            ResultListBox.Name = "ResultListBox";
            ResultListBox.Size = new Size(457, 184);
            ResultListBox.TabIndex = 14;
            ResultListBox.ValueMember = "ReleaseYear";
            ResultListBox.DoubleClick += ResultListBox_DoubleClick;
            // 
            // filmBindingSource
            // 
            filmBindingSource.DataSource = typeof(Film);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, изменитьToolStripMenuItem, инструментыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAsToolStripMenuItem, loadFromToolStripMenuItem, saveSearchResultToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(318, 26);
            saveAsToolStripMenuItem.Text = "Зберегти бібліотеку як...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // loadFromToolStripMenuItem
            // 
            loadFromToolStripMenuItem.Name = "loadFromToolStripMenuItem";
            loadFromToolStripMenuItem.Size = new Size(318, 26);
            loadFromToolStripMenuItem.Text = "Завантажити з...";
            loadFromToolStripMenuItem.Click += loadFromToolStripMenuItem_Click;
            // 
            // saveSearchResultToolStripMenuItem
            // 
            saveSearchResultToolStripMenuItem.Name = "saveSearchResultToolStripMenuItem";
            saveSearchResultToolStripMenuItem.Size = new Size(318, 26);
            saveSearchResultToolStripMenuItem.Text = "Зберегти результати пошуку як...";
            saveSearchResultToolStripMenuItem.Click += saveSearchResultToolStripMenuItem_Click;
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator3, toolStripSeparator4, seenToolStripMenuItem, wantToToolStripMenuItem, shareSeenToolStripMenuItem, shareWantToToolStripMenuItem });
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(81, 24);
            изменитьToolStripMenuItem.Text = "&Колекції";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(270, 6);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(270, 6);
            // 
            // seenToolStripMenuItem
            // 
            seenToolStripMenuItem.Name = "seenToolStripMenuItem";
            seenToolStripMenuItem.Size = new Size(273, 26);
            seenToolStripMenuItem.Text = "Переглянув";
            seenToolStripMenuItem.Click += seenToolStripMenuItem_Click;
            // 
            // wantToToolStripMenuItem
            // 
            wantToToolStripMenuItem.Name = "wantToToolStripMenuItem";
            wantToToolStripMenuItem.Size = new Size(273, 26);
            wantToToolStripMenuItem.Text = "Хочу переглянути";
            wantToToolStripMenuItem.Click += wantToToolStripMenuItem_Click;
            // 
            // shareSeenToolStripMenuItem
            // 
            shareSeenToolStripMenuItem.Name = "shareSeenToolStripMenuItem";
            shareSeenToolStripMenuItem.Size = new Size(273, 26);
            shareSeenToolStripMenuItem.Text = "Поділитись переглянутим";
            shareSeenToolStripMenuItem.Click += shareSeenToolStripMenuItem_Click;
            // 
            // shareWantToToolStripMenuItem
            // 
            shareWantToToolStripMenuItem.Name = "shareWantToToolStripMenuItem";
            shareWantToToolStripMenuItem.Size = new Size(273, 26);
            shareWantToToolStripMenuItem.Text = "Поділитись бажаним";
            shareWantToToolStripMenuItem.Click += shareWantToToolStripMenuItem_Click;
            // 
            // инструментыToolStripMenuItem
            // 
            инструментыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ClearFormToolStripMenuItem, deleteLibraryToolStripMenuItem });
            инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            инструментыToolStripMenuItem.Size = new Size(108, 24);
            инструментыToolStripMenuItem.Text = "&Інструменти";
            // 
            // ClearFormToolStripMenuItem
            // 
            ClearFormToolStripMenuItem.Name = "ClearFormToolStripMenuItem";
            ClearFormToolStripMenuItem.Size = new Size(294, 26);
            ClearFormToolStripMenuItem.Text = "Очистити поля";
            ClearFormToolStripMenuItem.Click += ClearFormToolStripMenuItem_Click;
            // 
            // deleteLibraryToolStripMenuItem
            // 
            deleteLibraryToolStripMenuItem.Name = "deleteLibraryToolStripMenuItem";
            deleteLibraryToolStripMenuItem.Size = new Size(294, 26);
            deleteLibraryToolStripMenuItem.Text = "Видалити поточну бібліотеку";
            deleteLibraryToolStripMenuItem.Click += deleteLibraryToolStripMenuItem_Click;
            // 
            // filmLibraryBindingSource
            // 
            filmLibraryBindingSource.DataSource = typeof(FilmLibrary);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(419, 151);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 19;
            label7.Text = "Рейтинг";
            // 
            // RatingBox
            // 
            RatingBox.Location = new Point(523, 144);
            RatingBox.Name = "RatingBox";
            RatingBox.Size = new Size(254, 27);
            RatingBox.TabIndex = 18;
            RatingBox.KeyPress += RatingBox_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 151);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 17;
            label8.Text = "Опис";
            // 
            // SummaryBox
            // 
            SummaryBox.Location = new Point(143, 144);
            SummaryBox.Name = "SummaryBox";
            SummaryBox.Size = new Size(254, 27);
            SummaryBox.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 184);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 21;
            label9.Text = "Час (хв.)";
            // 
            // SizeBox
            // 
            SizeBox.Location = new Point(143, 177);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(254, 27);
            SizeBox.TabIndex = 20;
            SizeBox.KeyPress += SizeBox_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(419, 184);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 23;
            label10.Text = "Студія";
            // 
            // StudioBox
            // 
            StudioBox.Location = new Point(523, 177);
            StudioBox.Name = "StudioBox";
            StudioBox.Size = new Size(254, 27);
            StudioBox.TabIndex = 22;
            // 
            // buttonLikeThis
            // 
            buttonLikeThis.Location = new Point(562, 311);
            buttonLikeThis.Name = "buttonLikeThis";
            buttonLikeThis.Size = new Size(215, 57);
            buttonLikeThis.TabIndex = 24;
            buttonLikeThis.Text = "Знайти схожі на цей";
            buttonLikeThis.UseVisualStyleBackColor = true;
            buttonLikeThis.Click += buttonLikeThis_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 234, 193);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLikeThis);
            Controls.Add(label10);
            Controls.Add(StudioBox);
            Controls.Add(label9);
            Controls.Add(SizeBox);
            Controls.Add(label7);
            Controls.Add(RatingBox);
            Controls.Add(label8);
            Controls.Add(SummaryBox);
            Controls.Add(ResultListBox);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(LocationBox);
            Controls.Add(ActorBox);
            Controls.Add(DirectorBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GenreBox);
            Controls.Add(YearBox);
            Controls.Add(NameBox);
            Controls.Add(buttonAddFilm);
            Controls.Add(buttonSearch);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "MainForm";
            Text = "Фільмотека";
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)filmLibraryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSearch;
        private Button buttonAddFilm;
        private TextBox NameBox;
        private TextBox YearBox;
        private TextBox GenreBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox LocationBox;
        private TextBox ActorBox;
        private TextBox DirectorBox;
        private ListBox ResultListBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem инструментыToolStripMenuItem;
        private BindingSource filmBindingSource;
        private BindingSource filmLibraryBindingSource;
        private Label label7;
        private TextBox RatingBox;
        private Label label8;
        private TextBox SummaryBox;
        private Label label9;
        private TextBox SizeBox;
        private Label label10;
        private TextBox StudioBox;
        private ToolStripMenuItem ClearFormToolStripMenuItem;
        private ToolStripMenuItem seenToolStripMenuItem;
        private Button buttonLikeThis;
        private ToolStripMenuItem wantToToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem loadFromToolStripMenuItem;
        private ToolStripMenuItem shareSeenToolStripMenuItem;
        private ToolStripMenuItem shareWantToToolStripMenuItem;
        private ToolStripMenuItem saveSearchResultToolStripMenuItem;
        private ToolStripMenuItem deleteLibraryToolStripMenuItem;
    }
}
