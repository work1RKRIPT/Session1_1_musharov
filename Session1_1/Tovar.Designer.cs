namespace Session1_1
{
    partial class Tovar
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
            System.Windows.Forms.Label артикулLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label скидкаLabel;
            System.Windows.Forms.Label производительLabel;
            System.Windows.Forms.Label поставщикLabel;
            System.Windows.Forms.Label категория_товараLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label изображениеLabel;
            System.Windows.Forms.Label labelitogCentaText;
            this.dataSet = new Session1_1.DataSet();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new Session1_1.DataSetTableAdapters.TovarTableAdapter();
            this.tableAdapterManager = new Session1_1.DataSetTableAdapters.TableAdapterManager();
            this.tovarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelMainText = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.артикулTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.единица_измеренияTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.скидкаTextBox = new System.Windows.Forms.TextBox();
            this.производительTextBox = new System.Windows.Forms.TextBox();
            this.поставщикTextBox = new System.Windows.Forms.TextBox();
            this.категория_товараTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.изображениеTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxTovar = new System.Windows.Forms.PictureBox();
            this.listBoxSkidka = new System.Windows.Forms.ListBox();
            this.labelPocent = new System.Windows.Forms.Label();
            this.labelRaschet = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFilterCount = new System.Windows.Forms.Label();
            артикулLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            скидкаLabel = new System.Windows.Forms.Label();
            производительLabel = new System.Windows.Forms.Label();
            поставщикLabel = new System.Windows.Forms.Label();
            категория_товараLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            изображениеLabel = new System.Windows.Forms.Label();
            labelitogCentaText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTovar)).BeginInit();
            this.SuspendLayout();
            // 
            // артикулLabel
            // 
            артикулLabel.AutoSize = true;
            артикулLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            артикулLabel.Location = new System.Drawing.Point(53, 326);
            артикулLabel.Name = "артикулLabel";
            артикулLabel.Size = new System.Drawing.Size(100, 25);
            артикулLabel.TabIndex = 3;
            артикулLabel.Text = "Артикул:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименованиеLabel.Location = new System.Drawing.Point(318, 326);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(167, 25);
            наименованиеLabel.TabIndex = 5;
            наименованиеLabel.Text = "Наименование:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            стоимостьLabel.Location = new System.Drawing.Point(53, 369);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(126, 25);
            стоимостьLabel.TabIndex = 9;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // скидкаLabel
            // 
            скидкаLabel.AutoSize = true;
            скидкаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            скидкаLabel.Location = new System.Drawing.Point(53, 406);
            скидкаLabel.Name = "скидкаLabel";
            скидкаLabel.Size = new System.Drawing.Size(91, 25);
            скидкаLabel.TabIndex = 11;
            скидкаLabel.Text = "Скидка:";
            // 
            // производительLabel
            // 
            производительLabel.AutoSize = true;
            производительLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            производительLabel.Location = new System.Drawing.Point(318, 369);
            производительLabel.Name = "производительLabel";
            производительLabel.Size = new System.Drawing.Size(172, 25);
            производительLabel.TabIndex = 13;
            производительLabel.Text = "Производитель:";
            // 
            // поставщикLabel
            // 
            поставщикLabel.AutoSize = true;
            поставщикLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            поставщикLabel.Location = new System.Drawing.Point(54, 489);
            поставщикLabel.Name = "поставщикLabel";
            поставщикLabel.Size = new System.Drawing.Size(129, 25);
            поставщикLabel.TabIndex = 15;
            поставщикLabel.Text = "Поставщик:";
            // 
            // категория_товараLabel
            // 
            категория_товараLabel.AutoSize = true;
            категория_товараLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            категория_товараLabel.Location = new System.Drawing.Point(318, 415);
            категория_товараLabel.Name = "категория_товараLabel";
            категория_товараLabel.Size = new System.Drawing.Size(121, 25);
            категория_товараLabel.TabIndex = 17;
            категория_товараLabel.Text = "Категория:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            количествоLabel.Location = new System.Drawing.Point(827, 323);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(135, 25);
            количествоLabel.TabIndex = 19;
            количествоLabel.Text = "Количество:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            описаниеLabel.Location = new System.Drawing.Point(318, 459);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(117, 25);
            описаниеLabel.TabIndex = 21;
            описаниеLabel.Text = "Описание:";
            // 
            // изображениеLabel
            // 
            изображениеLabel.AutoSize = true;
            изображениеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            изображениеLabel.Location = new System.Drawing.Point(963, 594);
            изображениеLabel.Name = "изображениеLabel";
            изображениеLabel.Size = new System.Drawing.Size(149, 25);
            изображениеLabel.TabIndex = 23;
            изображениеLabel.Text = "Изображение";
            // 
            // labelitogCentaText
            // 
            labelitogCentaText.AutoSize = true;
            labelitogCentaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelitogCentaText.Location = new System.Drawing.Point(54, 448);
            labelitogCentaText.Name = "labelitogCentaText";
            labelitogCentaText.Size = new System.Drawing.Size(163, 25);
            labelitogCentaText.TabIndex = 29;
            labelitogCentaText.Text = "Итоговая цена:";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.dataSet;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TovarTableAdapter = this.tovarTableAdapter;
            this.tableAdapterManager.UpdateOrder = Session1_1.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // tovarDataGridView
            // 
            this.tovarDataGridView.AutoGenerateColumns = false;
            this.tovarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tovarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.tovarDataGridView.DataSource = this.tovarBindingSource;
            this.tovarDataGridView.Location = new System.Drawing.Point(25, 86);
            this.tovarDataGridView.Name = "tovarDataGridView";
            this.tovarDataGridView.ReadOnly = true;
            this.tovarDataGridView.Size = new System.Drawing.Size(1142, 220);
            this.tovarDataGridView.TabIndex = 1;
            this.tovarDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tovarDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Артикул";
            this.dataGridViewTextBoxColumn1.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Единица_измерения";
            this.dataGridViewTextBoxColumn3.HeaderText = "Единица измерения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn4.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Скидка";
            this.dataGridViewTextBoxColumn5.HeaderText = "Скидка";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Производитель";
            this.dataGridViewTextBoxColumn6.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Поставщик";
            this.dataGridViewTextBoxColumn7.HeaderText = "Поставщик";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Категория_товара";
            this.dataGridViewTextBoxColumn8.HeaderText = "Категория товара";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn9.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn10.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Изображение";
            this.dataGridViewTextBoxColumn11.HeaderText = "Изображение";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Действующая_скидка";
            this.dataGridViewTextBoxColumn12.HeaderText = "Действующая скидка";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // LabelMainText
            // 
            this.LabelMainText.AutoSize = true;
            this.LabelMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMainText.Location = new System.Drawing.Point(18, 35);
            this.LabelMainText.Name = "LabelMainText";
            this.LabelMainText.Size = new System.Drawing.Size(114, 39);
            this.LabelMainText.TabIndex = 2;
            this.LabelMainText.Text = "Товар";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1071, 39);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 33);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // артикулTextBox
            // 
            this.артикулTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Артикул", true));
            this.артикулTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.артикулTextBox.Location = new System.Drawing.Point(180, 323);
            this.артикулTextBox.Name = "артикулTextBox";
            this.артикулTextBox.Size = new System.Drawing.Size(100, 31);
            this.артикулTextBox.TabIndex = 4;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Наименование", true));
            this.наименованиеTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.наименованиеTextBox.Location = new System.Drawing.Point(509, 320);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(278, 31);
            this.наименованиеTextBox.TabIndex = 6;
            // 
            // единица_измеренияTextBox
            // 
            this.единица_измеренияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Единица_измерения", true));
            this.единица_измеренияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.единица_измеренияTextBox.Location = new System.Drawing.Point(1071, 320);
            this.единица_измеренияTextBox.Name = "единица_измеренияTextBox";
            this.единица_измеренияTextBox.Size = new System.Drawing.Size(100, 31);
            this.единица_измеренияTextBox.TabIndex = 8;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стоимостьTextBox.Location = new System.Drawing.Point(180, 366);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(100, 31);
            this.стоимостьTextBox.TabIndex = 10;
            // 
            // скидкаTextBox
            // 
            this.скидкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Скидка", true));
            this.скидкаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.скидкаTextBox.Location = new System.Drawing.Point(180, 403);
            this.скидкаTextBox.Name = "скидкаTextBox";
            this.скидкаTextBox.Size = new System.Drawing.Size(76, 31);
            this.скидкаTextBox.TabIndex = 12;
            // 
            // производительTextBox
            // 
            this.производительTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Производитель", true));
            this.производительTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.производительTextBox.Location = new System.Drawing.Point(509, 366);
            this.производительTextBox.Name = "производительTextBox";
            this.производительTextBox.Size = new System.Drawing.Size(278, 31);
            this.производительTextBox.TabIndex = 14;
            // 
            // поставщикTextBox
            // 
            this.поставщикTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Поставщик", true));
            this.поставщикTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.поставщикTextBox.Location = new System.Drawing.Point(59, 523);
            this.поставщикTextBox.Name = "поставщикTextBox";
            this.поставщикTextBox.Size = new System.Drawing.Size(358, 31);
            this.поставщикTextBox.TabIndex = 16;
            // 
            // категория_товараTextBox
            // 
            this.категория_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Категория_товара", true));
            this.категория_товараTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.категория_товараTextBox.Location = new System.Drawing.Point(509, 415);
            this.категория_товараTextBox.Name = "категория_товараTextBox";
            this.категория_товараTextBox.Size = new System.Drawing.Size(278, 31);
            this.категория_товараTextBox.TabIndex = 18;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Количество", true));
            this.количествоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количествоTextBox.Location = new System.Drawing.Point(968, 320);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(100, 31);
            this.количествоTextBox.TabIndex = 20;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Описание", true));
            this.описаниеTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.описаниеTextBox.Location = new System.Drawing.Point(509, 459);
            this.описаниеTextBox.Multiline = true;
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(347, 127);
            this.описаниеTextBox.TabIndex = 22;
            // 
            // изображениеTextBox
            // 
            this.изображениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Изображение", true));
            this.изображениеTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.изображениеTextBox.Location = new System.Drawing.Point(907, 560);
            this.изображениеTextBox.Name = "изображениеTextBox";
            this.изображениеTextBox.Size = new System.Drawing.Size(236, 31);
            this.изображениеTextBox.TabIndex = 24;
            // 
            // pictureBoxTovar
            // 
            this.pictureBoxTovar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTovar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxTovar.Location = new System.Drawing.Point(907, 371);
            this.pictureBoxTovar.Name = "pictureBoxTovar";
            this.pictureBoxTovar.Size = new System.Drawing.Size(236, 183);
            this.pictureBoxTovar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTovar.TabIndex = 25;
            this.pictureBoxTovar.TabStop = false;
            // 
            // listBoxSkidka
            // 
            this.listBoxSkidka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSkidka.FormattingEnabled = true;
            this.listBoxSkidka.ItemHeight = 24;
            this.listBoxSkidka.Items.AddRange(new object[] {
            "Все диапазоны",
            "От 0-9% ",
            "От 10-14%",
            "От 15% "});
            this.listBoxSkidka.Location = new System.Drawing.Point(180, 44);
            this.listBoxSkidka.Name = "listBoxSkidka";
            this.listBoxSkidka.Size = new System.Drawing.Size(185, 28);
            this.listBoxSkidka.TabIndex = 26;
            this.listBoxSkidka.SelectedIndexChanged += new System.EventHandler(this.listBoxSkidka_SelectedIndexChanged);
            // 
            // labelPocent
            // 
            this.labelPocent.AutoSize = true;
            this.labelPocent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPocent.Location = new System.Drawing.Point(262, 415);
            this.labelPocent.Name = "labelPocent";
            this.labelPocent.Size = new System.Drawing.Size(25, 24);
            this.labelPocent.TabIndex = 28;
            this.labelPocent.Text = "%";
            // 
            // labelRaschet
            // 
            this.labelRaschet.AutoSize = true;
            this.labelRaschet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRaschet.Location = new System.Drawing.Point(223, 449);
            this.labelRaschet.Name = "labelRaschet";
            this.labelRaschet.Size = new System.Drawing.Size(88, 24);
            this.labelRaschet.TabIndex = 30;
            this.labelRaschet.Text = "загрузка";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(496, 42);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(36, 25);
            this.labelCount.TabIndex = 31;
            this.labelCount.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(455, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "из";
            // 
            // labelFilterCount
            // 
            this.labelFilterCount.AutoSize = true;
            this.labelFilterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilterCount.Location = new System.Drawing.Point(413, 42);
            this.labelFilterCount.Name = "labelFilterCount";
            this.labelFilterCount.Size = new System.Drawing.Size(36, 25);
            this.labelFilterCount.TabIndex = 33;
            this.labelFilterCount.Text = "30";
            // 
            // Tovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 691);
            this.Controls.Add(this.labelFilterCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelRaschet);
            this.Controls.Add(labelitogCentaText);
            this.Controls.Add(this.labelPocent);
            this.Controls.Add(this.listBoxSkidka);
            this.Controls.Add(this.pictureBoxTovar);
            this.Controls.Add(артикулLabel);
            this.Controls.Add(this.артикулTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(this.единица_измеренияTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(скидкаLabel);
            this.Controls.Add(this.скидкаTextBox);
            this.Controls.Add(производительLabel);
            this.Controls.Add(this.производительTextBox);
            this.Controls.Add(поставщикLabel);
            this.Controls.Add(this.поставщикTextBox);
            this.Controls.Add(категория_товараLabel);
            this.Controls.Add(this.категория_товараTextBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(изображениеLabel);
            this.Controls.Add(this.изображениеTextBox);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.LabelMainText);
            this.Controls.Add(this.tovarDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смотреть товар";
            this.Load += new System.EventHandler(this.Tovar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTovar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private DataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tovarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label LabelMainText;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox артикулTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox единица_измеренияTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.TextBox скидкаTextBox;
        private System.Windows.Forms.TextBox производительTextBox;
        private System.Windows.Forms.TextBox поставщикTextBox;
        private System.Windows.Forms.TextBox категория_товараTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.TextBox изображениеTextBox;
        private System.Windows.Forms.ListBox listBoxSkidka;
        private System.Windows.Forms.Label labelPocent;
        private System.Windows.Forms.PictureBox pictureBoxTovar;
        private System.Windows.Forms.Label labelRaschet;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFilterCount;
    }
}