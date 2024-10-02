using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wintestplc2
{
   public class ClassGeneral
    {
      public  static  void logError(string filePath,string message,string stackTrace)
        {
           
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"[{DateTime.Now}] خطا: {message}");
                writer.WriteLine(stackTrace);
                writer.WriteLine(message);
            }
        }
       public  static ushort ConvertHexAddressToDecimal(string hexAddress)
        {

            int decimalAddress = int.Parse(hexAddress, System.Globalization.NumberStyles.HexNumber);

            int baseAddress;
            int blockSize = 256;
            int registerAddress;

            if (decimalAddress >= 0x1000 && decimalAddress <= 0x1FFF)
            {
                baseAddress = 0x1000;
                int blockNumber = (decimalAddress - baseAddress) / 0x100;
                int offsetWithinBlock = (decimalAddress - baseAddress) % 0x100;
                registerAddress = blockNumber * blockSize + offsetWithinBlock;
            }
            else if (decimalAddress >= 0x9000 && decimalAddress <= 0x9FFF)
            {
                baseAddress = 0x9000;
                int blockNumber = (decimalAddress - baseAddress) / 0x100;
                int offsetWithinBlock = (decimalAddress - baseAddress) % 0x100;
                registerAddress = 4096 + blockNumber * blockSize + offsetWithinBlock;
            }
            else if (decimalAddress >= 0xA000 && decimalAddress <= 0xA70F)
            {
                baseAddress = 0xA000;
                int blockNumber = (decimalAddress - baseAddress) / 0x100;
                int offsetWithinBlock = (decimalAddress - baseAddress) % 0x100;
                registerAddress = 8192 + blockNumber * blockSize + offsetWithinBlock;
            }
            else
            {
                throw new ArgumentOutOfRangeException("آدرس هگزادسیمال خارج از محدوده معتبر است.");
            }

            return (ushort)registerAddress;
        }
    }
}
