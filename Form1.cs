using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Height_Map_Generator
{
    public partial class Form1 : Form
    {

        Bitmap res;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath.Text) || string.IsNullOrWhiteSpace(filePath.Text))
            {
                GenerateImage.Hide();
            }
            else
            {
                GenerateImage.Show();
            }
        }


        private void BrowseClicked(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Png file|*.png|Jpg file|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = ofd.FileName;

                InputPicture.Image = new Bitmap(filePath.Text);
            }
        }

        private void GenerateImage_Click(object sender, EventArgs e)
        {
            Bitmap original = new Bitmap(filePath.Text);
            Bitmap result = new Bitmap(InputPicture.Image.Width, InputPicture.Image.Height);

            
            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {

                    float value = 0;

                    int divider = 0;
                    if (RedChannel.Checked)
                    {
                        value += original.GetPixel(x, y).R;
                        divider++;
                    }
                    if (GreenChannel.Checked)
                    {
                        value += original.GetPixel(x, y).G;
                        divider++;
                    }
                    if (BlueChannel.Checked)
                    {
                        value += original.GetPixel(x, y).B;
                        divider++;
                    }

                    if (divider == 0)
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                        return;
                    }

                    if (!InverseChannels.Checked)
                    {
                        Color pixelColor = Color.FromArgb(255 - ((int)value / divider), 255 - ((int)value / divider), 255 - ((int)value / divider));
                        result.SetPixel(x, y, pixelColor);
                    }
                    else
                    {
                        Color pixelColor = Color.FromArgb((int)value / divider, (int)value / divider, (int)value / divider);
                        result.SetPixel(x, y, pixelColor);
                    }
                }
            }

            OutputPicture.Image = result;
            res = result;
        }
        private void OutputPicture_Click(object sender, EventArgs e)
        {
            SaveResult(sender, e);
        }
        private void SaveResult(object sender, EventArgs e)
        {
            if (OutputPicture.Image != null)
            {

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Png file|*.png|Jpg file|*.jpg";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    res.Save(sfd.FileName);

                }
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
