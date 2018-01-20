using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///----指定報表外部數據源  
            DataTable table = new DataTable();
            table.Columns.Add("工具", typeof(string));
            table.Columns.Add("語言", typeof(string));
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            table.Rows.Add("VS2010", "VC++ MFC");
            table.Rows.Add("VS2010", "C# 4.0");
            table.Rows.Add("VS2010", "VB.NET 4.0");
            ///---添加數據源
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = table;
            ///---向報表綁定數據源  
            this.reportViewer1.LocalReport.DataSources.Clear();//注，使用原文代碼上測試，數據一直不顯示，後來添加了這句代碼，代碼出現了。MS真坑。
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            //this.reportViewer1.LocalReport.ReportPath = @"..\..\Report1.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
