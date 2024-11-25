using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_Compress_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected folder path
                string folderPath = folderBrowserDialog1.SelectedPath;

                // Display the folder path in the text box
                txtPath.Text = folderPath;

                // Clear the ListBox before adding new items
                lbImageList.Items.Clear();

                // Retrieve all files in the selected folder
                string[] files = System.IO.Directory.GetFiles(folderPath);

                // Add each file to the ListBox
                foreach (string file in files)
                {
                    lbImageList.Items.Add(file);
                }
            }
        }


        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                // Extract the folder path
                string folderPath = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);

                // Display the folder path (optional)
                txtPath.Text = folderPath;

                // Add the selected file to the ListBox
                foreach (string selectedFile in openFileDialog1.FileNames)
                {
                    // Add the selected file to the ListBox
                    lbImageList.Items.Add(selectedFile);
                }
            }
        }


        private void btnCompress_Click(object sender, EventArgs e)
        {

            foreach (var item in lbImageList.Items)
            {
                string imagePath = item.ToString();
                string fileName = System.IO.Path.GetFileName(imagePath);
                string compressionImagePath = txtPath.Text +@"\"+ txtPrefix.Text + fileName;
                //MessageBox.Show(imagePath);
                //MessageBox.Show(compressionImagePath);

                using (Bitmap map = new Bitmap(imagePath))
                {
                    EncoderParameters encoderParameters = new EncoderParameters();

                    System.Drawing.Imaging.Encoder qualityEncoder = System.Drawing.Imaging.Encoder.Quality;
                    long compressionRatio = long.Parse(cmbRatio.SelectedItem.ToString());
                    EncoderParameter qualityEncoderParamter = new EncoderParameter(qualityEncoder, compressionRatio);

                    //save

                    ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Png);
                    encoderParameters.Param[0] = qualityEncoderParamter;
                    map.Save(compressionImagePath, jpgEncoder, encoderParameters);

                }
                MessageBox.Show("done");
            }


        }
    }
}
