using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    // Import newly generated Web service proxy.
    using Customerse;
    using Vendorse;
    using Journalse;
    using System.Diagnostics;
    using System.Xml;
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BatchUploader());
        }
        public void sendCustomer(String path)
        {
            try
            {
                var service = new Customer_Service();
                service.UseDefaultCredentials = true;
                service.Credentials = System.Net.CredentialCache.DefaultCredentials;
                service.Url = "http://Kenedy:7047/DynamicsNAV90/WS/DUALA%20TRADERS%20LIMITED/Page/Customer";


                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
                var nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Customer");
                Customer[] custArray = new Customer[nodeList.Count];
                foreach (XmlNode node in nodeList)
                {
                    for (int i = 0; i < custArray.Length; i++)
                    {
                        custArray[i] = new Customer();

                        custArray[i].Address = node.SelectSingleNode("Address").InnerText;
                        custArray[i].Name = node.SelectSingleNode("Name").InnerText;
                        custArray[i].Address_2 = node.SelectSingleNode("Address_2").InnerText;
                        custArray[i].Phone_No = node.SelectSingleNode("Phone_No").InnerText;
                        custArray[i].E_Mail = node.SelectSingleNode("E_Mail").InnerText;
                        custArray[i].Customer_Posting_Group = node.SelectSingleNode("Customer_Posting_Group").InnerText;
                        custArray[i].Gen_Bus_Posting_Group = node.SelectSingleNode("Gen_Bus_Posting_Group").InnerText;
                        custArray[i].VAT_Bus_Posting_Group = node.SelectSingleNode("VAT_Bus_Posting_Group").InnerText;
                        Console.WriteLine(custArray[i].Name);
                        service.CreateMultiple(ref custArray);

                    }

                }

                MessageBox.Show(nodeList.Count + " " + "Customer(s) data successfully uploaded..!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        public void sendVendor(String path)
        {
            try
            {
                var service = new Vendor_Service();
                service.UseDefaultCredentials = true;
                service.Credentials = System.Net.CredentialCache.DefaultCredentials;
                service.Url = "http://kenedy:7047/DynamicsNAV90/WS/DUALA%20TRADERS%20LIMITED/Page/Vendor";

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
                var nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Vendor");
                Vendor[] vendArray = new Vendor[nodeList.Count];
                foreach (XmlNode node in nodeList)
                {
                    for (int i = 0; i < vendArray.Length; i++)
                    {
                        vendArray[i] = new Vendor();

                        vendArray[i].Address = node.SelectSingleNode("Address").InnerText;
                        vendArray[i].Name = node.SelectSingleNode("Name").InnerText;
                        vendArray[i].Address_2 = node.SelectSingleNode("Address_2").InnerText;
                        vendArray[i].Phone_No_2 = node.SelectSingleNode("Phone_No_2").InnerText;
                        vendArray[i].E_Mail = node.SelectSingleNode("E_Mail").InnerText;
                        vendArray[i].Vendor_Posting_Group = node.SelectSingleNode("Vendor_Posting_Group").InnerText;
                        vendArray[i].Gen_Bus_Posting_Group = node.SelectSingleNode("Gen_Bus_Posting_Group").InnerText;
                        vendArray[i].VAT_Bus_Posting_Group = node.SelectSingleNode("VAT_Bus_Posting_Group").InnerText;
                        Console.WriteLine(vendArray[i].Name);
                        service.CreateMultiple(ref vendArray);


                    }

                }
                MessageBox.Show(nodeList.Count + " " + "Vendor(s) data successfully uploaded..!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
                }
        }
        public void sendPayment(String path)
        {
            try
            {

                var service = new Journal_Service();
                service.UseDefaultCredentials = true;
                service.Credentials = System.Net.CredentialCache.DefaultCredentials;
                service.Url = "http://kenedy:7047/DynamicsNAV90/WS/DUALA%20TRADERS%20LIMITED/Page/Journal";

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);



                var nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Payment");


                Journal[] journArray = new Journal[nodeList.Count];
               // Journal journ = new Journal();
                foreach (XmlNode node in nodeList)
                {
                    for (int i = 0; i < journArray.Length; i++)
                    {
                        journArray[i] = new Journal();
                        journArray[i].Journal_Template_Name = "GENERAL";
                        journArray[i].Line_No = Convert.ToInt32(node.SelectSingleNode("Line_No").InnerText);
                        journArray[i].Line_NoSpecified = true;
                        journArray[i].Document_No = node.SelectSingleNode("Document_No").InnerText;
                        journArray[i].Posting_Date = Convert.ToDateTime(node.SelectSingleNode("Posting_Date").InnerText);
                        journArray[i].Posting_DateSpecified = true;
                        journArray[i].Account_No = node.SelectSingleNode("Account_No").InnerText;
                        journArray[i].Description = node.SelectSingleNode("Description").InnerText;
                        journArray[i].Amount = Convert.ToDecimal(node.SelectSingleNode("Amount").InnerText);
                        journArray[i].AmountSpecified = true;
                        journArray[i].Bal_Account_No = node.SelectSingleNode("Bal_Account_No").InnerText;
                        Console.WriteLine(journArray[i].Posting_Date);
                        if (node.SelectSingleNode("Account_Type").InnerText.Equals("Customer"))
                        {
                            if (node.SelectSingleNode("Document_Type").InnerText.Equals("Payment"))
                            {
                                                              
                                journArray[i].Journal_Batch_Name = "PAYMENTS";
                                journArray[i].Account_Type = Account_Type.Customer;
                                journArray[i].Account_TypeSpecified = true;
                                journArray[i].Document_Type = Document_Type.Payment;
                                journArray[i].Document_TypeSpecified = true;
                                journArray[i].Bal_Account_Type = Bal_Account_Type.Bank_Account;
                                journArray[i].Bal_Account_TypeSpecified = true;
                                Console.WriteLine(journArray[i].Account_Type);
                            }
                            else if (node.SelectSingleNode("Document_Type").InnerText.Equals("Invoice"))
                            {
                                journArray[i].Journal_Batch_Name = "INVOICES";
                                journArray[i].Account_Type = Account_Type.Customer;
                                journArray[i].Account_TypeSpecified = true;
                                journArray[i].Document_Type = Document_Type.Invoice;
                                journArray[i].Document_TypeSpecified = true;
                                journArray[i].Bal_Account_Type = Bal_Account_Type.G_L_Account;
                                journArray[i].Bal_Account_TypeSpecified = true;
                            }
                        }
                        else if (node.SelectSingleNode("Account_Type").InnerText.Equals("Vendor"))
                        {
                            journArray[i].Journal_Batch_Name = "MEMPAYMENT";
                            journArray[i].Account_Type = Account_Type.Vendor;
                            journArray[i].Account_TypeSpecified = true;
                            journArray[i].Document_Type = Document_Type.Payment;
                            journArray[i].Document_TypeSpecified = true;
                            journArray[i].Bal_Account_Type = Bal_Account_Type.Bank_Account;
                            journArray[i].Bal_Account_TypeSpecified = true;
                        }
                        Console.WriteLine(journArray[i].Account_Type);
                        service.CreateMultiple(ref journArray);


                    }

                }
                MessageBox.Show(nodeList.Count + " " + "Payment(s) data successfully uploaded..!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
            }
        }
        
    }
}
