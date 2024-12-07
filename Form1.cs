using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.Threading.Tasks;


namespace TheRealMaluho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            // Show OpenFileDialog
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create Excel Application and Workbook
                Microsoft.Office.Interop.Excel.Application excelApplication = new Microsoft.Office.Interop.Excel.Application();
                Workbook excelWorkbook = excelApplication.Workbooks.Open(openFileDialog.FileName);

                // Get first Worksheet
                Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                // Get range of cells with data and images
                Range range = excelWorksheet.UsedRange;

                // Create new DataTable to store data and images
                System.Data.DataTable dataTable = new System.Data.DataTable();

                dataTable.Columns.Add("Data", typeof(string));
                dataTable.Columns.Add("Image", typeof(Image));

                // Loop through each row in the range
                for (int row = 1; row <= range.Rows.Count; row++)
                {
                    // Get cell with data
                    Range dataCell = (Range)range.Cells[row, 1];
                    string dataValue = dataCell.Value2.ToString();

                    // Get cell with image
                    Range imageCell = (Range)range.Cells[row, 2];
                    if (imageCell != null && imageCell.Value2 != null)
                    {
                        string imagePath = Path.Combine("C:\\Users\\user\\Desktop\\The real maluho icons\\back.png", imageCell.Value2.ToString());
                        // Load image from file
                        if (File.Exists(imagePath))
                        {
                            Image image = await Task.Run(() => Image.FromFile(imagePath));
                            dataTable.Rows.Add(dataValue, image);
                        }
                    }
                    else
                    {
                        dataTable.Rows.Add(dataValue, null);
                    }
                    // Add row to DataTable

                }

                // Create new DataGridViewImageColumn and add it to the DataGridView
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
              
                imageColumn.DataPropertyName = "Image";
                imageColumn.HeaderText = "Image";
                dataGridView1.Columns.Add(imageColumn);

                // Set DataGridView DataSource
                dataGridView1.DataSource = dataTable;

                // Close Excel Workbook and Application
                excelWorkbook.Close();
                excelApplication.Quit();
                Marshal.ReleaseComObject(excelWorksheet);
                Marshal.ReleaseComObject(excelWorkbook);
                Marshal.ReleaseComObject(excelApplication);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker4.Value;
            TimeSpan timeDiff = date2 - date1;
            double totalMinutes = Math.Abs(timeDiff.TotalMinutes);
            double totalHours = totalMinutes / 60.0;

            DateTime break1 = dateTimePicker2.Value;
            DateTime break2 = dateTimePicker3.Value;
            TimeSpan timediff2 = break2 - break1;
            double totalMinutes2 = Math.Abs(timediff2.TotalMinutes);
            double totalbreak = totalMinutes2 / 60.0;

            double total = totalHours - totalbreak;
            textBox1.Text = total.ToString("0.00");
        }
    }
    }

    
