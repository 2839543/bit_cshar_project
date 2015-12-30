using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SQLite;

namespace bankInterestCalc
{
    class Interest_table
    {

        static readonly string DB_PATH = "Data Source = interest.db";

        public Interest_table()   //无参数构造函数
        {
            SQLiteConnection conn = null;
            conn = new SQLiteConnection(DB_PATH);//创建数据库实例，指定文件位置  
            conn.Open();//打开数据库，若文件不存在会自动创建  
        }


        public static void Select()
        {

            using (SQLiteConnection con = new SQLiteConnection(DB_PATH))
            {
                con.Open();
                string sqlStr = @"SELECT *
                                    FROM interest";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, con))
                {
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            Console.WriteLine(dr["hero_id"].ToString() + dr["hero_name"]);
                        }
                    }
                }
            }
        }



        public static double GetLixi(string date, string type, string cunqi)
        {

            double lixi = 0;

            using (SQLiteConnection con = new SQLiteConnection(DB_PATH))
            {
                con.Open();
                string sqlStr = @"SELECT *   FROM interest where date <  datetime('" + date + "','localtime') order by date desc limit 1 ; ";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, con))
                {
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            switch (type)
                            {
                                default:
                                    break;
                                case "huoqi":
                                    lixi = Convert.ToDouble(dr["hq"]);
                                    break;
                                case "zczq":
                                    lixi = Convert.ToDouble(dr["zczq_" + cunqi]);
                                    break;
                                case "linghuo":
                                    try
                                    {
                                        lixi = Convert.ToDouble(dr[cunqi]);
                                    }
                                    catch { }
                                    break;
                            }

                        }
                    }
                }
            }
            return lixi;
        }

        public static String GetPercent()
        {
            string rPercent = String.Empty;

            string _currentTime = DateTime.Now.ToString("HHmm");

            using (SQLiteConnection con = new SQLiteConnection(DB_PATH))
            {
                con.Open();
                string sqlStr = @"SELECT *
                                    FROM battery where showtime > " + _currentTime + " order by showtime  limit 1;";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, con))
                {
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["showtime"].ToString() + dr["percent"]);
                            rPercent = dr["percent"].ToString();
                        }
                    }
                }

                return rPercent;
            }
        }


        public static void Insert(int showtime, int percent)
        {
            using (SQLiteConnection con = new SQLiteConnection(DB_PATH))
            {
                con.Open();
                string sqlStr = @"INSERT INTO battery
                                  VALUES
                                  (
                                      " + showtime + "," + percent +
                                  ")";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update()
        {
            using (SQLiteConnection con = new SQLiteConnection(DB_PATH))
            {
                con.Open();
                string sqlStr = @"UPDATE battery
                                     SET showtime = '盗贼'
                                   WHERE percent = 1";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete()
        {
            using (SQLiteConnection con = new SQLiteConnection(DB_PATH))
            {
                con.Open();
                string sqlStr = @"DELETE FROM battery";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteAll()
        {
            using (SQLiteConnection con = new SQLiteConnection(DB_PATH))
            {
                con.Open();
                string sqlStr = @"DELETE FROM battery";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
