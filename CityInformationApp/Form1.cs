using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityInformationApp
{
    public partial class CityInformation : Form
    {
        public CityInformation()
        {
            InitializeComponent();
            
        }

        private bool isUpdateMode = false;
        private int cityId;

        private string connectionString = ConfigurationManager.ConnectionStrings["CityInfoConString"].ConnectionString;
        private City aCity=new City();

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            aCity.CityName = cityTextBox.Text;
            aCity.About = aboutTextBox.Text;
            aCity.Country = countryTextBox.Text;


            if (isUpdateMode)
            {
                SqlConnection connection = new SqlConnection(connectionString);

                string query = "UPDATE cityInfo SET about='" + aCity.About + "',country='" +
                               aCity.Country + "' WHERE ID='"+cityId+"'";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowAffected > 0)
                {
                    MessageBox.Show("Data Updated Successfully");
                    saveButton.Text = "Save";
                    cityId = 0;
                    isUpdateMode = false;
                    ShowAllCitys();
                }
                else
                {
                    MessageBox.Show("Failed to Update Data");
                }
            }
            else
            {
                if (IsCityExists(aCity.CityName))
                {
                    MessageBox.Show("City Name Allready Exist");
                    return;
                }

                SqlConnection connection = new SqlConnection(connectionString);

                string query = "INSERT INTO cityInfo VALUES('" + aCity.CityName + "','" + aCity.About + "','" +
                               aCity.Country + "')";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowAffected > 0)
                {
                    MessageBox.Show("Data Inserted Successfully");
                    ShowAllCitys();
                }
                else
                {
                    MessageBox.Show("Failed to Insert Data");
                }
            }
            
            ClearAll();


        }

        private void ClearAll() 
        {
            cityTextBox.Clear();
            aboutTextBox.Clear();
            countryTextBox.Clear();
        }

        public bool IsCityExists(string cityName)
        {
            SqlConnection connection=new SqlConnection(connectionString);
            string query = "SELECT * FROM cityInfo WHERE cityName ='" + aCity.CityName + "'";

            bool isCityNameExists = false;

            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader =command.ExecuteReader();
            while (reader.Read())
            {
                isCityNameExists = true;
                break;
            }
            reader.Close();
            connection.Close();

            return isCityNameExists;
        }

        public void ShowAllCitys()
        {
            SqlConnection connection=new SqlConnection(connectionString);
            string query = "SELECT * FROM cityInfo";
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<City> listOfCities=new List<City>();
            while (reader.Read())
            {
                City aCity=new City();
                aCity.ID = int.Parse(reader["ID"].ToString());
                aCity.CityName = reader["cityName"].ToString();
                aCity.About = reader["about"].ToString();
                aCity.Country = reader["country"].ToString();

                listOfCities.Add(aCity);

            }
            reader.Close();
            connection.Close();

            LoadCityListView(listOfCities);
        }

        public void LoadCityListView(List<City> cities)
        {
            cityListView.Items.Clear();
            int counter = 1;
            foreach (City city in cities)
            {
                ListViewItem item=new ListViewItem(counter.ToString());
                item.SubItems.Add(city.CityName);
                item.SubItems.Add(city.About);
                item.SubItems.Add(city.Country);
                counter++;
                cityListView.Items.Add(item);
            }
        }

        private void CityInformation_Load(object sender, EventArgs e)
        {
            ShowAllCitys();
        }

        private void cityListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = cityListView.SelectedItems[0];
            int SerialNo = int.Parse(item.Text.ToString());
            string cityName = cityListView.SelectedItems[0].SubItems[1].Text;
            string about = cityListView.SelectedItems[0].SubItems[2].Text;
            string country = cityListView.SelectedItems[0].SubItems[3].Text;
            cityTextBox.Text = cityName;
            aboutTextBox.Text = about;
            countryTextBox.Text = country;
            isUpdateMode = true;
            saveButton.Text = "Update";
        }

        public City GetCityById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM cityInfo WHERE ID='"+id+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<City> listOfCities = new List<City>();
            while (reader.Read())
            {
                City aCity = new City();
                aCity.ID = int.Parse(reader["ID"].ToString());
                aCity.CityName = reader["cityName"].ToString();
                aCity.About = reader["about"].ToString();
                aCity.Country = reader["country"].ToString();

                listOfCities.Add(aCity);

            }
            reader.Close();
            connection.Close();

            return listOfCities.FirstOrDefault();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            
            Search1();
              
        }

        private void Search1()
        {
            List<City> cityList = null;
            if (citySearchRadioButton.Checked)
            {
                string searchInput = searchTextBox.Text;
                if (searchInput == "")
                {
                    cityList = Search("select * from cityInfo");
                    LoadCityListView(cityList);
                }
                else
                {
                    cityList = Search("select * from cityInfo where cityName like '%" + searchInput + "%'");
                    LoadCityListView(cityList);
                }

            }
            else if (countrySearchRadioButton.Checked)
            {
                string searchInput = searchTextBox.Text;
                if (searchInput == "")
                {
                    cityList = Search("select * from cityInfo");
                    LoadCityListView(cityList);
                }
                else
                {
                    cityList = Search("select * from cityInfo where country like '%" + searchInput + "%'");
                    LoadCityListView(cityList);
                }

            }
            else
            {
                MessageBox.Show("Select An Option");
                //cityList = Search("select * from cityInfo");
                //LoadCityListView(cityList);
            }
        }

        public List<City> Search(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query,connection);

            List<City> listOfCities = new List<City>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                City aCity = new City();
                aCity.ID = int.Parse(reader["ID"].ToString());
                aCity.CityName = reader["cityName"].ToString();
                aCity.About = reader["about"].ToString();
                aCity.Country = reader["country"].ToString();

                listOfCities.Add(aCity);
            }
            connection.Close();
            return listOfCities;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search1();
        } 

    }
}
