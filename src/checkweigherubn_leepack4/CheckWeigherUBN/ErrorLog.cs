/*==============================================================================
**                              CheckWeigherUBN
**                            Copyright 2016
**------------------------------------------------------------------------------
** Supported PLCs      : Mitsubishi
** Supported Compilers : Compiler independent (GxWorks3, Visual Studio 2017)
**------------------------------------------------------------------------------
** File name         : ErrorLog.cs
**
** Module name       : CheckWeigherUBN
**
**
** Summary: 
**
**= History ====================================================================
** 01.00 15/03/2019 dungvt
** - Creation
===============================================================================*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GlacialComponents.Controls;
using OfficeOpenXml;
using CheckWeigherUBN.Objects;
using static CheckWeigherUBN.Objects.AlarmContent;

namespace CheckWeigherUBN
{
  public partial class ErrorLog : UserControl
  {
    public delegate void RequestAlarmReset(object sender);
    public event RequestAlarmReset OnRequestAlarmReset;

    public delegate void SendErrorDisplay(bool isVisible, string content, string tiltle);
    public event SendErrorDisplay OnSendErrorDisplay;
    //

    private const int COL_ID = 0;
    private const int COL_ERROR_CODE = COL_ID + 1;
    private const int COL_ERROR_DESCRIPTION = COL_ERROR_CODE + 1;
    private const int COL_DATE_TIME = COL_ERROR_DESCRIPTION + 1;

    //
    private ConfigurationTypes _configuration = null;
    private int _error_code_previous = -1;
    private int _warning_code_previous = -1;

    private Timer _delay_timer = new Timer();
    public ErrorLog()
    {
      InitializeComponent();
      //
      this._delay_timer.Interval = 1000;
      this._delay_timer.Tick += _delay_timer_Tick;
    }

    private void _delay_timer_Tick(object sender, EventArgs e)
    {
      this._delay_timer.Enabled = false;
      DateTime dt = Utils.GetDateTimeFromClockByShift();
      eShift shift = Shift.GetShiftFromClock();
     // DisplayAlarmToListView(dt, shift, _configuration.TemplatePath, _configuration.DatabasePath);
    }

    /// <summary>
    /// Update configuration from main
    /// </summary>
    /// <param name="configuration"></param>
    public void UpdateConfiguration(ConfigurationTypes configuration)
    {
      _configuration = configuration;
      //load from database
      this._delay_timer.Enabled = true;
    }
    private void AddWarningLogToListView(bool currentWarning, bool previousWarning, eWarningType eWarningCode)
    {
    //  if (currentWarning != previousWarning)
    //  {
    //    string warning_code = ((int)(eWarningCode) + 1).ToString().PadLeft(3, '0');
    //    string description = "";
    //    if (eWarningCode == eWarningType.Warning_Box_Fail)
    //    {
    //      description = "Warning 00: Cảnh báo lỗi túi";
    //    }
    //    else if (eWarningCode == eWarningType.Warining_Save_Power_Mode) //M1033
    //    {
    //      description = "Warning 01: Trạng thái chờ"; // Warning 01: Cảnh báo Không có túi ở băng tải đầu vào
				//}
    //    else if (eWarningCode == eWarningType.Warning_DYN_Fail)
    //    {
    //      description = "Warning 02: Cân động bị lỗi";
    //    }
    //    else if (eWarningCode == eWarningType.Warning_LD_front)
    //    {
    //      description = "Warning 03: Tạm dừng do máy phía sau";
    //    }
    //    else if (eWarningCode == eWarningType.Warning_LD_Behind)
    //    {
    //      description = "Warning 04: Tạm dừng do máy phía trước";
    //    }
    //    else if (eWarningCode == eWarningType.Warning_31)
    //    {
    //      description = "Warning 05: Cảnh báo sensor đầu vào băng tải infeed bị che hoặc hư";
    //    }
				//else if (eWarningCode == eWarningType.Warning_06)
				//{
				//	description = "Warning 06: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_07)
    //    {
    //      description = "Warning 07: ";
    //    }
				//else if (eWarningCode == eWarningType.Warning_08)
				//{
				//	description = "Warning 08: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_09)
				//{
				//	description = "Warning 09: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_10)
				//{
				//	description = "Warning 10: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_11)
				//{
				//	description = "Warning 11: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_12)
				//{
				//	description = "Warning 12: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_13)
				//{
				//	description = "Warning 13: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_14)
				//{
				//	description = "Warning 14: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_15)
				//{
				//	description = "Warning 15: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_16)
				//{
				//	description = "Warning 16: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_17)
				//{
				//	description = "Warning 17: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_18)
				//{
				//	description = "Warning 18: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_19)
				//{
				//	description = "Warning 19: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_20)
				//{
				//	description = "Warning 20: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_21)
				//{
				//	description = "Warning 21: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_22)
				//{
				//	description = "Warning 22: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_23)
				//{
				//	description = "Warning 23: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_24)
				//{
				//	description = "Warning 24: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_25)
				//{
				//	description = "Warning 25: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_26)
				//{
				//	description = "Warning 26: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_27)
				//{
				//	description = "Warning 27: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_28)
				//{
				//	description = "Warning 28: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_29)
				//{
				//	description = "Warning 29: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_30)
				//{
				//	description = "Warning 30: ";
				//}
				//else if (eWarningCode == eWarningType.Warning_31)
				//{
				//	description = "Warning 31: ";
				//}



				////
				//if (description != "")
    //    {
    //      bool IsFound = false;
    //      for (int i = 0; (i < this.glacialList1.Items.Count) && (IsFound == false); i++)
    //      {
    //        IsFound = (this.glacialList1.Items[i].SubItems[COL_ERROR_CODE].Text == warning_code);
    //      }

    //      if (IsFound == false)
    //      {            
    //        /* Check if we already added */
    //        GLItem item = new GLItem();
    //        item.SubItems[COL_ID].Text = (this.glacialList1.Items.Count + 1).ToString();
    //        item.SubItems[COL_ERROR_CODE].Text = String.Format("{0}", warning_code);
    //        item.SubItems[COL_ERROR_DESCRIPTION].Text = description;
    //        item.SubItems[COL_DATE_TIME].Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
    //        this.glacialList1.Items.Insert(0, item);
    //      }
    //    }
    //  }/*if (currentError != previousError)*/
    }



    public List<AlarmType> DisplayAlarmToListView(DateTime dt, eShift shift, string templatePath, string databasePath, ConfigurationTypes configuration)
    {
      _configuration = configuration;
      //DateTime dt = Convert.ToDateTime(dateTimePicker3.Text);
      //eShift shift = (eShift)(cbShift.SelectedIndex);
      //
      AlarmDB sql = new AlarmDB(templatePath, databasePath, false);
      List<AlarmType> alarms = new List<AlarmType>();
      if (shift == eShift.SHIFT_ALL)
      {
        alarms = sql.LoadAllByDateTime(dt);
      }
      else
      {
        alarms = sql.LoadAllByDateShift(dt, (int)(shift));
      }

      alarms = alarms?.OrderByDescending(x => x.id).ToList();
      dataGridView1.DataSource = alarms;
      FormatDGV();
      //foreach (var item in alarms)
      //{
      //  int rowIndex = dataGridView1.Rows.Add();
      //  dataGridView1.Rows[rowIndex].Cells["Column1"].Value = item.id;
      //  dataGridView1.Rows[rowIndex].Cells["Column2"].Value = item.AlarmCode;
      //  dataGridView1.Rows[rowIndex].Cells["Column3"].Value = item.DateTime;
      //  dataGridView1.Rows[rowIndex].Cells["Column4"].Value = item.Description;

      //}


      //this.glacialList1.Items.Clear();
      //foreach (AlarmType alarm in alarms)
      //{
      //  GLItem item = new GLItem();

      //  item.SubItems[COL_ID].Text = alarm.id.ToString();
      //  item.SubItems[COL_ERROR_CODE].Text = alarm.AlarmCode.ToString();
      //  item.SubItems[COL_ERROR_DESCRIPTION].Text = alarm.Description;
      //  item.SubItems[COL_DATE_TIME].Text = alarm.DateTime;
      //  //
      //  this.glacialList1.Items.Insert(0, item);
      //}
      //this.glacialList1.Refresh();
      return alarms;

    }

    private void UpdateDataWarningCode(PLCFx5U_RawData rawdata, PLC_MachineData machineData)
    {
      //int warning_code = machineData.PLC_WarningCode.value.Convert_to_Int();
      ////
      //if (warning_code == 0)  /* No error --> clear request */
      //{
      //  if (this.glacialList1.Items.Count > 0)
      //  {
      //    this.glacialList1.Items.Clear();
      //    //save to _warning_code_previous
      //    _warning_code_previous = warning_code;
      //    this.glacialList1.Refresh();
      //  }
      //}
      //else
      //{
      //  if (_warning_code_previous != warning_code)
      //  {
      //    for (int i = 0; i < (int)eWarningType.End; i++)
      //    {
      //      bool current_warning = warning_code.ToBoolean(i);
      //      bool previous_warning = _warning_code_previous.ToBoolean(i);
      //      //
      //      AddWarningLogToListView(current_warning, previous_warning, (eWarningType)(i));
      //    }
      //    //
      //    this.glacialList1.Refresh();
      //    //
      //    //save to _error_code_previous
      //    _warning_code_previous = warning_code;
      //  }

      //}
    }


    //private void Add
    /// <param name="machineData"></param>
    public void UpdateData(PLCFx5U_RawData rawdata, PLC_MachineData machineData)
    {
      UpdateDataErrorCodeAndWarningCode(rawdata, machineData);
      //UpdateDataWarningCode(rawdata, machineData);
    }

    //private void btAlarmReset_Click(object sender, EventArgs e)
    //{
    //  if (OnRequestAlarmReset != null)
    //  {
    //    OnRequestAlarmReset(this);
    //  }
    //}

    private void btAlarmReset_1_Click(object sender, EventArgs e)
    {
        if (OnRequestAlarmReset != null)
        {
            OnRequestAlarmReset(this);
        }
    }


    private AlarmType[] all_errors_current = new AlarmType[20];
    private List<AlarmType> all_showing_errors_current = new List<AlarmType>();

    private int _lastValueCounter = -1;
    private int _offsetRead = -1;
    private int _latestErrorId = 0;
    public int offsetCnt = 0;
    private string title = "";

    private void UpdateDataErrorCodeAndWarningCode(PLCFx5U_RawData rawdata, PLC_MachineData machineData)
    {
      if (_latestErrorId <= 0) _latestErrorId = _lastValueCounter;
      // Kiểm tra log db error
      int counterError = machineData.Buffer_Counter.value.Convert_to_Int();
      if (counterError <= 0)
      {
        //save cnt last
        _configuration.IDcounterAlarm = counterError;
        ConfigurationDB configurationDB = new ConfigurationDB();
        configurationDB.Save(_configuration);
        _lastValueCounter = 0;

        //return;
      }
      AlarmType AlarmDisPlayName = null;
      //Error code
      int ErrorCode1 = machineData.PLC_Error_Buffer1.value.Convert_to_Int();
      int ErrorCode2 = machineData.PLC_Error_Buffer2.value.Convert_to_Int();
      int ErrorCode3 = machineData.PLC_Error_Buffer3.value.Convert_to_Int();
      int ErrorCode4 = machineData.PLC_Error_Buffer4.value.Convert_to_Int();
      int ErrorCode5 = machineData.PLC_Error_Buffer5.value.Convert_to_Int();
      int ErrorCode6 = machineData.PLC_Error_Buffer6.value.Convert_to_Int();
      int ErrorCode7 = machineData.PLC_Error_Buffer7.value.Convert_to_Int();
      int ErrorCode8 = machineData.PLC_Error_Buffer8.value.Convert_to_Int();
      int ErrorCode9 = machineData.PLC_Error_Buffer9.value.Convert_to_Int();
      int ErrorCode10 = machineData.PLC_Error_Buffer10.value.Convert_to_Int();
      List<int> ListErrorCodes = new List<int> { ErrorCode1, ErrorCode2, ErrorCode3 , ErrorCode4 , ErrorCode5,
                                                 ErrorCode6, ErrorCode7, ErrorCode8 , ErrorCode9 , ErrorCode10};

      //Warining code 
      int WarningCode1 = machineData.PLC_Warning_Buffer1.value.Convert_to_Int();
      int WarningCode2 = machineData.PLC_Warning_Buffer2.value.Convert_to_Int();
      int WarningCode3 = machineData.PLC_Warning_Buffer3.value.Convert_to_Int();
      int WarningCode4 = machineData.PLC_Warning_Buffer4.value.Convert_to_Int();
      int WarningCode5 = machineData.PLC_Warning_Buffer5.value.Convert_to_Int();
      int WarningCode6 = machineData.PLC_Warning_Buffer6.value.Convert_to_Int();
      int WarningCode7 = machineData.PLC_Warning_Buffer7.value.Convert_to_Int();
      int WarningCode8 = machineData.PLC_Warning_Buffer8.value.Convert_to_Int();
      int WarningCode9 = machineData.PLC_Warning_Buffer9.value.Convert_to_Int();
      int WarningCode10 = machineData.PLC_Warning_Buffer10.value.Convert_to_Int();

      List<int> ListWarningCodes = new List<int> { WarningCode1, WarningCode2, WarningCode3 , WarningCode4 , WarningCode5,
                                                 WarningCode6, WarningCode7, WarningCode8 , WarningCode9 , WarningCode10};
      //Lấy thông tin bảng mapping lỗi dưới DB
      List<AlarmContent> alarmContentsDB = _configuration.list_AlarmContent;
      int stt_err = _latestErrorId <= 0 ? 0 : _latestErrorId;


      for (int i = 9; i >= 0; i--)
      {
        //Warning
        var warningContent = alarmContentsDB.FirstOrDefault(s => s.ValuePLC == ListWarningCodes[i] && s.tyleAlarm == eTypeAlarm.warning.ToString());
        AlarmType warning = null;
        if (warningContent != null)
        {
          warning = CreateAlarm(warningContent.ValuePLC, warningContent.Code, warningContent.Description, warningContent.Solve, stt_err);


          if (all_errors_current[i] == null || all_errors_current[i].AlarmCode != warning.AlarmCode)
            all_errors_current[i] = warning;
          all_errors_current[i].id = stt_err--;
          if (warningContent.isDisplay.ToLower() == "true")
          {
            AlarmDisPlayName = warning;
            title = $"Warning: {warning.AlarmCode}";
          }

        }
        else
        {
          all_errors_current[i] = new AlarmType();

        }
      }

      for (int i = 9; i >= 0; i--)
      {
        //Error

        AlarmType error_alarm = null;
        var alarmContent = alarmContentsDB.FirstOrDefault(s => s.ValuePLC == ListErrorCodes[i] && s.tyleAlarm == eTypeAlarm.error.ToString());
        if (alarmContent != null)
        {
          error_alarm = CreateAlarm(alarmContent.ValuePLC, alarmContent.Code, alarmContent.Description, alarmContent.Solve, stt_err);

          if (all_errors_current[i + 10] == null || all_errors_current[i + 10].AlarmCode != error_alarm.AlarmCode)
            all_errors_current[i + 10] = error_alarm;
          all_errors_current[i + 10].id = stt_err--;
          if (alarmContent.isDisplay.ToLower() == "true")
          {
            AlarmDisPlayName = error_alarm;
            title = $"{error_alarm.AlarmCode}";
          }
        }
        else
        {
          all_errors_current[i + 10] = new AlarmType();
        }
      }


      if (AlarmDisPlayName != null && AlarmDisPlayName.Description.Trim() != "")
      {
        OnSendErrorDisplay?.Invoke(true, AlarmDisPlayName.Description, title);
      }
      else
      {
        OnSendErrorDisplay?.Invoke(false, "", "");
      }

      dataGridView1.DataSource = null;
      //all_showing_errors_current = all_errors_current.Where(x => x.id > 0).OrderByDescending(x=>x.DateTime).ToList();
      all_showing_errors_current = all_errors_current.Where(x => x.ValueCode > 0).OrderByDescending(x => x.DateTime).ToList();



      if (all_showing_errors_current != null && all_showing_errors_current.Count > 0)
      {
        for (int i = 0; i < all_showing_errors_current.Count; i++)
        {
          all_showing_errors_current[i].id = all_showing_errors_current.Count - i;
        }

        dataGridView1.DataSource = all_showing_errors_current;
        //dataGridView1.Columns[0].Visible = false;
        FormatDGV();
      }




      offsetCnt = (counterError - _lastValueCounter);
      //if (offsetCnt > 0 || _lastValueCounter == -1)
      //{
      //  _lastValueCounter = _configuration.LastCounterID;
      //}
      //else
      //{

      //}

      if (offsetCnt != 0 && offsetCnt > 0)
      {

        for (int i = 0; i < 10; i++)
        {
          var alarmContent = alarmContentsDB.FirstOrDefault(s => s.ValuePLC == ListErrorCodes[i]);
          if (alarmContent != null)
          {
            AlarmType error_alarm = CreateAlarm(alarmContent.ValuePLC, alarmContent.Code, alarmContent.Description, alarmContent.Solve, _latestErrorId + i + 1);

            if (i <= 8 && i > 8 - offsetCnt)
            {
              try
              {
                AlarmDB alarmDBsql = new AlarmDB(_configuration.TemplatePath, _configuration.DatabasePath, false);
                alarmDBsql.Save(error_alarm);
              }
              catch (Exception ex)
              {
                MessageBox.Show(ex.ToString());
              }

            }
          }
        }

        //save cnt last
        _configuration.IDcounterAlarm = counterError;
        ConfigurationDB configurationDB = new ConfigurationDB();
        configurationDB.Save(_configuration);

        _lastValueCounter = counterError;
        _latestErrorId = _lastValueCounter;
      }
    }

    private AlarmType CreateAlarm(int alarm_code, string code, string description, string solve, int id)
    {
      //AlarmDB alarmDBsql = new AlarmDB(_configuration.TemplatePath, _configuration.DatabasePath, false);
      eShift eCurShift = Shift.GetShiftFromClock();
      //DateTime dt_now = Utils.GetDateTimeFromClockByShift();
      AlarmType alarm = new AlarmType
      {
        id = id,
        ValueCode = alarm_code,
        AlarmCode = code,
        Description = description,
        Solve = solve,
        DateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
        ShiftId = (int)(eCurShift)
      };
      return alarm;

    }


    private void FormatDGV()
    {
      dataGridView1.Columns[2].Visible = false;

      dataGridView1.Columns[0].Width = 40;
      dataGridView1.Columns[1].Width = 160;
      dataGridView1.Columns[3].Width = 230;
    }





  }
}
