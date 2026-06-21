using System;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace MIPUB.DAL
{
    // Lớp tĩnh hỗ trợ khởi tạo kết nối Database dùng chung cho toàn bộ DAL
    public static class DatabaseHelper
    {
        // Lấy chuỗi kết nối từ file App.config bằng ConfigurationManager
        public static string GetConnectionString()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["MIPUB_DB"]?.ConnectionString;
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new Exception("Không tìm thấy chuỗi kết nối 'MIPUB_DB' trong App.config.");
                }
                return connectionString;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đọc cấu hình Database: " + ex.Message);
            }
        }

        // Khởi tạo và trả về đối tượng SqlConnection
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}