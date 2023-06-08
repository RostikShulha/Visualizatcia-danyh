using System;
using System.Windows.Forms;

namespace Pract_ChartBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            chartGraph.Series[0].Points.Clear();
            chartGraph.Series[1].Points.Clear();
            chartGraph.Series[2].Points.Clear();
            chartGraph.Series[3].Points.Clear();
            chartGraph.Series[4].Points.Clear();
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            txtZnach.Text = "";
            double Xmin, Xmax, Step;
            if (txtMax.Text == "" || txtMin.Text == "" || txtKrok.Text == "")
            {
                MessageBox.Show("Не всі дані введено", "Помилка вводу");
            }
            else
            {
                Xmin = double.Parse(txtMin.Text);
                Xmax = double.Parse(txtMax.Text);
                Step = double.Parse(txtKrok.Text);

                if (Xmin >= Xmax || Step <= 0)
                {
                    MessageBox.Show("Помилка вводу даних", "Помилка вводу");
                }
                else
                {
                    int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
                    double[] x = new double[count];
                    double[] y1 = new double[count];
                    double[] y2 = new double[count];
                    double[] y3 = new double[count];
                    double[] y4 = new double[count];
                    double[] y5 = new double[count];

                    for (int i = 0; i < count; i++)
                    {
                        x[i] = Xmin + Step * i;
                        y1[i] = Math.Sin(x[i]);
                        y2[i] = Math.Cos(x[i]);
                        y3[i] = Math.Sin(x[i]) + 2 * x[i];
                        y4[i] = Math.Sqrt(x[i]);
                        y5[i] = (4 + x[i]) / Math.Pow(x[i], 2);
                    }

                    string result = "";
                    for (int i = 0; i < count; i++)
                    {
                        switch (cbGraphics.SelectedIndex)
                        {
                            case 0:
                                result += "x[" + i.ToString() + "] = " + Convert.ToString(x[i]) + "  " + "y1[" + i.ToString() + "] = " + Convert.ToString(Math.Round(y1[i], 5)) + Environment.NewLine;
                                break;
                            case 1:
                                result += "x[" + i.ToString() + "] = " + Convert.ToString(x[i]) + "  " + "y2[" + i.ToString() + "] = " + Convert.ToString(Math.Round(y2[i], 5)) + Environment.NewLine;
                                break;
                            case 2:
                                result += "x[" + i.ToString() + "] = " + Convert.ToString(x[i]) + "  " + "y3[" + i.ToString() + "] = " + Convert.ToString(Math.Round(y3[i], 5)) + Environment.NewLine;
                                break;
                            case 3:
                                result += "x[" + i.ToString() + "] = " + Convert.ToString(x[i]) + "  " + "y4[" + i.ToString() + "] = " + Convert.ToString(Math.Round(y4[i], 5)) + Environment.NewLine;
                                break;
                            case 4:
                                result += "x[" + i.ToString() + "] = " + Convert.ToString(x[i]) + "  " + "y5[" + i.ToString() + "] = " + Convert.ToString(Math.Round(y5[i], 5)) + Environment.NewLine;
                                break;
                            default:
                                txtZnach.Text = "Графік не вибрано";
                                break;
                        }
                    }

                    txtZnach.Text = result;

                    chartGraph.ChartAreas[0].AxisX.Minimum = Xmin;
                    chartGraph.ChartAreas[0].AxisX.Maximum = Xmax;

                    chartGraph.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

                    chartGraph.Series[0].Enabled = chkSin.Checked;
                    chartGraph.Series[1].Enabled = chkCos.Checked;
                    chartGraph.Series[2].Enabled = chkSin2x.Checked;
                    chartGraph.Series[3].Enabled = chkSqrtx.Checked;
                    chartGraph.Series[4].Enabled = chkDil.Checked;

                    chartGraph.Series[0].Points.DataBindXY(x, y1);
                    chartGraph.Series[1].Points.DataBindXY(x, y2);
                    chartGraph.Series[2].Points.DataBindXY(x, y3);
                    chartGraph.Series[3].Points.DataBindXY(x, y4);
                    chartGraph.Series[4].Points.DataBindXY(x, y5);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbGraphics.Items.Add("Графік Sin(x)");
            cbGraphics.Items.Add("Графік Cos(x)");
            cbGraphics.Items.Add("Графік √x");
            cbGraphics.Items.Add("Графік Sin(x) + 2*x");
            cbGraphics.Items.Add("Графік (4 + x)/(x^2)");
        }
    }
}