using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;

namespace NoteTakingApp
{
    public partial class Form3 : MaterialForm
    {
        private Note currentNote;
        public Form3(Note n)
        {
            currentNote = n;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Yellow700, Primary.Yellow900,
                Primary.Orange500, Accent.DeepOrange700,
                TextShade.WHITE);
            LoadNote();
        }

        private void LoadNote()
        {
            materialLabel1.Text = currentNote.GetTitle();
            materialLabel2.Text = currentNote.GetText();
            byte[] image = currentNote.GetImage();
            if (image != null) // Verifică dacă imaginea există
            {
                using (MemoryStream ms = new MemoryStream(image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox1.Image = null; // Dacă nu există imagine, setează imaginea ca null
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}