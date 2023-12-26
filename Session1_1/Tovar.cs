using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1_1
{
    public partial class Tovar : Form
    {
        public Tovar()
        {
            InitializeComponent();
            
        }


        private void Tovar_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Tovar". При необходимости она может быть перемещена или удалена.
            try
            {
                this.tovarTableAdapter.Fill(this.dataSet.Tovar);
                labelCount.Text = tovarBindingSource.Count.ToString();
            }
            catch {
                MessageBox.Show("Ошибка заргрузки базы данных!");
                
            }


            }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();    
        }

        private void tovarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (изображениеTextBox.Text == "")
            {
                pictureBoxTovar.ImageLocation = Environment.CurrentDirectory + "\\..\\..\\Images\\picture.png";
            }
            else {
                pictureBoxTovar.ImageLocation = Environment.CurrentDirectory + "\\..\\..\\Images\\" + изображениеTextBox.Text;
            }

            int cost = Convert.ToInt32(стоимостьTextBox.Text) - (Convert.ToInt32(стоимостьTextBox.Text) * (Convert.ToInt32(скидкаTextBox.Text))/100);
            labelRaschet.Text = cost.ToString();
          
        }

        private void listBoxSkidka_SelectedIndexChanged(object sender, EventArgs e)
        {
   
            if (listBoxSkidka.SelectedIndex == 0) {
                tovarBindingSource.Filter = "";
            } else if(listBoxSkidka.SelectedIndex == 1)
            {
                tovarBindingSource.Filter = "Скидка > 0";
            }
            else if (listBoxSkidka.SelectedIndex == 2)
            {
                tovarBindingSource.Filter = "Скидка > 14";
            }
            else if (listBoxSkidka.SelectedIndex == 3)
            {
                tovarBindingSource.Filter = "Скидка >= 15";
            }
            labelFilterCount.Text = tovarBindingSource.Count.ToString();
        }
    }
}
