using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeLand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //G.init();
            //if (G.form2 == null) G.form2 = new Form2();
            //G.form2.Show();
            //G.form2.Activate();

            //Genotype gt = new Genotype(G.rnd);
            //Phenotype pt = new Phenotype(gt,0);
            //pt.show(G.form2.getPictureBox1());

            //G.pop = new Population(Params.populationCnt, G.rnd);
            //G.pop.unsetNewborn();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Phenotype pt = G.pop.getPhenotype(G.popCount);
            //pt.show(G.form2.getPictureBox1());
            //G.popCount ++;
            //label7.Text = G.popCount.ToString();
        }

        public void Messageline1(String s)
        {
            label7.Text = s;
        }

        public void Messageline2(String s)
        {
            label9.Text = s;
        }

        public void showNum(int num)
        {
            Phenotype pt = G.pop.getPhenotype(num);
            pt.show(G.form2.getPictureBox1());
            
            Messageline1( "Individual=" +num.ToString()+"  Score = "+pt.score.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            showNum(num);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int idx = G.pop.findBest();
            showNum(idx);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            G.pop.do1Generation();
            int idx = G.pop.findBest();
            showNum(idx);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            showNum(num);
            num++;
            textBox1.Text = num.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            G.init();
            if (G.form2 == null) G.form2 = new Form2();
            G.form2.Show();
            G.form2.Activate();
            label4.Text = "Running";

            Params.checkDuplicateGenes = checkBox2.Checked;
            Params.checkDuplicateGenomes = Convert.ToInt32(textBox4.Text);
            Params.mutationPercent = Convert.ToDouble(textBox3.Text);
            G.mutationCount = 0;
            G.dupGeneCount = 0;
            G.dupGeneomeCount = 0;

            G.rnd = new Random(Convert.ToInt32(textBox5.Text));
            Params.dimX = Convert.ToInt32(textBox6.Text);
            Params.dimY = Convert.ToInt32(textBox7.Text);
            Params.maxRepeat = Convert.ToInt32(textBox8.Text);
            Params.populationCnt = Convert.ToInt32(textBox9.Text);
            Params.genotypeSize = Convert.ToInt32(textBox10.Text);

            Genotype gt = new Genotype(G.rnd);
            Phenotype pt = new Phenotype(gt,0);
            pt.show(G.form2.getPictureBox1());

            G.pop = new Population(Params.populationCnt, G.rnd);
            G.pop.unsetNewborn();
            G.pop.generation = 0;
            while (G.pop.generation < Convert.ToInt32(textBox2.Text) && !checkBox1.Checked)
            {
                G.pop.do1Generation();
                int idx = G.pop.findBest();
                showNum(idx);
                label5.Text = G.pop.generation.ToString();
                label13.Text = "Mutations              :" + G.mutationCount.ToString();
                label14.Text = "Duplicate genes fixed  :" + G.dupGeneCount.ToString();
                label15.Text = "Duplicate genomes fixed:" + G.dupGeneomeCount.ToString();

            }
            label4.Text = "Ended";

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random rr = new Random();
            int ii = rr.Next(0, 9999999);
            textBox5.Text = ii.ToString();
        }
    }
}
