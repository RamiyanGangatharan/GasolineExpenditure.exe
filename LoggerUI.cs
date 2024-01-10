using System.Data.SqlClient;

namespace GasolineExpenditure
{
    internal class LoggerUI
    {
        // This class is planned to be used for methods that directly handle GUI functionality.

        private DataHandler data;
        public LoggerUI(DataHandler handler)
        {
            data = handler;
        }
        Gasoline newGasoline = new Gasoline();

        public void DeleteUI(DataGridView GasGrid)
        {
            if (GasGrid.SelectedRows.Count == 1)
            {
                var selectedRow = GasGrid.SelectedRows[0];
                var invoiceNumber = selectedRow.Cells["INVOICE"].Value.ToString() ?? "";

                try
                {
                    data.SQL_DELETE(invoiceNumber);
                    data.LoadGridView(GasGrid);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        public void UpdateHelper
          (
            RichTextBox InvoiceRTB, DateTimePicker dateTimePicker1, RichTextBox FirstNameRTB, RichTextBox LastNameRTB, ComboBox GasCompanyCombo,
            RichTextBox AddressRTB, RichTextBox PumpNumberRTB, ComboBox OctaneCombo, RichTextBox LitresRTB, RichTextBox LitresPerDollarRTB,
            RichTextBox TotalPointsRTB, RichTextBox PointsGainedRTB, RichTextBox TaxRTB, DataGridView GasGrid
          )
        {
            if (GasGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GasGrid.SelectedRows[0];
                if (DateTime.TryParse(row.Cells["DATE"].Value?.ToString(), out DateTime dateValue))
                {
                    newGasoline.Date = dateValue;
                }
                else
                {
                    newGasoline.Date = DateTime.MinValue;
                }

                newGasoline.FullName = row.Cells["NAME"].Value?.ToString() ?? "";
                newGasoline.Company = row.Cells["COMPANY"].Value?.ToString() ?? "";
                newGasoline.Station = row.Cells["ADDRESS"].Value?.ToString() ?? "";

                if (int.TryParse(row.Cells["PUMP"].Value?.ToString(), out int pumpNumber))
                {
                    newGasoline.PumpNumber = pumpNumber;
                }
                else
                {
                    newGasoline.PumpNumber = 0;
                }

                newGasoline.Octane = row.Cells["OCTANE"].Value?.ToString() ?? "";

                if (decimal.TryParse(row.Cells["LITRES"].Value?.ToString(), out decimal litres))
                {
                    newGasoline.Litres = litres;
                }
                else
                {
                    newGasoline.Litres = 0.0m;
                }

                if (decimal.TryParse(row.Cells["L/$CAD"].Value?.ToString(), out decimal litresPerDollar))
                {
                    newGasoline.LitresPerDollar = litresPerDollar;
                }
                else
                {
                    newGasoline.LitresPerDollar = 0.0m;
                }

                if (int.TryParse(row.Cells["PTS GAIN"].Value?.ToString(), out int pointsGained))
                {
                    newGasoline.PointsGained = pointsGained;
                }
                else
                {
                    newGasoline.PointsGained = 0;
                }

                if (int.TryParse(row.Cells["TOTAL PTS"].Value?.ToString(), out int totalPoints))
                {
                    newGasoline.TotalPoints = totalPoints;
                }
                else
                {
                    newGasoline.TotalPoints = 0;
                }

                if (int.TryParse(row.Cells["INVOICE"].Value?.ToString(), out int invoice))
                {
                    newGasoline.Invoice = invoice;
                }
                else
                {
                    newGasoline.Invoice = 0;
                }

                if (decimal.TryParse(row.Cells["TAXES"].Value?.ToString(), out decimal taxes))
                {
                    newGasoline.Taxes = taxes;
                }
                else
                {
                    newGasoline.Taxes = 0.0m;
                }

                InvoiceRTB.Text = newGasoline.Invoice.ToString();
                GasCompanyCombo.Text = newGasoline.Company.ToString();
                PumpNumberRTB.Text = newGasoline.PumpNumber.ToString();
                LitresRTB.Text = newGasoline.Litres.ToString();
                LitresPerDollarRTB.Text = newGasoline.LitresPerDollar.ToString();
                TaxRTB.Text = newGasoline.Taxes.ToString();
                OctaneCombo.Text = newGasoline.Octane.ToString();
                dateTimePicker1.Text = newGasoline.Date.ToString();
                PointsGainedRTB.Text = newGasoline.PointsGained.ToString();
                TotalPointsRTB.Text = newGasoline.TotalPoints.ToString();
                AddressRTB.Text = newGasoline.Station.ToString();
                string[] names = newGasoline.FullName.Split(' ');

                // Check if the array has at least two elements for first and last names
                if (names.Length >= 2)
                {
                    FirstNameRTB.Text = names[0]; // First name is the first element
                    LastNameRTB.Text = names[1]; // Last name is the second element
                }
                else if (names.Length == 1)
                {
                    FirstNameRTB.Text = names[0]; // Only one name is present
                    LastNameRTB.Text = ""; // No last name
                }
                else
                {
                    FirstNameRTB.Text = "";
                    LastNameRTB.Text = "";
                }
            }
        }
    }
}