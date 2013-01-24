﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Newtonsoft.Json.Tests.Documentation.Examples
{
  public class DeserializeDataSet
  {
    public void Example()
    {
      string json = @"{
        ""Table1"": [
          {
            ""id"": 0,
            ""item"": ""item 0""
          },
          {
            ""id"": 1,
            ""item"": ""item 1""
          }
        ]
      }";

      DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

      DataTable dataTable = dataSet.Tables["Table1"];

      Console.WriteLine(dataTable.Rows.Count);
      // 2

      foreach (DataRow row in dataTable.Rows)
      {
        Console.WriteLine(row["id"] + " - " + row["item"]);
      }
      // 0 - item 0
      // 1 - item 1
    }
  }
}