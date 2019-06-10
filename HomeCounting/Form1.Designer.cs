namespace HomeCounting
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Дата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тип = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Значение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.От = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Куда = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Категория = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьКатегорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оСоздателеЭтогоЧудаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Дата,
            this.Тип,
            this.Значение,
            this.От,
            this.Куда,
            this.Категория});
            this.dataGridView1.Location = new System.Drawing.Point(73, 244);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // Дата
            // 
            this.Дата.HeaderText = "Дата";
            this.Дата.Name = "Дата";
            // 
            // Тип
            // 
            this.Тип.HeaderText = "Тип";
            this.Тип.Name = "Тип";
            // 
            // Значение
            // 
            this.Значение.HeaderText = "Значение";
            this.Значение.Name = "Значение";
            // 
            // От
            // 
            this.От.HeaderText = "От";
            this.От.Name = "От";
            // 
            // Куда
            // 
            this.Куда.HeaderText = "Куда";
            this.Куда.Name = "Куда";
            // 
            // Категория
            // 
            this.Категория.HeaderText = "Категория";
            this.Категория.Name = "Категория";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.категорииToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьСчётToolStripMenuItem,
            this.удалитьСчетToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.создатьToolStripMenuItem.Text = "Создать счёт";
            // 
            // открытьСчётToolStripMenuItem
            // 
            this.открытьСчётToolStripMenuItem.Name = "открытьСчётToolStripMenuItem";
            this.открытьСчётToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьСчётToolStripMenuItem.Text = "Открыть счёт";
            // 
            // удалитьСчетToolStripMenuItem
            // 
            this.удалитьСчетToolStripMenuItem.Name = "удалитьСчетToolStripMenuItem";
            this.удалитьСчетToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьСчетToolStripMenuItem.Text = "Удалить счет";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.закрытьToolStripMenuItem.Text = "Закрыть программу";
            // 
            // категорииToolStripMenuItem
            // 
            this.категорииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКатегориюToolStripMenuItem,
            this.изменитьКатегорииToolStripMenuItem,
            this.удалитьКатегориюToolStripMenuItem});
            this.категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            this.категорииToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.категорииToolStripMenuItem.Text = "Категории";
            // 
            // добавитьКатегориюToolStripMenuItem
            // 
            this.добавитьКатегориюToolStripMenuItem.Name = "добавитьКатегориюToolStripMenuItem";
            this.добавитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.добавитьКатегориюToolStripMenuItem.Text = "Добавить категорию";
            // 
            // изменитьКатегорииToolStripMenuItem
            // 
            this.изменитьКатегорииToolStripMenuItem.Name = "изменитьКатегорииToolStripMenuItem";
            this.изменитьКатегорииToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.изменитьКатегорииToolStripMenuItem.Text = "Изменить категории";
            // 
            // удалитьКатегориюToolStripMenuItem
            // 
            this.удалитьКатегориюToolStripMenuItem.Name = "удалитьКатегориюToolStripMenuItem";
            this.удалитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.удалитьКатегориюToolStripMenuItem.Text = "Удалить категорию";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оСоздателеЭтогоЧудаToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оСоздателеЭтогоЧудаToolStripMenuItem
            // 
            this.оСоздателеЭтогоЧудаToolStripMenuItem.Name = "оСоздателеЭтогоЧудаToolStripMenuItem";
            this.оСоздателеЭтогоЧудаToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.оСоздателеЭтогоЧудаToolStripMenuItem.Text = "О создателе этого чуда";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Создать счёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Открыть счёт";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить счёт";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 51);
            this.button4.TabIndex = 5;
            this.button4.Text = "Новая категория";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 51);
            this.button5.TabIndex = 6;
            this.button5.Text = "Изменить категории";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(136, 146);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 51);
            this.button6.TabIndex = 7;
            this.button6.Text = "Удалить категорию";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(448, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 28);
            this.button7.TabIndex = 8;
            this.button7.Text = "Перевести на счет";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Счёт 1",
            "Счёт 2"});
            this.comboBox1.Location = new System.Drawing.Point(311, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Счёт 1",
            "Счёт 2"});
            this.comboBox2.Location = new System.Drawing.Point(613, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Счёт:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Счёт 1",
            "Счёт 2"});
            this.comboBox3.Location = new System.Drawing.Point(358, 139);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Баланс:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Описание счёта";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(448, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Домашняя бухгалтерия";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оСоздателеЭтогоЧудаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьСчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьКатегорииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип;
        private System.Windows.Forms.DataGridViewTextBoxColumn Значение;
        private System.Windows.Forms.DataGridViewTextBoxColumn От;
        private System.Windows.Forms.DataGridViewTextBoxColumn Куда;
        private System.Windows.Forms.DataGridViewTextBoxColumn Категория;
        private System.Windows.Forms.TextBox textBox1;
    }
}

