using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QECalc
{
    public partial class MainExec : Form
    {
        InfoForm info;

        public MainExec()
        {
            InitializeComponent();

            info = new InfoForm();
        }

        private void ValueHasChanged(object sender, EventArgs e)
        {
            decimal a = aInp.Value;
            decimal b = bInp.Value;
            decimal c = cInp.Value;

            var output = Calculate((double)a, (double)b, (double)c);

            OutputLabel.Text = output;

        }


        string Calculate(double a, double b, double c)
        {
            string output = "";

            if (a != 0)
            {
                double discr = Math.Pow(b, 2) - 4 * a * c;

                output += $"Дискриминант = {discr}\n";

                output += $"Центр параболы по x = {Math.Round(-b / (a * 2), 2)}\n";

                if (discr < 0)
                {
                    // ничего не делаем
                }
                else if (discr == 0)
                {
                    output += $"Одно пересечение\n";
                    
                    double xPos = Math.Round(-b / (a * 2), 2);
                    
                    output += $"x = -b / (a * 2) = {-b} / ({a} * 2) ";
                    output += $"= {-b} / {a * 2} = {xPos}\n";
                }
                else
                {
                    discr = Math.Round(Math.Sqrt(discr), 2);

                    output += $"Два пересечения\n";

                    double xPos2 = Math.Round((-b - discr) / (a * 2));
                    double xPos1 = Math.Round((-b + discr) / (a * 2));

                    output += $"x1 = (-b + D) / (a * 2) = ({-b} + {discr}) / ({a} * 2)";
                    output += $"= {Math.Round(-b + discr, 2)} / {a * 2} = {xPos1}\n\n";

                    output += $"x2 = (-b - D) / (a * 2) = {-b} - {discr} / ({a} * 2)";
                    output += $"= {Math.Round(-b - discr, 2)} / {a * 2} = {xPos2}\n\n";

                }
            }
            else
            {
                output += "A не должно равняться 0";
            }
            return output;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.ShowDialog();
        }
    }
}
