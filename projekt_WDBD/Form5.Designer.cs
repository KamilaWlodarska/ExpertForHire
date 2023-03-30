
namespace projekt_WDBD
{
    partial class Form5
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
            System.Windows.Forms.Label kosztLabel;
            System.Windows.Forms.Label idZleceniaLabel1;
            System.Windows.Forms.Label kosztLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.database2DataSet = new projekt_WDBD.Database2DataSet();
            this.kosztBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kosztTableAdapter = new projekt_WDBD.Database2DataSetTableAdapters.kosztTableAdapter();
            this.tableAdapterManager = new projekt_WDBD.Database2DataSetTableAdapters.TableAdapterManager();
            this.kosztDataGridView = new System.Windows.Forms.DataGridView();
            this.idZleceniaTextBox = new System.Windows.Forms.TextBox();
            this.kosztTextBox = new System.Windows.Forms.TextBox();
            this.kosztPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kosztPTableAdapter = new projekt_WDBD.Database2DataSetTableAdapters.kosztPTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.idZleceniaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idZleceniaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.kosztPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZleceniaTextBox1 = new System.Windows.Forms.TextBox();
            this.kosztTextBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idZleceniaLabel = new System.Windows.Forms.Label();
            kosztLabel = new System.Windows.Forms.Label();
            idZleceniaLabel1 = new System.Windows.Forms.Label();
            kosztLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosztBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosztDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosztPBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kosztPDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idZleceniaLabel
            // 
            idZleceniaLabel.AutoSize = true;
            idZleceniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            idZleceniaLabel.Location = new System.Drawing.Point(38, 280);
            idZleceniaLabel.Name = "idZleceniaLabel";
            idZleceniaLabel.Size = new System.Drawing.Size(112, 25);
            idZleceniaLabel.TabIndex = 5;
            idZleceniaLabel.Text = "id Zlecenia:";
            // 
            // kosztLabel
            // 
            kosztLabel.AutoSize = true;
            kosztLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            kosztLabel.Location = new System.Drawing.Point(38, 330);
            kosztLabel.Name = "kosztLabel";
            kosztLabel.Size = new System.Drawing.Size(64, 25);
            kosztLabel.TabIndex = 6;
            kosztLabel.Text = "koszt:";
            // 
            // idZleceniaLabel1
            // 
            idZleceniaLabel1.AutoSize = true;
            idZleceniaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            idZleceniaLabel1.Location = new System.Drawing.Point(320, 280);
            idZleceniaLabel1.Name = "idZleceniaLabel1";
            idZleceniaLabel1.Size = new System.Drawing.Size(112, 25);
            idZleceniaLabel1.TabIndex = 9;
            idZleceniaLabel1.Text = "id Zlecenia:";
            // 
            // kosztLabel1
            // 
            kosztLabel1.AutoSize = true;
            kosztLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            kosztLabel1.Location = new System.Drawing.Point(320, 330);
            kosztLabel1.Name = "kosztLabel1";
            kosztLabel1.Size = new System.Drawing.Size(64, 25);
            kosztLabel1.TabIndex = 11;
            kosztLabel1.Text = "koszt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(176, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Koszty zleceń";
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kosztBindingSource
            // 
            this.kosztBindingSource.DataMember = "koszt";
            this.kosztBindingSource.DataSource = this.database2DataSet;
            // 
            // kosztTableAdapter
            // 
            this.kosztTableAdapter.ClearBeforeFill = true;
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
            // kosztDataGridView
            // 
            this.kosztDataGridView.AllowUserToAddRows = false;
            this.kosztDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kosztDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kosztDataGridView.AutoGenerateColumns = false;
            this.kosztDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.kosztDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kosztDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.kosztDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kosztDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.kosztDataGridView.DataSource = this.kosztBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kosztDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.kosztDataGridView.GridColor = System.Drawing.Color.Black;
            this.kosztDataGridView.Location = new System.Drawing.Point(24, 88);
            this.kosztDataGridView.Name = "kosztDataGridView";
            this.kosztDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kosztDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kosztDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.kosztDataGridView.Size = new System.Drawing.Size(266, 163);
            this.kosztDataGridView.TabIndex = 5;
            // 
            // idZleceniaTextBox
            // 
            this.idZleceniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kosztBindingSource, "idZlecenia", true));
            this.idZleceniaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idZleceniaTextBox.Location = new System.Drawing.Point(156, 277);
            this.idZleceniaTextBox.Name = "idZleceniaTextBox";
            this.idZleceniaTextBox.Size = new System.Drawing.Size(100, 30);
            this.idZleceniaTextBox.TabIndex = 6;
            // 
            // kosztTextBox
            // 
            this.kosztTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kosztBindingSource, "koszt", true));
            this.kosztTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kosztTextBox.Location = new System.Drawing.Point(156, 327);
            this.kosztTextBox.Name = "kosztTextBox";
            this.kosztTextBox.Size = new System.Drawing.Size(100, 30);
            this.kosztTextBox.TabIndex = 7;
            // 
            // kosztPBindingSource
            // 
            this.kosztPBindingSource.DataMember = "kosztP";
            this.kosztPBindingSource.DataSource = this.database2DataSet;
            // 
            // kosztPTableAdapter
            // 
            this.kosztPTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idZleceniaToolStripLabel,
            this.idZleceniaToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(311, 136);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(243, 25);
            this.fillToolStrip.TabIndex = 8;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // idZleceniaToolStripLabel
            // 
            this.idZleceniaToolStripLabel.ForeColor = System.Drawing.Color.Black;
            this.idZleceniaToolStripLabel.Name = "idZleceniaToolStripLabel";
            this.idZleceniaToolStripLabel.Size = new System.Drawing.Size(64, 22);
            this.idZleceniaToolStripLabel.Text = "idZlecenia:";
            // 
            // idZleceniaToolStripTextBox
            // 
            this.idZleceniaToolStripTextBox.BackColor = System.Drawing.Color.Maroon;
            this.idZleceniaToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.idZleceniaToolStripTextBox.ForeColor = System.Drawing.Color.Azure;
            this.idZleceniaToolStripTextBox.Name = "idZleceniaToolStripTextBox";
            this.idZleceniaToolStripTextBox.Size = new System.Drawing.Size(130, 25);
            this.idZleceniaToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.ForeColor = System.Drawing.Color.Black;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(44, 22);
            this.fillToolStripButton.Text = "Szukaj";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // kosztPDataGridView
            // 
            this.kosztPDataGridView.AllowUserToAddRows = false;
            this.kosztPDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kosztPDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.kosztPDataGridView.AutoGenerateColumns = false;
            this.kosztPDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.kosztPDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kosztPDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.kosztPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kosztPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.kosztPDataGridView.DataSource = this.kosztPBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kosztPDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.kosztPDataGridView.GridColor = System.Drawing.Color.Black;
            this.kosztPDataGridView.Location = new System.Drawing.Point(311, 174);
            this.kosztPDataGridView.Name = "kosztPDataGridView";
            this.kosztPDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kosztPDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kosztPDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.kosztPDataGridView.Size = new System.Drawing.Size(248, 67);
            this.kosztPDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idZlecenia";
            this.dataGridViewTextBoxColumn3.HeaderText = "idZlecenia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "koszt";
            this.dataGridViewTextBoxColumn4.HeaderText = "koszt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // idZleceniaTextBox1
            // 
            this.idZleceniaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kosztPBindingSource, "idZlecenia", true));
            this.idZleceniaTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idZleceniaTextBox1.Location = new System.Drawing.Point(438, 277);
            this.idZleceniaTextBox1.Name = "idZleceniaTextBox1";
            this.idZleceniaTextBox1.Size = new System.Drawing.Size(100, 30);
            this.idZleceniaTextBox1.TabIndex = 10;
            // 
            // kosztTextBox1
            // 
            this.kosztTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kosztPBindingSource, "koszt", true));
            this.kosztTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kosztTextBox1.Location = new System.Drawing.Point(438, 327);
            this.kosztTextBox1.Name = "kosztTextBox1";
            this.kosztTextBox1.Size = new System.Drawing.Size(100, 30);
            this.kosztTextBox1.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "koszt";
            this.dataGridViewTextBoxColumn2.HeaderText = "koszt";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(581, 378);
            this.Controls.Add(kosztLabel1);
            this.Controls.Add(this.kosztTextBox1);
            this.Controls.Add(idZleceniaLabel1);
            this.Controls.Add(this.idZleceniaTextBox1);
            this.Controls.Add(this.kosztPDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(kosztLabel);
            this.Controls.Add(this.kosztTextBox);
            this.Controls.Add(idZleceniaLabel);
            this.Controls.Add(this.idZleceniaTextBox);
            this.Controls.Add(this.kosztDataGridView);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Azure;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Koszty zleceń";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosztBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosztDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosztPBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kosztPDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource kosztBindingSource;
        private Database2DataSetTableAdapters.kosztTableAdapter kosztTableAdapter;
        private Database2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kosztDataGridView;
        private System.Windows.Forms.TextBox idZleceniaTextBox;
        private System.Windows.Forms.TextBox kosztTextBox;
        private System.Windows.Forms.BindingSource kosztPBindingSource;
        private Database2DataSetTableAdapters.kosztPTableAdapter kosztPTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel idZleceniaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idZleceniaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView kosztPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idZleceniaTextBox1;
        private System.Windows.Forms.TextBox kosztTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}