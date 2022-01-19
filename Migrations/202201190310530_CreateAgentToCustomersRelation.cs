namespace AssignmentCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAgentToCustomersRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "AgentId", c => c.Int());
            CreateIndex("dbo.Customers", "AgentId");
            AddForeignKey("dbo.Customers", "AgentId", "dbo.Agents", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "AgentId", "dbo.Agents");
            DropIndex("dbo.Customers", new[] { "AgentId" });
            DropColumn("dbo.Customers", "AgentId");
        }
    }
}
