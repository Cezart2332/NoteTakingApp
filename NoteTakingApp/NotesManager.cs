using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace NoteTakingApp
{
    public static class NotesManager
    {
        private static List<Note> allNotes = new List<Note>();

        public static void AddNotes(Note note)
        {
            allNotes.Add(note);
        }

        public static void PrintNotes()
        {
            foreach (Note n in allNotes)
            {
                Console.WriteLine(n.GetTitle());
                Console.WriteLine(n.GetText());
            }
        }

        public static List<Note> GetNotes()
        {
            return allNotes;
        }

        public static void LoadNotesFromDatabase()
        {
            MySqlConnection con = Connection.DataSource();
            con.Open();
            string query = "SELECT title,text,image FROM note;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string title = reader.GetString("title");
                    string text = reader.GetString("text");
                    byte[] image = reader["image"] != DBNull.Value ? (byte[])reader["image"] : null;
                    
                    allNotes.Add(new Note(title,text,image));
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}