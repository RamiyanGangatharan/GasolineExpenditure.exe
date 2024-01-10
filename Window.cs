namespace GasolineExpenditure
{
    public partial class Window : Form
    {
        private DataHandler data;
        private LoggerUI UI;

        public Window()
        {
            InitializeComponent();
            data = new DataHandler();
            UI = new LoggerUI(data);
        }
        private void Window_Load(object sender, EventArgs e)
        {
            data.CreateConnection(GasGrid);
            data.OpenConnection();
        }

        private void Window_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.CloseConnection();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            // Retrieve values from form controls
            string firstname = FirstNameRTB.Text;
            string lastname = LastNameRTB.Text;
            string CombinedText = firstname + " " + lastname;

            try
            {
                if (int.TryParse(InvoiceRTB.Text, out int invoice))
                {
                    // Use 'invoice' as it has been successfully parsed
                }
                else
                {
                    MessageBox.Show("Please enter a valid invoice number.");
                }

                DateTime date = dateTimePicker1.Value;
                string fullName = CombinedText;
                string company = GasCompanyCombo.Text;
                string station = AddressRTB.Text;
                int pumpNumber = Convert.ToInt32(PumpNumberRTB.Text);
                string octane = OctaneCombo.Text;
                decimal litres = Convert.ToDecimal(LitresRTB.Text);
                decimal litresPerDollar = Convert.ToDecimal(LitresPerDollarRTB.Text);
                int totalPoints = Convert.ToInt32(TotalPointsRTB.Text);
                int pointsGained = Convert.ToInt32(PointsGainedRTB.Text);
                decimal taxes = Convert.ToDecimal(TaxRTB.Text);

                // Call the method from DataHandler to register the entry
                data.UploadGasolineEntry(invoice, date, fullName, company, station, pumpNumber, octane, litres, litresPerDollar, totalPoints, pointsGained, taxes, GasGrid);

                MessageBox.Show("Data inserted successfully.");
                data.LoadGridView(GasGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            UI.DeleteUI(GasGrid);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            data.CloseConnection();
            Close();
        }

        private void GasGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (GasGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GasGrid.SelectedRows[0];
                decimal price;
                int pumpNumber;
                int pointsGained;
                int totalPoints;

                if (!decimal.TryParse(selectedRow.Cells["COST"].Value?.ToString(), out price))
                {
                    price = 0.0m;
                }
                if (!int.TryParse(selectedRow.Cells["PUMP"].Value?.ToString(), out pumpNumber))
                {
                    pumpNumber = 0;
                }
                if (!int.TryParse(selectedRow.Cells["PTS GAIN"].Value?.ToString(), out pointsGained))
                {
                    pointsGained = 0;
                }
                if (!int.TryParse(selectedRow.Cells["TOTAL PTS"].Value?.ToString(), out totalPoints))
                {
                    totalPoints = 0;
                }

                Gasoline gasoline = new Gasoline
                {
                    Company = selectedRow.Cells["COMPANY"].Value?.ToString() ?? "",
                    PumpNumber = pumpNumber,
                    Octane = selectedRow.Cells["OCTANE"].Value?.ToString() ?? "",
                    PointsGained = pointsGained,
                    TotalPoints = totalPoints
                };

                FuelLabel.Text = "Fuel Company: " + gasoline.Company;
                PumpLabel.Text = "Pump Number: " + gasoline.PumpNumber;
                PriceLabel.Text = "Price: $" + price.ToString("0.00");
                OctaneLabel.Text = "Octane: " + gasoline.Octane;
                string purchaseDate = selectedRow.Cells["DATE"].Value?.ToString() ?? "Unknown Date";
                DateTime parsedDate;
                if (DateTime.TryParse(purchaseDate, out parsedDate))
                {
                    purchaseDate = parsedDate.ToShortDateString(); // Converts to date-only string
                }
                DateLabel.Text = "Date of Purchase: " + purchaseDate;
                DateLabel.Text = "Date of Purchase: " + purchaseDate;
                PointsGainedLabel.Text = "Points Gained: " + gasoline.PointsGained;
                TotalPointsLabel.Text = "Total Points: " + gasoline.TotalPoints;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UI.UpdateHelper(InvoiceRTB, dateTimePicker1, FirstNameRTB, LastNameRTB, GasCompanyCombo, AddressRTB, PumpNumberRTB, OctaneCombo, LitresRTB,
              LitresPerDollarRTB, TotalPointsRTB, PointsGainedRTB, TaxRTB, GasGrid);
            UI.DeleteUI(GasGrid);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            GasCompanyCombo.SelectedItem = null;
            PumpNumberRTB.Clear();
            LitresRTB.Clear();
            TaxRTB.Clear();
            InvoiceRTB.Clear();
            OctaneCombo.SelectedItem = null;
            LitresPerDollarRTB.Clear();
            PointsGainedRTB.Clear();
            TotalPointsRTB.Clear();
            AddressRTB.Clear();
            FirstNameRTB.Clear();
            LastNameRTB.Clear();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            data.LoadGridView(GasGrid);
        }
    }
}