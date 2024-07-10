using CheckWeigherUBN.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckWeigherUBN.DB
{
  public class AlarmContentDB
  {
    private const string Table_name = "AlarmContent";
    private const string _template_db_file_name = "Configuration";
    public object LoadAll()
    {
      List<AlarmContent> list_data = new List<AlarmContent>();
      try
      {
        DataTable recipe;
        String query = "";
        query = String.Format($"select * from {Table_name} where isDelete = '{false}'");
        SQLiteDatabase db = GetSQLiteDatabase_Configuration();
        if (db != null)
        {
          recipe = db.GetDataTable(query);
          foreach (DataRow r in recipe.Rows)
          {
            AlarmContent data = CreateObjectFromDataRow(r);
            list_data.Add(data);
          }
        }
      }
      catch (Exception ex)
      {

      }

      return list_data;
    }

    private AlarmContent CreateObjectFromDataRow(DataRow r)
    {
      AlarmContent dataRet = new AlarmContent()
      {
        Id = string_to_int(GetData(r, AlarmContent.eAlarmContent.id)),
        SttId = string_to_int(GetData(r, AlarmContent.eAlarmContent.SttId)),
        ValuePLC = string_to_int(GetData(r, AlarmContent.eAlarmContent.ValuePLC)),
        Code = GetData(r, AlarmContent.eAlarmContent.Code),
        Description = GetData(r, AlarmContent.eAlarmContent.Description),
        Solve = GetData(r, AlarmContent.eAlarmContent.Solve),
        tyleAlarm = GetData(r, AlarmContent.eAlarmContent.tyleAlarm),
        isDisplay = GetData(r, AlarmContent.eAlarmContent.isDisplay),
        //isDelete = GetData(r, AlarmContent.eAlarmContent.isDelete),
      };

      return dataRet;
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

    public int string_to_int(string str_value)
    {
      int value = 0;
      if (str_value != "")
      {
        try
        {
          value = (int)(double.Parse(str_value));
        }
        catch
        {
          value = (-1);
        }
      }
      return value;
    }

    private string GetData(DataRow r, AlarmContent.eAlarmContent data)
    {
      string ret = "";
      try
      {
        ret = r[data.ToString()].ToString();
      }
      catch
      {
      }
      return ret;
    }

  }
}
