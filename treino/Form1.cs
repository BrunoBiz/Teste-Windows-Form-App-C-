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
using MySql.Data.MySqlClient;

namespace treino
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSourceGridPrincipal = new BindingSource();
        private DataSet mDataSet;
        private MySqlDataAdapter mAdapter;

        public static DataTable GetData(string SqlCommand)
        {

            string connectionString = "root@localhost:3306";
            SqlConnection MySQLConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(SqlCommand, MySQLConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }

        public DataSet GetData2(string SqlCommand)
        {
            
            MySqlConnection mConn = new MySqlConnection(" Persist Security Info=False;server=localhost;database=sakila;uid=root;pwd=teste");
            //MySqlConnection mConn = new MySqlConnection("root@localhost:3306");

            mDataSet = new DataSet();

            try
            {
                mConn.Open();
            } 
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            if (mConn.State == ConnectionState.Open)
            {
                mAdapter = new MySqlDataAdapter(SqlCommand, mConn);

                mAdapter.Fill(mDataSet, "Actor");
            }

            return mDataSet;

            /*
            string connectionString = "root@localhost:3306";
            SqlConnection MySQLConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(SqlCommand, MySQLConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
            */
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sakilaActors.film_list'. Você pode movê-la ou removê-la conforme necessário.
            this.film_listTableAdapter.Fill(this.sakilaActors.film_list);
            // TODO: esta linha de código carrega dados na tabela 'sakilaActors.actor'. Você pode movê-la ou removê-la conforme necessário.
            this.actorTableAdapter.Fill(this.sakilaActors.actor);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextMain_Validated(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand CMD = new SqlCommand("select * from ACtor");
            SqlDataReader RDR = CMD.ExecuteReader();

            while (RDR.Read())
            {
                //this.DataGridBanco.DataSource
            }

            // Call Close when done reading.
            RDR.Close();

            //this.sakilaActorsBindingSource.Filter = "WHERE LEFT(FIRST_NAME, 1) = 'P'";
            //this.dataGridView1.Refresh();
        }

        private void ButtonGeraGrid_Click(object sender, EventArgs e)
        {
            this.DataGridBanco.AutoGenerateColumns = true;

            bindingSourceGridPrincipal.DataSource = GetData("Select * from Actor where left(FIRST_NAME, 1) = 'P'");

            this.DataGridBanco.DataSource = bindingSourceGridPrincipal;

            this.DataGridBanco.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            this.DataGridBanco.BorderStyle = BorderStyle.Fixed3D;

            this.DataGridBanco.Refresh();
        }

        private void ButtonDataCerto_Click(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mDataSet = GetData2("Select * from Actor where left(FIRST_NAME, 1) = 'P'");

            this.DataGridBanco.AutoGenerateColumns = true;

            //bindingSourceGridPrincipal.DataSource 
            //this.DataGridBanco.DataSource = bindingSourceGridPrincipal;

            this.DataGridBanco.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            this.DataGridBanco.BorderStyle = BorderStyle.Fixed3D;


            this.DataGridBanco.DataSource = mDataSet;
            this.DataGridBanco.DataMember = "Actor";

            this.DataGridBanco.Refresh();
        }
    }
}
