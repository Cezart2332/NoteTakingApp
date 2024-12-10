using System.ComponentModel;

namespace NoteTakingApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.textbox1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.textarea1 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(133, 679);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(92, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Add Note";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // textbox1
            // 
            this.textbox1.AnimateReadOnly = false;
            this.textbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textbox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox1.Depth = 0;
            this.textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textbox1.HideSelection = true;
            this.textbox1.LeadingIcon = null;
            this.textbox1.Location = new System.Drawing.Point(43, 107);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.MaxLength = 32767;
            this.textbox1.MouseState = MaterialSkin.MouseState.OUT;
            this.textbox1.Name = "textbox1";
            this.textbox1.PasswordChar = '\0';
            this.textbox1.PrefixSuffixText = null;
            this.textbox1.ReadOnly = false;
            this.textbox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textbox1.SelectedText = "";
            this.textbox1.SelectionLength = 0;
            this.textbox1.SelectionStart = 0;
            this.textbox1.ShortcutsEnabled = true;
            this.textbox1.Size = new System.Drawing.Size(371, 48);
            this.textbox1.TabIndex = 1;
            this.textbox1.TabStop = false;
            this.textbox1.Text = "Title";
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox1.TrailingIcon = null;
            this.textbox1.UseSystemPasswordChar = false;
            // 
            // textarea1
            // 
            this.textarea1.AnimateReadOnly = false;
            this.textarea1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textarea1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textarea1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textarea1.Depth = 0;
            this.textarea1.HideSelection = true;
            this.textarea1.Location = new System.Drawing.Point(43, 202);
            this.textarea1.Margin = new System.Windows.Forms.Padding(4);
            this.textarea1.MaxLength = 32767;
            this.textarea1.MouseState = MaterialSkin.MouseState.OUT;
            this.textarea1.Name = "textarea1";
            this.textarea1.PasswordChar = '\0';
            this.textarea1.ReadOnly = false;
            this.textarea1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textarea1.SelectedText = "";
            this.textarea1.SelectionLength = 0;
            this.textarea1.SelectionStart = 0;
            this.textarea1.ShortcutsEnabled = true;
            this.textarea1.Size = new System.Drawing.Size(949, 466);
            this.textarea1.TabIndex = 2;
            this.textarea1.TabStop = false;
            this.textarea1.Text = "Text";
            this.textarea1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textarea1.UseSystemPasswordChar = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(389, 679);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(107, 36);
            this.materialButton2.TabIndex = 3;
            this.materialButton2.Text = "View Notes";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 775);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 293);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(640, 679);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(127, 36);
            this.materialButton3.TabIndex = 5;
            this.materialButton3.Text = "Upload Image";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 1079);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.textarea1);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.materialButton1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton3;

        private MaterialSkin.Controls.MaterialButton materialButton2;

        private MaterialSkin.Controls.MaterialMultiLineTextBox2 textarea1;
        private MaterialSkin.Controls.MaterialTextBox2 textbox1;

        private MaterialSkin.Controls.MaterialButton materialButton1;

        #endregion
    }
}