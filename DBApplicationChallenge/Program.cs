using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DBApplicationChallenge
{
    /*
     Project Name: Database Application Challenge.
     Company: DHD Soultions inc.
     Postion: Application Developer -& Support Specialist.
     Candidate: Anita Elisha.
     Date: November 1st, 2023.
     Purpose: Testing Material.     
     */
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbapplicationchallenge;Integrated Security=True";
            string path = @"C:\Developer Practical Test\PO_DATA";

            string tblName = @"purchaseItem";
            string tableExist = @"IF EXISTS(
                SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
                WHERE TABLE_NAME = @purchaseItem) 
                SELECT 1 ELSE SELECT 0";

            Console.WriteLine("Welcome to Database Application Challenge.");
            Console.WriteLine("Part-2: Database Loder.\n");
            Console.WriteLine("Please press L or l for loading series of XML Files.");
            string load = Console.ReadLine();
          
      
            if (load == "l" || load == "L" )
            {
                try
                {
                    // Connect to the SQL database
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        using (SqlCommand command = new SqlCommand(tableExist, connection))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(tableExist, connection);

                            cmd.Parameters.Add("@purchaseItem", SqlDbType.NVarChar).Value = tblName;
                            int exists = (int)cmd.ExecuteScalar();
                            if (exists == 1)
                            {
                                //Table exists. IF NOT EXISTS(SELECT projectNumber FROM ProjectRecord WHERE projectNumber = '1032')
                                foreach (string file in Directory.EnumerateFiles(path))
                                {
                                    if (File.Exists(file))
                                    {
                                        //Console.WriteLine($"{file}");
                                        // Create a new SQL table


                                        // Insert the XML data into the SQL table

                                        string xmlFileName = Path.GetFileName(file);
                                        string[] poNumber = xmlFileName.Split('.');
                                        //Console.WriteLine(poNumber[0]);
                                        string xmlFilePath = file;

                                        // Load the XML file
                                        XmlDocument doc = new XmlDocument();
                                        doc.Load(xmlFilePath);

                                        // Get the root element
                                        XmlNode root = doc.DocumentElement;

                                        foreach (XmlNode node in root.ChildNodes)
                                        {
                                            string PONumber = poNumber[0];
                                            string partNumber = node.SelectSingleNode("partNumber").InnerText;
                                            double quantity = double.Parse(node.SelectSingleNode("quantity").InnerText);
                                            double costPer = double.Parse(node.SelectSingleNode("costPer").InnerText);
                                            string user = node.SelectSingleNode("purchaser").InnerText;
                                            string project = node.SelectSingleNode("project").InnerText;
                                            string insertQuery = string.Format($"IF NOT EXISTS(SELECT * FROM purchaseItem WHERE partNumber='{partNumber}' AND quantity={quantity} AND costPer={costPer} AND purchaser='{user}' AND project='{project}') " +
                                                "INSERT INTO purchaseItem (partNumber, quantity ,costPer,purchaser,project) VALUES ('{0}','{1}','{2}','{3}','{4}')", partNumber, quantity, costPer, user, project);
                                            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                            insertCommand.ExecuteNonQuery();

                                            string insertPRQuery = string.Format($"IF NOT EXISTS(SELECT * FROM  PurchaseRecord WHERE PONumber='{PONumber}' AND partNumber='{partNumber}' AND quantity={quantity} AND costPer={costPer} AND purchaser='{user}' AND projet='{project}') " +
                                                "INSERT INTO PurchaseRecord (PONumber,partNumber, quantity ,costPer,purchaser,projet) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}')", PONumber, partNumber, quantity, costPer, user, project);
                                            SqlCommand insertPRCommand = new SqlCommand(insertPRQuery, connection);
                                            insertPRCommand.ExecuteNonQuery();
                                        }


                                    }
                                }
                                Console.WriteLine("XML Files data load to SQL Server Database table completed.");

                            }
                            else
                            {
                                // Table doesn't exists.
                                //Create a new SQL table 'purchaseItem'
                                string createTableQuery = "CREATE TABLE purchaseItem (partNumber VARCHAR(60),quantity FLOAT,costPer FLOAT,  purchaser VARCHAR(60), project VARCHAR(50))";
                                SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);

                                createTableCommand.ExecuteNonQuery();
                                foreach (string file in Directory.EnumerateFiles(path))
                                {
                                    if (File.Exists(file))
                                    {
                                      

                                        // Insert the XML data into the SQL table
                                     
                                          string xmlFileName = Path.GetFileName(file);
                                          string[] poNumber = xmlFileName.Split('.');
                                           
                                            string xmlFilePath = file;

                                            // Load the XML file
                                            XmlDocument doc = new XmlDocument();
                                            doc.Load(xmlFilePath);

                                            // Get the root element
                                            XmlNode root = doc.DocumentElement;

                                            foreach (XmlNode node in root.ChildNodes)
                                            {
                                                string PONumber = poNumber[0];
                                                string partNumber = node.SelectSingleNode("partNumber").InnerText;
                                                double quantity = double.Parse(node.SelectSingleNode("quantity").InnerText);
                                                double costPer = double.Parse(node.SelectSingleNode("costPer").InnerText);
                                                string user = node.SelectSingleNode("purchaser").InnerText;
                                                string project = node.SelectSingleNode("project").InnerText;
                                                string insertQuery = string.Format("INSERT INTO purchaseItem (partNumber, quantity ,costPer,purchaser,project) VALUES ('{0}', '{1}','{2}','{3}','{4}')",  partNumber, quantity, costPer, user, project);
                                                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                                                insertCommand.ExecuteNonQuery();
                                                
                                                string insertPRQuery = string.Format("INSERT INTO PurchaseRecord (PONumber,partNumber, quantity ,costPer,purchaser,projet) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}')", PONumber, partNumber, quantity, costPer, user, project);
                                                SqlCommand insertPRCommand = new SqlCommand(insertPRQuery, connection);
                                                insertPRCommand.ExecuteNonQuery();
                                        }


                                    }
                                }
                                Console.WriteLine("XML Files data load to SQL Server Database table completed.");
                            }
                            connection.Close();
                        }

                       
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

             
            }
            else
            {
                Console.WriteLine("Key value press wrong! Please press L or l for loading series of XML files once more");
                load = Console.ReadLine();
            }

            Console.WriteLine("\nPart-3: Reporting pages.\n");

        
            bool stop = false;
            Console.WriteLine("Please enter project name for generate a report: ");
            string serachPN = Console.ReadLine();
            while (!stop)
            {


                DataContext db = new DataContext(connectionString);
                var query =
                    (from purchaseRecode in db.GetTable<PurchaseRecord>()
                     join mat in db.GetTable<MaterialMaster>() on purchaseRecode.partNumber equals mat.PartNumber
                     join user in db.GetTable<User>() on purchaseRecode.purchaser equals user.userName
                     join projectRecord in db.GetTable<ProjectRecord>() on purchaseRecode.projet equals projectRecord.projectNumber
                     where purchaseRecode.projet == serachPN
                     orderby purchaseRecode.purchaser
                     select new
                     {
                         purchaseRecode.purchaser,
                         mat.Description,
                         purchaseRecode.PONumber,
                         purchaseRecode.partNumber,
                         purchaseRecode.costPer,
                         purchaseRecode.quantity,
                         purchaseRecode.projet

                     }).ToList();

                var table = new ConsoleTable("User", "#Purchase Order", "Part Number", "Description", "Total Price");
                var projectTitle = query.Select(pd => pd.projet).DefaultIfEmpty("NOResult").First();
                if (projectTitle != "NOResult")
                    Console.WriteLine($"Project Title: {projectTitle} ");
                foreach (var item in query)
                {
                    table.AddRow(item.purchaser, item.PONumber, item.partNumber, item.Description, item.costPer * item.quantity);

                }
                table.Write();
                Console.WriteLine();
                double totalprice = query.Sum(p => p.costPer * p.quantity);
                Console.WriteLine($"Total Price For Project {serachPN} = " + totalprice.ToString("C2"));


                if (serachPN == "Q" || serachPN == "q")
                {
                    stop = true;
                    Environment.Exit(0);

                }

                else
                {

                    DataContext db1 = new DataContext(connectionString);
                    var query1 =
                        (from purchaseRecode in db1.GetTable<PurchaseRecord>()
                         join mat in db1.GetTable<MaterialMaster>() on purchaseRecode.partNumber equals mat.PartNumber
                         join user in db1.GetTable<User>() on purchaseRecode.purchaser equals user.userName
                         join projectRecord in db1.GetTable<ProjectRecord>() on purchaseRecode.projet equals projectRecord.projectNumber
                         where purchaseRecode.projet == serachPN
                         orderby purchaseRecode.purchaser
                         select new
                         {
                             purchaseRecode.purchaser,
                             mat.Description,
                             purchaseRecode.PONumber,
                             purchaseRecode.partNumber,
                             purchaseRecode.costPer,
                             purchaseRecode.quantity,
                             purchaseRecode.projet

                         }).ToList();

                    var table1 = new ConsoleTable("User", "#Purchase Order", "Part Number", "Description", "Total Price");

                    string title = query1.Select(pd => pd.projet).DefaultIfEmpty("NOResult").First();
                    if (title != "NOResult")
                    Console.WriteLine($"Project Title: {title} ");
                   
                    foreach (var item in query)
                    {
                        table.AddRow(item.purchaser, item.PONumber, item.partNumber, item.Description, item.costPer * item.quantity);

                    }
                    table.Write();
                    Console.WriteLine();
                    double totalprice1 = query.Sum(p => p.costPer * p.quantity);
                    Console.WriteLine($"Total Price For Project {serachPN} = " + totalprice1.ToString("C2"));
                    Console.WriteLine("\nPlease enter project name for generate a report or press Q to quit: ");
                    serachPN = Console.ReadLine();
                  

                  
                }
            }
            



            Console.ReadKey();
        }
    }
}
