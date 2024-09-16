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
    /// Interaction logic for EditKutyanev.xaml
    /// </summary>
    public partial class EditKutyanev : Window
    {
        bool modosit = false;
        //private string connectionString = "Data Source=kutyak.db";
        public EditKutyanev()
        {
            InitializeComponent();
        }

        public EditKutyanev(Kutyanev kutyanev)
        {
            InitializeComponent();
            textblockCim.Text = "Módosítás";
            textboxId.Text = kutyanev.Id.ToString();
            textboxKutyanev.Text = kutyanev.KutyaNev;
            modosit = true;

        }

        private void UjKutyanev()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string insertCommand = "insert into kutyanevek (kutyanev) values(@kutyanev)";

                    using (SQLiteCommand command=new SQLiteCommand(insertCommand,connection))
                    {
                        command.Parameters.AddWithValue("@kutyanev", textboxKutyanev.Text);
                        var sorok=command.ExecuteNonQuery();
                        MessageBox.Show($"Beszúrva:{sorok} sor.");
                    }

                    connection.Close();
                }
            }
            catch (SQLiteException sqlex) {
                MessageBox.Show($"Adatbázis hiba:{sqlex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModositKutyanev()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string insertCommand = "update kutyanevek set kutyanev=@kutyanev where Id=@id";

                    using (SQLiteCommand command = new SQLiteCommand(insertCommand, connection))
                    {
                        command.Parameters.AddWithValue("@id", textboxId.Text);
                        command.Parameters.AddWithValue("@kutyanev", textboxKutyanev.Text);
                        var sorok = command.ExecuteNonQuery();
                        MessageBox.Show($"Módosítva:{sorok} sor.");
                    }

                    connection.Close();
                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show($"Adatbázis hiba:{sqlex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (modosit)
            {
                ModositKutyanev();
            } else
            {
                UjKutyanev();
            }
        }
    }
}
