using System;
using System.Data;
using System.Data.SQLite;

namespace HalProject.Classes
{
    class DatabaseAccess
    {
        #region Database Update Strings
        private static readonly string CreateOrdersTableString =
            @"CREATE TABLE IF NOT EXISTS Orders ( " +
            "Order_Number INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " +
            "Recipient TEXT NOT NULL, " +
            "Price NUMERIC DEFAULT 0.00, " +
            "Print_ETA INTEGER DEFAULT 0, " +
            "Printer TEXT NOT NULL, " +
            "Status_Code INTEGER NOT NULL DEFAULT 2);";

        private static readonly string CreateItemsTableString =
            @"CREATE TABLE IF NOT EXISTS Items (" +
            "Item_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + 
            "Order_Number INTEGER NOT NULL, " + 
            "Item_Name TEXT NOT NULL, " + 
            "Item_URL TEXT, " + 
            "Item_Quantity INTEGER NOT NULL DEFAULT 1);";
        #endregion

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection("Data Source=database.sqlite;Version=3;");
        }

        public static void InitializeDatabase()
        {
            using (SQLiteConnection con = GetConnection())
            {
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = CreateOrdersTableString;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = CreateItemsTableString;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #region Database Query Methods
        public static DataTable SelectAllOrders()
        {
            using (SQLiteConnection con = GetConnection())
            {
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM Orders";
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        return dt;
                    }
                }
            }
        }

        public static DataTable SelectAllItemsInOrder(int i)
        {
            using (SQLiteConnection con = GetConnection())
            {
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Items NATURAL JOIN Orders WHERE Order_Number == @id";

                    SQLiteParameter param = cmd.CreateParameter();
                    cmd.Parameters.AddWithValue("@id", i);

                    using (SQLiteDataReader dr = cmd.ExecuteReader()) { 
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        return dt;
                    }
                }
            }
        }

        public static int SelectOrdersAutoincrementValue()
        {
            using (SQLiteConnection con = GetConnection())
            {
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM sqlite_sequence WHERE name == 'Orders'";
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        foreach (DataRow row in dt.Rows)
                            return Convert.ToInt32(row["seq"]);
                    }
                    return -1;
                }
            }
        }
        #endregion

        #region Database Update Methods
        public static void InsertOrder(Order order)
        {
            using (SQLiteConnection con = GetConnection())
            {
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Orders VALUES (NULL, @recipient, @price, @eta, @printer, 2)";
                    // The "2" is already a constraint in the database anyway.

                    // cmd.Parameters.AddWithValue("@orderid", order.OrderNumber);
                    cmd.Parameters.AddWithValue("@recipient", order.Recipient);
                    cmd.Parameters.AddWithValue("@price", order.Price);
                    cmd.Parameters.AddWithValue("@eta", order.PrintETA);
                    cmd.Parameters.AddWithValue("@printer", order.Printer);

                    cmd.ExecuteNonQuery();
                    int orderNumber = SelectOrdersAutoincrementValue();

                    InsertItems(orderNumber, order.ItemsList.ToArray());
                }
            }
        }

        public static void InsertItems(int orderNumber, params Item[] items)
        {
            using (SQLiteConnection con = GetConnection())
            {
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    foreach (Item i in items) {
                        cmd.CommandText = "INSERT INTO Items VALUES (NULL, @orderid, @name, @url, @qty)";
                        
                        cmd.Parameters.AddWithValue("@orderid", orderNumber);
                        cmd.Parameters.AddWithValue("@name", i.Name);
                        cmd.Parameters.AddWithValue("@url", i.Url);
                        cmd.Parameters.AddWithValue("@qty", i.Quantity);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void DeleteItems(int orderNumber)
        {
            using (SQLiteConnection con = GetConnection())
            {
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Orders WHERE Order_Number == @orderid";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

    }
}
