
namespace projekt_WDBD
{
    partial class Form4
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
            System.Windows.Forms.Label idFachowcaLabel;
            System.Windows.Forms.Label nrTelFLabel;
            System.Windows.Forms.Label zawodLabel;
            System.Windows.Forms.Label obszarLabel;
            System.Windows.Forms.Label stawkaGodzLabel;
            System.Windows.Forms.Label czyDostepnyLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.database2DataSet = new projekt_WDBD.Database2DataSet();
            this.fachowcyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fachowcyTableAdapter = new projekt_WDBD.Database2DataSetTableAdapters.FachowcyTableAdapter();
            this.tableAdapterManager = new projekt_WDBD.Database2DataSetTableAdapters.TableAdapterManager();
            this.fachowcyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idFachowcaTextBox = new System.Windows.Forms.TextBox();
            this.nrTelFTextBox = new System.Windows.Forms.TextBox();
            this.zawodTextBox = new System.Windows.Forms.TextBox();
            this.obszarTextBox = new System.Windows.Forms.TextBox();
            this.stawkaGodzTextBox = new System.Windows.Forms.TextBox();
            this.czyDostepnyCheckBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            idFachowcaLabel = new System.Windows.Forms.Label();
            nrTelFLabel = new System.Windows.Forms.Label();
            zawodLabel = new System.Windows.Forms.Label();
            obszarLabel = new System.Windows.Forms.Label();
            stawkaGodzLabel = new System.Windows.Forms.Label();
            czyDostepnyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fachowcyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fachowcyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idFachowcaLabel
            // 
            idFachowcaLabel.AutoSize = true;
            idFachowcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            idFachowcaLabel.Location = new System.Drawing.Point(32, 329);
            idFachowcaLabel.Name = "idFachowcaLabel";
            idFachowcaLabel.Size = new System.Drawing.Size(128, 25);
            idFachowcaLabel.TabIndex = 4;
            idFachowcaLabel.Text = "id Fachowca:";
            // 
            // nrTelFLabel
            // 
            nrTelFLabel.AutoSize = true;
            nrTelFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nrTelFLabel.Location = new System.Drawing.Point(32, 372);
            nrTelFLabel.Name = "nrTelFLabel";
            nrTelFLabel.Size = new System.Drawing.Size(85, 25);
            nrTelFLabel.TabIndex = 5;
            nrTelFLabel.Text = "nr Tel F:";
            // 
            // zawodLabel
            // 
            zawodLabel.AutoSize = true;
            zawodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            zawodLabel.Location = new System.Drawing.Point(32, 415);
            zawodLabel.Name = "zawodLabel";
            zawodLabel.Size = new System.Drawing.Size(75, 25);
            zawodLabel.TabIndex = 7;
            zawodLabel.Text = "zawod:";
            // 
            // obszarLabel
            // 
            obszarLabel.AutoSize = true;
            obszarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            obszarLabel.Location = new System.Drawing.Point(32, 456);
            obszarLabel.Name = "obszarLabel";
            obszarLabel.Size = new System.Drawing.Size(77, 25);
            obszarLabel.TabIndex = 9;
            obszarLabel.Text = "obszar:";
            // 
            // stawkaGodzLabel
            // 
            stawkaGodzLabel.AutoSize = true;
            stawkaGodzLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            stawkaGodzLabel.Location = new System.Drawing.Point(32, 498);
            stawkaGodzLabel.Name = "stawkaGodzLabel";
            stawkaGodzLabel.Size = new System.Drawing.Size(131, 25);
            stawkaGodzLabel.TabIndex = 11;
            stawkaGodzLabel.Text = "stawka Godz:";
            // 
            // czyDostepnyLabel
            // 
            czyDostepnyLabel.AutoSize = true;
            czyDostepnyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            czyDostepnyLabel.Location = new System.Drawing.Point(32, 536);
            czyDostepnyLabel.Name = "czyDostepnyLabel";
            czyDostepnyLabel.Size = new System.Drawing.Size(136, 25);
            czyDostepnyLabel.TabIndex = 13;
            czyDostepnyLabel.Text = "czy Dostepny:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(199, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fachowcy";
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fachowcyBindingSource
            // 
            this.fachowcyBindingSource.DataMember = "Fachowcy";
            this.fachowcyBindingSource.DataSource = this.database2DataSet;
            // 
            // fachowcyTableAdapter
            // 
            this.fachowcyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FachowcyTableAdapter = this.fachowcyTableAdapter;
            this.tableAdapterManager.KlienciTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projekt_WDBD.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZleceniaTableAdapter = null;
            // 
            // fachowcyDataGridView
            // 
            this.fachowcyDataGridView.AllowUserToAddRows = false;
            this.fachowcyDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fachowcyDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fachowcyDataGridView.AutoGenerateColumns = false;
            this.fachowcyDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.fachowcyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fachowcyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.fachowcyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fachowcyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.fachowcyDataGridView.DataSource = this.fachowcyBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fachowcyDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.fachowcyDataGridView.GridColor = System.Drawing.Color.Black;
            this.fachowcyDataGridView.Location = new System.Drawing.Point(12, 90);
            this.fachowcyDataGridView.Name = "fachowcyDataGridView";
            this.fachowcyDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fachowcyDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fachowcyDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.fachowcyDataGridView.Size = new System.Drawing.Size(554, 220);
            this.fachowcyDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idFachowca";
            this.dataGridViewTextBoxColumn1.HeaderText = "idFachowca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nrTelF";
            this.dataGridViewTextBoxColumn2.HeaderText = "nrTelF";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 62;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "zawod";
            this.dataGridViewTextBoxColumn3.HeaderText = "zawod";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 63;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "obszar";
            this.dataGridViewTextBoxColumn4.HeaderText = "obszar";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 63;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "stawkaGodz";
            this.dataGridViewTextBoxColumn5.HeaderText = "stawkaGodz";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 91;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "czyDostepny";
            this.dataGridViewCheckBoxColumn1.HeaderText = "czyDostepny";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 74;
            // 
            // idFachowcaTextBox
            // 
            this.idFachowcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fachowcyBindingSource, "idFachowca", true));
            this.idFachowcaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idFachowcaTextBox.Location = new System.Drawing.Point(174, 326);
            this.idFachowcaTextBox.Name = "idFachowcaTextBox";
            this.idFachowcaTextBox.Size = new System.Drawing.Size(150, 30);
            this.idFachowcaTextBox.TabIndex = 5;
            // 
            // nrTelFTextBox
            // 
            this.nrTelFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fachowcyBindingSource, "nrTelF", true));
            this.nrTelFTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nrTelFTextBox.Location = new System.Drawing.Point(174, 369);
            this.nrTelFTextBox.Name = "nrTelFTextBox";
            this.nrTelFTextBox.Size = new System.Drawing.Size(150, 30);
            this.nrTelFTextBox.TabIndex = 6;
            // 
            // zawodTextBox
            // 
            this.zawodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fachowcyBindingSource, "zawod", true));
            this.zawodTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zawodTextBox.Location = new System.Drawing.Point(174, 412);
            this.zawodTextBox.Name = "zawodTextBox";
            this.zawodTextBox.Size = new System.Drawing.Size(150, 30);
            this.zawodTextBox.TabIndex = 8;
            // 
            // obszarTextBox
            // 
            this.obszarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fachowcyBindingSource, "obszar", true));
            this.obszarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obszarTextBox.Location = new System.Drawing.Point(174, 453);
            this.obszarTextBox.Name = "obszarTextBox";
            this.obszarTextBox.Size = new System.Drawing.Size(150, 30);
            this.obszarTextBox.TabIndex = 10;
            // 
            // stawkaGodzTextBox
            // 
            this.stawkaGodzTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fachowcyBindingSource, "stawkaGodz", true));
            this.stawkaGodzTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stawkaGodzTextBox.Location = new System.Drawing.Point(174, 495);
            this.stawkaGodzTextBox.Name = "stawkaGodzTextBox";
            this.stawkaGodzTextBox.Size = new System.Drawing.Size(150, 30);
            this.stawkaGodzTextBox.TabIndex = 12;
            // 
            // czyDostepnyCheckBox
            // 
            this.czyDostepnyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.fachowcyBindingSource, "czyDostepny", true));
            this.czyDostepnyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czyDostepnyCheckBox.Location = new System.Drawing.Point(174, 537);
            this.czyDostepnyCheckBox.Name = "czyDostepnyCheckBox";
            this.czyDostepnyCheckBox.Size = new System.Drawing.Size(27, 24);
            this.czyDostepnyCheckBox.TabIndex = 14;
            this.czyDostepnyCheckBox.UseVisualStyleBackColor = true;
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
            this.button3.Location = new System.Drawing.Point(379, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 42);
            this.button3.TabIndex = 27;
            this.button3.Text = "usun";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button2.Location = new System.Drawing.Point(379, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 42);
            this.button2.TabIndex = 26;
            this.button2.Text = "aktualizuj";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button1.Location = new System.Drawing.Point(379, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "dodaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(578, 579);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(czyDostepnyLabel);
            this.Controls.Add(this.czyDostepnyCheckBox);
            this.Controls.Add(stawkaGodzLabel);
            this.Controls.Add(this.stawkaGodzTextBox);
            this.Controls.Add(obszarLabel);
            this.Controls.Add(this.obszarTextBox);
            this.Controls.Add(zawodLabel);
            this.Controls.Add(this.zawodTextBox);
            this.Controls.Add(nrTelFLabel);
            this.Controls.Add(this.nrTelFTextBox);
            this.Controls.Add(idFachowcaLabel);
            this.Controls.Add(this.idFachowcaTextBox);
            this.Controls.Add(this.fachowcyDataGridView);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Azure;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Fachowcy";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fachowcyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fachowcyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource fachowcyBindingSource;
        private Database2DataSetTableAdapters.FachowcyTableAdapter fachowcyTableAdapter;
        private Database2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fachowcyDataGridView;
        private System.Windows.Forms.TextBox idFachowcaTextBox;
        private System.Windows.Forms.TextBox nrTelFTextBox;
        private System.Windows.Forms.TextBox zawodTextBox;
        private System.Windows.Forms.TextBox obszarTextBox;
        private System.Windows.Forms.TextBox stawkaGodzTextBox;
        private System.Windows.Forms.CheckBox czyDostepnyCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}