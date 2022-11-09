using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//para agregar y reproducir videos
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
//deteccion de movimiento
using AForge.Vision.Motion;
//Activar camara web
using AForge.Video.DirectShow;
using AForge.Video;
using AForge.Imaging.Filters;
using System.Runtime.InteropServices;
//deteccion de cara

namespace Ruby
{
    public partial class Form1 : Form
    {
        VideoCapture videocapture;
        VideoCaptureDevice device;
        Bitmap video;
        Image<Bgr, Byte> currentFrame;
        double duracion,FrameCount;
        bool videoload = false;
        string filterName;
        //activar webcam
        private FilterInfoCollection MisDispositivos;
        FilterInfoCollection filter;
        private VideoCaptureDevice MiwebCam;
        private bool HayDispositivos;
        private Bitmap imageClean;
        int cb = 5;
        private string pathImages = @"C:\Users\yarel\Documents\Visual Studio 2019\Projects\Ruby\Fotos Guardadas\";
        MotionDetector motionDetector;
        float NivelDeDeteccion;
        Image<Bgr, byte> imgInput;
        String countFaces;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        public Form1()
        {InitializeComponent();}

        private void Form1_Load(object sender, EventArgs e)
        {
            videoSourcePlayer1.Visible = false;
            btn_apagar.Enabled = false;btn_desact_rostro.Enabled = false;btn_detector_mov.Enabled = false;btn_desactivar_mov.Enabled = false;photo.Enabled = false;
            motionDetector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());
            NivelDeDeteccion = 0;
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in filter)
                cb_webcam.Items.Add(device.Name);
                cb_webcam.SelectedIndex = 0;
                device = new VideoCaptureDevice();
            CargarDispositivos();
        }

        ColorMatrix BYWColorMatrix = new ColorMatrix(new float[][]
        {   new float[]{.3f, .3f, .3f, 0, 0},
            new float[]{.59f, .59f, .59f, 0, 0},
            new float[]{.11f, .11f, .11f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
        });
        ColorMatrix SColorMatrix = new ColorMatrix(new float[][]
        {  new float []{.349f, .349f, .272f, 0, 0 },
            new float []{.769f, .686f, .534f, 0, 0 },
            new float []{.189f, .168f, .131f, 0, 0 },
            new float []{.0f, .0f, .0f, 1, 0 },
            new float []{.0f, .0f, .0f, 0, 1 },
        });
        ColorMatrix NColorMatrix = new ColorMatrix(new float[][]
        { new float []{-1, 0, 0, 0, 0 },
            new float []{0, -1, 0, 0, 0 },
            new float []{0, 0, 0, -1, 0 },
            new float []{0, 0, 0, 1, 0 },
            new float []{1, 1, 1, 1, 1 },
        });
        ColorMatrix RAColorMatrix = new ColorMatrix(new float[][]
        { new float []{1, 0, 0, 0, 0 },
            new float []{0, -2, -1, 0, 0 },
            new float []{0, -1, 1, 1, 0 },
            new float []{0, 0, 1, 2, 0 },
            new float []{0, 0, 0, 0, 1 },
        });
        ColorMatrix UColorMatrix = new ColorMatrix(new float[][]
        { new float[] {1.5f, 1.5f, 1.5f, 0, 0},
            new float[] {1.5f, 1.5f, 1.5f, 0, 0},
            new float[] {1.5f, 1.5f, 1.5f, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {-1, -1, -1, 0, 1}
        });
        ColorMatrix PColorMatrix = new ColorMatrix(new float[][]
        { new float[] {0f, 0.2f, 0f, 0, 0},
            new float[] {0.2f, 0.2f, 0.2f, 0, 0},
            new float[] {0f, 0.2f, 0.2f, 0, 0},
            new float[] {0f, 0f, 0f, 1, 0},
            new float[] {0f, 0f, 0f, 0, 1}
        });
        Pixellate filterPixel = new Pixellate();

        //<--------funciones
        public void CerrarWebCam()
        {   if (MiwebCam != null && MiwebCam.IsRunning)
            {MiwebCam.SignalToStop();
             MiwebCam = null;
            }
        }
        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pb_camara_actual.Image = Imagen;
        }
        public void CargarDispositivos()
        {   MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {   HayDispositivos = true;
                for (int i = 0; i < MisDispositivos.Count; i++)
                {
                    cb_webcam.Items.Add(MisDispositivos[i].Name.ToString());
                }
                cb_webcam.SelectedIndex = 0;
            }
            else
            { HayDispositivos = false;  }
        }
        //--------------------Función para aplicar los filtros de las matrices
        private static Bitmap ApplyColorMatrix(Image sourceImage, ColorMatrix colorMatrix)
        {
            Bitmap bmp32BppSource = GetArgbCopy(sourceImage);
            Bitmap bmp32BppDest = new Bitmap(bmp32BppSource.Width, bmp32BppSource.Height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(bmp32BppDest))
            {
                ImageAttributes bmpAttributes = new ImageAttributes();
                bmpAttributes.SetColorMatrix(colorMatrix);

                graphics.DrawImage(bmp32BppSource, new Rectangle(0, 0, bmp32BppSource.Width, bmp32BppSource.Height),
                                    0, 0, bmp32BppSource.Width, bmp32BppSource.Height, GraphicsUnit.Pixel, bmpAttributes);
            }
            bmp32BppSource.Dispose();
            return bmp32BppDest;
        }
        private static Bitmap GetArgbCopy(Image sourceImage)
        {
            Bitmap bmpNew = new Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(bmpNew))
            {
                graphics.DrawImage(sourceImage, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), GraphicsUnit.Pixel);
                graphics.Flush();
            }
            return bmpNew;
        }
        //Función para aplicar los filtros de las matrices------------------
        private void CargarVideo(object sender, EventArgs e)
        {   if (FrameCount < duracion - 2)
            {    Mat m = new Mat();
                videocapture.Read(m);

                currentFrame = new Image<Bgr, byte>(m.Bitmap);
                //currentFrame.Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);
                FrameCount = videocapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames);
            }
            else
            {  FrameCount = 0;
                videocapture.SetCaptureProperty(CapProp.PosFrames, 0);}

            switch (filterName)
            {
                case "Sepia":
                    {
                        Image img = currentFrame.Bitmap;
                        Bitmap bmpinverted = new Bitmap(img.Width, img.Height);

                        ImageAttributes Ia = new ImageAttributes();
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                            {
                                new float []{.349f, .349f, .272f, 0, 0 },
                                new float []{.769f, .686f, .534f, 0, 0 },
                                new float []{.189f, .168f, .131f, 0, 0 },
                                new float []{.0f, .0f, .0f, 1, 0 },
                                new float []{.0f, .0f, .0f, 0, 1 },
                            });
                        Ia.SetColorMatrix(cmPicture);
                        Graphics gr = Graphics.FromImage(bmpinverted);

                        gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
                        gr.Dispose();
                        pb_video_resultado.Image = bmpinverted;

                        break;
                    }
                case "Gris":
                    {
                        Image img = currentFrame.Bitmap;
                        Bitmap bmpinverted = new Bitmap(img.Width, img.Height);

                        ImageAttributes Ia = new ImageAttributes();
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                            {
                                new float []{.3f, .3f, .3f, 0, 0 },
                                new float []{.3f, .3f, .3f, 0, 0 },
                                new float []{.3f, .3f, .3f, 0, 0 },
                                new float []{0, 0, 0, 1, 0 },
                                new float []{0, 0, 0, 0, 1 },
                            });
                        Ia.SetColorMatrix(cmPicture);
                        Graphics gr = Graphics.FromImage(bmpinverted);

                        gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
                        gr.Dispose();
                        pb_video_resultado.Image = bmpinverted;

                        break;
                    }
                case "Negativo":
                    {
                        Image img = currentFrame.Bitmap;
                        Bitmap bmpinverted = new Bitmap(img.Width, img.Height);

                        ImageAttributes Ia = new ImageAttributes();
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                            {
                                new float []{-1, 0, 0, 0, 0 },
                                new float []{0, -1, 0, 0, 0 },
                                new float []{0, 0, 0, -1, 0 },
                                new float []{0, 0, 0, 1, 0 },
                                new float []{1, 1, 1, 1, 1 },
                            });
                        Ia.SetColorMatrix(cmPicture);
                        Graphics gr = Graphics.FromImage(bmpinverted);

                        gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
                        gr.Dispose();
                        pb_video_resultado.Image = bmpinverted;

                        break;
                    }
                case "Rojizo":
                    {
                        Image img = currentFrame.Bitmap;

                        Bitmap bmpinverted = new Bitmap(img.Width, img.Height);

                        ImageAttributes Ia = new ImageAttributes();
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                            {
                                new float []{.588f, 0, 0, 0, 0 },
                                new float []{0,.058f, 0, 0, 0 },
                                new float []{0, 0, 0, .156f, 0 },
                                new float []{0, 0, 0, 1, 0 },
                                new float []{ 0, 0, 0, 0, 1 },
                            });
                        Ia.SetColorMatrix(cmPicture);
                        Graphics gr = Graphics.FromImage(bmpinverted);

                        gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
                        gr.Dispose();
                        pb_video_resultado.Image = bmpinverted;

                        break;
                    }
                case "RosaAzulado":
                    {
                        Image img = currentFrame.Bitmap;

                        Bitmap bmpinverted = new Bitmap(img.Width, img.Height);

                        ImageAttributes Ia = new ImageAttributes();
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                            {
                                new float []{1, 0, 0, 0, 0 },
                                new float []{0, -2, -1, 0, 0 },
                                new float []{0, -1, 1, 1, 0 },
                                new float []{0, 0, 1, 2, 0 },
                                new float []{0, 0, 0, 0, 1 },
                            });
                        Ia.SetColorMatrix(cmPicture);
                        Graphics gr = Graphics.FromImage(bmpinverted);

                        gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
                        gr.Dispose();
                        pb_video_resultado.Image = bmpinverted;

                        break;
                    }
                default:
                    {
                        pb_video_resultado.Image = currentFrame.Bitmap;
                        break;
                    }
            }
        }
        private void setHistogramas(int[] pRedC, int[] pGreenC, int[] pBlueC)
        {
            histogramaRed.Values = pRedC;
            histogramaRed.Color = Color.Red;
            histogramGreen.Values = pGreenC;
            histogramGreen.Color = Color.Green;
            histogramBlue.Values = pBlueC;
            histogramBlue.Color = Color.Blue;
        }
        private void setHistogramas1(int[] pRedC, int[] pGreenC, int[] pBlueC)
        {
            histogramaRed1.Values = pRedC;
            histogramaRed1.Color = Color.Red;
            histogramGreen1.Values = pGreenC;
            histogramGreen1.Color = Color.Green;
            histogramBlue1.Values = pBlueC;
            histogramBlue1.Color = Color.Blue;
        }
        private int[] getHistogramaRed(Bitmap pImagen)
        {
            int[] array = new int[256];
            Color rColor = new Color();
            for (int x = 0; x < pImagen.Width; x++)
            {
                for (int y = 0; y < pImagen.Height; y++)
                {
                    rColor = pImagen.GetPixel(x, y);
                    array[rColor.R]++;
                }
            }
            return array;
        }
        private int[] getHistogramaGreen(Bitmap pImagen)
        {
            int[] array = new int[256];
            Color rColor = new Color();
            for (int x = 0; x < pImagen.Width; x++)
            {
                for (int y = 0; y < pImagen.Height; y++)
                {
                    rColor = pImagen.GetPixel(x, y);
                    array[rColor.G]++;
                }
            }
            return array;
        }
        private int[] getHistogramaBlue(Bitmap pImagen)
        {
            int[] array = new int[256];
            Color rColor = new Color();
            for (int x = 0; x < pImagen.Width; x++)
            {
                for (int y = 0; y < pImagen.Height; y++)
                {
                    rColor = pImagen.GetPixel(x, y);
                    array[rColor.B]++;
                }
            }
            return array;

        }
        public static Bitmap ImpulseNoise(Bitmap image)
        {
            int w = image.Width;
            int h = image.Height;

            BitmapData image_data = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            image.UnlockBits(image_data);

            Random rnd = new Random();
            int noise_chance = 10;
            for (int i = 0; i < bytes; i += 3)
            {   int max = (int)(1000 / noise_chance);
                int tmp = rnd.Next(max + 1);
                for (int j = 0; j < 3; j++)
                {   if (tmp == 0 || tmp == max)
                    {   int sorp = tmp / max;
                        result[i + j] = (byte)(sorp * 255);
                    }
                    else
                    {result[i + j] = buffer[i + j];}
                }
            }

            Bitmap result_image = new Bitmap(w, h);
            BitmapData result_data = result_image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, result_data.Scan0, bytes);
            result_image.UnlockBits(result_data);

            return result_image;
        }
        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] detectedFaces = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
            countFaces = detectedFaces.Length.ToString();
            SolidBrush solidBrush = new SolidBrush(Color.Purple);
            Font font = new Font("Waltograph UI", 15.0f);
            int i = 0;
            foreach (Rectangle face in detectedFaces)
            {
                i++;
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Purple, 4))
                    {
                        graphics.DrawRectangle(pen, face);
                        graphics.DrawString("Rostro" + i, font, solidBrush, face.Location);

                    }
                }
            }

            //pictureBox1.Image = bitmap;
            pb_camara_actual.Image = bitmap;
        }
        //------>funciones

        private void btn_archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (file.ShowDialog() == DialogResult.OK)
            {  MessageBox.Show("Cargando imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pb_imagen_original.Image = new Bitmap(file.FileName);
                pb_imagen_original.SizeMode = PictureBoxSizeMode.Zoom;
                pb_imagen_resultado.Image = new Bitmap(file.FileName);
                pb_imagen_resultado.SizeMode = PictureBoxSizeMode.Zoom;
                txtruta.Text = file.FileName;
                MessageBox.Show("Imagen cargada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Cargando histogramas", "Espere por favor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setHistogramas(getHistogramaRed((Bitmap)pb_imagen_resultado.Image), getHistogramaGreen((Bitmap)pb_imagen_resultado.Image), getHistogramaBlue((Bitmap)pb_imagen_resultado.Image));
                MessageBox.Show("Histogramas cargados", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {  MessageBox.Show("No se ha seleccionado ninguna imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        private void cb_filtros_editar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pb_imagen_resultado.Image != null)
            { //Se define el filtro seleccionado según el combobox
                switch (cb_filtros_editar.SelectedIndex)
                {
                    case 0:
                        pb_imagen_resultado.Image = ApplyColorMatrix(pb_imagen_resultado.Image, BYWColorMatrix);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        pb_imagen_resultado.Image = ApplyColorMatrix(pb_imagen_resultado.Image, SColorMatrix);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        pb_imagen_resultado.Image = ApplyColorMatrix(pb_imagen_resultado.Image, NColorMatrix);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        pb_imagen_resultado.Image = ApplyColorMatrix(pb_imagen_resultado.Image, RAColorMatrix);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 4:
                        pb_imagen_resultado.Image = ApplyColorMatrix(pb_imagen_resultado.Image, UColorMatrix);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 5:
                        Bitmap imagensita = AForge.Imaging.Image.Clone(new Bitmap(pb_imagen_resultado.Image), PixelFormat.Format24bppRgb);
                        pb_imagen_resultado.Image = filterPixel.Apply(imagensita);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 6:
                        pb_imagen_resultado.Image = ImpulseNoise((Bitmap)pb_imagen_resultado.Image);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        pb_imagen_resultado.Image = pb_imagen_original.Image;
                        MessageBox.Show("Filtro (s) eliminado (s)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                MessageBox.Show("Cargando histogramas", "Espere por favor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setHistogramas(getHistogramaRed((Bitmap)pb_imagen_resultado.Image), getHistogramaGreen((Bitmap)pb_imagen_resultado.Image), getHistogramaBlue((Bitmap)pb_imagen_resultado.Image));
                MessageBox.Show("Histogramas cargados", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { MessageBox.Show("No hay una imagen para aplicar el filtro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            cb = cb_filtros_editar.SelectedIndex;
        }

        private void btn_video_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Files (* .mp4) | * .mp4";
            if (ofd.ShowDialog() == DialogResult.OK)
            {   MessageBox.Show("Cargando video", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                videocapture = new VideoCapture(ofd.FileName);
                videocapture.QueryFrame();
                Mat m = new Mat();
                videocapture.Read(m);
                //pictureBox1.Image = m.Bitmap;
                currentFrame = new Image<Bgr, byte>(m.Bitmap);
                //currentFrame.Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);
                //current frame 
                pb_video_original.Image = currentFrame.Bitmap;
                pb_video_resultado.Image = currentFrame.Bitmap;
                duracion = videocapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                //capprop posicion de los frames
                FrameCount = videocapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames);
                videoload = true;
                pb_video_resultado.BackgroundImage = null;
                tb_ruta_Video.Text = ofd.FileName;
                MessageBox.Show("Video cargado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { MessageBox.Show("No se ha seleccionado ningun video", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cb_filtro_videos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pb_video_resultado.Image != null)
            {
                //Se define el filtro seleccionado según el combobox
                switch (cb_filtro_videos.SelectedIndex)
                {
                    case 0:
                        filterName = "Gris";
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        filterName = "Sepia";
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        filterName = "Negativo";
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        filterName = "RosaAzulado";
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 4:
                        filterName = "Rojizo";
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        pb_video_resultado.Image = pb_video_original.Image;
                        MessageBox.Show("Filtro (s) eliminado (s)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            else
            { MessageBox.Show("No hay una imagen para aplicar el filtro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            cb = cb_filtro_videos.SelectedIndex;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (videoload)
            { Application.Idle += new EventHandler(CargarVideo);}
            
            else
            { MessageBox.Show("No se carga el video", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            
        }

        private void btn_save_imagen_Click(object sender, EventArgs e)
        {
            if (pb_imagen_resultado.Image != null)
            {   pb_imagen_resultado.Image.Save(pathImages + "LaChidaFotoConFiltro.jpg", ImageFormat.Jpeg);
                MessageBox.Show("Imagen guardada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {MessageBox.Show("No hay nada para guardar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            btn_apagar.Enabled = true;photo.Enabled = true;btn_rostro.Enabled = false;btn_desact_rostro.Enabled = false;btn_detector_mov.Enabled = true;btn_desactivar_mov.Enabled = true;
            CerrarWebCam();
            int i = cb_webcam.SelectedIndex;
            string NombreVideo = MisDispositivos[i].MonikerString;
            MiwebCam = new VideoCaptureDevice(NombreVideo);
            MiwebCam.NewFrame += new NewFrameEventHandler(Capturando);
            MiwebCam.Start();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            CerrarWebCam();
            pb_camara_actual.Image = null;
            btn_activar.Enabled = true;
            btn_desactivar_mov.Enabled = false;btn_detector_mov.Enabled = false;btn_desactivar_mov.Enabled = false;btn_apagar.Enabled = false;photo.Enabled = false;btn_rostro.Enabled = true;btn_desact_rostro.Enabled = false;
        }

        private void photo_Click(object sender, EventArgs e)
        {
            if (MiwebCam != null && MiwebCam.IsRunning)
            {  pb_camara_resultado.Image = pb_camara_actual.Image;
               pb_camara_actual.Image = pb_camara_resultado.Image;
               imageClean = (Bitmap)pb_camara_resultado.Image;
            }
            MessageBox.Show("Foto tomada......cargando histogramas", "Espere por favor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            setHistogramas1(getHistogramaRed((Bitmap)pb_camara_resultado.Image), getHistogramaGreen((Bitmap)pb_camara_resultado.Image), getHistogramaBlue((Bitmap)pb_camara_resultado.Image));
            MessageBox.Show("Histogramas cargados", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cb_filtro_camara_SelectedIndexChanged(object sender, EventArgs e)
        { if (pb_camara_resultado.Image != null)
            {//Se define el filtro seleccionado según el combobox
                switch (cb_filtro_camara.SelectedIndex)
                {
                    case 0:
                        pb_camara_resultado.Image = ApplyColorMatrix(pb_camara_resultado.Image, BYWColorMatrix);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        pb_camara_resultado.Image = ApplyColorMatrix(pb_camara_resultado.Image, SColorMatrix);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        pb_camara_resultado.Image = ApplyColorMatrix(pb_camara_resultado.Image, NColorMatrix);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        pb_camara_resultado.Image = ApplyColorMatrix(pb_camara_resultado.Image, RAColorMatrix);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 4:
                        pb_camara_resultado.Image = ApplyColorMatrix(pb_camara_resultado.Image, UColorMatrix);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 5:
                        Bitmap imagensita = AForge.Imaging.Image.Clone(new Bitmap(pb_camara_resultado.Image), PixelFormat.Format24bppRgb);
                        pb_camara_resultado.Image = filterPixel.Apply(imagensita);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 6:
                        pb_camara_resultado.Image = ImpulseNoise((Bitmap)pb_camara_resultado.Image);
                        MessageBox.Show("Filtro aplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        //pb_camara_resultado.Image = pb_camara.Image;
                        MessageBox.Show("Filtro (s) eliminado (s)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                MessageBox.Show("Cargando histogramas", "Espere por favor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setHistogramas1(getHistogramaRed((Bitmap)pb_camara_resultado.Image), getHistogramaGreen((Bitmap)pb_camara_resultado.Image), getHistogramaBlue((Bitmap)pb_camara_resultado.Image));
                MessageBox.Show("Histogramas cargados", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { MessageBox.Show("No hay una imagen para aplicar el filtro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            cb = cb_filtro_camara.SelectedIndex;
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        { NivelDeDeteccion = motionDetector.ProcessFrame(image);  }

        private void btn_detector_mov_Click(object sender, EventArgs e)
        {videoSourcePlayer1.Visible = true;videoSourcePlayer1.VideoSource = MiwebCam;videoSourcePlayer1.Start();}
            
        private void btn_rostro_Click(object sender, EventArgs e)
        {
            btn_apagar.Enabled = false;btn_activar.Enabled = false;btn_desact_rostro.Enabled = true;
            device = new VideoCaptureDevice(filter[cb_webcam.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
        }

        private void btn_desact_rostro_Click(object sender, EventArgs e)
        { if (device.IsRunning)
                device.Stop();
            pb_camara_actual.Image = null;
            btn_activar.Enabled = true;btn_apagar.Enabled = false;btn_desact_rostro.Enabled = false;
        }

        private void btn_delete_imagen_Click(object sender, EventArgs e)
        {pb_imagen_original.Image = null;pb_imagen_resultado.Image = null;}

        private void btn_delete_video_Click(object sender, EventArgs e)
        {pb_video_original.Image = null;pb_video_resultado.Image = null;}

        private void btn_delete_web_Click(object sender, EventArgs e)
        {pb_camara_resultado.Image = null;}

        private void btn_pause_Click(object sender, EventArgs e)
        { videoload = false;   }

        private void btn_save_web_Click(object sender, EventArgs e)
        {
            if (pb_camara_resultado.Image != null)
            {
                pb_camara_resultado.Image.Save(pathImages + "LaChidaFotoWebConFiltro.jpg", ImageFormat.Jpeg);
                MessageBox.Show("Imagen guardada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { MessageBox.Show("No hay nada para guardar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_desactivar_mov_Click(object sender, EventArgs e)
        {videoSourcePlayer1.Visible = false;videoSourcePlayer1.Stop();  MiwebCam.Start();}
    }
}
