using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_WDBD
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database2DataSet.koszt' . Możesz go przenieść lub usunąć.
            this.kosztTableAdapter.Fill(this.database2DataSet.koszt);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kosztPTableAdapter.Fill(this.database2DataSet.kosztP, ((int)(System.Convert.ChangeType(idZleceniaToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
