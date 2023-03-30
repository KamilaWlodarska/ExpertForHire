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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void zleceniaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zleceniaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database2DataSet.Zlecenia' . Możesz go przenieść lub usunąć.
            this.zleceniaTableAdapter.Fill(this.database2DataSet.Zlecenia);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataZ = dataZleceniaDateTimePicker.Value;
            DateTime dataP = dataPlanDateTimePicker.Value;
            DateTime dataR = dataRealizacjiDateTimePicker.Value;
            int idKlient = int.Parse(idKlientaTextBox.Text);
            string usluga = uslugaTextBox.Text;
            string idFachowiec = idFachowcaTextBox.Text;
            int czasW = int.Parse(czasWykonaniaTextBox.Text);

            string query = "insert into Zlecenia(dataZlecenia,dataPlan,dataRealizacji,idKlienta,usluga,idFachowca,czasWykonania) values(@dataZlecenia,@dataPlan,@dataRealizacji,@idKlienta,@usluga,@idFachowca,@czasWykonania)";
            SqlCommand updateCommand = new SqlCommand(query);
            updateCommand.Parameters.AddWithValue("@dataZlecenia", dataZ);
            updateCommand.Parameters.AddWithValue("@dataPlan", dataP);
            updateCommand.Parameters.AddWithValue("@dataRealizacji", dataR);
            updateCommand.Parameters.AddWithValue("@idKlienta", idKlient);
            updateCommand.Parameters.AddWithValue("@usluga", usluga);
            updateCommand.Parameters.AddWithValue("@idFachowca", idFachowiec);
            updateCommand.Parameters.AddWithValue("@czasWykonania", czasW);

            Class1 classObj = new Class1();
            int row = classObj.executeQuery(updateCommand);
            /*if (row == 1)
            {
                MessageBox.Show("został pomyślnie zmodyfikowany", "zaktualizowany!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            this.zleceniaTableAdapter.Fill(this.database2DataSet.Zlecenia);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DateTime dataZ = dataZleceniaDateTimePicker.Value;
            //DateTime dataP = dataPlanDateTimePicker.Value;
            //DateTime dataR = dataRealizacjiDateTimePicker.Value;
            int idKlient = int.Parse(idKlientaTextBox.Text);
            string usluga = uslugaTextBox.Text;
            string idFachowiec = idFachowcaTextBox.Text;
            int czasW = int.Parse(czasWykonaniaTextBox.Text);
            int idZlecenie = Convert.ToInt32(zleceniaDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);

            //string query = "UPDATE Zlecenia SET dataZlecenia= '" + dataZ + "', dataPlan= '" + dataP + "', dataRealizacji= '" + dataR + "', idKlienta= '" + idKlient + "', usluga= '" + usluga + "', idFachowca= '" + idFachowiec + "', czasWykonania= '" + czasW + "' WHERE idZlecenia='" + idZlecenie + "'";
            string query = "UPDATE Zlecenia SET idKlienta= '" + idKlient + "', usluga= '" + usluga + "', idFachowca= '" + idFachowiec + "', czasWykonania= '" + czasW + "' WHERE idZlecenia='" + idZlecenie + "'";
            SqlCommand updateCommand = new SqlCommand(query);
            //updateCommand.Parameters.AddWithValue("@dataZlecenia", dataZ);
            //updateCommand.Parameters.AddWithValue("@dataPlan", dataP);
            //updateCommand.Parameters.AddWithValue("@dataRealizacji", dataR);
            updateCommand.Parameters.AddWithValue("@idKlienta", idKlient);
            updateCommand.Parameters.AddWithValue("@usluga", usluga);
            updateCommand.Parameters.AddWithValue("@idFachowca", idFachowiec);
            updateCommand.Parameters.AddWithValue("@czasWykonania", czasW);

            Class1 classObj = new Class1();
            int row = classObj.executeQuery(updateCommand);
            this.zleceniaTableAdapter.Fill(this.database2DataSet.Zlecenia);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idZlecenie = Convert.ToInt32(zleceniaDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);

                string query = "DELETE from Zlecenia Where idZlecenia= '" + idZlecenie + "'";

                SqlCommand delete = new SqlCommand(query);
                Class1 classObj = new Class1();
                int row = classObj.executeQuery(delete);
            this.zleceniaTableAdapter.Fill(this.database2DataSet.Zlecenia);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
