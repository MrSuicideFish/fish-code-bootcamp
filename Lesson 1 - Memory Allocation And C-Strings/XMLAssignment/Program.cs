// When working with files, we work on an abstracted object
// that acts as a representation of the file on the disk

// In C#, the System.IO namespace allows us to talk to the disk

/*
 * Definitions
 * ------------
 * Disk - Your OS's hard drive
 * Application Path - The path to the executable (.exe)
 * Project Path - The path to the project (.csproj)
 * Serialize - Converting application data to file data
 * Deserialize - Converting file data to application data
 * Stream - A pipeline of data that can be used to read or write information to and from objects
 */

// Assignment
/*
 
Build a program that manages customers in a local XML Database
This database should be populated with premade data. Your program
Should support the following:
Loading the XML Data
Adding customers
Removing customers
Changing any contents like name/address/etc
Listing Customers
Searching for customer
Saving the data back to XML
*/

using System.Xml;
using System.Xml.Serialization;

public class Program
{
    public static void Main(string[] args)
    {
        XmlDocument doc = new XmlDocument();

        // Method 1
        XmlElement customerElement = doc.CreateElement("Customer");
        XmlElement customerName = doc.CreateElement("Name");
        XmlElement customerPhoneNumber = doc.CreateElement("PhoneNumber");
        XmlElement customerAddress = doc.CreateElement("Address");
        XmlElement customerEmailAddress = doc.CreateElement("EmailAddress");

        customerName.InnerText = "fijaiodjawd";
        customerPhoneNumber.InnerText = "1234567";
        customerAddress.InnerText = "fijaiodjawd";
        customerEmailAddress.InnerText = "fijaiodjawd";

        customerElement.AppendChild(customerName);
        customerElement.AppendChild(customerPhoneNumber);
        customerElement.AppendChild(customerAddress);
        customerElement.AppendChild(customerEmailAddress);

        doc.AppendChild(customerElement);

        Customer c = new Customer();
        c.Address = "dawd";
        c.Name = "dawd";
        c.EmailAddress = "dawd";
        c.PhoneNumber = "dawd";

        // method - serializing
        Customer newCustomer = new Customer();
        XmlSerializer serializer = new XmlSerializer(typeof(Customer));
        TextWriter writer = new StreamWriter("someFileName.xml");
        serializer.Serialize(writer, newCustomer);

        // method - deserializing
        string path = "SomeFileName.xml";
        TextReader reader = new StreamReader(path);
        XmlSerializer newSerializer = new XmlSerializer(typeof(Customer));
        Customer anotherCustomer = (Customer)newSerializer.Deserialize(reader);

        DateTime someTime = new DateTime();
        someTime = XmlConvert.ToDateTime("");

        // Assignment
        /*
         *  Build a program that manages customers in a local XML Database
         *  This database should be populated with premade data. Your program
         *  Should support the following:
         *  
         *      Loading the XML Data
         *      Adding customers
         *      Removing customers
         *      Changing any contents like name/address/etc
         *      Listing Customers
         *      Searching for customer
         *      Saving the data back to XML
         */
    }

    public static CustomerDatabase database;

    public static void AddCustomer()
    {
        string name = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string address = Console.ReadLine();
        string email = Console.ReadLine();

        if(!database.AddCustomer(name, phoneNumber, address, email))
        {
            // re-do the add
        }
    }
}