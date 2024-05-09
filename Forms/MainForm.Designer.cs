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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            button1 = new Button();
            button2 = new Button();
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
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитькакToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            печатьToolStripMenuItem = new ToolStripMenuItem();
            предварительныйпросмотрToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            seenToolStripMenuItem = new ToolStripMenuItem();
            очиститиToolStripMenuItem = new ToolStripMenuItem();
            инструментыToolStripMenuItem = new ToolStripMenuItem();
            очиститиПоляToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            содержимоеToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            опрограммеToolStripMenuItem = new ToolStripMenuItem();
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
            хочуПереглянутиToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filmLibraryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(523, 248);
            button1.Name = "button1";
            button1.Size = new Size(215, 57);
            button1.TabIndex = 0;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(523, 374);
            button2.Name = "button2";
            button2.Size = new Size(215, 57);
            button2.TabIndex = 1;
            button2.Text = "Внести новий фільм";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, изменитьToolStripMenuItem, инструментыToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, toolStripSeparator, сохранитьToolStripMenuItem, сохранитькакToolStripMenuItem, toolStripSeparator1, печатьToolStripMenuItem, предварительныйпросмотрToolStripMenuItem, toolStripSeparator2, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Image = (Image)resources.GetObject("создатьToolStripMenuItem.Image");
            создатьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            создатьToolStripMenuItem.Size = new Size(294, 26);
            создатьToolStripMenuItem.Text = "&Создать";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
            открытьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(294, 26);
            открытьToolStripMenuItem.Text = "&Открыть";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(291, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьToolStripMenuItem.Image");
            сохранитьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(294, 26);
            сохранитьToolStripMenuItem.Text = "&Сохранить";
            // 
            // сохранитькакToolStripMenuItem
            // 
            сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
            сохранитькакToolStripMenuItem.Size = new Size(294, 26);
            сохранитькакToolStripMenuItem.Text = "Сохранить &как";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(291, 6);
            // 
            // печатьToolStripMenuItem
            // 
            печатьToolStripMenuItem.Image = (Image)resources.GetObject("печатьToolStripMenuItem.Image");
            печатьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            печатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            печатьToolStripMenuItem.Size = new Size(294, 26);
            печатьToolStripMenuItem.Text = "&Печать";
            // 
            // предварительныйпросмотрToolStripMenuItem
            // 
            предварительныйпросмотрToolStripMenuItem.Image = (Image)resources.GetObject("предварительныйпросмотрToolStripMenuItem.Image");
            предварительныйпросмотрToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            предварительныйпросмотрToolStripMenuItem.Name = "предварительныйпросмотрToolStripMenuItem";
            предварительныйпросмотрToolStripMenuItem.Size = new Size(294, 26);
            предварительныйпросмотрToolStripMenuItem.Text = "Предварительный про&смотр";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(291, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(294, 26);
            выходToolStripMenuItem.Text = "Вы&ход";
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator3, toolStripSeparator4, seenToolStripMenuItem, хочуПереглянутиToolStripMenuItem, очиститиToolStripMenuItem });
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(81, 24);
            изменитьToolStripMenuItem.Text = "&Колекції";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(221, 6);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(221, 6);
            // 
            // seenToolStripMenuItem
            // 
            seenToolStripMenuItem.Name = "seenToolStripMenuItem";
            seenToolStripMenuItem.Size = new Size(224, 26);
            seenToolStripMenuItem.Text = "Переглянув";
            seenToolStripMenuItem.Click += seenToolStripMenuItem_Click;
            // 
            // очиститиToolStripMenuItem
            // 
            очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            очиститиToolStripMenuItem.Size = new Size(224, 26);
            очиститиToolStripMenuItem.Text = "Очистити";
            // 
            // инструментыToolStripMenuItem
            // 
            инструментыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { очиститиПоляToolStripMenuItem });
            инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            инструментыToolStripMenuItem.Size = new Size(108, 24);
            инструментыToolStripMenuItem.Text = "&Інструменти";
            // 
            // очиститиПоляToolStripMenuItem
            // 
            очиститиПоляToolStripMenuItem.Name = "очиститиПоляToolStripMenuItem";
            очиститиПоляToolStripMenuItem.Size = new Size(195, 26);
            очиститиПоляToolStripMenuItem.Text = "Очистити поля";
            очиститиПоляToolStripMenuItem.Click += очиститиПоляToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { содержимоеToolStripMenuItem, toolStripSeparator5, опрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "&Справка";
            // 
            // содержимоеToolStripMenuItem
            // 
            содержимоеToolStripMenuItem.Name = "содержимоеToolStripMenuItem";
            содержимоеToolStripMenuItem.Size = new Size(198, 26);
            содержимоеToolStripMenuItem.Text = "&Содержимое";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(195, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            опрограммеToolStripMenuItem.Size = new Size(198, 26);
            опрограммеToolStripMenuItem.Text = "&О программе…";
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
            buttonLikeThis.Location = new Point(523, 311);
            buttonLikeThis.Name = "buttonLikeThis";
            buttonLikeThis.Size = new Size(215, 57);
            buttonLikeThis.TabIndex = 24;
            buttonLikeThis.Text = "Знайти схожі на цей";
            buttonLikeThis.UseVisualStyleBackColor = true;
            buttonLikeThis.Click += buttonLikeThis_Click;
            // 
            // хочуПереглянутиToolStripMenuItem
            // 
            хочуПереглянутиToolStripMenuItem.Name = "хочуПереглянутиToolStripMenuItem";
            хочуПереглянутиToolStripMenuItem.Size = new Size(224, 26);
            хочуПереглянутиToolStripMenuItem.Text = "Хочу переглянути";
            хочуПереглянутиToolStripMenuItem.Click += хочуПереглянутиToolStripMenuItem_Click;
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
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "MainForm";
            Text = "Кінотека";
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)filmLibraryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
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
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитькакToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem инструментыToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem содержимоеToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem опрограммеToolStripMenuItem;
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
        private ToolStripMenuItem очиститиПоляToolStripMenuItem;
        private ToolStripMenuItem очиститиToolStripMenuItem;
        private ToolStripMenuItem seenToolStripMenuItem;
        private Button buttonLikeThis;
        private ToolStripMenuItem хочуПереглянутиToolStripMenuItem;
    }
}
