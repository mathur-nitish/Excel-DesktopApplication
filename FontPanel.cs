using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelClone
{
    public partial class FontPanel : UserControl
    {
        public FontPanel()
        {
            InitializeComponent();
            foreach(FontFamily Font in FontFamily.Families)
            {
                fontSelectBox.Items.Add(Font.Name);
            }
            fontSelectBox.SelectedIndex = 0;

            for(int i  = 2;i<=20;i+=2)
            {
                fontSizeBox.Items.Add((int)i);
            }
            fontSizeBox.SelectedIndex = 3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void disablePanelControls()
        {
            fontSelectBox.Enabled = false;
            fontSizeBox.Enabled = false;
        }

        public void enablePanelControls()
        {
            fontSelectBox.Enabled = true;
            fontSizeBox.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Point location = FontColorButton.Location;
            using (Form tempForm = new Form())
            {
                tempForm.StartPosition = FormStartPosition.Manual;
                tempForm.Location = location;
                tempForm.ShowInTaskbar = false;
                tempForm.Opacity = 0;
                tempForm.Size = new Size(1, 1);

                using (ColorDialog colorD = new ColorDialog())
                {
                    if(colorD.ShowDialog() == DialogResult.OK)
                    {
                        FontColorButton.BackColor = colorD.Color;
                        //Form1.tempCell.Style.ForeColor = colorD.Color;

                        // for set
                        foreach(DataGridViewCell cell in Form1.FocusedCellSet)
                        {
                            cell.Style.ForeColor = colorD.Color;
                        }
                    }
                }
            }

        }

        private void BOLDButton_Click(object sender, EventArgs e)
        {
            if (Form1.FocusedCellSet.Count > 0)
            {
                foreach (DataGridViewCell cell in Form1.FocusedCellSet)
                {
                    Font currentFont = cell.Style.Font ?? new Font("Arial", 10);
                    FontStyle newStyle;
                    if ((currentFont.Style & FontStyle.Bold) == FontStyle.Bold)
                    {
                        newStyle = currentFont.Style & ~FontStyle.Bold;
                    }
                    else
                    {
                        newStyle = currentFont.Style | FontStyle.Bold;
                    }
                    Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
                    cell.Style.Font = newFont;
                }
            }

            else
            {
                MessageBox.Show("No cell is selected");
            }



            //if (Form1.tempCell != null)
            //{
            //    Font currentFont = Form1.tempCell.Style.Font ?? new Font("Arial", 10);
            //    FontStyle newStyle;
            //    if ((currentFont.Style & FontStyle.Bold) == FontStyle.Bold) 
            //    {
            //        newStyle = currentFont.Style & ~FontStyle.Bold;
            //    }
            //    else
            //    {
            //        newStyle = currentFont.Style | FontStyle.Bold;
            //    }
            //    Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            //    Form1.tempCell.Style.Font = newFont;
            //}
            //else
            //{
            //    MessageBox.Show("No cell is selected. Please select a cell to toggle underline.", "Error");
            //}
        }

        private void ItalicsButton_Click(object sender, EventArgs e)
        {
            if (Form1.FocusedCellSet.Count>0)
            {
                foreach (DataGridViewCell cell in Form1.FocusedCellSet)
                {
                    Font currentFont = cell.Style.Font ?? new Font("Arial", 10);

                    FontStyle newStyle;
                    if ((currentFont.Style & FontStyle.Italic) == FontStyle.Italic)
                    {
                        newStyle = currentFont.Style & ~FontStyle.Italic;
                    }
                    else
                    {
                        newStyle = currentFont.Style | FontStyle.Italic;
                    }

                    Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
                    cell.Style.Font = newFont;
                }
            }
            else
            {
                MessageBox.Show("No cell is selected. Please select a cell to toggle underline.", "Error");
            }
        }

        private void UnderlineTEXT_Click(object sender, EventArgs e)
        {
            if (Form1.FocusedCellSet.Count>0)
            {
                foreach (DataGridViewCell cell in Form1.FocusedCellSet)
                {
                    Font currentFont = cell.Style.Font ?? new Font("Arial", 10);

                    FontStyle newStyle;
                    if ((currentFont.Style & FontStyle.Underline) == FontStyle.Underline)
                    {
                        newStyle = currentFont.Style & ~FontStyle.Underline;
                    }
                    else
                    {
                        newStyle = currentFont.Style | FontStyle.Underline;
                    }

                    Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);

                    cell.Style.Font = newFont;
                }
            }
            else
            {
                MessageBox.Show("No cell is selected. Please select a cell to toggle underline.", "Error");
            }
        }

        private void IncSizeFont_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in Form1.FocusedCellSet)
            {
                Font currentFont = cell.Style.Font != null ? cell.Style.Font : new Font("Arial", 10);
                Font newFont = new Font(currentFont.FontFamily, currentFont.Size + 2);
                cell.Style.Font = newFont;
                if (fontSizeBox.Items.Contains((int)newFont.Size))
                {
                    fontSizeBox.SelectedItem = (int)newFont.Size; // Update selection
                }
                else
                {
                    fontSizeBox.Items.Add((int)newFont.Size);
                    fontSizeBox.SelectedItem = (int)newFont.Size;
                }
            }
        }

        private void DecFontSize_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in Form1.FocusedCellSet)
            {
                Font currentFont = cell.Style.Font != null ? cell.Style.Font : new Font("Arial", 8);
                float newFontSize = currentFont.Size - 2;
                if (newFontSize > 0)
                {
                    Font newFont = new Font(currentFont.FontFamily, currentFont.Size - 2);
                   cell.Style.Font = newFont;
                    if (fontSizeBox.Items.Contains((int)newFont.Size))
                    {
                        fontSizeBox.SelectedItem = (int)newFont.Size;
                    }
                    else
                    {
                        fontSizeBox.Items.Add((int)newFont.Size);
                        fontSizeBox.SelectedItem = (int)newFont.Size;
                    }
                }
            }

        }

        private void fontSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Form1.FocusedCellSet.Count>0)
            {
                foreach (DataGridViewCell cell in Form1.FocusedCellSet)
                {
                    string selectedFont = fontSelectBox.SelectedItem.ToString();
                    Font currentFont = cell.Style.Font != null ? cell.Style.Font : new Font("Arial", 10, FontStyle.Regular);
                    cell.Style.Font = new Font(selectedFont, currentFont.Size, currentFont.Style);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // display the current cell selected
            int col = Form1.FocusedCellSet.First().ColumnIndex;
            int row = Form1.FocusedCellSet.First().RowIndex;

            
            //essageBox.Show($"Column: {col}, Row: {row}");

        }
    }
}
