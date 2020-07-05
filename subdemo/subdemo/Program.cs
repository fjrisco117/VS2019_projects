using System;
using Recurly;
using Recurly.Resources;

namespace subdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Recurly.Client("e9922993342845dbbc583c145b2ab811");

            try
            {
                var accountReq = new AccountCreate()
                {
                    Code = "76a5f681-5754-4760-932d-ba6d17b50147",
                    FirstName = "Frodo",
                    LastName = "Baggins",
                    Company = "76a5f681-5754-4760-932d-ba6d17b50147",
                    Address = new Address()
                    {
                        City = "New Orleans",
                        Region = "LA",
                        Country = "US",
                        PostalCode = "70115",
                        Street1 = "900 Camp St."
                    }
                };
                Account account = client.CreateAccount(accountReq);
                Console.WriteLine($"Created account {account.Code}");
            }
            catch (Recurly.Errors.Validation ex)
            {
                // If the request was not valid, you may want to tell your user
                // why. You can find the invalid params and reasons in ex.Error.Params
                Console.WriteLine($"Failed validation: {ex.Error.Message}");
            }
            catch (Recurly.Errors.ApiError ex)
            {
                // Use ApiError to catch a generic error from the API
                Console.WriteLine($"Unexpected Recurly Error: {ex.Error.Message}");
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
