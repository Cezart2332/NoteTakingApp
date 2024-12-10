using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Properties;

namespace NoteTakingApp
{
    public partial class Form2 : MaterialForm
    {
       
        public Form2()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Yellow700, Primary.Yellow900,
                Primary.Orange500, Accent.DeepOrange700,
                TextShade.WHITE);

            LoadNotes();
        }

        private void LoadNotes()
        {
            int yPosition = 120;
            foreach (Note n in NotesManager.GetNotes())
            {
                MaterialButton titleButton = new MaterialButton();
                titleButton.Text = n.GetTitle();
                titleButton.Location = new System.Drawing.Point(40, yPosition);
                titleButton.AutoSize = true;
                titleButton.Click += (sender, e) => OpenNote(n);
                this.Controls.Add(titleButton);
                
                yPosition += 50;
            }
        }

        private void OpenNote(Note n)
        {
            Form3 form3 = new Form3(n);
            form3.Show();
            this.Hide();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}