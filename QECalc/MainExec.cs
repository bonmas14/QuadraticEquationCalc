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

            var output = CalculateQuadraticEqusion((double)a, (double)b, (double)c);

            OutputLabel.Text = output;

        }


        string CalculateQuadraticEqusion(double a, double b, double c)
        {
            string outputInfo = "";

            if (a == 0)
            {
                outputInfo += "A не должно равняться 0";
                return outputInfo;
            }
            
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            outputInfo += $"Дискриминант = {discriminant}\n";

            outputInfo += $"Центр параболы по x = {Math.Round(-b / (a * 2), 2)}\n";

            if (discriminant < 0)
            {
                // ничего не делаем
            }
            else if (discriminant == 0)
            {
                outputInfo += $"Одно пересечение\n";
                    
                double xRoot = Math.Round(-b / (a * 2), 2);
                    
                outputInfo += $"x = -b / (a * 2) = {-b} / ({a} * 2) ";
                outputInfo += $"= {-b} / {a * 2} = {xRoot}\n";
            }
            else
            {
                discriminant = Math.Round(Math.Sqrt(discriminant), 2);

                outputInfo += $"Два пересечения\n";

                double xRoot1 = Math.Round((-b + discriminant) / (a * 2));

                outputInfo += $"x1 = (-b + D) / (a * 2) = ({-b} + {discriminant}) / ({a} * 2)";
                outputInfo += $"= {Math.Round(-b + discriminant, 2)} / {a * 2} = {xRoot1}\n\n";

                double xRoot2 = Math.Round((-b - discriminant) / (a * 2));

                outputInfo += $"x2 = (-b - D) / (a * 2) = {-b} - {discriminant} / ({a} * 2)";
                outputInfo += $"= {Math.Round(-b - discriminant, 2)} / {a * 2} = {xRoot2}\n\n";
            }

            return outputInfo;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.ShowDialog();
        }
    }
}
