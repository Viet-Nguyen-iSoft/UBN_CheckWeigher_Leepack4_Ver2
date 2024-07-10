using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CheckWeigherUBN.ExcelHandle
{
  public class ExcelPro
  {
    public static string _exportPath = "./Report/";
    public static string _templatePath = "Template/ReportTemplate.xlsx";
    public ExcelPro()
    {

    }
    public static void SetCell_SolidBackground(ExcelWorksheet worksheet, int row, int column, object value, ExcelHorizontalAlignment Alignment, Color background_color, Color ForeColor, ExcelBorderStyle excelBorderStyle = ExcelBorderStyle.Thin)
    {
      try
      {
        var cell = worksheet.Cells[row, column];
        var fill = cell.Style.Fill;
        //fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
        //fill.BackgroundColor.SetColor(background_color);
        cell.Value = value;
        cell.Style.Border.BorderAround(excelBorderStyle, Color.Black);
        cell.Style.HorizontalAlignment = Alignment;
        cell.Style.Font.Color.SetColor(ForeColor);
        //cell.AutoFitColumns();
      }
      catch
      {
      }
    }
    public static ExcelPackage LoadTempFile(string FileName)
    {
      //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
      string startupPath = $"{Environment.CurrentDirectory}\\{FileName}";
      FileInfo existingFile = new FileInfo(FileName);
      return new ExcelPackage(existingFile);
    }

    /// <summary>
    /// Find value in cells and return address
    /// </summary>
    /// <param name="excelPackage"></param>
    /// /// <param name="value_in_cell"></param>
    /// <returns>The cell contain the value</returns>
    public static ExcelRangeBase FindCells(ExcelPackage excelPackage, string sheetname, string valueInCells)
    {
      //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
      foreach (ExcelRangeBase cell in excelPackage.Workbook.Worksheets[sheetname].Cells)
      {
        if (cell.Value != null && cell.Value.ToString().Contains(valueInCells))
        {
          return cell;
        }
      }
      return null;
    }

    /// <summary>
    /// Replace the value in cell of ExcelPackage
    /// </summary>
    /// <param name="excelPackage"></param>
    /// <param name="cell"></param>
    /// <param name="value"></param>
    public static bool Replace(ref ExcelPackage excelPackage, string sheetName, string oldValue, string newValue)
    {
      //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
      using (var _cell = FindCells(excelPackage, sheetName, oldValue))
      {
        if (_cell == null) return false;
        else
        {
          excelPackage.Workbook.Worksheets[sheetName].Cells[_cell.Address].Value = newValue;
        }
      }
      return true;
    }

    public static bool SetCellBackColor(ref ExcelPackage excelPackage, string sheetName, string byValue, Color color)
    {
      //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
      foreach (ExcelRangeBase cell in excelPackage.Workbook.Worksheets[$"{sheetName}"].Cells)
      {
        if (cell.Value != null && cell.Value.ToString() == $"{byValue}")
        {
          cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
          cell.Style.Fill.BackgroundColor.SetColor(color);
        }
      }
      return true;
    }

    /// <summary>
    /// https://stackoverflow.com/questions/13669733/export-datatable-to-excel-with-epplus
    /// </summary>
    /// <param name="excelPackage"></param>
    /// <param name="data"></param>
    public static void InsertTableSource<T>(ref ExcelPackage excelPackage, string sheetname, List<T> data)
    {
      //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
      if (data != null)
      {
        string address = excelPackage.Workbook.Worksheets["Report"].Cells.Address;
        //MessageBox.Show($"{"address"} {address}");
        excelPackage.Workbook.Worksheets["Report"].Cells[FindCells(excelPackage, sheetname, "#table")?.Address].LoadFromCollection(data, true, OfficeOpenXml.Table.TableStyles.Dark1);
      }
      else
      {
        Replace(ref excelPackage, sheetname, "#table", "No data");
      }
    }

    /// <summary>
    /// https://stackoverflow.com/questions/13669733/export-datatable-to-excel-with-epplus
    /// </summary>
    /// <param name="excelPackage"></param>
    /// <param name="data"></param>
    public static void InsertTableSource<T>(ref ExcelPackage excelPackage, string sheetname, List<T> data, OfficeOpenXml.Table.TableStyles tableStyles)
    {
      //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
      if (data != null)
      {
        string address;
        if (excelPackage.Workbook.Worksheets[sheetname] != null)
          address = excelPackage.Workbook.Worksheets[sheetname].Cells.Address;
        else
        {
          throw new Exception($"Template dont have work sheet {sheetname}");
        }
        //MessageBox.Show($"{"address"} {address}");
        excelPackage.Workbook.Worksheets[sheetname].Cells[FindCells(excelPackage, sheetname, "#table").Address].LoadFromCollection(data, true, tableStyles);
      }
      else
      {
        Replace(ref excelPackage, sheetname, "#table", "No data");
      }
    }
    public static void InsertTableSource<T>(ref ExcelPackage excelPackage, string sheetname, DataTable data, OfficeOpenXml.Table.TableStyles tableStyles)
    {
      //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
      if (data != null)
      {
        string address;
        if (excelPackage.Workbook.Worksheets[sheetname] != null)
          address = excelPackage.Workbook.Worksheets[sheetname].Cells.Address;
        else
        {
          throw new Exception($"Template dont have work sheet {sheetname}");
        }
        //MessageBox.Show($"{"address"} {address}");
        excelPackage.Workbook.Worksheets[sheetname].Cells[FindCells(excelPackage, sheetname, "#table").Address].LoadFromDataTable(data, true, tableStyles);
      }
      else
      {
        Replace(ref excelPackage, sheetname, "#table", "No data");
      }
    }
    //save object ExcelPackage template to binary file
    //public static void SaveReportFormat(ExcelPackage formatTemp)
    //{
    //  // Create a hashtable of values that will eventually be serialized.
    //  // To serialize the ExcelPackage,
    //  // you must first open a stream for writing.
    //  // In this case, use a file stream.
    //  FileStream fs = new FileStream("ReportFormat_v2.dat", FileMode.Create);
    //  // Construct a BinaryFormatter and use it to serialize the data to the stream.
    //  BinaryFormatter formatter = new BinaryFormatter();
    //  try
    //  {
    //    var stream = new MemoryStream(formatTemp.GetAsByteArray());
    //    formatter.Serialize(fs, stream);
    //  }
    //  catch (SerializationException ex)
    //  {
    //    var msg = $"Source : {ex.Source}, Message : {ex.Message}, HelpLink : {ex.HelpLink}";
    //    //  DataProvider.Ins.Add<AppLog>(new List<AppLog>() { new AppLog()
    //    // {
    //    //   Content= $"Source : {ex.Source}, Message : {ex.Message}, HelpLink : {ex.HelpLink}",
    //    //   Inserted=DateTime.Now
    //    //}
    //    // });
    //    throw;
    //  }
    //  finally
    //  {
    //    fs.Close();
    //  }
    //}

    /// <summary>
    /// If using DotNet5.0, user must:
    /// In Visual Studio:

    //Open Package Manager Console and type in Install-Package System.Text.Encoding.CodePages -Version 4.4.0. Change the version number appropriately.

    //Add this line to your code: Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

    // the necessary directive if required.
    /// </summary>
    /// <returns></returns>
    public static ExcelPackage LoadReportFormat()
    {

      //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
      //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
      FileInfo template = new FileInfo(_templatePath);
      ExcelPackage result = new ExcelPackage(template);

      try
      {
        // Declare the hashtable reference.

        // Open the file containing the data that you want to deserialize.
        //fs = new FileStream(_templatePath, FileMode.Open);
        //result.Settings.
        //BinaryFormatter formatter = new BinaryFormatter();

        // Deserialize the hashtable from the file and
        // assign the reference to the local variable.
        //result = (ExcelPackage)formatter.Deserialize(fs);
        //result.Load((Stream)formatter.Deserialize(fs));
      }
      catch (SerializationException ex)
      {
        var msg = $"Source : {ex.Source}, Message : {ex.Message}, HelpLink : {ex.HelpLink}";
        //  DataProvider.Ins.Add<AppLog>(new List<AppLog>() { new AppLog()
        // {
        //   Content= $"Source : {ex.Source}, Message : {ex.Message}, HelpLink : {ex.HelpLink}",
        //   Inserted=DateTime.Now
        //}
        // });
        throw ex;
      }
      finally
      {
        //fs?.Close();
      }
      return result;
    }


  }
}
