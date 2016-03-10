using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritimoOrganizacao_Antoanne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Algorithm alg = new Algorithm();
            List<int> test = new List<int>();
            Console.WriteLine(test.Count);
            alg.AddRandomElements(2000, 0, 50, test);
            alg.AddRandomElements(51, 0, 50, test);
            Console.WriteLine(test.Count);
            alg.BubbleSort(test);
            Console.WriteLine(alg.Elapsed);
        }
    }
}
