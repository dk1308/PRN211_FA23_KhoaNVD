using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace DemoDataProviderWinform;

public partial class FormProduct : Form
{
    public FormProduct()
    {
        InitializeComponent();
    }

    private DataSet dataSet = new DataSet();

    private void Form1_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=LAPTOP-8EJE3NEE;Database=MyStore;User Id=sa;Password=123456;TrustServerCertificate=true;Trusted_Connection=SSPI;Encrypt=false;";
        string SQL = "Select * from Products; Select * from Categories";
        try
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, connectionString);
            dataAdapter.Fill(dataSet);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Get data from server!");
        }
    }

    public void btnViewProducts_Click(object sender, EventArgs e)
    {
        dgvList.DataSource = dataSet.Tables[0];
    }

    public void btnViewCategories_Click(object sender, EventArgs e)
    {
        dgvList.DataSource = dataSet.Tables[1];
    }

    public void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }


}