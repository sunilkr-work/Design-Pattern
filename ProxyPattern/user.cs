using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class user
    {
        ProxyImage image;

        public ProxyImage  GetImage(string imageName, string imageSize)
        {
            Console.WriteLine("User is requesting an image.");
            image = new ProxyImage("Sunil");
            //image.ImageName = imageName;
            //image.ImageSize = imageSize;
            return image;
        }
    }
}
