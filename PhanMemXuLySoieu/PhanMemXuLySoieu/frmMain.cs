using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using ExcelDataReader;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Grid;

namespace PhanMemXuLySoieu
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            btnFileText.ReadOnly = true;
            btnFileExcel.ReadOnly = true;
            DataTable dt = new DataTable();
            gridLook.Properties.DataSource = dt;
        }

        private void btnChuyenFile_Click(object sender, EventArgs e)
        {
            gridLoc.Refresh();
            gridLoc.DataSource = null;
            DataTable dt = new DataTable();

            if (File.Exists(btnFileText.Text))
            {
                var fileStream = new FileStream(btnFileText.Text, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] arrListStr = line.Split(txtKiTu.Text[0]);
                        if (dt.Columns.Count == 0)
                        {
                            for (int i = 0; i < arrListStr.Length; i++)
                                dt.Columns.Add(i.ToString());
                        }

                        dt.Rows.Add(arrListStr);


                    }
                }
            }

            gridLoc.DataSource = dt;

        }

        private void btnFileText_Properties_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files(.txt)|*.txt";
            openFileDialog1.Title = "Select an text file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string txtPath = openFileDialog1.FileName;
                FileStream stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                btnFileText.Text = openFileDialog1.FileName;

                stream.Close();
            }
        }

        private void btnFileText_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (File.Exists(btnFileText.Text))
            {
                var fileStream = new FileStream(btnFileText.Text, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] arrListStr = line.Split(txtKiTu.Text[0]);
                        if (dt.Columns.Count == 0)
                        {
                            for (int i = 0; i < arrListStr.Length; i++)
                                dt.Columns.Add(i.ToString());
                        }
                        dt.Rows.Add(arrListStr);
                    }
                }
            }

            gridLoc.DataSource = dt;

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel Files(.xlsx)|*.xlsx";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;


                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridLoc.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridLoc.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridLoc.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridLoc.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridLoc.ExportToHtml(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            XtraMessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        XtraMessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonEdit2_Properties_Click(object sender, EventArgs e)
        {
            gridLoc.Refresh();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx";
            openFileDialog1.Title = "Select an Excel file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string txtPath = openFileDialog1.FileName;
                    btnFileExcel.Text = openFileDialog1.FileName;
                    FileStream stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    DataSet result = excelReader.AsDataSet();
                    DataTable dt = result.Tables[0];
                    dt.Rows[0].Delete();
                    gridLoc.DataSource = dt;
                    stream.Close();
                }
                catch
                {
                    XtraMessageBox.Show("Vui lòng chọn lại file excel .xlsx (2010 trở lên)");
                }

            }
        }
        public double khoangcanh(float x, float y, float a, float b)
        {
            return Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b));
        }
        private void btnXuLy_Click(object sender, EventArgs e)
        {
            if (btnFileExcel.Text != "" && File.Exists(btnFileExcel.Text))
            {
                splashScreenManager1.ShowWaitForm();
                gridView1.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridView1.Columns[2].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

                DataTable dtLoi = new DataTable();
                DataTable dt = new DataTable();
                for (int i = 0; i < gridView1.Columns.Count; i++)
                {
                    dt.Columns.Add(gridView1.Columns[i].FieldName);
                    dtLoi.Columns.Add(gridView1.Columns[i].FieldName);
                }

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    DataRow row = gridView1.GetDataRow(i);
                    dt.Rows.Add(row.ItemArray);
                }


                for (int i = 0; i < dt.Rows.Count -1; i++)
                {
                    if (dt.Rows[i][0].ToString() == dt.Rows[i + 1][0].ToString() && dt.Rows[i][1].ToString() == dt.Rows[i + 1][1].ToString() /*&& dt.Rows[i][2].ToString() == dt.Rows[i + 1][2].ToString()*/)
                    {
                       
                        dtLoi.Rows.Add(dt.Rows[i+1 ][0], dt.Rows[i+1][1], dt.Rows[i +1][2]);
                        dt.Rows[i + 1].Delete();
                        i--;
                    }
                }
                DataTable dtChenhLech = new DataTable();
                dtChenhLech.Columns.Add();
                dtChenhLech.Columns.Add();
                dtChenhLech.Columns.Add();
                dtChenhLech.Columns.Add();


                for (int i = 0; i < dtLoi.Rows.Count; i++)
                {
                    //for(int j=0;j<dtChenhLech.Rows.Count;j++)
                    //{
                    //    dtChenhLech.Rows[j].Delete();
                    //}
                   
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        dtChenhLech.Rows.Add(dt.Rows[j][0], dt.Rows[j][1], dt.Rows[j][2],
                            khoangcanh(float.Parse(dt.Rows[i][0].ToString()), float.Parse(dt.Rows[i][1].ToString()), float.Parse(dt.Rows[j][0].ToString()), float.Parse(dt.Rows[j][1].ToString())).ToString());

                    }
                  
                        dtChenhLech = dtChenhLech.AsEnumerable()
                           .OrderBy(r => r.Field<string>(dtChenhLech.Columns[3]))
                        .CopyToDataTable();
                   
                    List<string> list = new List<string>();
                    float min = 1000000;
                    for (int j = i; j < dtLoi.Rows.Count; j++)
                    {
                        if (dtLoi.Rows[i][0] == dtLoi.Rows[j][0] && dtLoi.Rows[i][1] == dtLoi.Rows[j][1])
                        {
                            if (min >= float.Parse(dtLoi.Rows[j][2].ToString()) - (float.Parse(dtChenhLech.Rows[0][2].ToString()) + float.Parse(dtChenhLech.Rows[1][2].ToString())) / 2)
                                min = float.Parse(dtLoi.Rows[j][2].ToString()) - (float.Parse(dtChenhLech.Rows[0][2].ToString()) + float.Parse(dtChenhLech.Rows[1][2].ToString())) / 2;
                        }
                    }
                    for (int j = i ; j < dtLoi.Rows.Count; j++)
                    {
                        if (dtLoi.Rows[i][0] == dtLoi.Rows[j][0] && dtLoi.Rows[i][1] == dtLoi.Rows[j][1])
                        {
                            if (min == float.Parse(dtLoi.Rows[j][2].ToString()) - (float.Parse(dtChenhLech.Rows[0][2].ToString()) + float.Parse(dtChenhLech.Rows[1][2].ToString())) / 2)
                            {
                                for (int z = 0; z < dt.Rows.Count; z++)
                                {
                                    if (dtLoi.Rows[j][0] == dt.Rows[z][0] && dtLoi.Rows[j][1] == dt.Rows[z][1])
                                    {
                                        if (float.Parse(dt.Rows[z][2].ToString()) >= (float.Parse(dtChenhLech.Rows[0][2].ToString()) + float.Parse(dtChenhLech.Rows[1][2].ToString())) / 2 + min)
                                        {
                                            string a = dt.Rows[z][0].ToString();
                                            string b = dt.Rows[z][1].ToString();
                                            string c = dt.Rows[z][2].ToString();


                                            dt.Rows[z].Delete();
                                            dt.Rows.Add(dtLoi.Rows[i][0], dtLoi.Rows[i][1], dtLoi.Rows[j][2]) ;
                                            dtLoi.Rows[i].Delete();
                                            dtLoi.Rows.Add(a, b, c);
                                           
                                            ////MessageBox.Show(dtLoi.Rows[i][0] + "-" + dtLoi.Rows[i][1] + "-" + min + float.Parse(dtChenhLech.Rows[0][2].ToString()) + float.Parse(dtChenhLech.Rows[1][2].ToString()) / 2);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    dtChenhLech.Clear();
                }
                
                gridLoc.DataSource = dt;
                gridLook.Properties.DataSource = dtLoi;
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void gridLook_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveDS_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel Files(.xlsx)|*.xlsx";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;


                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridLoc.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridLoc.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridLoc.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridLoc.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridLoc.ExportToHtml(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            XtraMessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        XtraMessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveDSLoi_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel Files(.xlsx)|*.xlsx";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                     
                    gridLookup.DataSource = gridLook.Properties.DataSource;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridLookup.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridLookup.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridLookup.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridLookup.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridLookup.ExportToHtml(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            XtraMessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        XtraMessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}