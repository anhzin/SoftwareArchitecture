using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtProvider
{
    public class DataProvider
    {
        public static SqlParameter Param(string paramName, object value)
        {
            var param = new SqlParameter("@" + paramName, value);
            if(param.Value == null)
            {
                param.Value = DBNull.Value;
            }
            return param;
        }
        public static SqlParameter OutputParam(string paramName, SqlDbType type, int size = 0)
        {
            var param = new SqlParameter("@" + paramName, type);
            if(size != 0)
            {
                param = new SqlParameter("@" + paramName, type, size);
            }
            param.Direction = ParameterDirection.Output;
            return param;
        }
        public static string GetConnectionString()
        {
            string strConnection = ConfigurationManager.
                ConnectionStrings["MotorcycleDB"].ConnectionString;
            return strConnection;
        }

        //Execute Query
        public static DataSet ExecuteQueryWithDataSet(string strSQL,
            CommandType cmdType,
            params SqlParameter[] param)
        {
            try
            {
                using (var cnn = new SqlConnection(GetConnectionString()))
                {
                    using (var cmd = new SqlCommand(strSQL, cnn))
                    {
                        cmd.CommandType = cmdType;
                        cmd.Parameters.AddRange(param);
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            var ds = new DataSet();
                            da.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }
        public static SqlDataReader ExecuteQueryWithDataReader(string strSQL,
            CommandType cmdType, params SqlParameter[] param)
        {
            try
            {
                var cnn = new SqlConnection(GetConnectionString());
                using (var cmd = new SqlCommand(strSQL, cnn))
                {
                    cmd.CommandType = cmdType;
                    cmd.Parameters.AddRange(param);
                    cnn.Open();
                    // When using CommandBehavior.CloseConnection, the connection will be closed when the 
                    // IDataReader is closed.
                    var rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    return rd;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }
        //ExecuteNonQuery
        public static bool ExecuteNonQuery(string strSQL,
            CommandType cmdType, params SqlParameter[] paramList)
        {
            try
            {
                using (var cnn = new SqlConnection(GetConnectionString()))
                {
                    using (var cmd = new SqlCommand(strSQL, cnn))
                    {
                        cmd.CommandType = cmdType;
                        cmd.Parameters.AddRange(paramList);
                        cnn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }

        //Executes the query, and returns the first column of the first row in the result set returned by the query. Additional columns or rows are ignored
        public static object ExecuteScalarQuery(string strSQL,
            CommandType cmdType, params SqlParameter[] paramList)
        {
            try
            {
                using (var cnn = new SqlConnection(GetConnectionString()))
                {
                    using (var cmd = new SqlCommand(strSQL, cnn))
                    {
                        cmd.CommandType = cmdType;
                        cmd.Parameters.AddRange(paramList);
                        cnn.Open();
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }
    }
}
