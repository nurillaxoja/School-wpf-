using System;
using System.Collections.Generic;
using School.dbModules;
using LiteDB;


namespace School.dbHelper
{
    class UsersHelper
    {

        public static IEnumerable<UsersModule> UsersCollections()
        {
            var users = new List<UsersModule>();
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<UsersModule>("Users");
                var result = collection.FindAll();
                users.AddRange(result);
            }
            return users;
        }
        public void userInsert(string valName, string valUserName, string valPassword, string valGender, DateTime valDateOfBrith, string valPhoto)
        {
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var collection = db.GetCollection<UsersModule>("Users");
                UsersModule usermod = new UsersModule();
                //collection.DeleteAll();
                collection.Insert(new UsersModule()
                { name = valName, userName = valUserName, password = valPassword, gender = valGender, dateOfBrith = valDateOfBrith, photo = valPhoto });

                Logger log = new Logger();
                string logerString = string.Format("New user was created with name -> {0} username -> {1} gender-> {2} date of Brith -> {3} photo name -> {4} ", valName, valUserName, valGender, valDateOfBrith, valPhoto);
                log.WriteSignup(logerString);
            }
        }

        public static UsersModule LogIn(string userVal)
        {
            var userToReturn = new List<UsersModule>();
            using (var db = new LiteDatabase(dbConnection.dbLocation))
            {
                var users = db.GetCollection<UsersModule>("Users");
                var result = users.FindAll();
                foreach (UsersModule user in result)
                {
                    userToReturn.Add(user);
                }
                return userToReturn.Find(x => x.userName == userVal);
            }
            //return null;
        }
        //string userName = "";
        //bool flag = false;

        //public string getLoginUsername(string value)
        //{
            
        //    if (flag == false)
        //    {
        //        userName = value;
        //        flag = true;
        //    }


        //    return userName;
        //}
    }
}