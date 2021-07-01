using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace _1313.model
{
    class EstimateCSV
    {


        public void PanelEstimate(System.Data.DataTable ds)
        {
            var excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel._Worksheet)excelApp.ActiveSheet;

            var rngCelStr = (Excel.Range)workSheet.Cells[3];
            var rng = rngCelStr.EntireColumn;
            rng.NumberFormat = "@";

            for (var i = 0; i < ds.Columns.Count; i++)
            {
                workSheet.Cells[1, i + 1] = ds.Columns[i].ColumnName;
            }

            for (var i = 0; i < ds.Rows.Count; i++)
            {
                for (var j = 0; j < ds.Columns.Count; j++)
                {
                    workSheet.Cells[i + 2, j + 1] = ds.Rows[i][j];
                }
            }
        }
    }
}
