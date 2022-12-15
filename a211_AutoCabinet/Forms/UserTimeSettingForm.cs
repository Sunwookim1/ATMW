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
    public partial class UserTimeSettingForm : Form
    {

        public delegate void SettingUpdateDateTime(DateTime DateTime, bool ApplyCheck);
        public event SettingUpdateDateTime UpdateDateTime;

        public delegate void SettingContinueDateTime(int TimeInterval, bool ApplyCheck);
        public event SettingContinueDateTime UpdateContinueDateTime;

        private bool ContinuetoApplyCheck = false;


        public UserTimeSettingForm()
        {
            InitializeComponent();
            InitDateTimePicker();
            checkBox3.Checked = true;
        }

        private void InitDateTimePicker()
        {
            // 년월일 세팅
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";

            // 시분초 세팅
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "tt hh:mm:ss";
            dateTimePicker2.ShowUpDown = true;
        }

        private void btnTimeSetting_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                try
                {
                    string YearFormat = dateTimePicker1.Value.Year.ToString().Length < 2 ? "0" + dateTimePicker1.Value.Year.ToString() : dateTimePicker1.Value.Year.ToString();
                    string MonthFormat = dateTimePicker1.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker1.Value.Month.ToString() : dateTimePicker1.Value.Month.ToString();
                    string DayFormat = dateTimePicker1.Value.Day.ToString().Length < 2 ? "0" + dateTimePicker1.Value.Day.ToString() : dateTimePicker1.Value.Day.ToString();
                    string HourForamt = dateTimePicker2.Value.Hour.ToString().Length < 2 ? "0" + dateTimePicker2.Value.Hour.ToString() : dateTimePicker2.Value.Hour.ToString();
                    string MinuteForamt = dateTimePicker2.Value.Minute.ToString().Length < 2 ? "0" + dateTimePicker2.Value.Minute.ToString() : dateTimePicker2.Value.Minute.ToString();
                    string SecondForamt = dateTimePicker2.Value.Second.ToString().Length < 2 ? "0" + dateTimePicker2.Value.Second.ToString() : dateTimePicker2.Value.Second.ToString();

                    string DateTimePickerValue =
                        YearFormat +
                        MonthFormat +
                        DayFormat +
                        HourForamt +
                        MinuteForamt +
                        SecondForamt;

                    DateTime SettingDateTime = DateTime.ParseExact(DateTimePickerValue, "yyyyMMddHHmmss", null);
                    ContinuetoApplyCheck = false;

                    UpdateDateTime(SettingDateTime, ContinuetoApplyCheck);

                    MessageBox.Show(Properties.Resources.StringAntSave);

                    Close();
                }
                catch
                {
                    MessageBox.Show(Properties.Resources.StringErrorSettingDateTime);
                }
            }
            else if (checkBox3.Checked == true)
            {
                try
                {
                    //시 -> 분 -> 초 -> 밀리초(1/1000)
                    int HourtoMiliSec = Convert.ToInt32(textBox2.Text);

                    // 1. 시 == 60분
                    HourtoMiliSec = HourtoMiliSec * 60;

                    // 2. 분 == 60초
                    HourtoMiliSec = HourtoMiliSec * 60;

                    // 3. 초 == 1000밀리초
                    HourtoMiliSec = HourtoMiliSec * 1000;

                    //분-> 초 -> 밀리초
                    int MintoMiliSec = Convert.ToInt32(textBox3.Text);

                    MintoMiliSec = MintoMiliSec * 60;

                    MintoMiliSec = MintoMiliSec * 1000;

                    //초 -> 밀리초
                    int SectoMiliSec = Convert.ToInt32(textBox5.Text);

                    SectoMiliSec = SectoMiliSec * 1000;


                    int TotalMiliSec = HourtoMiliSec + MintoMiliSec + SectoMiliSec;

                    ContinuetoApplyCheck = true;

                    UpdateContinueDateTime(TotalMiliSec, ContinuetoApplyCheck);

                    MessageBox.Show(Properties.Resources.StringAntSave);

                    Close();
                }
                catch
                {
                    MessageBox.Show(Properties.Resources.StringErrorSettingDateTime);
                }
            }
        }

        private void UserTimeSettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true && checkBox3.Checked == true)
            {
                checkBox3.Checked = false;
            }

            if (checkBox2.Checked == true)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;

                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox5.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true && checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }

            if (checkBox3.Checked == true)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;

                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox5.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) // 숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) // 숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) // 숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "00";
            }
            else
            {
                // 텍스트 길이가 2보다 작을때
                if (textBox2.Text.Length < 2)
                    textBox2.Text = "0" + textBox2.Text;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "00";
            }
            else
            {
                // 텍스트 길이가 2보다 작을때
                if (textBox3.Text.Length < 2)
                    textBox3.Text = "0" + textBox3.Text;
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "00";
            }
            else
            {
                // 텍스트 길이가 2보다 작을때
                if (textBox5.Text.Length < 2)
                    textBox5.Text = "0" + textBox5.Text;
            }
        }
    }
}
