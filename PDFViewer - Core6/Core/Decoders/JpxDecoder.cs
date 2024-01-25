using FreeImageAPI;
using System;
using System.Drawing;
using System.IO;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Filters;

namespace PDFViewer___Core6
{
    public class JpxDecoder : IPdfFilter
    {
        public string Name
        {
            get
            {
                return PdfFilterNames.JPXDecode;
            }
        }

        public byte[] Decode(PdfObject decodedObject, byte[] inputData, DecodeParameters decodeParameters)
        {
            using MemoryStream stream = new(inputData);
            using FreeImageBitmap bitmap = FreeImageBitmap.FromStream(stream);


            int width = decodedObject.Width;
            int height = decodedObject.Height;
            int pixelSize = (decodedObject.ColorSpace == ColorSpace.Gray) ? 1 : 3;
            byte[] result = new byte[width * height * pixelSize];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color pixel = bitmap.GetPixel(i, j);
                    int index = j * width + i;

                    if (decodedObject.ColorSpace == ColorSpace.Gray)
                    {
                        result[index] = (byte)(0.2126 * pixel.R + 0.7152 * pixel.G + 0.0722 * pixel.B);
                    }
                    else
                    {
                        result[index * 3] = pixel.R;
                        result[index * 3 + 1] = pixel.G;
                        result[index * 3 + 2] = pixel.B;
                    }
                }
            }

            return result;
        }

        public byte[] Encode(PdfObject encodedObject, byte[] inputData)
        {
            throw new NotImplementedException();
        }
    }
}
