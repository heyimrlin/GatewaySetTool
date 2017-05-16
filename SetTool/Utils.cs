using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace SetTool
{
    public class Utils
    {
        public static uint  CRC16(byte[] modbusdata)
        {
            uint crc16 = 0xffff;
            int length = modbusdata.Length;
            for (uint i = 0; i < length; i++)
            {
                crc16 ^= modbusdata[i];
                for (uint j = 0; j < 8; j++)
                {
                    if ((crc16 & 0x01) == 1)
                    {
                        crc16 = (crc16 >> 1) ^ 0xA001;
                    }
                    else
                    {
                        crc16 = crc16 >> 1;
                    }
                }
            }
            return crc16;
        }

        public static byte[] parseData(string DataType, StringWriter sw)
        {
            string head = "B8480000" + DataType;

            string jsonText = sw.GetStringBuilder().ToString();
            string jsonLen = "0000" + Convert.ToString(jsonText.Length, 16);
            jsonLen = jsonLen.Substring(jsonLen.Length - 4);
            jsonLen = jsonLen.ToUpper();

            byte[] DByte = HexstrToByte(head + jsonLen);

            byte[] JByte = Encoding.Default.GetBytes(jsonText);

            byte[] DJByte = new byte[DByte.Length + JByte.Length];
            DByte.CopyTo(DJByte, 0);
            JByte.CopyTo(DJByte, DByte.Length);

            string checksum = "0000" + Convert.ToString(Utils.CRC16(DJByte), 16);
            checksum = checksum.Substring(checksum.Length - 4);
            checksum = checksum.ToUpper();

            byte[] CKByte = HexstrToByte(checksum);

            byte[] result = new byte[DJByte.Length+CKByte.Length];
            DJByte.CopyTo(result, 0);
            CKByte.CopyTo(result, DJByte.Length);

            return result;
        }

        public static byte[] parseData(string DataType, byte[] FileBytes)
        {
            string head = "B8480000" + DataType;

            string fileLen = "0000" + Convert.ToString(FileBytes.Length, 16);
            fileLen = fileLen.Substring(fileLen.Length - 4);
            fileLen = fileLen.ToUpper();

            byte[] DByte = HexstrToByte(head + fileLen);

            byte[] DFByte = new byte[DByte.Length + FileBytes.Length];
            DByte.CopyTo(DFByte, 0);
            FileBytes.CopyTo(DFByte, DByte.Length);

            string checksum = "0000" + Convert.ToString(Utils.CRC16(DFByte), 16);
            checksum = checksum.Substring(checksum.Length - 4);
            checksum = checksum.ToUpper();

            byte[] CKByte = HexstrToByte(checksum);

            byte[] result = new byte[DFByte.Length + CKByte.Length];
            DFByte.CopyTo(result, 0);
            CKByte.CopyTo(result, DFByte.Length);

            return result;
        }

        public static byte[] HexstrToByte(string data)
        {
            int len = (data.Length) / 2;
            byte[] result = new byte[len];
            for (int i = 0; i < len; i++)
            {
                result[i] = Convert.ToByte(data.Substring(i * 2, 2), 16);
            }
            return result;
        }

        public static JObject analysisData(byte[] data)
        {
            try
            {
                string msg = BitConverter.ToString(data).Replace("-", "");
                string head = msg.Substring(0, 4);
                string type = msg.Substring(8, 2);
                int length = Convert.ToInt16(msg.Substring(10, 4), 16);
                string jsonText = Encoding.Default.GetString(data, 7, length);

                JObject JO = JObject.Parse(jsonText);
                return JO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示");
                return null;
            }
        }
    }
}
