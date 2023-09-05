using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula5
{
    public partial class Form1 : Form
    {
        Random randNum = new Random();
        int i;
        int[] valores1 = new int[10];
        int[] valores2 = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    valores1[i] = randNum.Next(1, 10);
                    listBoxV1.Items.Add(valores1[i]);
                    valores2[i] = randNum.Next(1, 10);
                    listBoxV2.Items.Add(valores2[i]);
                    listBoxRES.Items.Add(valores1[i] * valores2[i]) ;
                }
            }
            catch (Exception erro)
            {
                erro.Message.ToString();
            }
        }
    }
}
