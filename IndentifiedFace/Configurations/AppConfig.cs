using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndentifiedFace.Configurations;
using IndentifiedFace.Configurations.Language;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace IndentifiedFace
{
    public class AppConfig : IndentifiedFace.Configurations.Configuration
    {
        public AppConfig(String lang) {
            if (lang.ToUpper().Equals("EN")) 
            { 
                _languagePackage = new EnglishLanguagePackage(); 
            }
            else 
            { 
                _languagePackage = new EnglishLanguagePackage(); 
            }
        }

        public LanguagePackage getLanguagePackage() 
        {
            return _languagePackage;
        }

        public String getDatabaseConnectionString() {

            return ConfigurationSettings.AppSettings["ConnectionString"].ToString();
        }
        public DataTable EXECUTE_PROCE(string SQL)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"].ToString());
                cn.Open();
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.Text;
               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.Dispose();
                cn.Close();
                return ds.Tables[0];
            }
            catch (SqlException ex)
            {

                return null;
            }
            return null;

        }

        private LanguagePackage _languagePackage;
    }
}
