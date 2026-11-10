
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Students__Grades
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString =
            @"Server=DESKTOP-86VJV2K\SQLEXPRESS01;Database=GradesDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database Connection Failed:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }
    }
}
