using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Web2App
{
    public static class ImageToIconUtil
    {
        public static bool ConvertToIcon(Stream inputStream, Stream outputStream, int iconSize = 16, bool preserveAspectRatio = false)
        {
            Bitmap inputBitmap = (Bitmap) Image.FromStream(inputStream);
            
            if(inputBitmap == null)
                return false;

            float iconWidth = iconSize;
            float iconHeight = iconSize;

            if(preserveAspectRatio)
            {
                if(inputBitmap.Width > inputBitmap.Height)
                {
                    iconHeight = ((float) inputBitmap.Height / inputBitmap.Width) * iconSize;
                }
                else
                {
                    iconWidth = ((float) inputBitmap.Width / inputBitmap.Height) * iconSize;
                }
            }

            Bitmap targetBitmap = new Bitmap(inputBitmap, new Size((int) iconWidth, (int) iconHeight));
            
            if(targetBitmap == null)
                return false;

            using(MemoryStream memoryStream = new MemoryStream())
            {
                targetBitmap.Save(memoryStream, ImageFormat.Png);

                BinaryWriter iconBinaryWriter = new BinaryWriter(outputStream);
                
                if(outputStream == null || iconBinaryWriter == null)
                    return false;

                iconBinaryWriter.Write((byte) 0);
                iconBinaryWriter.Write((byte) 0);
                iconBinaryWriter.Write((short) 1);
                iconBinaryWriter.Write((short) 1);
                iconBinaryWriter.Write((byte) iconWidth);
                iconBinaryWriter.Write((byte) iconHeight);
                iconBinaryWriter.Write((byte) 0);
                iconBinaryWriter.Write((byte) 0);
                iconBinaryWriter.Write((short) 0);
                iconBinaryWriter.Write((short) 32);
                iconBinaryWriter.Write((int) memoryStream.Length);
                iconBinaryWriter.Write(6 + 16);
                iconBinaryWriter.Write(memoryStream.ToArray());

                iconBinaryWriter.Flush();
            }

            return true;
        }

        public static byte[] ConvertToIcon(Image image, bool preserveAspectRatio = false)
        {
            MemoryStream inputMemoryStream = new MemoryStream();
            image.Save(inputMemoryStream, ImageFormat.Png);

            inputMemoryStream.Seek(0, SeekOrigin.Begin);

            MemoryStream outputMemoryStream = new MemoryStream();

            int size = image.Size.Width;

            if(!ConvertToIcon(inputMemoryStream, outputMemoryStream, size, preserveAspectRatio))
                return null;

            return outputMemoryStream.ToArray();
        }
    }
}
