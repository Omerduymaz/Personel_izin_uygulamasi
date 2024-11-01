using MySql.Data.MySqlClient;
using System.Data;

namespace Kantot.Class
{
    internal class DBOperation
    {
        #region Değişkenler ve Tanımlamalar
        static MySqlConnection KOConn = new MySqlConnection(DBConnection.DBConnecitonAddress);
        static MySqlDataAdapter KOAdp;
        public static MySqlCommand KOCmd = new MySqlCommand();
        #endregion

        #region Kullanıcı Tanımlı Olaylar
        public static DataTable veriGetir(string sorgu)
        {
            DataTable KOteriTablo = new DataTable();
            KOAdp = new MySqlDataAdapter(sorgu, KOConn);
            KOAdp.Fill(KOteriTablo);
            return KOteriTablo;
        }

        public static void KomutCalistir(string komut)
        {
            try
            {
                if (KOConn.State == ConnectionState.Closed)
                    KOConn.Open();
                KOCmd.CommandText = komut;
                KOCmd.Connection = KOConn;
                KOParameter.islemDurumu = KOCmd.ExecuteNonQuery();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (KOConn.State == ConnectionState.Open)
                    KOConn.Close();
            }
        }
        #endregion
    }
}
