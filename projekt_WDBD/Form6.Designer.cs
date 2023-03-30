
namespace projekt_WDBD
{
    partial class Form6
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
            System.Windows.Forms.Label idKlientaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.database2DataSet = new projekt_WDBD.Database2DataSet();
            this.jakiFachowiecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jakiFachowiecTableAdapter = new projekt_WDBD.Database2DataSetTableAdapters.jakiFachowiecTableAdapter();
            this.tableAdapterManager = new projekt_WDBD.Database2DataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.obszarToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.obszarToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.zawodToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.zawodToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.jakiFachowiecDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFachowcaTextBox = new System.Windows.Forms.TextBox();
            this.miastoKlientaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miastoKlientaTableAdapter = new projekt_WDBD.Database2DataSetTableAdapters.miastoKlientaTableAdapter();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.miastoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.miastoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.miastoKlientaDataGridView = new System.Windows.Forms.DataGridView();
            this.idKlientaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idFachowcaLabel = new System.Windows.Forms.Label();
            idKlientaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jakiFachowiecBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jakiFachowiecDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miastoKlientaBindingSource)).BeginInit();
            this.fillToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miastoKlientaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idFachowcaLabel
            // 
            idFachowcaLabel.AutoSize = true;
            idFachowcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            idFachowcaLabel.Location = new System.Drawing.Point(23, 215);
            idFachowcaLabel.Name = "idFachowcaLabel";
            idFachowcaLabel.Size = new System.Drawing.Size(128, 25);
            idFachowcaLabel.TabIndex = 7;
            idFachowcaLabel.Text = "id Fachowca:";
            // 
            // idKlientaLabel
            // 
            idKlientaLabel.AutoSize = true;
            idKlientaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            idKlientaLabel.Location = new System.Drawing.Point(302, 220);
            idKlientaLabel.Name = "idKlientaLabel";
            idKlientaLabel.Size = new System.Drawing.Size(98, 25);
            idKlientaLabel.TabIndex = 9;
            idKlientaLabel.Text = "id Klienta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(361, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Klient";
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jakiFachowiecBindingSource
            // 
            this.jakiFachowiecBindingSource.DataMember = "jakiFachowiec";
            this.jakiFachowiecBindingSource.DataSource = this.database2DataSet;
            // 
            // jakiFachowiecTableAdapter
            // 
            this.jakiFachowiecTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FachowcyTableAdapter = null;
            this.tableAdapterManager.KlienciTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projekt_WDBD.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZleceniaTableAdapter = null;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obszarToolStripLabel,
            this.obszarToolStripTextBox,
            this.zawodToolStripLabel,
            this.zawodToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.fillToolStrip.Location = new System.Drawing.Point(18, 86);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(102, 106);
            this.fillToolStrip.TabIndex = 7;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // obszarToolStripLabel
            // 
            this.obszarToolStripLabel.ForeColor = System.Drawing.Color.Black;
            this.obszarToolStripLabel.Name = "obszarToolStripLabel";
            this.obszarToolStripLabel.Size = new System.Drawing.Size(100, 15);
            this.obszarToolStripLabel.Text = "obszar:";
            // 
            // obszarToolStripTextBox
            // 
            this.obszarToolStripTextBox.BackColor = System.Drawing.Color.Maroon;
            this.obszarToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.obszarToolStripTextBox.ForeColor = System.Drawing.Color.Azure;
            this.obszarToolStripTextBox.Name = "obszarToolStripTextBox";
            this.obszarToolStripTextBox.Size = new System.Drawing.Size(98, 23);
            this.obszarToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zawodToolStripLabel
            // 
            this.zawodToolStripLabel.ForeColor = System.Drawing.Color.Black;
            this.zawodToolStripLabel.Name = "zawodToolStripLabel";
            this.zawodToolStripLabel.Size = new System.Drawing.Size(100, 15);
            this.zawodToolStripLabel.Text = "zawod:";
            // 
            // zawodToolStripTextBox
            // 
            this.zawodToolStripTextBox.BackColor = System.Drawing.Color.Maroon;
            this.zawodToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.zawodToolStripTextBox.ForeColor = System.Drawing.Color.Azure;
            this.zawodToolStripTextBox.Name = "zawodToolStripTextBox";
            this.zawodToolStripTextBox.Size = new System.Drawing.Size(98, 23);
            this.zawodToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.ForeColor = System.Drawing.Color.Black;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(100, 19);
            this.fillToolStripButton.Text = "Szukaj";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // jakiFachowiecDataGridView
            // 
            this.jakiFachowiecDataGridView.AllowUserToAddRows = false;
            this.jakiFachowiecDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jakiFachowiecDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.jakiFachowiecDataGridView.AutoGenerateColumns = false;
            this.jakiFachowiecDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.jakiFachowiecDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jakiFachowiecDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.jakiFachowiecDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jakiFachowiecDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.jakiFachowiecDataGridView.DataSource = this.jakiFachowiecBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jakiFachowiecDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.jakiFachowiecDataGridView.GridColor = System.Drawing.Color.Black;
            this.jakiFachowiecDataGridView.Location = new System.Drawing.Point(123, 86);
            this.jakiFachowiecDataGridView.Name = "jakiFachowiecDataGridView";
            this.jakiFachowiecDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jakiFachowiecDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jakiFachowiecDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.jakiFachowiecDataGridView.Size = new System.Drawing.Size(153, 106);
            this.jakiFachowiecDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idFachowca";
            this.dataGridViewTextBoxColumn1.HeaderText = "idFachowca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idFachowcaTextBox
            // 
            this.idFachowcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jakiFachowiecBindingSource, "idFachowca", true));
            this.idFachowcaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idFachowcaTextBox.Location = new System.Drawing.Point(157, 215);
            this.idFachowcaTextBox.Name = "idFachowcaTextBox";
            this.idFachowcaTextBox.Size = new System.Drawing.Size(100, 30);
            this.idFachowcaTextBox.TabIndex = 8;
            // 
            // miastoKlientaBindingSource
            // 
            this.miastoKlientaBindingSource.DataMember = "miastoKlienta";
            this.miastoKlientaBindingSource.DataSource = this.database2DataSet;
            // 
            // miastoKlientaTableAdapter
            // 
            this.miastoKlientaTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip1
            // 
            this.fillToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miastoToolStripLabel,
            this.miastoToolStripTextBox,
            this.fillToolStripButton1});
            this.fillToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.fillToolStrip1.Location = new System.Drawing.Point(457, 98);
            this.fillToolStrip1.Name = "fillToolStrip1";
            this.fillToolStrip1.Size = new System.Drawing.Size(102, 65);
            this.fillToolStrip1.TabIndex = 9;
            this.fillToolStrip1.Text = "fillToolStrip1";
            // 
            // miastoToolStripLabel
            // 
            this.miastoToolStripLabel.ForeColor = System.Drawing.Color.Black;
            this.miastoToolStripLabel.Name = "miastoToolStripLabel";
            this.miastoToolStripLabel.Size = new System.Drawing.Size(100, 15);
            this.miastoToolStripLabel.Text = "miasto:";
            // 
            // miastoToolStripTextBox
            // 
            this.miastoToolStripTextBox.BackColor = System.Drawing.Color.Maroon;
            this.miastoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.miastoToolStripTextBox.ForeColor = System.Drawing.Color.Azure;
            this.miastoToolStripTextBox.Name = "miastoToolStripTextBox";
            this.miastoToolStripTextBox.Size = new System.Drawing.Size(98, 23);
            this.miastoToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillToolStripButton1
            // 
            this.fillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.fillToolStripButton1.Name = "fillToolStripButton1";
            this.fillToolStripButton1.Size = new System.Drawing.Size(100, 19);
            this.fillToolStripButton1.Text = "Szukaj";
            this.fillToolStripButton1.Click += new System.EventHandler(this.fillToolStripButton1_Click);
            // 
            // miastoKlientaDataGridView
            // 
            this.miastoKlientaDataGridView.AllowUserToAddRows = false;
            this.miastoKlientaDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.miastoKlientaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.miastoKlientaDataGridView.AutoGenerateColumns = false;
            this.miastoKlientaDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.miastoKlientaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.miastoKlientaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miastoKlientaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.miastoKlientaDataGridView.DataSource = this.miastoKlientaBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.miastoKlientaDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.miastoKlientaDataGridView.GridColor = System.Drawing.Color.Black;
            this.miastoKlientaDataGridView.Location = new System.Drawing.Point(290, 86);
            this.miastoKlientaDataGridView.Name = "miastoKlientaDataGridView";
            this.miastoKlientaDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.miastoKlientaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.miastoKlientaDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.miastoKlientaDataGridView.Size = new System.Drawing.Size(164, 106);
            this.miastoKlientaDataGridView.TabIndex = 9;
            // 
            // idKlientaTextBox
            // 
            this.idKlientaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.miastoKlientaBindingSource, "idKlienta", true));
            this.idKlientaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idKlientaTextBox.Location = new System.Drawing.Point(406, 215);
            this.idKlientaTextBox.Name = "idKlientaTextBox";
            this.idKlientaTextBox.Size = new System.Drawing.Size(100, 30);
            this.idKlientaTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fachowiec";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idKlienta";
            this.dataGridViewTextBoxColumn2.HeaderText = "idKlienta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(575, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(idKlientaLabel);
            this.Controls.Add(this.idKlientaTextBox);
            this.Controls.Add(this.miastoKlientaDataGridView);
            this.Controls.Add(this.fillToolStrip1);
            this.Controls.Add(idFachowcaLabel);
            this.Controls.Add(this.idFachowcaTextBox);
            this.Controls.Add(this.jakiFachowiecDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Azure;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Fachowiec - Klient";
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jakiFachowiecBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jakiFachowiecDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miastoKlientaBindingSource)).EndInit();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miastoKlientaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource jakiFachowiecBindingSource;
        private Database2DataSetTableAdapters.jakiFachowiecTableAdapter jakiFachowiecTableAdapter;
        private Database2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel obszarToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox obszarToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel zawodToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox zawodToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView jakiFachowiecDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox idFachowcaTextBox;
        private System.Windows.Forms.BindingSource miastoKlientaBindingSource;
        private Database2DataSetTableAdapters.miastoKlientaTableAdapter miastoKlientaTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip1;
        private System.Windows.Forms.ToolStripLabel miastoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox miastoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton1;
        private System.Windows.Forms.DataGridView miastoKlientaDataGridView;
        private System.Windows.Forms.TextBox idKlientaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}