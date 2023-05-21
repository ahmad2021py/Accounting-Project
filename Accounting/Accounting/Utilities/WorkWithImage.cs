using System.Drawing;
using System.IO;

namespace Accounting.Utilities
{
    public static class WorkWithImage
    {
        //------------Fields----------------




        //-------Methods--------------------------

        public static byte[] imageToByteArray(Image imageIn)
        {
            if (imageIn == null) return null;
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }



        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null) return null;
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


































        //---End Block of Class And Namespace------------------------
    }

}
