
using FluentMigrator;

namespace Requirements.Data.Migrations
{
    [Migration(1)]
    public class AddTableAddress : Migration
    {
        public override void Up()
        {
            Create.Table("address")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("address_line_two").AsString()
                .WithColumn("type").AsString()
                .WithColumn("state").AsString()
                .WithColumn("city").AsString()
                .WithColumn("neighborhood").AsString()
                .WithColumn("zip_code").AsString();
        }

        public override void Down()
        {
            Delete.Table("address");
        }
    }
}
