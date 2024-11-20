using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=HAMZA;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi!");

            #endregion

                #region Ürün Ekleme İşlemi

            string ProductName;
            decimal ProductPrice;
            string ProductStatus;
            //bool productStatus;

            Console.Write("Ürün adı: ");
            ProductName =Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            ProductPrice = decimal.Parse(Console.ReadLine());

           
                SqlConnection connection = new SqlConnection("Data Source=HAMZA;initial catalog=EgitimKampiDb;integrated security=true");
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) VALUES (@ProductName, @ProductPrice, @ProductStatus)", connection);
                command.Parameters.AddWithValue("@ProductName", ProductName);
                command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                command.Parameters.AddWithValue("@ProductStatus", true);
                Console.Write("Ürün eklemesi başarılı!");
                command.ExecuteNonQuery();
                connection.Close();
         
            #endregion 


            Console.Read();

        }
    }

}
            