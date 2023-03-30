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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void klienciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klienciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database2DataSet.Klienci' . Możesz go przenieść lub usunąć.
            this.klienciTableAdapter.Fill(this.database2DataSet.Klienci);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = imieTextBox.Text;
            string nazw = nazwiskoTextBox.Text;
            string nrtelk = nrTelKTextBox.Text;
            string miasto = miastoTextBox.Text;
            string adres = adresTextBox.Text;

            string query = "insert into Klienci(imie,nazwisko,nrTelK,miasto,adres) values(@imie,@nazwisko,@nrTelK,@miasto,@adres)";
            SqlCommand updateCommand = new SqlCommand(query);
            updateCommand.Parameters.AddWithValue("@imie", imie);
            updateCommand.Parameters.AddWithValue("@nazwisko", nazw);
            updateCommand.Parameters.AddWithValue("@nrTelK", nrtelk);
            updateCommand.Parameters.AddWithValue("@miasto", miasto);
            updateCommand.Parameters.AddWithValue("@adres", adres);

            Class1 classObj = new Class1();
            int row = classObj.executeQuery(updateCommand);
            /*if (row == 1)
            {
                MessageBox.Show("został pomyślnie zmodyfikowany", "zaktualizowany!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            this.klienciTableAdapter.Fill(this.database2DataSet.Klienci);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imie = imieTextBox.Text;
            string nazw = nazwiskoTextBox.Text;
            string nrtelk = nrTelKTextBox.Text;
            string miasto = miastoTextBox.Text;
            string adres = adresTextBox.Text;
            int idKlient = Convert.ToInt32(klienciDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);
            string query = "UPDATE Klienci SET imie= '" + imie + "', nazwisko= '" + nazw + "', nrTelK= '" + nrtelk + "', miasto= '" + miasto + "', adres= '" + adres +  "' WHERE idKlienta='" + idKlient + "'";
            SqlCommand updateCommand = new SqlCommand(query);
            updateCommand.Parameters.AddWithValue("@imie", imie);
            updateCommand.Parameters.AddWithValue("@nazwisko", nazw);
            updateCommand.Parameters.AddWithValue("@nrTelK", nrtelk);
            updateCommand.Parameters.AddWithValue("@miasto", miasto);
            updateCommand.Parameters.AddWithValue("@adres", adres);

            Class1 classObj = new Class1();
            int row = classObj.executeQuery(updateCommand);
            this.klienciTableAdapter.Fill(this.database2DataSet.Klienci);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idKlient = Convert.ToInt32(klienciDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);
            string query = "DELETE from Klienci Where idKlienta= '" + idKlient + "'";

            SqlCommand delete = new SqlCommand(query);
            Class1 classObj = new Class1();
            int row = classObj.executeQuery(delete);
            this.klienciTableAdapter.Fill(this.database2DataSet.Klienci);
        }
    }
}
