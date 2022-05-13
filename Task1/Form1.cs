using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           // emp_name.Text = "Enter Name here";
           // emp_salary.Text = "Enter Salary here";
           // DocDestroy.Text = "Enter DocDestroy here";
           // ID.Text = "Enter Id here";
           
            string Query = "select * from employee";  
            SqlCommand MyCommand2 = new SqlCommand(Query, FF_POSSystem.MySqlConnection.GetConnected());
            SqlDataAdapter MyAdapter = new SqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            grd.DataSource = dTable;

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn1_Click(object sender, EventArgs e) //button code
        {

                String i = ID.Text;
                int id = Int32.Parse(i); //for convert string to varchar
                String emp = emp_name.Text;
                String salary = emp_salary.Text;
                String DD = DocDestroy.Text;
                label2.Text = i + " " + emp + " " + salary + " " + DD; //display values on labels

            if (btn.Text == "Submit") //for inserting the data 
            {
                try
                { 
                   //string connetionString;
                  //SqlConnection MyConn2;
                  //  connetionString = "Data Source=192.168.1.2,1433;Network Library=DBMSSOCN;Initial Catalog=Sync_Db;Persist Security Info=True;User ID=sa;Password=Abacus$123;";
                   // FF_POSSystem.MySqlConnection.GetConnected(); //this function call from other class
                    string Insert = "insert into employee(ID,emp_name,emp_salary,DocDestroy) values('" + this.ID.Text + "','" + this.emp_name.Text + "','" + this.emp_salary.Text + "','" + this.DocDestroy.Text + "');";
                    //  MyConn2 = new SqlConnection(connetionString);   
                    SqlCommand MyCommand2 = new SqlCommand(Insert, FF_POSSystem.MySqlConnection.GetConnected());
                    SqlDataReader MyReader2;
                    // MyConn2.Open();  
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.                    
                    MessageBox.Show("Data Is Saved"); // alert massage 
                    
                    while (MyReader2.Read())
                    {}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ID.Clear(); //for clear the input values
                emp_name.Clear();   //for clear the input values
                emp_salary.Clear(); //for clear the input values
                DocDestroy.Clear(); //for clear the input values
                
            }
            else if (btn.Text == "Update") //for updating the data 
            {
                try
                {
                    FF_POSSystem.MySqlConnection.GetConnected();
                    string Update = "update employee set ID='" + this.ID.Text + "',emp_name='" + this.emp_name.Text + "',emp_salary='" + this.emp_salary.Text + "',DocDestroy='" + this.DocDestroy.Text + "' where ID='" + this.ID.Text + "';";
                    SqlCommand MyCommand2 = new SqlCommand(Update, FF_POSSystem.MySqlConnection.GetConnected());
                    SqlDataReader MyReader2; 
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.                    
                    MessageBox.Show("Data Is Updated");
                    while (MyReader2.Read())
                    {}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ID.Clear();
                emp_name.Clear();
                emp_salary.Clear();
                DocDestroy.Clear();


            }
            else{
                try
                {
                    FF_POSSystem.MySqlConnection.GetConnected();
                    string Delete = "delete from employee where ID='" + this.ID.Text + "';"; 
                    SqlCommand MyCommand2 = new SqlCommand(Delete, FF_POSSystem.MySqlConnection.GetConnected());
                    SqlDataReader MyReader2;
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.                    
                    MessageBox.Show("Data Is Delete");
                    while (MyReader2.Read())
                    {}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ID.Clear();
                }
            
                }
       
        

        private void senddatatb(object sender, DataGridViewCellEventArgs e)//for selecting the row from grideview and passto textbox
        {
//            MessageBox.Show("you delete this row");
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grd.Rows[e.RowIndex];
                ID.Text = row.Cells["ID"].Value.ToString();
                btn.Text = "Delete";
            }

            

        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deldatatb(object sender, DataGridViewCellEventArgs e)
        {
            //  MessageBox.Show("you delete this row");
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grd.Rows[e.RowIndex];
                ID.Text = row.Cells["ID"].Value.ToString();
                emp_name.Text = row.Cells["emp_name"].Value.ToString();
                emp_salary.Text = row.Cells["emp_salary"].Value.ToString();
                DocDestroy.Text = row.Cells["DocDestroy"].Value.ToString();
                btn.Text = "Update";
            }
        }

     
        //for hint text in textbox
        private void ID_Enter(object sender, EventArgs e)
        {
            //String idd = "Enter Id Here";
           // int id = Int32.Parse(idd); //for convert string to varchar

            if (ID.Text == "Enter Id Here")
            {
                ID.Text = "";
            }
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                ID.Text = "Enter Id Here";
                ID.ForeColor = Color.Gray;
            }
        }
        private void emp_name_enter(object sender, EventArgs e)
        {
            if (emp_name.Text == "Enter Name here")
            {
                emp_name.Text = "";
            }
        }

        private void emp_name_leave(object sender, EventArgs e)
        {
            if (emp_name.Text == "")
            {
                emp_name.Text = "Enter Name Here";
                emp_name.ForeColor = Color.Gray;
            }
        }

        private void emp_salary_enter(object sender, EventArgs e)
        {
            if (emp_salary.Text == "Enter Salary here")
            {
                emp_salary.Text = "";
            }
        }

        private void emp_salary_leave(object sender, EventArgs e)
        {
            if (emp_salary.Text == "")
            {
                emp_salary.Text = "Enter Salary Here";
                emp_salary.ForeColor = Color.Gray;
            }
        }

        private void DocDestroy_enter(object sender, EventArgs e)
        {
            if (DocDestroy.Text == "Enter DocDestroy here")
            {
                DocDestroy.Text = "";
            }
        }

        private void DocDestroy_leave(object sender, EventArgs e)
        {
            if (DocDestroy.Text == "")
            {
                DocDestroy.Text = "Enter DocDestroy Here";
                DocDestroy.ForeColor = Color.Gray;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
         //   string connetionString;
         //   SqlConnection cnn;
         //   connetionString ="Data Source=192.168.1.2,1433;Network Library=DBMSSOCN;Initial Catalog=FF_STEEL_1;Persist Security Info=True;User ID=sa;Password=Abacus$123;";
         //   cnn = new SqlConnection(connetionString);
         //   cnn.Open();
         //   MessageBox.Show("Connection Open  !");
         //   cnn.Close();


        }
    }

