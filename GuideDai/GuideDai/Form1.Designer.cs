namespace GuideDai
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
            this.components = new System.ComponentModel.Container();
            this.infoGridView = new System.Windows.Forms.DataGridView();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberBortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOfLastControlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personInfosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TableForUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invitationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoButton = new System.Windows.Forms.Button();
            this.PoshukBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ParametrComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoGridView
            // 
            this.infoGridView.AllowUserToAddRows = false;
            this.infoGridView.AllowUserToDeleteRows = false;
            this.infoGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoGridView.AutoGenerateColumns = false;
            this.infoGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.infoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.numberBortDataGridViewTextBoxColumn,
            this.dataOfLastControlDataGridViewTextBoxColumn});
            this.infoGridView.DataSource = this.personInfosBindingSource;
            this.infoGridView.Location = new System.Drawing.Point(0, 24);
            this.infoGridView.Name = "infoGridView";
            this.infoGridView.ReadOnly = true;
            this.infoGridView.RowHeadersVisible = false;
            this.infoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.infoGridView.Size = new System.Drawing.Size(800, 343);
            this.infoGridView.TabIndex = 0;
            this.infoGridView.DoubleClick += new System.EventHandler(this.showInfoButton_Click);
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "ПІП";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип транспорту";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Колір";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberBortDataGridViewTextBoxColumn
            // 
            this.numberBortDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberBortDataGridViewTextBoxColumn.DataPropertyName = "NumberBort";
            this.numberBortDataGridViewTextBoxColumn.HeaderText = "Бортовий номер";
            this.numberBortDataGridViewTextBoxColumn.Name = "numberBortDataGridViewTextBoxColumn";
            this.numberBortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataOfLastControlDataGridViewTextBoxColumn
            // 
            this.dataOfLastControlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataOfLastControlDataGridViewTextBoxColumn.DataPropertyName = "DataOfLastControl";
            this.dataOfLastControlDataGridViewTextBoxColumn.HeaderText = "Дата останнього техогляду";
            this.dataOfLastControlDataGridViewTextBoxColumn.Name = "dataOfLastControlDataGridViewTextBoxColumn";
            this.dataOfLastControlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personInfosBindingSource
            // 
            this.personInfosBindingSource.DataMember = "PersonInfos";
            this.personInfosBindingSource.DataSource = this.databaseBindingSource;
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataSource = typeof(GuideDai.Models.Database);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tableToolStripMenuItem,
            this.invitationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShowShortcutKeys = false;
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.loadToolStripMenuItem.Text = "Завантажити";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveToolStripMenuItem.Text = "Зберегти";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.TableForUserToolStripMenuItem});
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tableToolStripMenuItem.Text = "Таблиця";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "Створити";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Змінити";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Видалити";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // TableForUserToolStripMenuItem
            // 
            this.TableForUserToolStripMenuItem.Name = "TableForUserToolStripMenuItem";
            this.TableForUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TableForUserToolStripMenuItem.Text = "Таблиця корист.";
            this.TableForUserToolStripMenuItem.Click += new System.EventHandler(this.TableForUserToolStripMenuItem_Click);
            // 
            // invitationToolStripMenuItem
            // 
            this.invitationToolStripMenuItem.Name = "invitationToolStripMenuItem";
            this.invitationToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.invitationToolStripMenuItem.Text = "Запрошення";
            this.invitationToolStripMenuItem.Click += new System.EventHandler(this.invitationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.helpToolStripMenuItem.Text = "Допомога";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showInfoButton.Location = new System.Drawing.Point(687, 373);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(84, 23);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Детальніше";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // PoshukBox
            // 
            this.PoshukBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PoshukBox.Location = new System.Drawing.Point(97, 375);
            this.PoshukBox.Name = "PoshukBox";
            this.PoshukBox.Size = new System.Drawing.Size(199, 20);
            this.PoshukBox.TabIndex = 3;
            this.PoshukBox.TextChanged += new System.EventHandler(this.searchInfoBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пошук:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Параметр:";
            // 
            // ParametrComboBox
            // 
            this.ParametrComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ParametrComboBox.FormattingEnabled = true;
            this.ParametrComboBox.Items.AddRange(new object[] {
            "ПІП",
            "Адреса",
            "Тип транспорту",
            "Марка",
            "Колір",
            "Бортовий номер"});
            this.ParametrComboBox.Location = new System.Drawing.Point(97, 401);
            this.ParametrComboBox.Name = "ParametrComboBox";
            this.ParametrComboBox.Size = new System.Drawing.Size(199, 21);
            this.ParametrComboBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ParametrComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PoshukBox);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.infoGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Головна";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.infoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView infoGridView;
        private System.Windows.Forms.BindingSource personInfosBindingSource;
        private System.Windows.Forms.BindingSource databaseBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem invitationToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberBortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOfLastControlDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.TextBox PoshukBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TableForUserToolStripMenuItem;
        private System.Windows.Forms.ComboBox ParametrComboBox;
    }
}

