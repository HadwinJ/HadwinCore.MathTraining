using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MathTraining.Web.Data.Migrations
{
    public partial class ArticleAnnotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FileNameOfView",
                table: "Articles",
                maxLength: 50,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "EnglishTitle",
                table: "Articles",
                maxLength: 50,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "ChineseTitle",
                table: "Articles",
                maxLength: 50,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "BriefIntroduction",
                table: "Articles",
                maxLength: 256,
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FileNameOfView",
                table: "Articles",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EnglishTitle",
                table: "Articles",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ChineseTitle",
                table: "Articles",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BriefIntroduction",
                table: "Articles",
                nullable: true);
        }
    }
}
