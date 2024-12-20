﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ExcelClone
{
    public partial class Form1 : Form
    {
        private string tempTextHightlighted;
        static public DataGridViewCell tempCell;
        static public HashSet<DataGridViewCell> FocusedCellSet = new HashSet<DataGridViewCell>();
        private FontPanel tempPanelRef;
        private bool formula = false;
        private enum Tabs { Basic, Insert, Formulas, View };
        private Tabs activeTab = Tabs.Basic;
        public Form1()
        {
            InitializeComponent();
            sheet1.ContextMenuStrip = baseContextstrip;
            sheet1.RowCount = 50;
            sheet1.ColumnCount = 26;
            for (int i = 0; i < sheet1.ColumnCount; i++)
            {
                sheet1.Columns[i].Name = ((char)('A' + i)).ToString(); // A, B, C...
            }
            sheet1.RowPostPaint += Sheet1_RowPostPaint;

            // Set a wider row header width for visibility
            sheet1.RowHeadersWidth = 50;

            FontPanel box = new FontPanel();
            panel1.Controls.Clear();
            panel1.Controls.Add(box);
            tempPanelRef = box;
            basicTabbutton.BackColor = Color.WhiteSmoke;
            tempPanelRef.disablePanelControls();

            sheet1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            sheet1.MultiSelect = true;

            // Event handler for selection change
            sheet1.SelectionChanged += sheet1_SelectionChanged;



            //this.FormBorderStyle = FormBorderStyle.None;
            //this.Padding = new Padding(5);



        }
        private void Sheet1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Calculate the row number (1-based)
            string rowNumber = (e.RowIndex + 1).ToString();

            // Get the bounds of the row header
            Rectangle rowHeaderBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                sheet1.RowHeadersWidth,
                e.RowBounds.Height
            );

            using (Brush brush = new SolidBrush(sheet1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    rowNumber,
                    sheet1.RowHeadersDefaultCellStyle.Font ?? sheet1.Font,
                    brush,
                    rowHeaderBounds,
                    new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    });
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewCell temp = sheet1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //tempCell = temp;
            //FocusedCellSet.Add(temp);
            //tempPanelRef.enablePanelControls();
        }
        private void sheet1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (tempCell == null)
            //{
            //    tempPanelRef.disablePanelControls();
            //}

        }

        private void sheet1_SelectionChanged(object sender, EventArgs e)
        {
            FocusedCellSet.Clear();
            tempPanelRef.enablePanelControls();
            foreach (DataGridViewCell cell in sheet1.SelectedCells)
            {
                FocusedCellSet.Add(cell);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontPanel box = new FontPanel();
            panel1.Controls.Clear();
            panel1.Controls.Add(box);
            tempPanelRef = box;
            basicTabbutton.BackColor = Color.WhiteSmoke;
            //tempCell.Style.Font = new Font("Arial", 18, FontStyle.Bold | FontStyle.Italic);
            switch (activeTab)
            {
                case Tabs.Insert:
                    insertTabbutton.BackColor = Color.MediumSeaGreen;
                    break;
                case Tabs.Formulas:
                    formulasTabbutton.BackColor = Color.MediumSeaGreen;
                    break;
                case Tabs.View:
                    viewTabbutton.BackColor = Color.MediumSeaGreen;
                    break;
                default:
                    break;
            }
            activeTab = Tabs.Basic;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DummyPanel dummyPanel = new DummyPanel();
            panel1.Controls.Clear();
            panel1.Controls.Add(dummyPanel);
            insertTabbutton.BackColor = Color.WhiteSmoke;
            switch (activeTab)
            {
                case Tabs.Basic:
                    basicTabbutton.BackColor = Color.MediumSeaGreen;
                    break;
                case Tabs.Formulas:
                    formulasTabbutton.BackColor = Color.MediumSeaGreen;
                    break;
                case Tabs.View:
                    viewTabbutton.BackColor = Color.MediumSeaGreen;
                    break;
                default:
                    break;
            }
            activeTab = Tabs.Insert;
        }

        private void formulasTabbutton_Click(object sender, EventArgs e)
        {
            DummyPanel dummyPanel = new DummyPanel();
            panel1.Controls.Clear();
            panel1.Controls.Add(dummyPanel);
            formulasTabbutton.BackColor = Color.WhiteSmoke;

            switch (activeTab)
            {
                case Tabs.Basic:
                    basicTabbutton.BackColor = Color.MediumSeaGreen;
                    break;
                case Tabs.Insert:
                    insertTabbutton.BackColor = Color.MediumSeaGreen;
                    break;
                case Tabs.View:
                    viewTabbutton.BackColor = Color.MediumSeaGreen;
                    break;
                default:
                    break;
            }
            activeTab = Tabs.Formulas;
        }

        private void viewTabbutton_Click(object sender, EventArgs e)
        {
            DummyPanel dummyPanel = new DummyPanel();
            panel1.Controls.Clear();
            panel1.Controls.Add(dummyPanel);
            formulasTabbutton.BackColor = Color.WhiteSmoke;

            switch (activeTab)
            {
                case Tabs.Basic:
                    basicTabbutton.BackColor = Color.MediumSeaGreen;
                    break;
                case Tabs.Insert:
                    insertTabbutton.BackColor = Color.MediumSeaGreen;
                    break;
                case Tabs.Formulas:
                    formulasTabbutton.BackColor = Color.MediumSeaGreen;
                    break;
                default:
                    break;
            }
            activeTab = Tabs.View;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // when clicked autoFill
            // now to get the reference all the FocusedCells and then count


        }

        private void duplicateOption_Click(object sender, EventArgs e)
        {
            // get the first element that is selected and then fill all the other
            MessageBox.Show((string)FocusedCellSet.Last().Value);
            string tempDuplicateValue = (string)FocusedCellSet.Last().Value;
            foreach (DataGridViewCell cell in FocusedCellSet)
            {
                cell.Value = tempDuplicateValue;
            }
        }

        private void sheet1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int columnIdx = FocusedCellSet.First().ColumnIndex;
            //int rowIdx = FocusedCellSet.First().RowIndex;

            //Rectangle cellRectangle = sheet1.GetCellDisplayRectangle(columnIdx, rowIdx, false);
            //Point buttonPosition = sheet1.PointToScreen(new Point(cellRectangle.X,cellRectangle.Y));




            //// Convertint the cell position to screen coordinates
            //Point screenPosition = sheet1.PointToScreen(new Point(cellRectangle.Right, cellRectangle.Bottom));
            //baseContextstrip.Show(screenPosition);
        }

        private void sheet1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private bool CheckValid(string s)
        {
            // checking for SUM
            if (s[0]!='=')
            {
                return false;
            }
            return true;
        }

        private string getValidStr(string s)
        {
            string temp = "";
            int iter = 0;
            while (iter<s.Length && s[iter] != '(')
            {
                iter++;
            }
            iter++;
            while(iter<s.Length && s[iter]!=')')
            {
                temp += s[iter];
                iter++;
            }
            return temp;
        }

        private void sheet1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string s = FocusedCellSet.First().Value.ToString();
            formula = CheckValid(s);
            s = s.ToLower();
            if (formula)
            {
                s = getValidStr(s);
                MessageBox.Show(s);

                // itz gonna work
                int stIdx = s[0] - 97;
                int enIdx = -1;
                for (int i = s.Length - 1; i != ':' && i >= 0; i--)
                {
                    if (s[i] >= '0' && s[i] <= '9')
                    {
                        // pass
                    }
                    else
                    {
                        enIdx = s[i] - 97;
                        break;
                    }
                }

                // is my stIdx==enIdx? -> Column aggregation
                // else -> Row aggregation

                if (stIdx == enIdx)
                {
                    // A5:A6
                    string tempNum = "";
                    int iter = 1;
                    while (iter < s.Length && s[iter] != ':')
                    {
                        tempNum += s[iter];
                        iter++;
                    }
                    int num1 = int.Parse(tempNum);
                    iter += 2;
                    tempNum = "";
                    while (iter < s.Length)
                    {
                        tempNum += s[iter];
                        iter++;
                    }
                    int num2 = int.Parse(tempNum);

                    MessageBox.Show($"{stIdx},{num2}");
                    
                    // aggregating vertically
                    int sum = 0;        // taking example as of SUM
                    for (int i = num1; i < num2; i++)
                    {
                        sum += int.Parse(sheet1.Rows[i].Cells[stIdx].Value.ToString());
                    }
                    FocusedCellSet.First().Value = sum;

                    MessageBox.Show("Ended");
                }
                else
                {
                    string tempNum = "";
                    int iter = 1;
                    while (iter < s.Length && s[iter] != ':')
                    {
                        tempNum += s[iter];
                        iter++;
                    }
                    int num1 = int.Parse(tempNum);
                    MessageBox.Show($"{stIdx},{num1}");
                    
                    // aggregating horizontally
                    int sum = 0;        // taking example as of SUM
                    for (int i = stIdx; i <= enIdx; i++)
                    {
                        sum += int.Parse(sheet1.Rows[num1].Cells[i].Value.ToString());
                    }
                    FocusedCellSet.First().Value = sum;

                }
            }
        }
    }
}
