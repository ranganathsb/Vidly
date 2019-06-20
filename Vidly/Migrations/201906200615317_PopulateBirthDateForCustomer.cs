namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthDateForCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate='1980-1-1' Where Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
