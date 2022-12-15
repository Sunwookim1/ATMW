using ATMW.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMW.Forms
{
    public partial class ATMW_Main : Form
    {
        private void StartApiRequest()
        {
            foreach (SaveAPI value in SaveApiData)
            {
                if (value.ApiType == "RequestJSON1")
                {
                    ApiDefinit.RequestJSON1(value.DeviceId, value.WorkerId, value.Location, value.Time, value.Epc, value.Count, value.StockCount, value.InOutputCount);
                }
                else
                {
                    ApiDefinit.RequestJSON2(value.DeviceId, value.WorkerId, value.Location, value.Time, value.Epc, value.Count, value.StockCount, value.InOutputCount);
                }
            }
            SaveApiData.Clear();

            // ContinuetoApplyCheck false이면 한번 실행되고 타이머 종료
            if (!ContinuetoApplyCheck)
            {
                APITimer.Enabled = false;
            }
        }
    }

    public class SaveAPI
    {
        public string ApiType { get; set; }
        public string DeviceId { get; set; }
        public string WorkerId { get; set; }
        public int Location { get; set; }
        public string Time { get; set; }
        public string Epc { get; set; }
        public int Count { get; set; }
        public int StockCount { get; set; }
        public int InOutputCount { get; set; }

        //public int InputCount { get; set; }
        //public int OutputCount { get; set; }

        public SaveAPI(string ApiType, string DeviceId, string WorkerId, int Location, string Time, string Epc, int Count, int StockCount, int InOutputCount)
        {
            this.ApiType = ApiType;
            this.DeviceId = DeviceId;
            this.WorkerId = WorkerId;
            this.Location = Location;
            this.Time = Time;
            this.Epc = Epc;
            this.Count = Count;
            this.StockCount = StockCount;
            this.InOutputCount = InOutputCount;
        }
    }
}
