
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CS312.Proj
{
    public static class ReportService
    {
        // استخدام قاعدة البيانات الحقيقية وليس البيانات التجريبية
        public static bool UseSampleData = false;

        // الاتصال بنفس SQL Server Instance المحلي
        private static readonly string connStr =
            @"Data Source=.\SQLEXPRESS01;
              Initial Catalog=GradesDB;
              Integrated Security=True;
              TrustServerCertificate=True;
              Connect Timeout=15;";

        // أسماء الأعمدة المطلوبة بواسطة صفحة Reports
        private const string GradesSql = @"
            SELECT
                StudentID,
                StudentName,
                CourseID,
                CourseName,
                Percentage AS Score
            FROM vw_GradesDetails
            ORDER BY CourseName, StudentName;";

        public static DataTable GetGrades()
        {
            if (UseSampleData)
            {
                return BuildSample();
            }

            using (SqlConnection con = new SqlConnection(connStr))
            using (SqlDataAdapter da = new SqlDataAdapter(GradesSql, con))
            {
                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        // جدول احتياطي بنفس الأعمدة المطلوبة
        private static DataTable BuildSample()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("StudentID", typeof(int));
            dt.Columns.Add("StudentName", typeof(string));
            dt.Columns.Add("CourseID", typeof(int));
            dt.Columns.Add("CourseName", typeof(string));
            dt.Columns.Add("Score", typeof(double));

            return dt;
        }
    }
}
