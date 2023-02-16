using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities
{
    public class ConverFileToByte
    {
        //convert IFromFile -> Bye[]
        public byte[] ConverFromFileToByte(IFormFile request)
        {
            byte[] ImageConvert;
            using (var ms = new MemoryStream())
            {
                request.CopyToAsync(ms);
                var FileByte = ms.ToArray();
                ImageConvert = FileByte;
            }
            return ImageConvert;
        }
    }
}
