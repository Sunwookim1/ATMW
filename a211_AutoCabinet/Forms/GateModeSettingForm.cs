using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Apulsetech.Rfid.Type.RFID.Untraceable;
using static Apulsetech.Rfid.Vendor.Chip.Impinj.Register;
using static ATMW.Forms.ATMW_Main;

namespace ATMW.Forms
{
    public partial class ATMW_Main : Form
    {
        public struct TagInfo
        {
            public string Port;
            public string Epc;
            public string Rssi;
            public int ReadingCount;
            public bool CountCheck;
            public TagInfo(string Port, string Epc, string Rssi)
            {
                this.Port = Port;
                this.Epc = Epc;
                this.Rssi = Rssi;
                this.ReadingCount = 0;
                this.CountCheck = false;
            }
        }

        private const int MAX_TAG_COUNT = 9999;
        private bool GateModeCheck = false;
        public List<TagInfo> TagInfoList = new List<TagInfo>();
        private bool GateMode_Port_Change = false;
        private int InfoCount = 0;

        // 태그가 과거에 읽혔는지 체크 한 후 
        // 태그가 과거 리스트에 존재하지 않을 경우 리스트에 저장 
        private void UpdateTagList(string port, string epc, string rssi)
        {
            if (GateModeCheck)
            {
                bool TagCheck = false;
                InfoCount = 0;
                TagInfo info = new TagInfo();
                for (int i = 0; i < TagInfoList.Count; i++)
                {
                    if (TagInfoList[i].Epc == epc)
                    {
                        InfoCount = i;
                        info = TagInfoList[i];
                        TagCheck = true;
                    }
                }

                // 리스트에 태그가 존재하지 않는다면
                // 리스트에 넣어주자
                if (!TagCheck)
                {
                    TagInfo newTag = new TagInfo(port, epc, rssi);
                    TagInfoList.Add(newTag);
                }
                // 리스트에 있는데 포트도 다르고 Rssi가 이전보다 크다면(음수) 리스트에 있는 리딩 카운트를 초기화 시켜주자
                else
                {
                    if (info.Port != port)
                    {
                        //Rssi를 넣으면 좀 애매해짐
                        if (info.ReadingCount < 3)
                        {
                            info.Port = port;
                            info.ReadingCount = 0;
                            TagInfoList[InfoCount] = info;
                        }
                        // 리딩 카운트가 3이상이면 
                        // 이미 읽혀진 태그이므로 
                        // 모든 포트를 하나의 포트로 보기때문에 현재 포트로 태그를 옮길필요가 없다.

                        if (info.ReadingCount >= 3)
                        {
                            GateMode_Port_Change = true;
                        }

                    }
                }
            }
        }

        // 다른 안테나에서도 읽혀도 같은 포트처럼 인식하기
        private bool Antenna_unification(string epc)
        {
            // 현재 읽힌 태그가 다른 포트에 읽혔는지 확인
            for (int i = 0; i < AntCount; i++)
            {
                // 동일 포트는 무시
                if (CurentPort != 0)
                {
                    if (g_TagBufferData[i, g_TagBufferCurLocationArray[i], 0].Contains(epc))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // 리딩 3번 카운트한 후 입출고 처리
        private bool ReadingCount(string epc)
        {
            if (GateModeCheck)
            {
                // cs1612 https://kindtis.tistory.com/591
                for (int i = 0; i < TagInfoList.Count; i++)
                {
                    if (TagInfoList[i].Epc == epc)
                    {
                        TagInfo info = TagInfoList[i];
                        info.ReadingCount++;
                        TagInfoList[i] = info;

                        if (TagInfoList[i].ReadingCount == 1)
                        {
                            // beep
                            mSoundUtil.PlayCountOneSound();
                        }

                        if (TagInfoList[i].ReadingCount == 2)
                        {
                            // beep
                            mSoundUtil.PlayCountTwoSound();
                        }

                        if (TagInfoList[i].ReadingCount == 3)
                        {
                            // beep
                            mSoundUtil.PlayCountThreeSound();
                            return true;
                        }
                        else if (TagInfoList[i].ReadingCount > 3)
                            return true;
                    }
                }

            }
            return false;
        }

        // 태그가 리딩되었다가 안되면 빠져나간 것으로 간주하고 
        // list에 등록된 태그 삭제.
        private void RemoveTagInfo(string Epc)
        {
            for (int i = 0; i < TagInfoList.Count; i++)
            {
                if (TagInfoList[i].Epc == Epc)
                {
                    TagInfo info = TagInfoList[i];
                    TagInfoList.Remove(info);
                }
            }
        }

        // 포트가 다른데 
        // 이전 데이터가 현재 데이터에도 읽혔을 경우
        // 출고처리하면 안댐
        // 입고처리도하면 안댐
        private bool PortandBufferCheck(int CurentPort, int CurrentBuffer)
        {
            if (GateModeCheck)
            {
                // 현재 포트의 현재 버퍼와 이전 포트(옮기기전)와 이전 버퍼를 비교하여 같은 데이터가 있고
                // 게이트 모드이면 
                for (int i = 0; i < g_TagBufferData[CurentPort, CurrentBuffer, 0].Length; i++)
                {
                    for (int j = 0; j < TagInfoList.Count; j++)
                    {
                        if (g_TagBufferData[CurentPort, CurrentBuffer, 0][0] == TagInfoList[j].Epc)
                        {
                            TagInfo info = TagInfoList[j];
                            info.Port = Convert.ToString(CurentPort);
                            TagInfoList[j] = info;

                            return true;
                        }
                    }
                    
                }
            }
            return false;
        }
        
    }
}
