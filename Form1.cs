using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using Accord.Video.FFMPEG;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic;

namespace Simple_Stop_Animation
{
    public partial class Form1 : Form
    {
        string projectFolder = "";
        string Title = "Spencer's Simple Stop Motion Animation";
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;
        bool OnionSkinActive = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            ChooseImgFile.Filter = "Image File|*.bmp;*.jpg;*.jpeg;*.png;*.tiff;*.raw";
            ChooseImgFile.FileName = "";
            DialogResult result = ChooseImgFile.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ChooseImgFile.FileName))
            {
                string FileName = ChooseImgFile.SafeFileName;

                int Width = GetImageWidth(ChooseImgFile.FileName);
                int height = GetImageHeight(ChooseImgFile.FileName);
                string ImageDetails = Width.ToString() + " x " + height.ToString();

                string FileLocation = ChooseImgFile.FileName;

                addItemToList(FileName.ToString(), ImageDetails.ToString(), FileLocation.ToString());

                if (isCameraRunning == false)
                {
                    picturePreview.Image = Image.FromFile(ChooseImgFile.FileName.ToString());
                }
            }
        }



        int GetImageWidth(string file)
        {
            int width = 0;
            try
            {
                using (var srcImage = Image.FromFile(file))
                {
                    width = srcImage.Width;
                    srcImage.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception error has occured:\n" + e.Message.ToString(), Title);
            }
            return width;
        }

        int GetImageHeight(string file)
        {
            int height = 0;
            try
            {
                using (var srcImage = Image.FromFile(file))
                {
                    height = srcImage.Height;
                    srcImage.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception error has occured:\n" + e.Message.ToString(), Title);
            }
            return height;
        }

        private void btnRemoveImg_Click(object sender, EventArgs e)
        {
            if (listImages.SelectedItems.Count > 0)
            {
                listImages.Items.Remove(listImages.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Select a file to remove first.\n", Title);
            }
        }

        /*
        private void btnDebug_Click(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                if (capture.IsOpened())
                {
                    textDebug.Text = textDebug.Text + "FPS: " + capture.Fps + "\n";
                    textDebug.Text = textDebug.Text + "FrameHeight: " + capture.FrameHeight + "\n";
                    textDebug.Text = textDebug.Text + "FrameWidth: " + capture.FrameWidth + "\n";
                    textDebug.Text = textDebug.Text + "Sharpness: " + capture.Sharpness + "\n";
                    textDebug.Text = textDebug.Text + "Zoom: " + capture.Zoom + "\n";
                    textDebug.Text = textDebug.Text + "Tilt: " + capture.Tilt + "\n";
                    textDebug.Text = textDebug.Text + "Brightness: " + capture.Brightness + "\n";
                    textDebug.Text = textDebug.Text + "Contrast: " + capture.Contrast + "\n";
                    textDebug.Text = textDebug.Text + "Backlight: " + capture.BackLight + "\n";
                    textDebug.Text = textDebug.Text + "Auto Focus: " + capture.AutoFocus + "\n";
                    textDebug.Text = textDebug.Text + "Auto Exposure: " + capture.AutoExposure + "\n";
                    textDebug.Text = textDebug.Text + "Exposure: " + capture.Exposure + "\n";
                    textDebug.Text = textDebug.Text + "Focus: " + capture.Focus + "\n";
                    textDebug.Text = textDebug.Text + "Gain: " + capture.Gain + "\n";
                    textDebug.Text = textDebug.Text + "Gamma: " + capture.Gamma + "\n";
                    textDebug.Text = textDebug.Text + "Hue: " + capture.Hue + "\n";
                    textDebug.Text = textDebug.Text + "Iris: " + capture.Iris + "\n";
                    textDebug.Text = textDebug.Text + "Monochrome: " + capture.Monocrome + "\n";
                    textDebug.Text = textDebug.Text + "Pan: " + capture.Pan + "\n";
                    textDebug.Text = textDebug.Text + "Temperature: " + capture.Temperature + "\n";
                }
            }
        }
        */

        private void listImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listImages.SelectedItems.Count > 0)
            {
                string filename = listImages.SelectedItems[0].SubItems[2].Text.ToString();
                if (isCameraRunning == false)
                {
                    picturePreview.Image = Image.FromFile(filename);
                }
            }
            else
            {
                return;
            }
        }

        void ConvertToMovie()
        {
            if (listImages.Items.Count > 1)
            {
                Stream tempImg = new MemoryStream();

                int width = (int)MovieWidth.Value;
                int height = (int)MovieHeight.Value;

                VideoFileWriter writer = new VideoFileWriter();

                writer.Open(@projectFolder + @"\MyMovie.mp4", width, height, (int)FPS.Value, VideoCodec.Default, (int)bitrate.Value * 1000);
                
                for (int i = 0; i < listImages.Items.Count; i++)
                {
                    //This will re-size the images to the output size (whether that's smaller or larger).
                    using (var srcImage = Image.FromFile(@listImages.Items[i].SubItems[2].Text.ToString()))
                    {
                        using (var newImage = new Bitmap(width, height))
                        using (var graphics = Graphics.FromImage(newImage))
                        {
                            graphics.DrawImage(srcImage, new Rectangle(0, 0, width, height));
                            newImage.Save(tempImg, System.Drawing.Imaging.ImageFormat.Bmp);

                            newImage.Dispose();
                        }
                        srcImage.Dispose();
                    }

                    Bitmap temp = new Bitmap(Image.FromStream(tempImg));
                    writer.WriteVideoFrame(temp);
                    temp.Dispose();
                }
                writer.Close();
            }
            else
            {
                MessageBox.Show("You need at least two images to make a movie.", Title);
            }
        }




        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.IsBackground = true;
            camera.Start();
        }

        private void CaptureCameraCallback()
        { 
            frame = new Mat();
            capture = new VideoCapture(0);


            if (capture.IsOpened())
            {
                capture.Fps = 120;
                capture.FrameHeight = 8000;
                capture.FrameWidth = 8000;
                grpCameraControl.Enabled = true;

                while (isCameraRunning)
                {
                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);

                    
                    if (picturePreview.Image != null)
                    {
                        picturePreview.Image.Dispose();
                    }


                    if (OnionSkinActive == true && listImages.Items.Count > 0)
                    {
                        //here it is crashing as it's accessing the list image from the thread and another source at the same time and it becomes out of memory, too.
                        try
                        {
                            /*
                            Bitmap TransparentImage = SetImageOpacity(Image.FromFile(listImages.Items[listImages.Items.Count - 1].SubItems[2].Text.ToString()), 0.5f);
                            Image newImage = Overlap(image, TransparentImage);
                            picturePreview.Image = newImage;
                            TransparentImage.Dispose();
                            */
                            //image.Dispose();
                        }
                        catch(Exception e)
                        {
                            MessageBox.Show(e.Message.ToString());
                        }
                    }
                    else
                    {
                        picturePreview.Image = image;
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ConvertToMovie();
        }

        private void btnWebCam_Click(object sender, EventArgs e)
        {
            if (isCameraRunning == false)
            {
                isCameraRunning = true;
                CaptureCamera();
                btnStartWebCam.Text = "Stop WebCam";
            }
            else
            {
                if (capture.IsOpened())
                {
                    capture.Dispose();
                }
                isCameraRunning = false;
                grpCameraControl.Enabled = false;
                btnStartWebCam.Text = "Image From WebCam";
            }
        }

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            TakePicture();
        }

        void TakePicture()
        {
            if (isCameraRunning)
            {
                lock (image)
                {
                    var myUniqueFileName = string.Format(@"{0}.bmp", Guid.NewGuid());
                    string savePath = @projectFolder + @"\" + myUniqueFileName;
                    image.Save(savePath, ImageFormat.Bmp);

                    int Width = image.Width;
                    int height = image.Height;
                    string ImageDetails = Width.ToString() + " x " + height.ToString();

                    addItemToList(myUniqueFileName.ToString(), ImageDetails, savePath);
                }
            }
        }


        void addItemToList(string fileName, string imageSize, string savePath)
        {
            ListViewItem item = new ListViewItem(fileName);
            item.SubItems.Add(imageSize);
            item.SubItems.Add(savePath);
            
            if (listImages.SelectedItems.Count == 1)
            {
                int index = listImages.SelectedItems[0].Index;
                listImages.Items.Insert(index + 1, item);
            }
            else
            {
                listImages.Items.Add(item);
            }
            
            item.Selected = true;
        }


        private void MovieWidth_ValueChanged(object sender, EventArgs e)
        {
            // Resolution must be a value divisible by 2, so this takes care of that.
            if ((int)MovieWidth.Value % 2 == 0)
            {

            }
            else
            {
                MovieWidth.Value = (MovieWidth.Value + 1);
            }
        }

        private void MovieHeight_ValueChanged(object sender, EventArgs e)
        {
            // Resolution must be a value divisible by 2, so this takes care of that.
            if ((int)MovieHeight.Value % 2 == 0)
            {

            }
            else
            {
                MovieHeight.Value = MovieHeight.Value + 1;
            }
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            CreateProject();
        }

        void CreateProject()
        {
            string input = Interaction.InputBox("Please enter a name for the new project.", Title, "", 10, 10);

            if (input.Length < 1)
            {
                return;
            }
            else
            {
                string path = Application.StartupPath;
                path = path + @"\" + input.ToString();
                if (!Directory.Exists(@path))
                {
                    projectFolder = path;
                    Directory.CreateDirectory(@path);
                    StreamWriter sw = File.CreateText(path + @"\SSMApro.ject");
                    sw.Close();

                    enableControls(); 
                }
                else
                {
                    MessageBox.Show("Project already exists, please choose another name.", Title);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string line = "";
                for (int i = 0; i < listImages.Items.Count; i++)
                {
                    line = line + listImages.Items[i].SubItems[0].Text.ToString() + ";";
                    line = line + listImages.Items[i].SubItems[1].Text.ToString() + ";";
                    line = line + listImages.Items[i].SubItems[2].Text.ToString() + ";";
                    line = line + "\n";
                    File.WriteAllText(projectFolder + @"\SSMApro.ject", line);
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), Title);
            }
        }

        private void btnLoadProject_Click(object sender, EventArgs e)
        {
           chooseProject();
        }

        void chooseProject()
        {
            ChooseProjectFile.Filter = "Project File|*.ject";
            ChooseProjectFile.FileName = "";
            DialogResult result = ChooseProjectFile.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ChooseProjectFile.FileName))
            {
                bool Loaded = loadProject(ChooseProjectFile.FileName);
                if(Loaded == true)
                {
                    projectFolder = Path.GetDirectoryName(ChooseProjectFile.FileName);
                    enableControls();
                }
                else
                {
                    MessageBox.Show("Failed to load project file correctly.", Title);
                }
            }
        }


        void clearList()
        {
            //.clear() seems to remove the headers, too. Weird :-/
            //listImages.Clear();

            /*
            listImages.BeginUpdate();
            for (int i = 0; i < listImages.Items.Count; i++)
            {
                listImages.Items.Remove(listImages.Items[i]);
            }
            listImages.EndUpdate();
            */

            listImages.Items.Clear();
        }

        bool loadProject(string file)
        {
            clearList();

            bool LoadedProperly = false;
            int counter = 0;

            string line = "";

            StreamReader projectFile = new StreamReader(@file);

            listImages.BeginUpdate();

            while ((line = projectFile.ReadLine()) != null)
            {
                string[] delimitedStrings = line.Split(';');

                ListViewItem item = new ListViewItem(delimitedStrings[0]);
                item.SubItems.Add(delimitedStrings[1]);
                item.SubItems.Add(delimitedStrings[2]);

                listImages.Items.Add(item);
                
                counter++;
            }

            listImages.EndUpdate();
            listImages.EnsureVisible(listImages.Items.Count - 1);
            listImages.Items[listImages.Items.Count - 1].Selected = true;
            projectFile.Close();

            if(counter == 0)
            {
                LoadedProperly = false;
            }
            else
            {
                LoadedProperly = true;
            }
            return LoadedProperly;
        }

        void enableControls()
        {
            grpOutputOptions.Enabled = true;
            GrpControls.Enabled = true;
            btnSave.Enabled = true;
            //checkBoxOnionSkin.Enabled = true;
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            //Brightness ranges from 0 - 255
            int value = trackBarBrightness.Value;
            capture.Brightness = value;
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            int value = trackBarContrast.Value;
            capture.Contrast = value;
        }

        private void checkBoxAutoFocus_CheckedChanged(object sender, EventArgs e)
        {
            capture.AutoFocus = checkBoxAutoFocus.Checked;
        }

        private void trackBarExposure_Scroll(object sender, EventArgs e)
        {
            float value = (trackBarExposure.Value/10) * -1;
            capture.AutoExposure = value;
            capture.Exposure = value;
        }


        void defaultCameraOptions()
        {
            capture.Exposure = -6;
            capture.AutoExposure = -6;
            capture.AutoFocus = true;
            capture.Contrast = 32;
            capture.Brightness = 128;
            capture.Gain = 19;
            capture.Sharpness = 24;

            trackBarExposure.Value = 60;
            checkBoxAutoFocus.Checked = true;
            trackBarContrast.Value = 32;
            trackBarBrightness.Value = 128;
            trackBarGain.Value = 19;
            trackBarSharpness.Value = 24;
        }

        private void btnResetCameraControls_Click(object sender, EventArgs e)
        {
            defaultCameraOptions();
        }

        private void trackBarGain_Scroll(object sender, EventArgs e)
        {
            float value = trackBarGain.Value;
            capture.Gain = value;
        }

        private void trackBarSharpness_Scroll(object sender, EventArgs e)
        {
            float value = trackBarSharpness.Value;
            capture.Sharpness = value;
        }

        private void checkBoxOnionSkin_CheckedChanged(object sender, EventArgs e)
        {
            OnionSkinActive = checkBoxOnionSkin.Checked;
        }



        public static Image Overlap(Image SolidImage, Image OverlayImage)
        {
            var target = new Bitmap(SolidImage.Width, SolidImage.Height, PixelFormat.Format32bppArgb);
            var graphics = Graphics.FromImage(target);
            graphics.CompositingMode = CompositingMode.SourceOver; // this is the default, but just to be clear

            graphics.DrawImage(SolidImage, 0, 0);
            graphics.DrawImage(OverlayImage, 0, 0);
            graphics.Save();
            graphics.Dispose();
            return target;
        }


        public static Bitmap SetImageOpacity(Image imagefile, float opacity)
        {
            try
            {
                //create a Bitmap the size of the image provided  
                Bitmap bmp = new Bitmap(imagefile.Width, imagefile.Height);

                //create a graphics object from the image  
                using (Graphics gfx = Graphics.FromImage(bmp))
                {

                    //create a color matrix object  
                    ColorMatrix matrix = new ColorMatrix();

                    //set the opacity  
                    matrix.Matrix33 = opacity;

                    //create image attributes  
                    ImageAttributes attributes = new ImageAttributes();

                    //set the color(opacity) of the image  
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    //now draw the image  
                    gfx.DrawImage(imagefile, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, imagefile.Width, imagefile.Height, GraphicsUnit.Pixel, attributes);

                    gfx.Dispose();
                    attributes.Dispose();
                }
                return bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearList();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            MoveItemUp();
        }

        void MoveItemUp()
        {
            int index = listImages.SelectedItems[0].Index;
            if (index > 0)
            {
                ListViewItem theItem = listImages.Items[index];

                listImages.Items.Remove(listImages.Items[index]);
                listImages.Items.Insert(index - 1, theItem);
            }
            else
            {
                MessageBox.Show("You can't move the frame any higher up the list!", Title);
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            MoveItemDown();
        }

        void MoveItemDown()
        {
            int index = listImages.SelectedItems[0].Index;
            if (index < listImages.Items.Count - 1)
            {
                ListViewItem theItem = listImages.Items[index];

                listImages.Items.Remove(listImages.Items[index]);
                listImages.Items.Insert(index + 1, theItem);
            }
            else
            {
                MessageBox.Show("You can't move the frame any lower down the list!", Title);
            }
        }

    }
}
