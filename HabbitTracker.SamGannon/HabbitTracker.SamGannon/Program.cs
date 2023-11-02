﻿using HabitTracker.SamGannon;
using Microsoft.Data.Sqlite;
using System.Globalization;

string connectionString = @"Data Source=habit-Tracker.db";
Helpers helper;

using (var connection = new SqliteConnection(connectionString))
{
    connection.Open();
    var tableCmd = connection.CreateCommand();

    tableCmd.CommandText = @"CREATE TABLE IF NOT EXISTS drinking_water (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Date TEXT,
            Quantity INTEGER)";

    tableCmd.ExecuteNonQuery();

    connection.Close();
}

Menu menu = new Menu();
menu.GetUserInput();
