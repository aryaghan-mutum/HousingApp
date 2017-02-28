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
using System.Diagnostics;
using Word = Microsoft.Office.Interop.Word;

namespace HousingAndDiningApp
{
    public partial class FurnitureView : Form
    {
        public FurnitureView()
        {
            InitializeComponent();
        }

        #region update button


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=enterprise.cba.ksu.edu;Initial Catalog=Group3;User ID=group3;Password=Grp3313s");
            DataTable dt = new DataTable("INFO");

            //Opens a database connection
            con.Open();
            
            //storing the data of comboboxes in variables 
            string building = Convert.ToString(comboBoxBuilding.SelectedItem);
            string floor = Convert.ToString(comboBoxFloor.SelectedItem);
            string room = Convert.ToString(comboBoxRoom.SelectedItem);

                string query = "SELECT BUILDING_ID FROM BUILDING WHERE NAME ='" + building + "'";
                SqlCommand commandbuilding = new SqlCommand(query, con);
                string getbuilding = (string)commandbuilding.ExecuteScalar();

                string query2 = "SELECT FLOOR_ID FROM FLOOR WHERE BUILDING_ID ='" + getbuilding + "' AND FLOORNUM = '" + floor + "'";
                SqlCommand commandfloor = new SqlCommand(query2, con);
                string getfloor = (string)commandfloor.ExecuteScalar();

                string query3 = "SELECT ROOM_ID FROM ROOM WHERE FLOOR_ID = '" + getfloor + "' AND ROOMNUM = '" + room + "'";
                SqlCommand commandroom = new SqlCommand(query3, con);
                string getroom = (string)commandroom.ExecuteScalar();

                string query4 = "SELECT * FROM ROOM_ASSETS WHERE ROOM_ID = '" +getroom+ "'";
                SqlCommand commandFID = new SqlCommand(query4, con);
                 string getFID = commandFID.ExecuteScalar().ToString();

                string query5 = "SELECT * FROM FURNITURE WHERE FURNITURE_ID ='" +getFID+"'";
                SqlCommand commandfurniture = new SqlCommand(query5, con);
                string getFurniture = (string)commandfurniture.ExecuteScalar();

                SqlDataReader reader = commandFID.ExecuteReader();
                if (reader.HasRows)
                {

                    dt = new DataTable();
                    dt.Load(reader);
                    dataGridView2.DataSource = dt;
                }
            // Closes the connection to the database
            con.Close();

      
        }
        #endregion


        private void FurnitureView_Load(object sender, EventArgs e)
        {
            this.housingTableTableAdapter.Fill(this.housing.HousingTable);
        }

        private void RequisitionBtn_Click(object sender, EventArgs e)
        {
        Spire.DataExport.RTF.RTFExport rtfExport = new Spire.DataExport.RTF.RTFExport();
        rtfExport.DataSource = Spire.DataExport.Common.ExportSource.DataTable;
        rtfExport.DataTable = this.dataGridView2.DataSource as DataTable;
        rtfExport.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
        Spire.DataExport.RTF.RTFStyle rtfStyle = new Spire.DataExport.RTF.RTFStyle();
        rtfStyle.FontColor = Color.Blue;
        rtfExport.RTFOptions.DataStyle = rtfStyle;
        rtfExport.FileName = @"..\..\ToWord.doc";
        rtfExport.SaveToFile();
        }
    




    }  // end class
} // enc namespace


       


