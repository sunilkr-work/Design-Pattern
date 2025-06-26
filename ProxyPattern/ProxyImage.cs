using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class ProxyImage
    {
        public Image Image { get; set; }

        public string Name { get; set; }
        //public ProxyImage(string imageName, string imageSize)
        //{
        //    Image = new Image(imageName, imageSize);
        //}

        public ProxyImage(string name)
        {
            Name = name;
        }

        public void CompressImage()
        {
            Image = new Image();
            Image.ImageName = Name;
        }
    }
}
