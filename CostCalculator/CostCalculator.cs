using System;
using System.Windows.Forms;


namespace CostCalculator
{
    public partial class CostCalculator : Form
    {
        public CostCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double ferry, flight, fuel, groceries, travelExpenses, extras, amountSaved;

            // Calculate the cost
            try
            {
                ferry = double.Parse(txtFerry.Text);
                flight = double.Parse(txtFlight.Text);
                fuel = double.Parse(txtFuel.Text);
                groceries = double.Parse(txtGroceries.Text);
                travelExpenses = double.Parse(txtTravelExpenses.Text);
                amountSaved = double.Parse(txtSavings.Text);
                extras = double.Parse(txtExtras.Text);

                double result = ferry + flight + fuel + groceries + travelExpenses;
                double dateDiff;
                double weeklySaving;
                double totalSaving = 0;

                if (monthCalendar1.SelectionRange.Start < DateTime.Now)
                {
                    MessageBox.Show("Please select a future date.");
                    return;
                }
                else
                {
                    dateDiff = (monthCalendar1.SelectionRange.Start - DateTime.Now).TotalDays;
                    if (dateDiff < 7)
                    {
                        MessageBox.Show("Please select a date that is at least a week away.");
                        return;
                    }

                    weeklySaving = result / (dateDiff / 7);

                    progressBar1.Maximum = (int)result;

                    totalSaving += amountSaved;

                    progressBar1.Value = (int)Math.Min(totalSaving, result);

                    labelResult.Text = $"The total cost is: ${result.ToString("F2")}\n" +
                    $"You need to save ${weeklySaving.ToString("F2")} per week.";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

        }
    }
}
