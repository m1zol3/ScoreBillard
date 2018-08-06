using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
 

namespace ScoreBillard
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// Entry TFS new point
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string connectionQuery = "SERVER=192.168.2.121;DATABASE=oberhausen;SslMode=none;UID=Micha;PASSWORD=rRcysO6IAdpn7QMl;";
            //string connectionQuery = "SERVER=localhost;DATABASE=oberhausen;SslMode=none;UID=root;PASSWORD=;";
             
            MySqlConnection connection = new MySqlConnection(connectionQuery);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM spieler", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            myGrid.DataContext = dt;

        }
    }
}
