using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System.IO;

namespace NoteTakingApp
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Yellow700, Primary.Yellow900,
                Primary.Orange500, Accent.DeepOrange700,
                TextShade.WHITE);
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] image = null;
                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                    image = ms.ToArray();
                }
                Note note = new Note(textbox1.Text, textarea1.Text,image);
                NotesManager.AddNotes(note);
                string query = $"INSERT INTO note(title,text,image) values(@title, @text, @image);";
                MySqlConnection con = Connection.DataSource();
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@title", textbox1.Text);
                cmd.Parameters.AddWithValue("@text", textarea1.Text);
                cmd.Parameters.AddWithValue("@image", image ?? (object)DBNull.Value);
                int l = cmd.ExecuteNonQuery();
                textbox1.Text = "";
                textarea1.Text = "";
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files | *.jpg; *.jpeg; *.png; *.bmp";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(dialog.FileName);
                }
            }
            catch (Exception exception)
            
            {
                Console.WriteLine(exception);
            }
        }
        
    }
}