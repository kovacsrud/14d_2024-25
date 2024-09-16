using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
using System.Windows.Shapes;

namespace WpfSqliteKutyak.views
{
    /// <summary>
    /// Interaction logic for Kutyanevek.xaml
    /// </summary>
    public partial class Kutyanevek : Window
    {
        //private string connectionString = "Data Source=kutyak.db";
        public Kutyanevek()
        {
            InitializeComponent();
            datagridKutyanevek.ItemsSource = GetKutyanevek();
        }

        private List<Kutyanev> GetKutyanevek()
        {
            List<Kutyanev> kutyanevek = new List<Kutyanev>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string sqlCommand = "select * from kutyanevek";

                    using (SQLiteCommand command = new SQLiteCommand(sqlCommand, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Kutyanev kutyanev = new Kutyanev();

                                kutyanev.Id = Convert.ToInt32(reader["Id"]);
                                kutyanev.KutyaNev = reader["kutyanev"].ToString();

                                kutyanevek.Add(kutyanev);

                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return kutyanevek;
        }

        private void buttonUjKutyanev_Click(object sender, RoutedEventArgs e)
        {
            EditKutyanev editKutyanev= new EditKutyanev();
            editKutyanev.ShowDialog();
        }

        private void datagridKutyanevek_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var aktKutyanev=datagridKutyanevek.SelectedItem as Kutyanev;
            EditKutyanev editKutyanev = new EditKutyanev(aktKutyanev);
            editKutyanev.ShowDialog();
        }
    }
}
