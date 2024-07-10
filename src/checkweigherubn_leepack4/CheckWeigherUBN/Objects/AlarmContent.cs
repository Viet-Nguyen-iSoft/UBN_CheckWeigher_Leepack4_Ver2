using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CheckWeigherUBN.Objects
{
  public class AlarmContent : BaseObject, ICloneable
  {
    public enum eAlarmContent
    {
      id = 0,
      SttId,
      ValuePLC,
      Code,
      Description,
      Solve,
      isDelete,
      tyleAlarm,
      isDisplay,
      STT,

    }

    public enum eTypeAlarm
    {
      warning,
      error,
    }
    public static Dictionary<String, eSQLiteDatabaseDataType> GetDictionaryDB()
    {
      Dictionary<String, eSQLiteDatabaseDataType> dictionaryDB = new Dictionary<String, eSQLiteDatabaseDataType>();
      dictionaryDB.Add(AlarmContent.eAlarmContent.id.ToString(), eSQLiteDatabaseDataType.INTEGER_PRIMARY_KEY_AUTOINCREMENT);
      dictionaryDB.Add(AlarmContent.eAlarmContent.Code.ToString(), eSQLiteDatabaseDataType.INTEGER);
      dictionaryDB.Add(AlarmContent.eAlarmContent.Description.ToString(), eSQLiteDatabaseDataType.TEXT);
      dictionaryDB.Add(AlarmContent.eAlarmContent.Solve.ToString(), eSQLiteDatabaseDataType.TEXT);
      dictionaryDB.Add(AlarmContent.eAlarmContent.isDelete.ToString(), eSQLiteDatabaseDataType.BOOLEAN);
      dictionaryDB.Add(AlarmContent.eAlarmContent.STT.ToString(), eSQLiteDatabaseDataType.INTEGER);
      dictionaryDB.Add(AlarmContent.eAlarmContent.tyleAlarm.ToString(), eSQLiteDatabaseDataType.TEXT);

      return dictionaryDB;
    }

    public override Dictionary<String, String> BuildDictionaryWithValue()
    {
      Dictionary = new Dictionary<String, String>();
      //
      Dictionary.Add(AlarmContent.eAlarmContent.id.ToString(), Id.ToString());
      Dictionary.Add(AlarmContent.eAlarmContent.Code.ToString(), Code.ToString());
      Dictionary.Add(AlarmContent.eAlarmContent.Description.ToString(), Description);
      Dictionary.Add(AlarmContent.eAlarmContent.Solve.ToString(), Solve);
      Dictionary.Add(AlarmContent.eAlarmContent.isDelete.ToString(), isDelete.ToString());
      Dictionary.Add(AlarmContent.eAlarmContent.tyleAlarm.ToString(), tyleAlarm.ToString());
      Dictionary.Add(AlarmContent.eAlarmContent.isDisplay.ToString(), isDisplay.ToString());


      return Dictionary;
    }


    /// <summary>
    /// 
    /// </summary>
    public int Id { get; set; }
    [DisplayName("ID")]
    public int SttId { get; set; }
    [DisplayName("Value PLC")]
    public int ValuePLC { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string Solve { get; set; }
    public bool isDelete { get; set; }

    [DisplayName("Type Alarm")]
    public string tyleAlarm { get; set; }
    public string isDisplay { get; set; }

    public AlarmContent()
    {
    }

    object ICloneable.Clone()
    {
      return this.Clone();
    }

    public AlarmContent Clone()
    {
      AlarmContent dataRet = new AlarmContent()
      {
        Code = Code,
        Description = Description,
        Solve = Solve,
        isDelete = isDelete,
        SttId = SttId,
        tyleAlarm = tyleAlarm,
        isDisplay = isDisplay,
      };
      return dataRet;
    }


  }
}
