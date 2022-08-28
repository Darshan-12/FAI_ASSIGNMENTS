using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_Assignment
{
    namespace Entities
    {
        class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Phone_number { get; set; }
        }
    }

    namespace Repository
    {
        using Entities;
        class CustomerRepo
        {
            public CustomerRepo(int size)
            {
                customers = new Customer[size];
            }
            private Customer[] customers = null;

            public void AddCustomer(Customer customer)
            {
                
                for (int i = 0; i < customers.Length; i++)
                {
                    if (customers[i] == null)
                    {
                        customers[i] = new Customer
                        {
                            CustomerId = customer.CustomerId,
                            Name = customer.Name,
                            Address = customer.Address,
                            Phone_number =customer.Phone_number,
                             
                        };
                        return;
                    }
                    else continue;
                }
                throw new Exception("Further details cannot be added");
            }

            public void UpdateCustomer(int id, Customer customer)
            {
                
                for (int i = 0; i < customers.Length; i++)
                {
                    if (customers[i] != null && customers[i].CustomerId == id)
                    {
                        customers[i] = new Customer
                        {
                            CustomerId = customer.CustomerId,
                            Name = customer.Name,
                            Address = customer.Address,
                            Phone_number = customer.Phone_number,
                           
                        };
                        return;
                    }
                    else continue;
                }
                throw new Exception("No customer details found");
            }

            public void DeleteCustomer(int id)
            {
               
                for (int i = 0; i < customers.Length; i++)
                {
                    
                    if (customers[i] != null && customers[i].CustomerId == id)
                    {
                       
                        customers[i] = null;
                        return;
                    }

                }
                throw new Exception("No customer details found " + id);
            }

            public Customer FindCustomerById(int id)
            {
                foreach (Customer customer in customers)
                {
                    if (customer.CustomerId == id)
                        return customer;
                }
                throw new Exception("No customer details found " + id);
            }


        }
    }

    namespace CustomerDetails
    {
        using Entities;
        /// <summary>
        /// Helper class to take inputs from the User based on the questions asked.
        /// </summary>
        class Util
        {
            public static string GetString(string question)
            {
                Console.WriteLine(question);
                return Console.ReadLine();
            }

            public static int GetNumber(string question)
            {
                return int.Parse(GetString(question));
            }
            public static short GetShortNumber(string question) => short.Parse(GetString(question));

            public static double GetDoubleNumber(string question) => double.Parse(GetString(question));
        }

        class Assignment11
        {
            private static Repository.CustomerRepo repo = null;
            const string menu = "----Customer detils management---------- \ncPress 1 for add 2 for delete 3 for update 4 for findby id"; 
            static void Main(string[] args)
            {
                int size = Util.GetNumber("Enter the no of Customers details to be added");
                repo = new Repository.CustomerRepo(size);
                var processing = true;
                do
                {
                    string choice = Util.GetString(menu);
                    processing = processMenu(choice);
                } while (processing);
            }

            private static bool processMenu(string choice)
            {
                switch (choice)
                {
                    case "1"://for adding
                        addCustomer();
                        break;
                    case "2"://for deleting
                        deleteCustomer();
                        break;
                    case "3"://for updating
                        updateCustomer();
                        break;
                    case "4"://finding by id
                        findCustomerById();
                        return true;
                    default:
                        return false;
                }
                return true;
            }

            private static void findCustomerById()
            {
                //take id from the user
                int id = Util.GetNumber("Enter the Id of the customer to find");
                //call the repo function
                var foundCustomer = repo.FindCustomerById(id);
                if (foundCustomer != null)
                {
                   
                    Console.WriteLine($"Customer name {foundCustomer.Name} Customer address {foundCustomer.Address} that costs {foundCustomer.Phone_number}");
                }
                else
                {
                    Console.WriteLine("No customer details found to display!!!!");
                }
            }
            

            private static void updateCustomer()
            {

                var cs = createCustomer();
                
                repo.UpdateCustomer(cs.CustomerId, cs);
               
                Console.WriteLine("customer detais updated successfully");
            }

            private static Customer createCustomer()
            {
                int id = Util.GetNumber("Enter the Id of the Customer ");
                string name = Util.GetString("Enter the name ");
                string address = Util.GetString("Enter the Address ");
                string phone = Util.GetString("Enter the Phone number ");

                Customer c = new Customer
                {
                    CustomerId = id,
                    Address = address,
                    Name = name,
                    Phone_number = phone,
                    
                };
                return c;
            }
            private static void deleteCustomer()
            {
                
                int id = Util.GetNumber("Enter the Id of the customer to delete");
       
                repo.DeleteCustomer(id);
            
                Console.WriteLine("Customer details  deleted Successfully");
            }

            private static void addCustomer()
            {
                
                Customer c = createCustomer();
                
                repo.AddCustomer(c);
               
                Console.WriteLine("Customer details added successfully");
            }
        }
    }
   
}
