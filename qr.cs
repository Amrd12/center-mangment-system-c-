using System;
using System.Drawing;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;

namespace student_enrolled
{
    public class QR
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public event Action<string> QRCodeScanned;

        public QR()
        {
            // Initialize video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            }
            else
            {
                throw new InvalidOperationException("No video capture devices found.");
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap videoFrame = (Bitmap)eventArgs.Frame.Clone();

                // Use ZXing.Net to decode QR codes
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode(videoFrame);

                if (result != null)
                {
                    string decodedText = result.Text;
                        QRCodeScanned?.Invoke(decodedText);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
            }
        }

        public void StartScanning()
        {
            if (videoSource != null && !videoSource.IsRunning)
            {
                videoSource.Start();
            }
        }

        public void StopScanning()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        public Bitmap GenerateQRCode(string textToEncode, int width, int height)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            barcodeWriter.Options = new ZXing.Common.EncodingOptions
            {
                Width = width,
                Height = height
            };

            return new Bitmap(barcodeWriter.Write(textToEncode));
        }

        public string DecodeQRCode(Bitmap qrCodeImage)
        {
            try
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode(qrCodeImage);

                if (result != null)
                {
                    return result.Text;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
            }

            return null; // No QR code found or unable to decode.
        }
    }
}
