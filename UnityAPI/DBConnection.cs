using System;
using System.IO;
using SQLite;
using UnityAPI.Models;

namespace UnityAPI
{
    public class DbConnection
    {
        public static DbConnection Instance;

        private const string Dbname = "Library.db3";
        public readonly SQLiteConnection Connection;

        public DbConnection()
        {
            Instance = this;
            if (Connection != null) return;
            Connection =
                new SQLiteConnection(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Dbname));

            Connection.CreateTable<AgeGroups>();
            Connection.CreateTable<Answers>();
            Connection.CreateTable<AnswerTypes>();
            Connection.CreateTable<Books>();
            Connection.CreateTable<Categories>();
            Connection.CreateTable<Grades>();
            Connection.CreateTable<Guardians>();
            Connection.CreateTable<QuestionAgeGroups>();
            Connection.CreateTable<QuestionCategories>();
            Connection.CreateTable<Questions>();
            Connection.CreateTable<QuestionTags>();
            Connection.CreateTable<QuestionTypes>();
            Connection.CreateTable<Students>();
            Connection.CreateTable<Tags>();
            Connection.CreateTable<Teachers>();
            Connection.CreateTable<Types>();
            //Connection.CreateTable<Users>();
        }
    }
}