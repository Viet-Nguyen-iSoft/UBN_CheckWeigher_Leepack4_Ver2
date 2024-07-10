using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace CheckWeigherUBN
{

  public class AlarmType : BaseObject, ICloneable
  {
    public enum eAlarm
    {
      id,
      DateTime,
      ShiftId,
      ValueCode,
      AlarmCode,
      Description,
      Solve,
    }


    public static Dictionary<String, eSQLiteDatabaseDataType> GetDictionaryDB()
    {
      Dictionary<String, eSQLiteDatabaseDataType> dictionaryDB = new Dictionary<String, eSQLiteDatabaseDataType>();
      dictionaryDB.Add(AlarmType.eAlarm.id.ToString(), eSQLiteDatabaseDataType.INTEGER_PRIMARY_KEY_AUTOINCREMENT);
      dictionaryDB.Add(AlarmType.eAlarm.DateTime.ToString(), eSQLiteDatabaseDataType.TEXT);
      dictionaryDB.Add(AlarmType.eAlarm.ShiftId.ToString(), eSQLiteDatabaseDataType.INTEGER);
      //dictionaryDB.Add(AlarmType.eAlarm.AlarmCode.ToString(), eSQLiteDatabaseDataType.INTEGER);
      dictionaryDB.Add(AlarmType.eAlarm.ValueCode.ToString(), eSQLiteDatabaseDataType.INTEGER);
      dictionaryDB.Add(AlarmType.eAlarm.AlarmCode.ToString(), eSQLiteDatabaseDataType.TEXT);
      dictionaryDB.Add(AlarmType.eAlarm.Description.ToString(), eSQLiteDatabaseDataType.TEXT);
      dictionaryDB.Add(AlarmType.eAlarm.Solve.ToString(), eSQLiteDatabaseDataType.TEXT);
      //
      return dictionaryDB;
    }



    public override Dictionary<String, String> BuildDictionaryWithValue()
    {
      Dictionary = new Dictionary<String, String>();
      //
      Dictionary.Add(AlarmType.eAlarm.DateTime.ToString(), DateTime.ToString());
      Dictionary.Add(AlarmType.eAlarm.ShiftId.ToString(), ShiftId.ToString());
      Dictionary.Add(AlarmType.eAlarm.ValueCode.ToString(), ValueCode.ToString());
      Dictionary.Add(AlarmType.eAlarm.AlarmCode.ToString(), AlarmCode.ToString());
      Dictionary.Add(AlarmType.eAlarm.Description.ToString(), Description.ToString());
      Dictionary.Add(AlarmType.eAlarm.Solve.ToString(), Solve.ToString());
      return Dictionary;
    }

    [DisplayName("ID")]
    public int id { get; set; } = 0;
    public string DateTime { get; set; }
    [Browsable(false)]
    public int ShiftId { get; set; }
    public int ValueCode { get; set; }
    public string AlarmCode { get; set; }
    public string Description { get; set; }

    public bool isErrorAlarm = false;
    public string Solve { get; set; }

    public void SetErrorAlarm(bool value)
    {
      isErrorAlarm = value;
    }
    public bool GetErrorAlarm()
    {
      return isErrorAlarm;
    }
    //
    public AlarmType()
    {
    }

    object ICloneable.Clone()
    {
      return this.Clone();
    }

    // <summary>
    /// Copy to instance
    /// </summary>
    /// <returns></returns>
    public AlarmType Clone()
    {
      AlarmType dataRet = new AlarmType()
      {
        DateTime = DateTime,
        AlarmCode = AlarmCode,
        ShiftId = ShiftId,
        Description = Description,
        Solve = Solve,
      };
      return dataRet;
    }
    /// <summary>
    /// Check data if kDifferent
    /// </summary>
    /// <param name="dst"></param>
    /// <returns></returns>
    public bool checkDifferent(AlarmType dst)
    {
      bool ret = false;
      ret |= (AlarmCode != dst.AlarmCode);
      ret |= (Description != dst.Description);
      ret |= (ShiftId != dst.ShiftId);
      ret |= (Solve != dst.Solve);
      //ret |= (DateTime != dst.DateTime);
      return ret;
    }


  }
}
