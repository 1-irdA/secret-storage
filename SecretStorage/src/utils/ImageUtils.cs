﻿using System.Drawing;
using System.IO;

namespace SecretStorage.src.utils
{
    /// <summary>
    /// Image utils class
    /// </summary>
    public class ImageUtils
    {
        /// <summary>
        /// Convert an image in a bytes array with 
        /// the image location
        /// </summary>
        /// <param name="fileName">Image location</param>
        /// <returns>An array with bytes</returns>
        public static byte[] FromFileNameToBytes(string fileName)
        {
            byte[] encodedImage = null;

            if (File.Exists(fileName))
            {
                FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader binReader = new BinaryReader(stream);
                encodedImage = binReader.ReadBytes((int)stream.Length);
            }

            return encodedImage;
        }

        /// <summary>
        /// COnvert an array of bytes to an image
        /// </summary>
        /// <param name="toConvert">Bytes array to convert</param>
        /// <returns>An image</returns>
        public static Image FromBytesToImage(byte[] toConvert)
        {
            Image decodedImage = null;

            if (toConvert != null)
            {
                MemoryStream ms = new MemoryStream(toConvert);
                decodedImage = Image.FromStream(ms);
            }

            return decodedImage;
        }
    }
}
