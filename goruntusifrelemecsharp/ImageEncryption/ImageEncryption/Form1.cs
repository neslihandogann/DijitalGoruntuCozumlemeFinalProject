using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEncryption
{
    public partial class Form1 : Form
    {

        private Bitmap originalImage;
        private Bitmap encryptedImage;
        private Bitmap decryptedImage;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                pbOriginal.Image = originalImage;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
              if (originalImage != null)
            {
                string key = tbKey.Text;

                encryptedImage = originalImage.Clone() as Bitmap;

                Random rnd = new Random(key.GetHashCode());

                for (int x = 0; x < originalImage.Width; x++)
                {
                    for (int y = 0; y < originalImage.Height; y++)
                    {
                        Color originalColor = originalImage.GetPixel(x, y);
                        int rndValue = rnd.Next(256);

                        int r = (originalColor.R + key[0] + rndValue) % 256;
                        int g = (originalColor.G + key[1] + rndValue) % 256;
                        int b = (originalColor.B + key[2] + rndValue) % 256;

                        encryptedImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }

                pbEncrypted.Image = encryptedImage;
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resmi şifreleyin.", "Hata",, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                string key = tbKey.Text;

                decryptedImage = originalImage.Clone() as Bitmap;
                pbDecrypted.Image = decryptedImage;
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resmi şifreleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (encryptedImage != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image Files (*.png)|*.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    encryptedImage.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resmi şifreleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

