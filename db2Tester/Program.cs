using System;
using IBM.Data.DB2.Core;
using Microsoft.Extensions.Options;

namespace db2Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TestContext())
            {
                db.Database.EnsureCreated();
                Console.WriteLine("EnsuredCreated");
                db.TestModels.Add(new TestModel() { NameStr = "test213edewdwea" });
                db.TestModels.Add(new TestModel() { NameStr = "test213edewdwea" });
                db.TestModels.Add(new TestModel() { NameStr = "test213edewdwea" });
                db.TestModels.Add(new TestModel() { NameStr = "test213edewdwea" });
                db.TestModels.Add(new TestModel() { NameStr = "test213edewdwea" });
                db.SaveChanges();
                foreach (var dbTestModel in db.TestModels)
                {
                    Console.WriteLine(dbTestModel.Id);
                }
            }
        }
    }
}
