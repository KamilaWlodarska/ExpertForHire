
namespace projekt_WDBD
{
    partial class Form2
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
            System.Windows.Forms.Label idZleceniaLabel;
            System.Windows.Forms.Label dataZleceniaLabel;
            System.Windows.Forms.Label dataPlanLabel;
            System.Windows.Forms.Label dataRealizacjiLabel;
            System.Windows.Forms.Label idKlientaLabel;
            System.Windows.Forms.Label uslugaLabel;
            System.Windows.Forms.Label idFachowcaLabel;
            System.Windows.Forms.Label czasWykonaniaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.database2DataSet = new projekt_WDBD.Database2DataSet();
            this.zleceniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zleceniaTableAdapter = new projekt_WDBD.Database2DataSetTableAdapters.ZleceniaTableAdapter();
            this.tableAdapterManager = new projekt_WDBD.Database2DataSetTableAdapters.TableAdapterManager();
            this.zleceniaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZleceniaTextBox = new System.Windows.Forms.TextBox();
            this.dataZleceniaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataPlanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataRealizacjiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idKlientaTextBox = new System.Windows.Forms.TextBox();
            this.uslugaTextBox = new System.Windows.Forms.TextBox();
            this.idFachowcaTextBox = new System.Windows.Forms.TextBox();
            this.czasWykonaniaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            idZleceniaLabel = new System.Windows.Forms.Label();
            dataZleceniaLabel = new System.Windows.Forms.Label();
            dataPlanLabel = new System.Windows.Forms.Label();
            dataRealizacjiLabel = new System.Windows.Forms.Label();
            idKlientaLabel = new System.Windows.Forms.Label();
            uslugaLabel = new System.Windows.Forms.Label();
            idFachowcaLabel = new System.Windows.Forms.Label();
            czasWykonaniaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zleceniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zleceniaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idZleceniaLabel
            // 
            idZleceniaLabel.AutoSize = true;
            idZleceniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            idZleceniaLabel.Location = new System.Drawing.Point(30, 332);
            idZleceniaLabel.Name = "idZleceniaLabel";
            idZleceniaLabel.Size = new System.Drawing.Size(112, 25);
            idZleceniaLabel.TabIndex = 3;
            idZleceniaLabel.Text = "id Zlecenia:";
            // 
            // dataZleceniaLabel
            // 
            dataZleceniaLabel.AutoSize = true;
            dataZleceniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataZleceniaLabel.Location = new System.Drawing.Point(30, 377);
            dataZleceniaLabel.Name = "dataZleceniaLabel";
            dataZleceniaLabel.Size = new System.Drawing.Size(135, 25);
            dataZleceniaLabel.TabIndex = 5;
            dataZleceniaLabel.Text = "data Zlecenia:";
            // 
            // dataPlanLabel
            // 
            dataPlanLabel.AutoSize = true;
            dataPlanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataPlanLabel.Location = new System.Drawing.Point(30, 427);
            dataPlanLabel.Name = "dataPlanLabel";
            dataPlanLabel.Size = new System.Drawing.Size(100, 25);
            dataPlanLabel.TabIndex = 7;
            dataPlanLabel.Text = "data Plan:";
            // 
            // dataRealizacjiLabel
            // 
            dataRealizacjiLabel.AutoSize = true;
            dataRealizacjiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataRealizacjiLabel.Location = new System.Drawing.Point(30, 476);
            dataRealizacjiLabel.Name = "dataRealizacjiLabel";
            dataRealizacjiLabel.Size = new System.Drawing.Size(143, 25);
            dataRealizacjiLabel.TabIndex = 9;
            dataRealizacjiLabel.Text = "data Realizacji:";
            // 
            // idKlientaLabel
            // 
            idKlientaLabel.AutoSize = true;
            idKlientaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            idKlientaLabel.Location = new System.Drawing.Point(563, 330);
            idKlientaLabel.Name = "idKlientaLabel";
            idKlientaLabel.Size = new System.Drawing.Size(98, 25);
            idKlientaLabel.TabIndex = 11;
            idKlientaLabel.Text = "id Klienta:";
            // 
            // uslugaLabel
            // 
            uslugaLabel.AutoSize = true;
            uslugaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            uslugaLabel.Location = new System.Drawing.Point(563, 378);
            uslugaLabel.Name = "uslugaLabel";
            uslugaLabel.Size = new System.Drawing.Size(76, 25);
            uslugaLabel.TabIndex = 13;
            uslugaLabel.Text = "usluga:";
            // 
            // idFachowcaLabel
            // 
            idFachowcaLabel.AutoSize = true;
            idFachowcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            idFachowcaLabel.Location = new System.Drawing.Point(563, 427);
            idFachowcaLabel.Name = "idFachowcaLabel";
            idFachowcaLabel.Size = new System.Drawing.Size(128, 25);
            idFachowcaLabel.TabIndex = 15;
            idFachowcaLabel.Text = "id Fachowca:";
            // 
            // czasWykonaniaLabel
            // 
            czasWykonaniaLabel.AutoSize = true;
            czasWykonaniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            czasWykonaniaLabel.Location = new System.Drawing.Point(563, 476);
            czasWykonaniaLabel.Name = "czasWykonaniaLabel";
            czasWykonaniaLabel.Size = new System.Drawing.Size(163, 25);
            czasWykonaniaLabel.TabIndex = 17;
            czasWykonaniaLabel.Text = "czas Wykonania:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(458, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zlecenia";
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zleceniaBindingSource
            // 
            this.zleceniaBindingSource.DataMember = "Zlecenia";
            this.zleceniaBindingSource.DataSource = this.database2DataSet;
            // 
            // zleceniaTableAdapter
            // 
            this.zleceniaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FachowcyTableAdapter = null;
            this.tableAdapterManager.KlienciTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projekt_WDBD.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZleceniaTableAdapter = this.zleceniaTableAdapter;
            // 
            // zleceniaDataGridView
            // 
            this.zleceniaDataGridView.AllowUserToAddRows = false;
            this.zleceniaDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zleceniaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.zleceniaDataGridView.AutoGenerateColumns = false;
            this.zleceniaDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.zleceniaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zleceniaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.zleceniaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zleceniaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.zleceniaDataGridView.DataSource = this.zleceniaBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.zleceniaDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.zleceniaDataGridView.GridColor = System.Drawing.Color.Black;
            this.zleceniaDataGridView.Location = new System.Drawing.Point(24, 84);
            this.zleceniaDataGridView.Name = "zleceniaDataGridView";
            this.zleceniaDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zleceniaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zleceniaDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.zleceniaDataGridView.Size = new System.Drawing.Size(1033, 220);
            this.zleceniaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idZlecenia";
            this.dataGridViewTextBoxColumn1.HeaderText = "idZlecenia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 81;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dataZlecenia";
            this.dataGridViewTextBoxColumn2.HeaderText = "dataZlecenia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 94;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataPlan";
            this.dataGridViewTextBoxColumn3.HeaderText = "dataPlan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 74;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dataRealizacji";
            this.dataGridViewTextBoxColumn4.HeaderText = "dataRealizacji";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 98;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idKlienta";
            this.dataGridViewTextBoxColumn5.HeaderText = "idKlienta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 72;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "usluga";
            this.dataGridViewTextBoxColumn6.HeaderText = "usluga";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "idFachowca";
            this.dataGridViewTextBoxColumn7.HeaderText = "idFachowca";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "czasWykonania";
            this.dataGridViewTextBoxColumn8.HeaderText = "czasWykonania";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 108;
            // 
            // idZleceniaTextBox
            // 
            this.idZleceniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zleceniaBindingSource, "idZlecenia", true));
            this.idZleceniaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idZleceniaTextBox.Location = new System.Drawing.Point(179, 327);
            this.idZleceniaTextBox.Name = "idZleceniaTextBox";
            this.idZleceniaTextBox.Size = new System.Drawing.Size(330, 30);
            this.idZleceniaTextBox.TabIndex = 4;
            // 
            // dataZleceniaDateTimePicker
            // 
            this.dataZleceniaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zleceniaBindingSource, "dataZlecenia", true));
            this.dataZleceniaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataZleceniaDateTimePicker.Location = new System.Drawing.Point(179, 373);
            this.dataZleceniaDateTimePicker.Name = "dataZleceniaDateTimePicker";
            this.dataZleceniaDateTimePicker.Size = new System.Drawing.Size(330, 30);
            this.dataZleceniaDateTimePicker.TabIndex = 6;
            // 
            // dataPlanDateTimePicker
            // 
            this.dataPlanDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zleceniaBindingSource, "dataPlan", true));
            this.dataPlanDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataPlanDateTimePicker.Location = new System.Drawing.Point(179, 422);
            this.dataPlanDateTimePicker.Name = "dataPlanDateTimePicker";
            this.dataPlanDateTimePicker.Size = new System.Drawing.Size(330, 30);
            this.dataPlanDateTimePicker.TabIndex = 8;
            // 
            // dataRealizacjiDateTimePicker
            // 
            this.dataRealizacjiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zleceniaBindingSource, "dataRealizacji", true));
            this.dataRealizacjiDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataRealizacjiDateTimePicker.Location = new System.Drawing.Point(179, 471);
            this.dataRealizacjiDateTimePicker.Name = "dataRealizacjiDateTimePicker";
            this.dataRealizacjiDateTimePicker.Size = new System.Drawing.Size(330, 30);
            this.dataRealizacjiDateTimePicker.TabIndex = 10;
            // 
            // idKlientaTextBox
            // 
            this.idKlientaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zleceniaBindingSource, "idKlienta", true));
            this.idKlientaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idKlientaTextBox.Location = new System.Drawing.Point(727, 327);
            this.idKlientaTextBox.Name = "idKlientaTextBox";
            this.idKlientaTextBox.Size = new System.Drawing.Size(330, 30);
            this.idKlientaTextBox.TabIndex = 12;
            // 
            // uslugaTextBox
            // 
            this.uslugaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zleceniaBindingSource, "usluga", true));
            this.uslugaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uslugaTextBox.Location = new System.Drawing.Point(727, 375);
            this.uslugaTextBox.Name = "uslugaTextBox";
            this.uslugaTextBox.Size = new System.Drawing.Size(330, 30);
            this.uslugaTextBox.TabIndex = 14;
            // 
            // idFachowcaTextBox
            // 
            this.idFachowcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zleceniaBindingSource, "idFachowca", true));
            this.idFachowcaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idFachowcaTextBox.Location = new System.Drawing.Point(727, 424);
            this.idFachowcaTextBox.Name = "idFachowcaTextBox";
            this.idFachowcaTextBox.Size = new System.Drawing.Size(330, 30);
            this.idFachowcaTextBox.TabIndex = 16;
            // 
            // czasWykonaniaTextBox
            // 
            this.czasWykonaniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zleceniaBindingSource, "czasWykonania", true));
            this.czasWykonaniaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czasWykonaniaTextBox.Location = new System.Drawing.Point(727, 473);
            this.czasWykonaniaTextBox.Name = "czasWykonaniaTextBox";
            this.czasWykonaniaTextBox.Size = new System.Drawing.Size(330, 30);
            this.czasWykonaniaTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(24, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "dodaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Azure;
            this.button2.Location = new System.Drawing.Point(222, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "aktualizuj";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Azure;
            this.button3.Location = new System.Drawing.Point(419, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 42);
            this.button3.TabIndex = 21;
            this.button3.Text = "usun";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.Azure;
            this.button4.Location = new System.Drawing.Point(611, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 42);
            this.button4.TabIndex = 22;
            this.button4.Text = "koszt";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.Azure;
            this.button5.Location = new System.Drawing.Point(804, 530);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(253, 42);
            this.button5.TabIndex = 23;
            this.button5.Text = "Fachowiec - Klient";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1101, 594);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(czasWykonaniaLabel);
            this.Controls.Add(this.czasWykonaniaTextBox);
            this.Controls.Add(idFachowcaLabel);
            this.Controls.Add(this.idFachowcaTextBox);
            this.Controls.Add(uslugaLabel);
            this.Controls.Add(this.uslugaTextBox);
            this.Controls.Add(idKlientaLabel);
            this.Controls.Add(this.idKlientaTextBox);
            this.Controls.Add(dataRealizacjiLabel);
            this.Controls.Add(this.dataRealizacjiDateTimePicker);
            this.Controls.Add(dataPlanLabel);
            this.Controls.Add(this.dataPlanDateTimePicker);
            this.Controls.Add(dataZleceniaLabel);
            this.Controls.Add(this.dataZleceniaDateTimePicker);
            this.Controls.Add(idZleceniaLabel);
            this.Controls.Add(this.idZleceniaTextBox);
            this.Controls.Add(this.zleceniaDataGridView);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Azure;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zleceniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zleceniaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource zleceniaBindingSource;
        private Database2DataSetTableAdapters.ZleceniaTableAdapter zleceniaTableAdapter;
        private Database2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView zleceniaDataGridView;
        private System.Windows.Forms.TextBox idZleceniaTextBox;
        private System.Windows.Forms.DateTimePicker dataZleceniaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataPlanDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataRealizacjiDateTimePicker;
        private System.Windows.Forms.TextBox idKlientaTextBox;
        private System.Windows.Forms.TextBox uslugaTextBox;
        private System.Windows.Forms.TextBox idFachowcaTextBox;
        private System.Windows.Forms.TextBox czasWykonaniaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}