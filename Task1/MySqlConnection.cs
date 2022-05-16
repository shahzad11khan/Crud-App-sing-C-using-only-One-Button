using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF_POSSystem
{
    class MySqlConnection
    {
        public static string UserName = "";
        public static string RoleID = "";
        public static string FranchiseLocation = "";
        public static string FranchiseDescription = "";
        public static string mCompanyID = "";
        public static string mCompanyName = "";
        public static string mSOInvoice = "";
        public static string U_Name = "";
        public static string SaleReports = "";
        public static string SaleLayout = "";
        public static string writePermission = "";

        public static string FromForm = "";

        // bellow four line are credentails  for SAP Crystel Report 203 server

        public static string ServerName = "server name";
        public static string DatabaseName = "database name";
        public static string UserID = "your name";
        public static string Password = "password ";

        public static string LinkServerName = "192";
        //public static string ServerName = "20";
        //public static string DatabaseName = "";
        //public static string UserID = "";
        //public static string Password = "";

        //public static string conLive = "there is your database link";
       
        public static string conLive = "there is your database link";
        //1.9 POS
        //public static string conLive = "there is your database link";
        //1.2 POS
      // public static string conLive = "there is your database link";
       //1.2 public ip
       // public static string conLive = "there is your database link";
        
        public static SqlConnection GetConnected()
        {
           
            //202.141.236.205,1434
           string  connetionString = "there is your database link along with id and password";

           SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            return con;
        }
        public static Boolean CheckGetConnected()
        {
            SqlConnection con = new SqlConnection(conLive);
           
            try
            {
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error",ex.Message);
                
                return false;
            }
            finally
            {
                con.Close();
                
            }

        }
        
        public static SqlConnection GetConnectedSAP()
        {
          
            SqlConnection con = new SqlConnection("there is your database link along with id and password");
             con.Open();
            return con;
        }
        public static object FilCombo(string str, ComboBox pComboBox)
        {
            SqlConnection connection = MySqlConnection.GetConnected();
            string sqlRead = str;
            SqlCommand command = new SqlCommand(sqlRead, connection);
            command.CommandType = CommandType.Text;
            pComboBox.Items.Clear();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleResult);
            while (reader.Read())
            {
                pComboBox.Items.Add(reader.GetValue(0));
            }
            connection.Close();
            return str;
        }
        public static object FilComboSAP(string str, ComboBox pComboBox)
        {
            SqlConnection connection = MySqlConnection.GetConnectedSAP();
            string sqlRead = str;
            SqlCommand command = new SqlCommand(sqlRead, connection);
            command.CommandType = CommandType.Text;
            pComboBox.Items.Clear();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleResult);
            while (reader.Read())
            {
                pComboBox.Items.Add(reader.GetValue(0));
            }
            connection.Close();
            return str;
        }
        public static object FillDictionarySAP(string str, Dictionary<string, float> dict)
        {
            SqlConnection connection = MySqlConnection.GetConnectedSAP();
            string sqlRead = str;
            SqlCommand command = new SqlCommand(sqlRead, connection);
            command.CommandType = CommandType.Text;
            dict.Clear();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleResult);
            while (reader.Read())
            {
                dict.Add(reader.GetValue(0).ToString(), (float) Convert.ToDouble(reader.GetValue(1).ToString()));
            }
            connection.Close();
            return str;
        }
        public static Boolean RecordExist(string strSQL, string fldName)
        {
            Boolean Exist = new Boolean();
            using (SqlConnection connection = MySqlConnection.GetConnected())
            {
                string sqlRead = strSQL;
                SqlCommand command = new SqlCommand(sqlRead, connection);
                command.CommandType = CommandType.Text;
                //command.ExecuteReader();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Exist = true;
                    string ma = MySqlConnection.messageCaption();
                    //msg.Show(" " + fldName + " ... " + "found in the Database", ma, "OK");
                    MessageBox.Show(" " + fldName + " ... " + "found in the Database", ma, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Exist = false;
                }


            }//// using Block ends
            return Exist;


        }
        public static Boolean RecordExist_Menu(string strSQL, string fldName)
        {
            Boolean Exist = new Boolean();
            using (SqlConnection connection = MySqlConnection.GetConnected())
            {
                string sqlRead = strSQL;
                SqlCommand command = new SqlCommand(sqlRead, connection);
                command.CommandType = CommandType.Text;
                //command.ExecuteReader();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Exist = true;
                    string ma = MySqlConnection.messageCaption();
                    //msg.Show(" " + fldName + " ... " + "found in the Database", ma, "OK");
                    MessageBox.Show(" " + fldName + " ... " + " have not Authority", ma, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Exist = false;
                }


            }//// using Block ends
            return Exist;


        }
        public static string InsertUpdateDelete(string str)
        {
            SqlConnection connection = MySqlConnection.GetConnected();
            string sqlRead = str;
            SqlCommand command = new SqlCommand(sqlRead, connection);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            connection.Close();
            return str;
        }
        public static Boolean RecordExist_No_Message(string strSQL)
        {
            Boolean Exist = new Boolean();
            using (SqlConnection connection = MySqlConnection.GetConnected())
            {
                string sqlRead = strSQL;
                SqlCommand command = new SqlCommand(sqlRead, connection);
                command.CommandType = CommandType.Text;
                //command.ExecuteReader();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Exist = true;
                }
                else
                {
                    Exist = false;
                }


            }//// using Block ends
            return Exist;


        }
        public static Boolean RecordnotExist(string strSQL, string str)
        {
            Boolean Exist = new Boolean();
            using (SqlConnection connection = MySqlConnection.GetConnected())
            {
                string sqlRead = strSQL;
                SqlCommand command = new SqlCommand(sqlRead, connection);
                command.CommandType = CommandType.Text;
                //command.ExecuteReader();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Exist = false;
                }
                else
                {
                    Exist = true;
                    string ma = MySqlConnection.messageCaption();
                   // msg.Show(str + " not found in the Database", ma, "OK");
                    MessageBox.Show(str + " not found in the Database", ma, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }


            }//// using Block ends
            return Exist;


        }
        public static Boolean RecordnotExist_No_Message(string strSQL)
        {

            Boolean Exist = new Boolean();
            using (SqlConnection connection = MySqlConnection.GetConnected())
            {
                string sqlRead = strSQL;
                SqlCommand command = new SqlCommand(sqlRead, connection);
                command.CommandType = CommandType.Text;
                //command.ExecuteReader();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Exist = false;
                }
                else
                {
                    Exist = true;

                }

            }
            //// using Block ends
            return Exist;


        }
        public static SqlDataReader RecordsExist(string strSQL)
        {

            SqlConnection connection = MySqlConnection.GetConnected();

            string sqlRead = strSQL;
            SqlCommand command = new SqlCommand(sqlRead, connection);
            command.CommandType = CommandType.Text;
            //command.ExecuteReader();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleResult);
            return reader;


        }
        public static Boolean digits(Label objlabel, TextBox objTextBox)
        {
            Boolean B = new Boolean();

            if (System.Char.IsNumber(objTextBox.Text, int.Parse(objTextBox.TextLength.ToString())) == false)
            {

                string ma = MySqlConnection.messageCaption();
                //msg.Show("Only Digits allowed while entering data in " + objlabel.Text + " ...", ma, "OK");
                 MessageBox.Show("only Digits allowed while entering data in " + objlabel.Text + " ...", ma, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return B;

        }
        public static string Relocate(string strsql)
        {
            string mCode = "0";

            using (SqlDataReader reader_1 = MySqlConnection.GetRow_FromDatabase(strsql))
            {

                if (reader_1.HasRows)
                {
                    reader_1.Read();
                    mCode = reader_1.GetValue(0).ToString();

                }


            }
            return mCode;

        }
        public static string messageCaption()
        {
            string ma = "Inventory... System";

            return ma;
        }
        public static SqlDataReader GetRow_FromDatabase(string str)
        {

            SqlConnection connection = MySqlConnection.GetConnected();
            string sqlRead = str;
            SqlCommand command = new SqlCommand(sqlRead, connection);
            command.CommandType = CommandType.Text;
            //command.ExecuteReader();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleResult);

            return reader;
        }
        public static SqlDataReader GetRow_FromDatabaseSAP(string str)
        {

            SqlConnection connection = MySqlConnection.GetConnectedSAP();
            string sqlRead = str;
            SqlCommand command = new SqlCommand(sqlRead, connection);
            command.CommandType = CommandType.Text;
            //command.ExecuteReader();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection | CommandBehavior.SingleResult);

            return reader;
        }
        public static DataGridTableStyle FormatGrid(DataGrid grid, int wid, int col, string view_Name)
        {
            DataGridTableStyle Dt = new DataGridTableStyle();

            //int Width=new int();
            SizeF size = new SizeF();

            size.Width = wid;

            //g.Dispose();
            grid.TableStyles[view_Name].GridColumnStyles[col].Width = wid;
            grid.TableStyles[view_Name].GridLineStyle = DataGridLineStyle.Solid;
            grid.TableStyles[view_Name].HeaderFont.Bold.Equals(true);
            // dataGrid1.TableStyles["View_Registration"].HeaderFont = SystemFonts.CaptionFont.Underline.Equals(true);
            grid.TableStyles[view_Name].HeaderForeColor = Color.DarkRed;
            grid.TableStyles[view_Name].SelectionBackColor = Color.DodgerBlue;
            grid.TableStyles[view_Name].ReadOnly = (true);
            grid.TableStyles[view_Name].GridLineColor = Color.Coral;

            return Dt;
        }
        public static DataSet GetDataSet(string str, string view_Name)
        {
            DataSet ds = new DataSet();

            using (SqlConnection connection = MySqlConnection.GetConnected())
            {

                SqlDataAdapter adap = new SqlDataAdapter(str, connection);
                //adap.Fill(ds, "View_Registration");
                adap.Fill(ds, view_Name);
                return ds;

            }
        }
        public static DataSet GetDataSetSAP(string str, string view_Name)
        {
            DataSet ds = new DataSet();

            using (SqlConnection connection = MySqlConnection.GetConnectedSAP())
            {

                SqlDataAdapter adap = new SqlDataAdapter(str, connection);
                //adap.Fill(ds, "View_Registration");
                adap.Fill(ds, view_Name);
                return ds;

            }
        }
        public static DataSet GetDataSetMy(string str, string view_Name)
        {
            DataSet ds = new DataSet();

            using (SqlConnection connection = MySqlConnection.GetConnected())
            {

                SqlDataAdapter adap = new SqlDataAdapter(str, connection);

                adap.Fill(ds, view_Name);
                return ds;

            }
        }
    }
}
