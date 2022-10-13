using MongoDataAccess.DataAccess;
using MongoDataAccess.Models;
using MongoDB.Driver;
using MongoDBDemp;

//string connectionString = "mongodb://127.0.0.1:27017";
//string databaseName = "SimpleDb";
//string collectionName = "People";

//var client = new MongoClient(connectionString);
//var db = client.GetDatabase(databaseName);
//var collection = db.GetCollection<PersonModel>(collectionName);

//var person = new PersonModel()
//{
//    FirstName = "Haman",
//    LastName = "Shareghi"
//};

//await collection.InsertOneAsync(person);
//var results = await collection.FindAsync(_ => true);

//foreach (var item in results.ToList())
//{
//    Console.WriteLine($"{item.Id} : {item.FirstName} : {item.LastName}");
//}


ChoreDataAccess db = new ChoreDataAccess();
 
await db.CreateUser(new UserModel()
{
    FirstName = "Haman",
    LastName = "Shareghi"
});

var users = await db.GetAllUsers();

var chore = new ChoreModel()
{
    AssignedTo = users.First(),
    ChoreText = "Mom in Lawn",
    FrequencyInDays = 7
};
await db.CreateChore(chore);
