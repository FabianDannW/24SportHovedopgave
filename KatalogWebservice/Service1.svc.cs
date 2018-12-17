using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI;
using KatalogWebservice.Model;

namespace KatalogWebservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        private const string ConnectionString = "Insert ConnectionString here";

        public List<CatalogItem> GetAllCatalogItems()
        {
            const string selectAllCatalogItems = "select * from catalogItem order by itemId";
            using (SqlConnection databaseConnection = new SqlConnection(ConnectionString))
            {
                databaseConnection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectAllCatalogItems, databaseConnection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        List<CatalogItem> catalogList = new List<CatalogItem>();
                        while (reader.Read())
                        {
                            CatalogItem catalogItem = ReadCatalogItem(reader);
                            catalogList.Add(catalogItem);
                        }

                        return catalogList;
                    }
                }
            }
        }


        private static CatalogItem ReadCatalogItem(IDataRecord reader)
        {
            int itemId = reader.GetInt32(0);
            string itemName = reader.GetString(1);
            string imgPath = reader.IsDBNull(2) ? null : reader.GetString(2);
            string description = reader.IsDBNull(3) ? null : reader.GetString(3);
            double price = reader.GetDouble(4);

            CatalogItem catalogItem = new CatalogItem
            {
                ItemId = itemId,
                ItemName = itemName,
                ImgPath = imgPath,
                Description = description,
                Price = price
            };
            return catalogItem;
        }


        public CatalogItem AddCatalogItem(CatalogItem catalogItem)
        {
            const string insertCatalogItem =
                "insert into catalogItem (id, itemName, imgPath, description, price) values (@id, @itemName, @imgPath, @description, @price)";

            using (SqlConnection databaseConnection = new SqlConnection(ConnectionString))
            {
                databaseConnection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertCatalogItem, databaseConnection))
                {
                    insertCommand.Parameters.AddWithValue("@id", catalogItem.ItemId);
                    insertCommand.Parameters.AddWithValue("@itemName", catalogItem.ItemName);
                    insertCommand.Parameters.AddWithValue("@imgPath", catalogItem.ImgPath);
                    insertCommand.Parameters.AddWithValue("@description", catalogItem.Description);
                    insertCommand.Parameters.AddWithValue("@price", catalogItem.Price);

                    return catalogItem;

                }
            }
        }
    }
}