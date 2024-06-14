using System;
using System.Windows.Forms;

namespace Lab6
{public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double lower = double.Parse(txtLowerBound.Text);
                double upper = double.Parse(txtUpperBound.Text);

                FuzzyNumber fuzzyNumber = new FuzzyNumber(lower, upper);
                FuzzyNumber inverseFuzzyNumber = fuzzyNumber.GetInverse();

                lblResult.Text = $"Відповідь: {inverseFuzzyNumber}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректне значення змінних.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    public class FuzzyNumber
    {
        public double LowerBound { get; set; }
        public double UpperBound { get; set; }

        public FuzzyNumber(double lower, double upper)
        {
            LowerBound = lower;
            UpperBound = upper;
        }

     
        public FuzzyNumber GetInverse()
        {
            if (LowerBound <= 0 && UpperBound >= 0)
            {
                throw new InvalidOperationException("Неможливо обчислити обернену величину: Нуль знаходиться в інтервалі.");
            }

            double lower, upper;
            if (LowerBound > 0)
            {
                lower = 1 / UpperBound;
                upper = 1 / LowerBound;
            }
            else 
            {
                lower = 1 / UpperBound;
                upper = 1 / LowerBound;
            }

            return new FuzzyNumber(lower, upper);
        }

        public override string ToString()
        {
            return $"({LowerBound}, {UpperBound})";
        }
    }
    
        }
    }
