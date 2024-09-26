using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfSqliteKutyak.Model;

namespace WpfSqliteKutyak
{
    public static class DbRepo
    {
        public static List<Kutyanev> GetKutyanevek()
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

        public static void UjKutyanev(Kutyanev kutyanev)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string insertCommand = "insert into kutyanevek (kutyanev) values(@kutyanev)";

                    using (SQLiteCommand command = new SQLiteCommand(insertCommand, connection))
                    {
                        command.Parameters.AddWithValue("@kutyanev", kutyanev.KutyaNev);
                        var sorok = command.ExecuteNonQuery();
                        MessageBox.Show($"Beszúrva:{sorok} sor.");
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

        public static void ModositKutyanev(Kutyanev kutyanev)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string insertCommand = "update kutyanevek set kutyanev=@kutyanev where Id=@id";

                    using (SQLiteCommand command = new SQLiteCommand(insertCommand, connection))
                    {
                        command.Parameters.AddWithValue("@id", kutyanev.Id);
                        command.Parameters.AddWithValue("@kutyanev", kutyanev.KutyaNev);
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

        public static void TorolKutyanev(Kutyanev kutyanev)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string insertCommand = "delete from kutyanevek where Id=@id";

                    using (SQLiteCommand command = new SQLiteCommand(insertCommand, connection))
                    {
                        command.Parameters.AddWithValue("@id", kutyanev.Id);
                        
                        var sorok = command.ExecuteNonQuery();
                        MessageBox.Show($"Törölve:{sorok} sor.");
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

        public static List<Rendeles> GetRendelesiAdatok()
        {
            List<Rendeles> rendelesLista = new List<Rendeles>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string sqlCommand = @"select kutya.Id as Id,
                                         fajtaid,
                                         nevid,
                                         eletkor,
                                         utolsoell,
                                         kutyanev,
                                         nev as fajtanev
                                      from kutya,kutyanevek,kutyafajtak
                                      where kutya.fajtaid=kutyafajtak.Id and kutya.nevid=kutyanevek.Id";

                    using (SQLiteCommand command = new SQLiteCommand(sqlCommand, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Rendeles rendeles = new Rendeles();
                                rendeles.Id = Convert.ToInt32(reader["Id"]); ;
                                rendeles.NevId = Convert.ToInt32(reader["nevid"]);
                                rendeles.FajtaId = Convert.ToInt32(reader["fajtaid"]);
                                rendeles.Eletkor = Convert.ToInt32(reader["eletkor"]);
                                rendeles.UtolsoEll = reader["utolsoell"].ToString();
                                rendeles.FajtaNev = reader["fajtanev"].ToString();
                                rendeles.KutyaNev = reader["kutyanev"].ToString();

                                rendelesLista.Add(rendeles);

                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return rendelesLista;
        }

        public static void UjRendelesiAdat(Rendeles rendeles)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string insertCommand = "insert into kutya (fajtaid,nevid,eletkor,utolsoell) values(@fajtaid,@nevid,@eletkor,@utolsoell)";

                    using (SQLiteCommand command = new SQLiteCommand(insertCommand, connection))
                    {
                        command.Parameters.AddWithValue("@fajtaid", rendeles.FajtaId);
                        command.Parameters.AddWithValue("@nevid", rendeles.NevId);
                        command.Parameters.AddWithValue("@eletkor", rendeles.Eletkor);
                        command.Parameters.AddWithValue("@utolsoell", rendeles.UtolsoEll);

                        var sorok = command.ExecuteNonQuery();
                        MessageBox.Show($"Beszúrva:{sorok} sor.");
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

        public static void ModositRendelesiAdat(Rendeles rendeles)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string insertCommand = "update kutya set  fajtaid=@fajtaid,nevid=@nevid,eletkor=@eletkor,utolsoell=@utolsoell where Id=@Id";

                    using (SQLiteCommand command = new SQLiteCommand(insertCommand, connection))
                    {
                        command.Parameters.AddWithValue("@Id", rendeles.Id);
                        command.Parameters.AddWithValue("@fajtaid", rendeles.FajtaId);
                        command.Parameters.AddWithValue("@nevid", rendeles.NevId);
                        command.Parameters.AddWithValue("@eletkor", rendeles.Eletkor);
                        command.Parameters.AddWithValue("@utolsoell", rendeles.UtolsoEll);

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

        public static List<Kutyafajta> GetKutyafajtak()
        {
            List<Kutyafajta> kutyafajtak = new List<Kutyafajta>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string sqlCommand = "select * from kutyafajtak";

                    using (SQLiteCommand command = new SQLiteCommand(sqlCommand, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Kutyafajta kutyafajta = new Kutyafajta();

                                kutyafajta.Id = Convert.ToInt32(reader["Id"]);
                                kutyafajta.FajtaNev = reader["nev"].ToString();
                                kutyafajta.EredetiFajtaNev = reader["eredetinev"].ToString();

                                kutyafajtak.Add(kutyafajta);

                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return kutyafajtak;
        }
    }
}
