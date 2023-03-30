using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_WDBD
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void fachowcyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fachowcyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database2DataSet.Fachowcy' . Możesz go przenieść lub usunąć.
            this.fachowcyTableAdapter.Fill(this.database2DataSet.Fachowcy);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idFachowiec = idFachowcaTextBox.Text;
            string nrtelf = nrTelFTextBox.Text;
            string zawod = zawodTextBox.Text;
            string obszar = obszarTextBox.Text;
            string stawka = stawkaGodzTextBox.Text;
            bool dostep = czyDostepnyCheckBox.Checked;

            string query = "insert into Fachowcy(idFachowca,nrTelF,zawod,obszar,stawkaGodz,czyDostepny) values(@idFachowca,@nrTelF,@zawod,@obszar,@stawkaGodz,@czyDostepny)";
            SqlCommand updateCommand = new SqlCommand(query);
            updateCommand.Parameters.AddWithValue("@idFachowca", idFachowiec);
            updateCommand.Parameters.AddWithValue("@nrTelF", nrtelf);
            updateCommand.Parameters.AddWithValue("@zawod", zawod);
            updateCommand.Parameters.AddWithValue("@obszar", obszar);
            updateCommand.Parameters.AddWithValue("@stawkaGodz", stawka);
            updateCommand.Parameters.AddWithValue("@czyDostepny", dostep);

            Class1 classObj = new Class1();
            int row = classObj.executeQuery(updateCommand);
            this.fachowcyTableAdapter.Fill(this.database2DataSet.Fachowcy);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idFachowiec = idFachowcaTextBox.Text;
            string nrtelf = nrTelFTextBox.Text;
            string zawod = zawodTextBox.Text;
            string obszar = obszarTextBox.Text;
            string stawka = stawkaGodzTextBox.Text;
            bool dostep = czyDostepnyCheckBox.Checked;
            string idFach = (string)fachowcyDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value;
            string query = "UPDATE Fachowcy SET idFachowca= '" + idFachowiec + "', nrTelF= '" + nrtelf + "', zawod= '" + zawod + "', obszar= '" + obszar + "', stawkaGodz= '" + stawka + "', czyDostepny= '" + dostep + "' WHERE idFachowca='" + idFach + "'";
            SqlCommand updateCommand = new SqlCommand(query);
            updateCommand.Parameters.AddWithValue("@idFachowca", idFachowiec);
            updateCommand.Parameters.AddWithValue("@nrTelF", nrtelf);
            updateCommand.Parameters.AddWithValue("@zawod", zawod);
            updateCommand.Parameters.AddWithValue("@obszar", obszar);
            updateCommand.Parameters.AddWithValue("@stawkaGodz", stawka);
            updateCommand.Parameters.AddWithValue("@czyDostepny", dostep);

            Class1 classObj = new Class1();
            int row = classObj.executeQuery(updateCommand);
            this.fachowcyTableAdapter.Fill(this.database2DataSet.Fachowcy);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idFach = (string)fachowcyDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value;
            string query = "DELETE from Fachowcy Where idFachowca= '" + idFach + "'";

            SqlCommand delete = new SqlCommand(query);
            Class1 classObj = new Class1();
            int row = classObj.executeQuery(delete);
            this.fachowcyTableAdapter.Fill(this.database2DataSet.Fachowcy);
        }
    }
}
