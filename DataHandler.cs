using System.Data;
using System.Data.SqlClient;

namespace GasolineExpenditure
{
    internal class DataHandler
    {
        // This Class is planned to be used to handle all database processes and anything to do with data manipulation.

        private SqlConnection conn;
        private SqlCommand command;

        public DataHandler()
        {
            string connectionString = "Data Source=LAPTOP-3UT42LKF;Initial Catalog=GasolineExpenditure;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(connectionString);
            command = new SqlCommand(connectionString, conn);
        }

        public void SQL_SELECT()
        {
            OpenConnection();
            command.CommandText =
              "SELECT " +
              "InvoiceNumber AS 'INVOICE', " +
              "DateofPurchase AS 'DATE', " +
              "FullName AS 'NAME', " +
              "Company AS 'COMPANY', " +
              "Station AS 'ADDRESS', " +
              "PumpNumber AS 'PUMP', " +
              "Octane AS 'OCTANE', " +
              "Litres AS 'LITRES', " +
              "LitresPerDollar AS 'L/$CAD', " +
              "Taxes AS 'TAXES', " +
              "Cost AS 'COST', " +
              "TotalPoints AS 'TOTAL PTS', " +
              "PointsGained AS 'PTS GAIN' " +
              "FROM Gasoline_2023 ORDER BY DateofPurchase DESC;";
        }

        public void SQL_INSERT(Gasoline gasoline)
        {
            OpenConnection();
            command.CommandText =
              "INSERT INTO Gasoline_2023 " +
              "(InvoiceNumber, DateofPurchase, FullName, Company, Station, PumpNumber, Octane, Litres, LitresPerDollar, TotalPoints, PointsGained, Taxes) " +
              "VALUES " +
              "(@InvoiceNumber, @Date, @FullName, @Company, @Station, @PumpNumber, @Octane, @Litres, @LitresPerDollar, @TotalPoints, @PointsGained, @Taxes);";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@InvoiceNumber", gasoline.Invoice);
            command.Parameters.AddWithValue("@Date", gasoline.Date);
            command.Parameters.AddWithValue("@FullName", gasoline.FullName);
            command.Parameters.AddWithValue("@Company", gasoline.Company);
            command.Parameters.AddWithValue("@Station", gasoline.Station);
            command.Parameters.AddWithValue("@PumpNumber", gasoline.PumpNumber);
            command.Parameters.AddWithValue("@Octane", gasoline.Octane);
            command.Parameters.AddWithValue("@Litres", gasoline.Litres);
            command.Parameters.AddWithValue("@LitresPerDollar", gasoline.LitresPerDollar);
            command.Parameters.AddWithValue("@TotalPoints", gasoline.TotalPoints);
            command.Parameters.AddWithValue("@PointsGained", gasoline.PointsGained);
            command.Parameters.AddWithValue("@Taxes", gasoline.Taxes);
            command.ExecuteNonQuery();
        }

        public void UploadGasolineEntry
          (int invoice, DateTime date, string fullName, string company, string station, int pumpNumber, string octane,
            decimal litres, decimal litresPerDollar, int totalPoints, int pointsGained, decimal taxes, DataGridView GasGrid)
        {
            OpenConnection();
            // Create a new Gasoline object and insert it into the database
            Gasoline gasoline = new Gasoline(invoice, date, fullName, company, station, pumpNumber, octane, litres, litresPerDollar, totalPoints, pointsGained, taxes);
            SQL_INSERT(gasoline);
            SQL_RETRIEVE(GasGrid);
        }

        public void SQL_DELETE(string invoiceNumber)
        {
            OpenConnection();
            string deleteQuery = "DELETE FROM Gasoline_2023 WHERE InvoiceNumber = @InvoiceNumber;";
            command.CommandText = deleteQuery;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber);
            command.ExecuteNonQuery();
        }

        public void SQL_RETRIEVE(DataGridView GasGrid)
        {
            OpenConnection();
            SqlDataAdapter DA = new SqlDataAdapter(command);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            GasGrid.Refresh();
            GasGrid.DataSource = DT;
        }

        public void LoadGridView(DataGridView GasGrid)
        {
            OpenConnection();
            try
            {
                SQL_SELECT();
                SQL_RETRIEVE(GasGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message);
            }
        }

        public void CreateConnection(DataGridView GasGrid)
        {
            string connectionString = "Data Source=LAPTOP-3UT42LKF;Initial Catalog=GasolineExpenditure;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(connectionString);
            conn.Open();
            command = conn.CreateCommand();
            LoadGridView(GasGrid);
        }
        public void OpenConnection()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }
}