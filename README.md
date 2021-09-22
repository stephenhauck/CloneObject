# CloneObject
How to clone objects in C# easily .. been using it for years 

Newtonsoft is awesome ... here is how I copy objects when necessary

//profile object instance
{"FullName":"Jonathan Smith","Location":"New York","Qualification":"Awesome at anything!","Age":21,"SomeIrrelevantProperty":"No used in ProfileDTO"}

//profileDTO object instance, notice the irrelevant field is dropped 
{"FullName":"Jonathan Smith","Location":"New York","Qualification":"Awesome at anything!","Age":21}

//profileCopy object instance
{"FullName":"Jonathan Smith","Location":"New York","Qualification":"Awesome at anything!","Age":21,"SomeIrrelevantProperty":"No used in ProfileDTO"}
