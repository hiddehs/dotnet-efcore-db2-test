using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IBM.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace db2Tester
{
  public class TestContext : DbContext
  {
    public TestContext()
    {

    }
    public TestContext(DbContextOptions<TestContext> options) : base(options)
    {
    }
    private const string connectionString = "server=localhost:50000;uid=db2inst1;pwd=testdbpassword;database=testdb";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseDb2(connectionString, x => x.SetServerInfo(IBMDBServerType.LUW));
      // optionsBuilder.UseDb2(connectionString);
    }


    public virtual DbSet<TestModel> TestModels { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<TestModel>().ToTable("TestModel");
        // .Property(e=>e.ID).ValueGeneratedOnAdd();
      // base.OnModelCreating(modelBuilder);
    }
  }

  public partial class TestModel
  {
    public int Id { get; set; }
    public string NameStr { get; set; }
  }
}
