using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressImages
{
    class Program
    {
        private void CompressImage(Image sourceImage, int imageQuality, string savePath)
        {
            try
            {
                //Create an ImageCodecInfo-object for the codec information
                ImageCodecInfo jpegCodec = null;

                //Set quality factor for compression
                EncoderParameter imageQualitysParameter = new EncoderParameter(
                            System.Drawing.Imaging.Encoder.Quality, imageQuality);

                //List all avaible codecs (system wide)
                ImageCodecInfo[] alleCodecs = ImageCodecInfo.GetImageEncoders();

                EncoderParameters codecParameter = new EncoderParameters(1);
                codecParameter.Param[0] = imageQualitysParameter;

                //Find and choose JPEG codec
                for (int i = 0; i < alleCodecs.Length; i++)
                {
                    if (alleCodecs[i].MimeType == "img/jpeg")
                    {
                        jpegCodec = alleCodecs[i];
                        break;
                    }
                }

                //Save compressed image
                sourceImage.Save(savePath, jpegCodec, codecParameter);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
