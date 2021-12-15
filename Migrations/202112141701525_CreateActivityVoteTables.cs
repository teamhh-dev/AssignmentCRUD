namespace AssignmentCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateActivityVoteTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Duration = c.String(),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ActivityID = c.Int(nullable: false),
                        VoterName = c.String(),
                        Radius = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Votes");
            DropTable("dbo.Activities");
        }
    }
}
