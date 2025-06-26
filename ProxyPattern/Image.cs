using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Image
    {
        public string ImageName;
        public string ImageSize;
        public Image(string imageName, string imageSize)
        {
            this.ImageName = imageName;
            this.ImageSize = imageSize;
        }

        public Image()
        {
            CompressImage(ImageName);
        }
        void CompressImage(string image)
        {
            Console.WriteLine("Compressing image...");
            Thread.Sleep(5000);
            Console.WriteLine($"Image {image} compressed successfully.");
        }
    }
}
