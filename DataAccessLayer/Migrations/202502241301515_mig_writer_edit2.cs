﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writer_edit2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 200));
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 2000));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 2000));
        }
    }
}
