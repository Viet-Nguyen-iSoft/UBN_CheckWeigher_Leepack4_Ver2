using Aspose.Cells;
using CheckWeigherUBN.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static CheckWeigherUBN.Objects.AlarmContent;

namespace CheckWeigherUBN
{
  public partial class FrmAlarm : Form
  {
    public delegate void SendSaveDataAlarm();
    public event SendSaveDataAlarm OnSendSaveDataAlarm;

    public FrmAlarm()
    {
      InitializeComponent();
    }

    public Color selectBtn = Color.FromArgb(255, 128, 0);
    public Color nonSelectBtn = Color.DimGray;
    public ConfigurationTypes _configuration = new ConfigurationTypes();
    public FrmAlarm(ConfigurationTypes configuration)
    {
      InitializeComponent();

      _configuration = configuration;
    }


    private List<AlarmContent> alarmContents = new List<AlarmContent>();

    private void btImportFromExcel_Click(object sender, EventArgs e)
    {
      DialogResult result = this.openFileDialog1.ShowDialog();
      if (result == DialogResult.OK)
      {
        alarmContents = new List<AlarmContent>();
        alarmContents = PareXlsxByAspose(file_name);
        UpdateDGV(alarmContents, eTypeAlarm.error);
      }
    }

    private string file_name = "";

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
      file_name = openFileDialog1.FileName;
    }


    private void UpdateDGV(List<AlarmContent> datas, eTypeAlarm typeAlarm)
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new Action(() => { UpdateDGV(datas, typeAlarm); }));
        return;
      }

      try
      {
        if (datas.Count > 0)
        {
          if (typeAlarm == eTypeAlarm.error)
          {
            this.btnError.BackColor = selectBtn;
            this.btnWarning.BackColor = nonSelectBtn;
            this.dataGridView1.DataSource = datas?.Where(s => s.tyleAlarm == eTypeAlarm.error.ToString()).ToList();
          }
          else
          {
            this.btnError.BackColor = nonSelectBtn;
            this.btnWarning.BackColor = selectBtn;
            this.dataGridView1.DataSource = datas?.Where(s => s.tyleAlarm == eTypeAlarm.warning.ToString()).ToList();
          }

          ////dataGridView1.Refresh();
          dataGridView1.Columns[0].Visible = false;
          dataGridView1.Columns[7].Visible = false;
          dataGridView1.Columns[6].Visible = false;
          dataGridView1.Columns[8].Visible = false;
          //dataGridView1.Columns[5].Visible = false;
          //new FrmNotification().ShowMessage("File excel đã được load thành công.", eImage.Information);
        }
        else
        {
          //new FrmNotification().ShowMessage("File excel load không tìm thấy dữ liệu !", eImage.Warning);
        }
      }
      catch (Exception EX)
      {
        throw EX;
      }
    }

    #region Read Exxcel

    public List<AlarmContent> PareXlsxByAspose(string file_path)
    {
      List<AlarmContent> production_datas = new List<AlarmContent>();

      FileInfo dest_file_info = new FileInfo(file_path);
      Workbook wb = new Workbook(dest_file_info.FullName);
      WorksheetCollection collection = wb.Worksheets;
      bool is_exit_loop = false;

      int id = 1;
      for (int worksheetIndex = 0; worksheetIndex < collection.Count && is_exit_loop == false; worksheetIndex++)
      {
        Worksheet worksheet = collection[worksheetIndex];
        if (worksheet.Name.Trim().ToLower() == "error")
        {
          int max_rows = worksheet.Cells.MaxDataRow;
          int max_cols = worksheet.Cells.MaxDataColumn;

          for (int row = 3; row <= max_rows; row++)
          {
            try
            {
              AlarmContent production_data = new AlarmContent();
              production_data.Id = id++;
              production_data.SttId = int.Parse(GetText(worksheet, row, 0));
              var a = GetText(worksheet, row, 1);
              production_data.ValuePLC = int.Parse(GetText(worksheet, row, 1));
              production_data.Code = GetText(worksheet, row, 2);
              production_data.Description = GetText(worksheet, row, 3);
              production_data.Solve = GetText(worksheet, row, 4);
              production_data.isDisplay = GetText(worksheet, row, 5);
              production_data.isDelete = false;
              production_data.tyleAlarm = eTypeAlarm.error.ToString();

              if (production_data.Code != "")
              {
                production_datas.Add(production_data);
              }

            }
            catch (Exception ex)
            {
              //AppCore.Ins.LogErrorToFileLog("File excel load thất bại !" + ex.ToString());
              //new FrmNotification().ShowMessage("File excel load thất bại !", eImage.Warning);
            }
          }
        }
        if (worksheet.Name.Trim().ToLower() == "warning")
        {
          int max_rows = worksheet.Cells.MaxDataRow;
          int max_cols = worksheet.Cells.MaxDataColumn;

          for (int row = 3; row <= max_rows; row++)
          {
            try
            {
              AlarmContent production_data = new AlarmContent();
              production_data.Id = id++;
              production_data.SttId = int.Parse(GetText(worksheet, row, 0));
              production_data.ValuePLC = int.Parse(GetText(worksheet, row, 1));
              production_data.Code = GetText(worksheet, row, 2);
              production_data.Description = GetText(worksheet, row, 3);
              production_data.Solve = GetText(worksheet, row, 4);
              production_data.isDisplay = GetText(worksheet, row, 5);
              production_data.isDelete = false;
              production_data.tyleAlarm = eTypeAlarm.warning.ToString();

              if (production_data.Code != "")
              {
                production_datas.Add(production_data);
              }
            }
            catch (Exception ex)
            {
              //AppCore.Ins.LogErrorToFileLog("File excel load thất bại !" + ex.ToString());
              //new FrmNotification().ShowMessage("File excel load thất bại !", eImage.Warning);
            }
          }
        }
      }
      return production_datas;
    }

    private static string GetText(Worksheet worksheet, int row, int column)
    {
      string ret = "";
      try
      {
        object textObj = worksheet.Cells[row, column].Value;
        if (textObj != null)
          ret = textObj.ToString().Trim();
      }
      catch (Exception ex)
      {
        //AppCore.Ins.LogErrorToFileLog(ex.ToString());
      }
      return ret;
    }

    private Double GetDouble(Worksheet worksheet, int row, int column)
    {
      string ret = "";
      double value = 0;
      try
      {

        object textObj = worksheet.Cells[row, column].Value;
        if (textObj != null)
        {
          Double.TryParse(textObj.ToString(), out value);
        }
      }
      catch
      {
      }
      return value;
    }

    private uint GetUint(Worksheet worksheet, int row, int column)
    {
      string ret = "";
      uint value = 0;
      try
      {
        object textObj = worksheet.Cells[row, column].Value;
        if (textObj != null)
        {
          uint.TryParse(textObj.ToString(), out value);
        }
      }
      catch
      {
      }
      return value;
    }




    #endregion


    private const string Table_name = "AlarmContent";
    private const string _template_db_file_name = "Configuration";
    private void btSave_Click_1(object sender, EventArgs e)
    {
      try
      {
        if (alarmContents.Count > 0)
        {
          SQLiteDatabase db = GetSQLiteDatabase_Configuration();

          string query = $"UPDATE {Table_name} SET isDelete = '{true}'";
          db.ExecuteNonQuery(query);

          for (int idx = 0; idx < alarmContents.Count; idx++)
          {
            AlarmContent dataSaved = alarmContents[idx];
            query = String.Format($"INSERT INTO {Table_name} ({AlarmContent.eAlarmContent.Code}, {AlarmContent.eAlarmContent.Description}, {AlarmContent.eAlarmContent.Solve}, {AlarmContent.eAlarmContent.isDelete}, {AlarmContent.eAlarmContent.tyleAlarm}, {AlarmContent.eAlarmContent.isDisplay}, {AlarmContent.eAlarmContent.SttId} , {AlarmContent.eAlarmContent.ValuePLC})" +
                 $" VALUES ('{dataSaved.Code}', '{dataSaved.Description}', '{dataSaved.Solve}', '{dataSaved.isDelete}', '{dataSaved.tyleAlarm}', '{dataSaved.isDisplay}', '{dataSaved.SttId}', '{dataSaved.ValuePLC}');");
            db.ExecuteNonQuery(query);
          }

          OnSendSaveDataAlarm?.Invoke();
        }

        this.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi");
      }
    }
    
    private SQLiteDatabase GetSQLiteDatabase_Configuration()
    {
      SQLiteDatabase db = new SQLiteDatabase();
      string databaseName = "";
      FileInfo configurationFile = new FileInfo(String.Format("{0}\\{1}.s3db", Application.StartupPath, _template_db_file_name));
      //
      databaseName = configurationFile.FullName;
      //
      if (databaseName != "")
      {
        db = new SQLiteDatabase(databaseName);
      }
      else
      {
        db = null;
      }
      return db;
    }

    private void FrmAlarm_Load_1(object sender, EventArgs e)
    {
      alarmContents = _configuration.list_AlarmContent;
      UpdateDGV(alarmContents, eTypeAlarm.error);
    }

    private void btnError_Click_1(object sender, EventArgs e)
    {
      UpdateDGV(alarmContents, eTypeAlarm.error);
    }

    private void btnWarning_Click_1(object sender, EventArgs e)
    {
      UpdateDGV(alarmContents, eTypeAlarm.warning);
    }

    private void btExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    
  }
}
