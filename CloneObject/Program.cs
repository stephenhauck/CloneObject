using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace CloneObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new object instance 
            var profile = new Profile()
            {
                FullName = "Jonathan Smith",
                Location = "New York",
                Qualification = "Awesome at anything!",
                Age = 21,
                SomeIrrelevantProperty = "No used in ProfileDTO",
                ProfileAddrress = new Addrress()
                {
                    HouseApartmentNumber = "12",
                    StreetName = "Main Street",
                    CityName = "San Diego",
                    PostalCode = "12111"
                }
            };

            // Copy it over to an instance of ProfileDTO
            var profileDTO = JsonConvert.DeserializeObject<ProfileDTO>(JsonConvert.SerializeObject(profile));

            // Copy it over to an instance of ProfileCopy
            var profileCopy = JsonConvert.DeserializeObject<ProfileCopy>(JsonConvert.SerializeObject(profile));

            Debug.WriteLine($"profile object = {JsonConvert.SerializeObject(profile)}");
            Debug.WriteLine($"profileDTO object = {JsonConvert.SerializeObject(profileDTO)}");
            Debug.WriteLine($"profileCopy object = {JsonConvert.SerializeObject(profileCopy)}");
            

        }
    }

    public class Profile
    {
        public string FullName { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }
        public int Age { get; set; }
        public string SomeIrrelevantProperty { get; set; }
        public Addrress ProfileAddrress { get; set; }
    }


    public class Addrress
    {
        public string HouseApartmentNumber { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
    }

    public class ProfileDTO
    {
        [JsonProperty("FullName")] //Will take the property named "FullName" when deserializing and put the data in this element
        public string FullName_NOMATCH { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }
        public int Age { get; set; }
        [JsonProperty("ProfileAddrress")] //Property mapping
        public Addrress ProfileAddrress_NOMATCH { get; set; }
    }

    public class ProfileCopy 
    {
        public string FullName { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }
        public int Age { get; set; }
        public string SomeIrrelevantProperty { get; set; }
        public Addrress ProfileAddrress { get; set; }
    }
}
