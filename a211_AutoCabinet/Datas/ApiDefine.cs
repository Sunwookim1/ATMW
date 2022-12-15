using ATMW.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Apulsetech.Remote.Type.RemoteDevice;
using System.Windows.Forms;

namespace ATMW.Datas
{
    public class ApiDefinit
    {
        public static string GsUri { get; set; }
        public static string ApiUri { get; set; }
        public static string DeviceId { get; set; }
        public static string DeviceName { get; set; }
        public static bool NetWorkModeCheck { get; set; }

        // 인벤토리 스탑 때마다 태그 리스트 업데이트하기 위한 이벤트
        public delegate void GetTagList(string[] str);
        public static event GetTagList GetTagListEvent;


        // 디바이스 존재 여부 확인 API
        public static bool DeviceIdRequest()
        {
            HttpWebRequest wReq;
            HttpWebResponse wResp;
            Uri uri = new Uri(ApiDefinit.GsUri + "/alertDeviceStartEvent/" + DeviceId);
            wReq = (HttpWebRequest)WebRequest.Create(uri);
            wReq.Method = "GET";


            wResp = (HttpWebResponse)wReq.GetResponse();
            using (StreamReader streamReader = new StreamReader(wResp.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();

                switch (result)
                {
                    case "true":
                        return true;
                    case "false":
                        return false;
                    default:
                        return false;
                }
            }

        }

        public static void RequestJSON2(string DeviceId, string WorkerId, int Location, string Time, string Epc, int Count, int StockCount, int OutputCount)
        {
            JObject JSonData = new JObject();
            JSonData.Add("DEVICE_ID", DeviceId);
            JSonData.Add("WORKER_ID", WorkerId);
            JSonData.Add("LOCATION", Location);
            JSonData.Add("DATE_TIME", Time);
            JSonData.Add("EPC", Epc);
            JSonData.Add("COUNT", Count);
            JSonData.Add("STOCK_COUNT", StockCount);
            JSonData.Add("OUTPUT_COUNT", OutputCount);

            HttpWebRequest wReq;
            HttpWebResponse wResp;
            Uri uri = new Uri(ApiDefinit.GsUri + "/alertOutputEvent");
            wReq = (HttpWebRequest)WebRequest.Create(uri);
            wReq.Method = "POST";
            wReq.ContentType = "application/json";
            wReq.ContentLength = JSonData.ToString().Length;

            using (StreamWriter streamWriter = new StreamWriter(wReq.GetRequestStream()))
            {
                streamWriter.Write(JSonData.ToString());
            }

            try
            {
                wResp = (HttpWebResponse)wReq.GetResponse();
                using (StreamReader streamReader = new StreamReader(wResp.GetResponseStream()))
                {
                    string result = streamReader.ReadToEnd();
                }
            }
            catch (WebException wex)
            {
                var pageContent = new StreamReader(wex.Response.GetResponseStream())
                                      .ReadToEnd();
            }

        }

        public static void RequestJSON1(string DeviceId, string WorkerId, int Location, string Time, string Epc, int Count, int StockCount, int InputCount)
        {
            JObject JSonData = new JObject();
            JSonData.Add("DEVICE_ID", DeviceId);
            JSonData.Add("WORKER_ID", WorkerId);
            JSonData.Add("LOCATION", Location);
            JSonData.Add("DATE_TIME", Time);
            JSonData.Add("EPC", Epc);
            JSonData.Add("COUNT", Count);
            JSonData.Add("STOCK_COUNT", StockCount);
            JSonData.Add("INPUT_COUNT", InputCount);

            HttpWebRequest wReq;
            HttpWebResponse wResp;
            Uri uri = new Uri(ApiDefinit.GsUri + "/alertInputEvent");
            wReq = (HttpWebRequest)WebRequest.Create(uri);
            wReq.Method = "POST";
            wReq.ContentType = "application/json";
            wReq.ContentLength = JSonData.ToString().Length;

            using (StreamWriter streamWriter = new StreamWriter(wReq.GetRequestStream()))
            {
                streamWriter.Write(JSonData.ToString());
            }

            try
            {
                wResp = (HttpWebResponse)wReq.GetResponse();
                using (StreamReader streamReader = new StreamReader(wResp.GetResponseStream()))
                {
                    string result = streamReader.ReadToEnd();
                }
            }
            catch (WebException wex)
            {
                var pageContent = new StreamReader(wex.Response.GetResponseStream())
                                      .ReadToEnd();
            }

        }

        // Row Column 값 보내기
        public static bool RequestUpdateColRowNum(string DeviceId, string Row, string Column)
        {
            ResponseUpdateColRowNum responseUpdateJson;

            JObject JsonData = new JObject();
            JsonData.Add("DEVICE_ID", DeviceId);
            JsonData.Add("COL_NUM", Convert.ToInt32(Column));
            JsonData.Add("ROW_NUM", Convert.ToInt32(Row));
            string result = string.Empty;

            HttpWebRequest wReq;
            HttpWebResponse wRes;
            Uri uri = new Uri(ApiDefinit.ApiUri + "/mwCon/updateColRowNum");
            wReq = (HttpWebRequest)WebRequest.Create(uri);
            wReq.Method = "POST";
            wReq.ContentType = "application/json";
            wReq.ContentLength = JsonData.ToString().Length;

            using (StreamWriter streamwriter = new StreamWriter(wReq.GetRequestStream()))
            {
                streamwriter.Write(JsonData.ToString());
            }

            try
            {
                wRes = (HttpWebResponse)wReq.GetResponse();
                using (StreamReader streamreader = new StreamReader(wRes.GetResponseStream()))
                {
                    result = streamreader.ReadToEnd();
                }

                JObject obj = JObject.Parse(result);

                string objstring = obj.ToString();

                responseUpdateJson = new ResponseUpdateColRowNum();
                responseUpdateJson = JsonConvert.DeserializeObject<ResponseUpdateColRowNum>(objstring);

                switch (Convert.ToInt32(responseUpdateJson.code))
                {
                    case 200:
                        return true;
                    case 204:
                        MessageBox.Show("UpdateRowColumn - Failed 204");
                        return false;
                }

            }
            catch (WebException wex)
            {
                var pageContent = new StreamReader(wex.Response.GetResponseStream())
                                     .ReadToEnd();
                MessageBox.Show(pageContent.ToString());
            }
            return false;
        }

        public static void ReqeustTagList()
        {
            HttpWebRequest wReq;
            HttpWebResponse wResp;
            string result = string.Empty;
            Uri uri = new Uri(ApiDefinit.ApiUri + "/mwCon/getTag");
            wReq = (HttpWebRequest)WebRequest.Create(uri);
            wReq.Method = "GET";

            // 요청 데이터 받기
            try
            {
                wResp = (HttpWebResponse)wReq.GetResponse();
                using (StreamReader streamReader = new StreamReader(wResp.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                //json파싱
                JObject obj = JObject.Parse(result);
                string objstring = obj.ToString();

                ResponseJson responseJson = new ResponseJson();
                responseJson = JsonConvert.DeserializeObject<ResponseJson>(objstring);

                string[] TagListArr = new string[responseJson.dataList.Count];
                int count = 0;
                foreach (ValueJson TagData in responseJson.dataList)
                {
                    TagListArr[count] = TagData.TAG;
                    count++;
                }
                if (TagListArr != null)
                    GetTagListEvent(TagListArr);
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Status.ToString());
            }
        }


        // 하트비트 검사
        public static void RequestHartBit(string DeviceId, string DateTime)
        {
            if (SharedValues.Reader.GetConnectionStatus())
            {
                JObject JsonData = new JObject();
                JsonData.Add("DEVICE_ID", DeviceId);
                JsonData.Add("DATE_TIME", DateTime);

                HttpWebRequest wReq;
                Uri uri = new Uri(ApiDefinit.GsUri + "/alertDeviceConnected");
                wReq = (HttpWebRequest)WebRequest.Create(uri);
                wReq.Method = "POST";
                wReq.ContentType = "application/json";
                wReq.ContentLength = JsonData.ToString().Length;

                using (StreamWriter streamwriter = new StreamWriter(wReq.GetRequestStream()))
                {
                    streamwriter.Write(JsonData.ToString());
                }
            }
        }
    }

    public class ResponseJson
    {
        public string code;
        public string message;
        public List<ValueJson> dataList;
    }

    public class ResponseUpdateColRowNum
    {
        public string code;
        public string message;
        public string data;
    }

    public class ValueJson
    {
        public string TAG;
    }

}



