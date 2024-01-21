using System;

class ShippingAddress
{
    // Properties
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }

    // Constructor
    public ShippingAddress(string street, string city, string state, string zipCode, string country)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
        Country = country;
    }

    // Display method
    public void DisplayAddress()
    {
        Console.WriteLine($"Street: {Street}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"State: {State}");
        Console.WriteLine($"Zip Code: {ZipCode}");
        Console.WriteLine($"Country: {Country}");
    }
}

class Program
{
    static void Main()
    {
        // Example usage
        ShippingAddress myAddress = new ShippingAddress("123 Main St", "Anytown", "CA", "12345", "USA");

        // Display the address
        Console.WriteLine("Shipping Address:");
        myAddress.DisplayAddress();
    }
}