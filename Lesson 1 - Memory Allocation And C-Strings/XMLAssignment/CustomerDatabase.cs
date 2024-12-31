using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CustomerDatabase
{
    public List<Customer> customerDatabase;

    public bool AddCustomer(string name, 
                            string email,
                            string address,
                            string phoneNumber)
    {
        //validation
        if(string.IsNullOrEmpty(name)
        || string.IsNullOrEmpty(address)
        || string.IsNullOrEmpty(phoneNumber))
        {
            return false;
        }

        Customer newCustomer = new Customer();
        newCustomer.Name = name;
        newCustomer.Address = address;

        customerDatabase.Add(newCustomer);
        return true;
    }

    public bool RemoveCustomer(string name)
    {
        for (int i = 0; i < customerDatabase.Count; i++)
        {
            if (customerDatabase[i].Name == name)
            {
                // found a customer
                customerDatabase.RemoveAt(i);
                return true;
            }
        }

        return false;
    }
}
