using SimulationLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g;
            String sText;

            int iX;
            int iY;
            SizeF sizeText;

            TabControl ctlTab;

            ctlTab = (TabControl)(sender);

            g = e.Graphics;

            sText = ctlTab.TabPages[e.Index].Text;
            sizeText = g.MeasureString(sText, ctlTab.Font);

            iX = e.Bounds.Left + 6;
            iY = (int)(e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2);

            g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtZ0.Text != "" && txtm.Text != "")
            {
                int z0 = Convert.ToInt32(txtZ0.Text);
                int m = Convert.ToInt32(txtm.Text);
                    if (cmbType.SelectedIndex == 0)
                    {
                        var d = MixedCongruentialGenerator.FindFullPeriodParameters(z0, m);
                        rtbRandomNumbers.Text = "";
                        if (d != null)
                        {
                            StringBuilder s = new StringBuilder();
                            foreach (MixedCongruentialGeneratorParameters i in d)
                            {
                                s.AppendLine("a=" + i.a + " , c=" + i.c + "\n");
                            }
                            rtbRandomNumbers.Text = s.ToString();
                        }
                    }
                    else
                    {
                        var d = MultiplicativeCongruentialGenerator.FindFullPeriodParameters(z0, m);
                        rtbRandomNumbers.Text = "";
                        StringBuilder s = new StringBuilder();
                        if (d != null)
                        {
                            foreach (var i in d)
                            {
                                s.AppendLine("a=" + i + "\n");
                            }
                            rtbRandomNumbers.Text = s.ToString();
                        }
                    }
            }
            else
                MessageBox.Show("Please, you need to specify Z0 and m");
        }
            catch
            {
                MessageBox.Show("Please, check again your numbers");
            }
}

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCount.Text != "" && txtZ0.Text != "" && txtm.Text != "" && txta.Text != "")
                {
                    int z0 = Convert.ToInt32(txtZ0.Text);
                    int m = Convert.ToInt32(txtm.Text);
                    int a = Convert.ToInt32(txta.Text);
                    int count = Convert.ToInt32(txtCount.Text);

                    if (cmbType.SelectedIndex == 0)
                    {
                        if (txtc.Text != "")
                        {
                            int c = Convert.ToInt32(txtc.Text);
                            var d = MixedCongruentialGenerator.GetNumbers(count, z0, a, c, m, chkZeroToOne.Checked);
                            rtbRandomNumbers.Text = "";
                            if (d != null)
                            {
                                StringBuilder s = new StringBuilder();
                                foreach (var i in d)
                                {
                                    s.AppendLine(i.ToString());
                                }
                                rtbRandomNumbers.Text = s.ToString();
                            }
                        }
                        else
                            MessageBox.Show("Please, you need to specify c");
                    }
                    else
                    {
                        var d = MultiplicativeCongruentialGenerator.GetNumbers(count, z0, a, m, chkZeroToOne.Checked);
                        rtbRandomNumbers.Text = "";
                        if (d != null)
                        {
                            StringBuilder s = new StringBuilder();
                            foreach (var i in d)
                            {
                                s.AppendLine(i.ToString());
                            }
                            rtbRandomNumbers.Text = s.ToString();
                        }
                    }
                }
                else
                    MessageBox.Show("Please, you need to specify Length, Z0, a and m");
            }
            catch
            {
                MessageBox.Show("Please, check again your numbers");
            }
        }
    }
}
