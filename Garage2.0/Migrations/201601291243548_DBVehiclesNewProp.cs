namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBVehiclesNewProp : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vehicles", "Member_MemberId", "dbo.Members");
            DropIndex("dbo.Vehicles", new[] { "Member_MemberId" });
            RenameColumn(table: "dbo.Vehicles", name: "Member_MemberId", newName: "MemberId");
            AlterColumn("dbo.Vehicles", "MemberId", c => c.Int(nullable: false));
            CreateIndex("dbo.Vehicles", "MemberId");
            AddForeignKey("dbo.Vehicles", "MemberId", "dbo.Members", "MemberId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "MemberId", "dbo.Members");
            DropIndex("dbo.Vehicles", new[] { "MemberId" });
            AlterColumn("dbo.Vehicles", "MemberId", c => c.Int());
            RenameColumn(table: "dbo.Vehicles", name: "MemberId", newName: "Member_MemberId");
            CreateIndex("dbo.Vehicles", "Member_MemberId");
            AddForeignKey("dbo.Vehicles", "Member_MemberId", "dbo.Members", "MemberId");
        }
    }
}
