using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SetTool
{
    public class JsonData
    {
        public static StringWriter JsonHandshake()      // 握手
        {
            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteValue("pc");
            writer.WritePropertyName("msg");
            writer.WriteValue(0xAABBCCDD);
            writer.WriteEndObject();
            writer.Flush();
            return sw;
        }

        public static StringWriter JsonLogin(string name,string passwd)      // 用户登录
        {
            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteValue(name);
            writer.WritePropertyName("passwd");
            writer.WriteValue(passwd);
            writer.WriteEndObject();
            writer.Flush();
            return sw;
        }

        public static StringWriter JsonDataSync()       // 数据同步
        {
            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartObject();
            writer.WritePropertyName("sync_data");
            writer.WriteValue("sync_from_gw");
            writer.WriteEndObject();
            writer.Flush();
            return sw;
        }

        public static StringWriter JsonSetSysInfo(string IP,string Mask,string Bcast,string Mac,
            string Permit,string Authority,string IPMode,string Version,string User,string Passwd)     // 设置网关信息
        {
            StringWriter sw = new StringWriter();
            StringWriter sw0 = new StringWriter();
            JsonWriter writer0 = new JsonTextWriter(sw0);
            writer0.WriteStartObject();
            writer0.WritePropertyName("ip");
            writer0.WriteValue(IP);
            writer0.WritePropertyName("mask");
            writer0.WriteValue(Mask);
            writer0.WritePropertyName("bcast");
            writer0.WriteValue(Bcast);
            writer0.WritePropertyName("mac");
            writer0.WriteValue(Mac);
            writer0.WritePropertyName("pro_info");
            writer0.WriteValue(Permit);
            writer0.WritePropertyName("authority");
            writer0.WriteValue(Authority);
            writer0.WritePropertyName("ip_mode");
            writer0.WriteValue(IPMode);
            writer0.WritePropertyName("version");
            writer0.WriteValue(Version);
            writer0.WritePropertyName("name");
            writer0.WriteValue(User);
            writer0.WritePropertyName("passwd");
            writer0.WriteValue(Passwd);
            writer0.WriteEndObject();
            writer0.Flush();
            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartObject();
            writer.WritePropertyName("request_id");
            writer.WriteValue("");
            writer.WritePropertyName("set_gateway_info");
            writer.WriteRawValue(sw0.ToString());
            writer.WriteEndObject();
            writer.Flush();
            return sw;
        }

        public static StringWriter JsonGetSysInfo()     // 获取网关信息
        {
            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartObject();
            writer.WritePropertyName("request_id");
            writer.WriteValue("");
            writer.WritePropertyName("get_gateway_info");
            writer.WriteValue("yes");
            writer.WriteEndObject();
            writer.Flush();
            return sw;
        }

        public static StringWriter JsonUpdate(string UpdateType,int FileLength)     // 软件更新
        {
            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartObject();
            writer.WritePropertyName("req_update");
            writer.WriteValue(UpdateType);
            writer.WritePropertyName("file_len");
            writer.WriteValue(FileLength);
            writer.WriteEndObject();
            writer.Flush();
            return sw;
        }

        public static StringWriter JsonRefactory()      // 恢复出厂设置
        {
            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartObject();
            writer.WritePropertyName("req_refactory");
            writer.WriteValue("yes");
            writer.WriteEndObject();
            writer.Flush();
            return sw;
        }

        public static StringWriter JsonReboot()     // 系统重启
        {
            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartObject();
            writer.WritePropertyName("sys_reboot");
            writer.WriteValue("yes");
            writer.WriteEndObject();
            writer.Flush();
            return sw;
        }
    }
}
