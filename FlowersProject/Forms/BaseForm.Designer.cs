namespace FlowersProject
{
    partial class BaseForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_refresh = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.pictureBox_find = new System.Windows.Forms.PictureBox();
            this.label_flowers = new System.Windows.Forms.Label();
            this.pictureBox_eraser = new System.Windows.Forms.PictureBox();
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Provider = new System.Windows.Forms.TextBox();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Porvider = new System.Windows.Forms.Label();
            this.label_Coutry = new System.Windows.Forms.Label();
            this.label_TypeFlowers = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_Control = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_find)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox_refresh);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.pictureBox_find);
            this.panel1.Controls.Add(this.label_flowers);
            this.panel1.Controls.Add(this.pictureBox_eraser);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 40);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox_refresh
            // 
            this.pictureBox_refresh.Image = global::FlowersProject.Properties.Resources.refresh;
            this.pictureBox_refresh.Location = new System.Drawing.Point(623, 3);
            this.pictureBox_refresh.Name = "pictureBox_refresh";
            this.pictureBox_refresh.Size = new System.Drawing.Size(34, 34);
            this.pictureBox_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_refresh.TabIndex = 3;
            this.pictureBox_refresh.TabStop = false;
            this.pictureBox_refresh.Click += new System.EventHandler(this.pictureBox_refresh_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(704, 8);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 22);
            this.textBox_search.TabIndex = 4;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // pictureBox_find
            // 
            this.pictureBox_find.Image = global::FlowersProject.Properties.Resources.find;
            this.pictureBox_find.Location = new System.Drawing.Point(663, 3);
            this.pictureBox_find.Name = "pictureBox_find";
            this.pictureBox_find.Size = new System.Drawing.Size(34, 34);
            this.pictureBox_find.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_find.TabIndex = 2;
            this.pictureBox_find.TabStop = false;
            // 
            // label_flowers
            // 
            this.label_flowers.AutoSize = true;
            this.label_flowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_flowers.Location = new System.Drawing.Point(12, 8);
            this.label_flowers.Name = "label_flowers";
            this.label_flowers.Size = new System.Drawing.Size(91, 29);
            this.label_flowers.TabIndex = 0;
            this.label_flowers.Text = "Цветы";
            // 
            // pictureBox_eraser
            // 
            this.pictureBox_eraser.Image = global::FlowersProject.Properties.Resources.eraser;
            this.pictureBox_eraser.Location = new System.Drawing.Point(583, 3);
            this.pictureBox_eraser.Name = "pictureBox_eraser";
            this.pictureBox_eraser.Size = new System.Drawing.Size(34, 34);
            this.pictureBox_eraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_eraser.TabIndex = 1;
            this.pictureBox_eraser.TabStop = false;
            this.pictureBox_eraser.Click += new System.EventHandler(this.pictureBox_eraser_Click);
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Location = new System.Drawing.Point(2, 73);
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.RowHeadersWidth = 51;
            this.dataGridView_main.RowTemplate.Height = 24;
            this.dataGridView_main.Size = new System.Drawing.Size(816, 349);
            this.dataGridView_main.TabIndex = 5;
            this.dataGridView_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_Provider);
            this.panel2.Controls.Add(this.textBox_Country);
            this.panel2.Controls.Add(this.textBox_Type);
            this.panel2.Controls.Add(this.textBox_Id);
            this.panel2.Controls.Add(this.textBox_Name);
            this.panel2.Controls.Add(this.label_Porvider);
            this.panel2.Controls.Add(this.label_Coutry);
            this.panel2.Controls.Add(this.label_TypeFlowers);
            this.panel2.Controls.Add(this.label_Name);
            this.panel2.Controls.Add(this.label_Id);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label);
            this.panel2.Location = new System.Drawing.Point(0, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 156);
            this.panel2.TabIndex = 6;
            // 
            // textBox_Provider
            // 
            this.textBox_Provider.Location = new System.Drawing.Point(208, 121);
            this.textBox_Provider.Name = "textBox_Provider";
            this.textBox_Provider.Size = new System.Drawing.Size(266, 22);
            this.textBox_Provider.TabIndex = 11;
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(208, 93);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(266, 22);
            this.textBox_Country.TabIndex = 10;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(208, 65);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(266, 22);
            this.textBox_Type.TabIndex = 9;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(208, 9);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(266, 22);
            this.textBox_Id.TabIndex = 7;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(208, 37);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(266, 22);
            this.textBox_Name.TabIndex = 8;
            // 
            // label_Porvider
            // 
            this.label_Porvider.AutoSize = true;
            this.label_Porvider.Location = new System.Drawing.Point(120, 124);
            this.label_Porvider.Name = "label_Porvider";
            this.label_Porvider.Size = new System.Drawing.Size(82, 16);
            this.label_Porvider.TabIndex = 6;
            this.label_Porvider.Text = "Поставщик:";
            // 
            // label_Coutry
            // 
            this.label_Coutry.AutoSize = true;
            this.label_Coutry.Location = new System.Drawing.Point(40, 96);
            this.label_Coutry.Name = "label_Coutry";
            this.label_Coutry.Size = new System.Drawing.Size(162, 16);
            this.label_Coutry.TabIndex = 5;
            this.label_Coutry.Text = "Страна происхождения:";
            // 
            // label_TypeFlowers
            // 
            this.label_TypeFlowers.AutoSize = true;
            this.label_TypeFlowers.Location = new System.Drawing.Point(82, 68);
            this.label_TypeFlowers.Name = "label_TypeFlowers";
            this.label_TypeFlowers.Size = new System.Drawing.Size(120, 16);
            this.label_TypeFlowers.TabIndex = 4;
            this.label_TypeFlowers.Text = "Сорт, тип цветка:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(126, 40);
            this.label_Name.Name = "label_Name";
            this.label_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Name.Size = new System.Drawing.Size(76, 16);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Название:";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(179, 12);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(23, 16);
            this.label_Id.TabIndex = 2;
            this.label_Id.Text = "ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FlowersProject.Properties.Resources.record;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(43, 11);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(83, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Запись:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_Change);
            this.panel3.Controls.Add(this.button_Save);
            this.panel3.Controls.Add(this.button_Delete);
            this.panel3.Controls.Add(this.button_Add);
            this.panel3.Controls.Add(this.label_Control);
            this.panel3.Location = new System.Drawing.Point(525, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 156);
            this.panel3.TabIndex = 0;
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(29, 90);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(117, 34);
            this.button_Change.TabIndex = 14;
            this.button_Change.Text = "Изменить";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(152, 90);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(117, 34);
            this.button_Save.TabIndex = 13;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(152, 52);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(117, 32);
            this.button_Delete.TabIndex = 12;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(29, 52);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(117, 32);
            this.button_Add.TabIndex = 8;
            this.button_Add.Text = "Новая запись";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_Control
            // 
            this.label_Control.AutoSize = true;
            this.label_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Control.Location = new System.Drawing.Point(97, 24);
            this.label_Control.Name = "label_Control";
            this.label_Control.Size = new System.Drawing.Size(128, 25);
            this.label_Control.TabIndex = 7;
            this.label_Control.Text = "Управление:";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 572);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(834, 619);
            this.MinimumSize = new System.Drawing.Size(834, 619);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "            ";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_find)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_flowers;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.PictureBox pictureBox_find;
        private System.Windows.Forms.PictureBox pictureBox_eraser;
        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_Provider;
        private System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Porvider;
        private System.Windows.Forms.Label label_Coutry;
        private System.Windows.Forms.Label label_TypeFlowers;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_Control;
        private System.Windows.Forms.PictureBox pictureBox_refresh;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Delete;
    }
}

