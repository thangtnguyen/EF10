using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF10_AWDBLibrary.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //schema existed prior to first migration.
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //Down method should likely never be run on an existing database for the first migration. The schema existed before, and history demands it is retained in the state it was before any migrations were applied.
        }
    }
}
