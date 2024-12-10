using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NoteTakingApp
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            NotesManager.LoadNotesFromDatabase();
            Form1 form1 = new Form1();
            Application.Run(form1);
            
        }
    }
}