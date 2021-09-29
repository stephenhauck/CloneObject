# CloneObject
How to clone objects in C# easily .. been using it for years 

Newtonsoft is awesome ... here is how I copy objects when necessary

            //Create a new object instance 
            var profile = new Profile()
            {
                FullName = "Jonathan Smith",
                Location = "New York",
                Qualification = "Awesome at anything!",
                Age = 21,
                SomeIrrelevantProperty = "No used in ProfileDTO"
            };

            // Copy it over to an instance of ProfileDTO
            var profileDTO = JsonConvert.DeserializeObject<ProfileDTO>(JsonConvert.SerializeObject(profile));

            // Copy it over to an instance of ProfileCopy
            var profileCopy = JsonConvert.DeserializeObject<ProfileCopy>(JsonConvert.SerializeObject(profile));


//profile object instance
{"FullName":"Jonathan Smith","Location":"New York","Qualification":"Awesome at anything!","Age":21,"SomeIrrelevantProperty":"No used in ProfileDTO"}

//profileDTO object instance, notice the irrelevant field is dropped 
{"FullName":"Jonathan Smith","Location":"New York","Qualification":"Awesome at anything!","Age":21}

//profileCopy object instance
{"FullName":"Jonathan Smith","Location":"New York","Qualification":"Awesome at anything!","Age":21,"SomeIrrelevantProperty":"No used in ProfileDTO"}