# CloneObject
How to clone objects in C# easily .. been using it for years, works on complex objects as well

Also shows how to clone objects having different names with annotations.

Here is a video explaining it in 1 minute https://youtu.be/FdHZCB707Uo

Newtonsoft is awesome ... here is how I copy objects when necessary

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


//profile object instance
[
    {
        "FullName": "Jonathan Smith",
        "Location": "New York",
        "Qualification": "Awesome at anything!",
        "Age": 21,
        "SomeIrrelevantProperty": "No used in ProfileDTO",
        "ProfileAddrress": {
            "HouseApartmentNumber": "12",
            "StreetName": "Main Street",
            "CityName": "San Diego",
            "PostalCode": "12111"
        }
    }
]

//profileDTO object instance, notice the irrelevant field is dropped 
[
    {
        "FullName": "Jonathan Smith",
        "Location": "New York",
        "Qualification": "Awesome at anything!",
        "Age": 21,
        "ProfileAddrress": {
            "HouseApartmentNumber": "12",
            "StreetName": "Main Street",
            "CityName": "San Diego",
            "PostalCode": "12111"
        }
    }
]

//profileCopy object instance
[
    {
        "FullName": "Jonathan Smith",
        "Location": "New York",
        "Qualification": "Awesome at anything!",
        "Age": 21,
        "SomeIrrelevantProperty": "No used in ProfileDTO",
        "ProfileAddrress": {
            "HouseApartmentNumber": "12",
            "StreetName": "Main Street",
            "CityName": "San Diego",
            "PostalCode": "12111"
        }
    }
]
