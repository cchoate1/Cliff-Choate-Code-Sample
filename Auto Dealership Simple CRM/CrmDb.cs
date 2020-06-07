using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CustomerResourceManagement
{
    class CrmDb
    {
        protected SqlConnectionStringBuilder _connSb;
        public SqlConnectionStringBuilder ConnectString
        {
            set
            {
                _connSb = new SqlConnectionStringBuilder();
                _connSb = value;
            }
            get { return _connSb; }

        }

        protected SqlConnection _crmConnection;
        public SqlConnection CrmConnection
        {
            set { _crmConnection = new SqlConnection(ConnectString.ConnectionString); }
            get { return _crmConnection; }
        }

        private DataSet _ds;
        public DataSet DS
        {
            set { _ds = value; }
            get { return _ds; }
        }

        public void CloseConnection()
        {
            CrmConnection.Close();
        }
        /*......Dictionary object to hold parameter key-value pairs
        for calling stored procedures  */
        private Dictionary<string, object> _crmDbParm
                            = new Dictionary<string, object>();
        public Dictionary<string, object> DbParms
        {
            set { this._crmDbParm = value; }
            get { return this._crmDbParm; }
        }

        public void ExecuteQueries(string command)
        {
            SqlCommand cmd = new SqlCommand(command);
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader DataReader(string command)
        {
            SqlCommand cmd = new SqlCommand(command);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public CrmDb()
        {
            ConnectString = new SqlConnectionStringBuilder();

            ConnectString.InitialCatalog = "crm";
            ConnectString.DataSource = "sdev265crm.database.windows.net";
            ConnectString.UserID = "SDEV265";
            ConnectString.Password = "IvyTech265";
            CrmConnection = new SqlConnection(ConnectString.ConnectionString);
        }
        public CrmDb(string uname, string pwd)
        {

        }
        public object GetTableData(string command)
        {
            SqlDataAdapter custDR = new SqlDataAdapter(command, CrmConnection);
            DataSet custDS = new DataSet();
            custDR.Fill(custDS);
            object dataum = custDS.Tables[0];
            return dataum;
        }

        public object InsertCustomer(Customer CustObj)
        {
            /* .... return code for database call 
             *          default as error          ... */
            bool DbError = true;

            /* ... Create an integer for the new row's identity 
             *      column value (auto-increment) ... */
            Int32 identityNum = 0;

            this.DbParms.Add("@first_name", CustObj.FirstName);
            this.DbParms.Add("@last_name", CustObj.LastName);
            this.DbParms.Add("@address1", CustObj.Address1);
            this.DbParms.Add("@address2", CustObj.Address2);
            this.DbParms.Add("@city", CustObj.City);
            this.DbParms.Add("@state", CustObj.State);
            this.DbParms.Add("@zip_code", CustObj.ZipCode);
            this.DbParms.Add("@phone", CustObj.Phone);
            this.DbParms.Add("@email", CustObj.Email);
            this.DbParms.Add("@contactPreference_id", CustObj.PreferredContactID);
            this.DbParms.Add("@interests", CustObj.Interests);
            this.DbParms.Add("@min_price", CustObj.MinPrice);
            this.DbParms.Add("@max_price", CustObj.MaxPrice);

            /* using directive allows for object disposal */
            using (CrmConnection)
            {
                /* ... spInsert stored procedure ... */
                SqlCommand spInsert = CrmConnection.CreateCommand();

                spInsert.CommandText = "exec [crm].[uspInsertCustomer]";

                //....(the parameters sent to the insert sp are in a key/value pair.)
                //....(parse the key/value pair into the SqlCommand SqlParameters object)
                foreach (KeyValuePair<string, object> parm in DbParms)
                {
                    //....(now we need to set the parameter to match the data type in the database)
                    SqlParameter newParm = spInsert.CreateParameter();
                    newParm = spInsert.CreateParameter();
                    newParm.Direction = ParameterDirection.Input;
                    newParm = spInsert.Parameters.AddWithValue(parm.Key, parm.Value);
                    newParm.SqlDbType = SqlDbType.Structured;
                    newParm.TypeName = "crm.CustomerTableType";
                }
                /*
                    *....The insert stored procedure returns the value of auto increment 
                    *    identity column on the table. To capture it, we need an OUTPUT
                    *     parameter direction. */
                //....(last parameter for the identity column inserted)
                SqlParameter newParmOut = spInsert.CreateParameter();
                newParmOut = spInsert.CreateParameter();
                newParmOut = spInsert.Parameters.AddWithValue("@new_identity", identityNum);
                newParmOut.Direction = ParameterDirection.Output;
                newParmOut.SqlDbType = SqlDbType.Structured;
                newParmOut.TypeName = "crm.CustomerTableType";

                /* ... we want to be able to trap SQL related errors ... */
                try
                {
                    /* ... Finished with parameters ---
                     *                                           */
                    /* ... Ready to insert the row ...
                      * *****************************************/

                    CrmConnection.Open();
                    spInsert.ExecuteNonQuery();

                    /* ... This is the important  ... Database Access
                     * *******************************************/

                }
                /* ... Error Handler(s)... */
                catch (SqlException ex)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    Console.WriteLine(errorMessages.ToString());
                }
                catch (Exception ex)
                {
                    CrmErrors errorMessages = new CrmErrors("Error in CrmDb-spInsert");
                }
                finally { }  // all resources should be managed by garbage collector




                // return string.Format({0}, 
                return CustObj;
            }
            /*  End of insert transaction 
             *****************************/
        } 
    }
                        //}
                        //private object customerO (object customerI)
                        //{
                        //    string gtdRead = "Select * from [crm].[tblCustomer]";
                        //    GetTableData(gtdRead);.
                        //    return CustomerO;
                        //}
                        //{

                        //}


                        //public object GetCustomers(string command, SqlConnection conn)
                        //{
                        //    SqlDataAdapter dr = new SqlDataAdapter(command, conn);
                        //    DataSet ds = new DataSet();
                        //    dr.Fill(ds);
                        //    object dataum = ds.Tables[0];
                        //    return dataum;
                        //}

}

