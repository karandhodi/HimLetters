using EASendMail;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Windows.Forms;

namespace HimLetters
{
    public partial class MainForm : Form
    {
       
        /// <summary> 
        /// MainForm constructor
        /// </summary> 
        /// <returns>
        /// </returns>
        public MainForm()
        {
            InitializeComponent();
        }
        
        /// <summary> 
        /// Method to execute menuItemExit click event
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        /// <returns>
        /// </returns>
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        /// <summary> 
        /// Method to execute when MainForm load event takes place
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        /// <returns>
        /// </returns>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // setting window size and position
            this.Height = Screen.PrimaryScreen.WorkingArea.Size.Height + 10;
            this.Width = 1100;
            this.CenterToScreen();

            InitializeListViewDocumentType();
            InitializeCmbBoxLetterType();
            InitializeCmbBoxFacility();

            // setting dataGridView's background color 
            dataGridViewPhysicians.ColumnHeadersDefaultCellStyle.BackColor = Control.DefaultBackColor;
            dataGridViewPhysicians.EnableHeadersVisualStyles = false;

            dataGridViewPhysicians.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewPhysicians.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;

            dataGridViewPhysicians.Columns[0].Width = 100;
            dataGridViewPhysicians.Columns[1].Width = 100;
            dataGridViewPhysicians.Columns[2].Width = 100;
            dataGridViewPhysicians.Columns[3].Width = 500;

            dataGridViewPhysiciansExclude.ColumnHeadersDefaultCellStyle.BackColor = Control.DefaultBackColor;
            dataGridViewPhysiciansExclude.EnableHeadersVisualStyles = false;

            dataGridViewPhysiciansExclude.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewPhysiciansExclude.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;

            dataGridViewPhysicians.RowTemplate.Height = 5;

            menuItemStatusBar.Checked = true;

            radioBtnSortProviderName.Checked = true;
            radioBtnProviderName.Checked = true;

            btnRetrievePhysicians.Enabled = false;
            btnDistributeLetters.Enabled = false;
            btnMove.Enabled = false;
            btnSelectAll.Enabled = false;
            btnPrintList.Enabled = false;
            menuItemEmail.Enabled = false;
            menuItemPaper.Enabled = false;
            menuItemPrint.Enabled = false;

            Email.TrueValue = true;
            Email.FalseValue = false;
        }

        /// <summary> 
        /// Method to initialize Letter Type combo box
        /// </summary> 
        /// <returns>
        /// </returns>
        private void InitializeCmbBoxLetterType()
        {
            try
            {
                WebClient proxy = new WebClient();
                byte[] data = proxy.DownloadData("http://localhost:49962/ServiceLetterType.svc/getlettertypelist");
                Stream stream = new MemoryStream(data);
                DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<ServiceReferenceLetterType.getLetterTypeList_Results>));
                List<ServiceReferenceLetterType.getLetterTypeList_Results> srlt = obj.ReadObject(stream) as List<ServiceReferenceLetterType.getLetterTypeList_Results>;

                for (int letterTypeListIndex = 0; letterTypeListIndex < srlt.Count; ++letterTypeListIndex)
                {
                    cmbBoxLetterType.Items.Add(srlt[letterTypeListIndex].Name);
                }
            }

            catch (FaultException<ServiceReferenceLetterType.LetterTypeException> ex)
            {
                MessageBox.Show(ex.Message);
                Logger(ex.Message);
            }

        }

        /// <summary> 
        /// Method to initialize Facility combo box
        /// </summary> 
        /// <returns>
        /// </returns>
        private void InitializeCmbBoxFacility()
        {
            try
            {
                WebClient proxy = new WebClient();
                byte[] data = proxy.DownloadData("http://localhost:49962/ServiceFacility.svc/getfacility");
                Stream stream = new MemoryStream(data);
                DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<ServiceReferenceFacility.getFacility_Results>));
                List<ServiceReferenceFacility.getFacility_Results> srf = obj.ReadObject(stream) as List<ServiceReferenceFacility.getFacility_Results>;

                cmbBoxFacility.Items.Add("All Facilities");

                for (int facilityListIndex = 0; facilityListIndex < srf.Count; ++facilityListIndex)
                {
                    cmbBoxFacility.Items.Add(srf[facilityListIndex].Facility_Name);
                }
            }
            catch (FaultException<ServiceReferenceFacility.FacilityException> ex)
            {
                MessageBox.Show(ex.Message);
                Logger(ex.Message);
            }


        }

        /// <summary> 
        /// Method to initialize Document Type list view
        /// </summary> 
        /// <returns>
        /// </returns>
        private void InitializeListViewDocumentType()
        {
            int itemHeight = 20;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, itemHeight);
            listViewDocumentType.SmallImageList = imgList;

            ListViewItem item = new ListViewItem("All document types");
            item.Checked = true;
            listViewDocumentType.Items.Add(item);

            item = new ListViewItem("Coding Note");
            item.Checked = true;
            listViewDocumentType.Items.Add(item);

            item = new ListViewItem("Consultation Note");
            item.Checked = true;
            listViewDocumentType.Items.Add(item);

            item = new ListViewItem("Discharge Note-Physician");
            item.Checked = true;
            listViewDocumentType.Items.Add(item);

            item = new ListViewItem("History and Physical");
            item.Checked = true;
            listViewDocumentType.Items.Add(item);

            item = new ListViewItem("Operative Report");
            item.Checked = true;
            listViewDocumentType.Items.Add(item);

            item = new ListViewItem("Progressive Note-Physician");
            item.Checked = true;
            listViewDocumentType.Items.Add(item);
        }

        /// <summary> 
        /// Method to execute menuItemStatusBar click event
        /// </summary> 
        /// <returns>
        /// </returns>
        private void menuItemStatusBar_Click(object sender, EventArgs e)
        {
            if (statusStripMainForm.Visible == true)
            {
                menuItemStatusBar.Checked = false;
                statusStripMainForm.Visible = false;
            }
            else
            {
                menuItemStatusBar.Checked = true;
                statusStripMainForm.Visible = true;
            }
        }

        /// <summary> 
        /// Method to execute cmbBoxLetterType selected index change event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void cmbBoxLetterType_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnSelectAll.Enabled = false;
            btnMove.Enabled = false;
            btnMove.Text = "Move";
            btnDistributeLetters.Enabled = false;
            btnPrintList.Enabled = false;
            menuItemPrint.Enabled = false;

            dataGridViewPhysiciansExclude.Rows.Clear();
            dataGridViewPhysicians.Rows.Clear();

            if (cmbBoxFacility.SelectedIndex != -1)
                btnRetrievePhysicians.Enabled = true;

            int index = cmbBoxLetterType.SelectedIndex + 1;

            try
            {
                WebClient proxy = new WebClient();
                String url = String.Format("http://localhost:49962/ServiceLetterDetails.svc/getLetterDetail/{0}", index);
                byte[] data = proxy.DownloadData(url);
                Stream stream = new MemoryStream(data);
                DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<ServiceReferenceLetterDetails.getLetterDetail_Results>));
                List<ServiceReferenceLetterDetails.getLetterDetail_Results> srld = obj.ReadObject(stream) as List<ServiceReferenceLetterDetails.getLetterDetail_Results>;

                if (srld[0].Chart_On_Hold == null)
                {
                    lblChartOnHold.Enabled = false;
                    lblChartOnHoldValue.Text = String.Empty;
                }
                else
                {
                    lblChartOnHoldValue.Text = srld[0].Chart_On_Hold;
                    lblChartOnHold.Enabled = true;
                }

                if (srld[0].Charts_To_Include == null)
                {
                    lblChartsToInclude.Enabled = false;
                    lblChartsToIncludeValue.Text = String.Empty;
                }
                else
                {
                    lblChartsToIncludeValue.Text = srld[0].Charts_To_Include;
                    lblChartsToInclude.Enabled = true;
                }

                if (srld[0].Deficiencies_To_Include == null)
                {
                    lblDeficienciesToInclude.Enabled = false;
                    lblDeficienciesToIncludeValue.Text = String.Empty;
                }
                else
                {
                    lblDeficienciesToIncludeValue.Text = srld[0].Deficiencies_To_Include;
                    lblDeficienciesToInclude.Enabled = true;
                }

                if (srld[0].Include_Documents == null)
                {
                    lblIncludeDocuments.Enabled = false;
                    lblIncludeDocumentsValue.Text = String.Empty;
                }
                else
                {
                    lblIncludeDocumentsValue.Text = srld[0].Include_Documents;
                    lblIncludeDocuments.Enabled = true;
                }

                if (srld[0].Include_Visits == null)
                {
                    lblIncludeVisits.Enabled = false;
                    lblIncludeVisitsValue.Text = String.Empty;
                }
                else
                {
                    lblIncludeVisitsValue.Text = srld[0].Include_Visits;
                    lblIncludeVisits.Enabled = true;
                }

                if (srld[0].Physicians_To_Include == null)
                {
                    lblPhysiciansToInclude.Enabled = false;
                    lblPhysiciansToIncludeValue.Text = String.Empty;
                }
                else
                {
                    lblPhysiciansToIncludeValue.Text = srld[0].Physicians_To_Include;
                    lblPhysiciansToInclude.Enabled = true;
                }
                if (srld[0].Chart_On_Hold == null)
                {
                    lblChartOnHold.Enabled = false;
                    lblChartOnHoldValue.Text = String.Empty;
                }
                else
                {
                    lblChartOnHoldValue.Text = srld[0].Chart_On_Hold;
                    lblChartOnHold.Enabled = true;
                }

                if (srld[0].Deficient_Day_Range_Start == null)
                {
                    lblDeficientDayRange.Enabled = false;
                    lblDeficiencyDayRangeValue.Text = String.Empty;
                }
                else
                {
                    lblDeficiencyDayRangeValue.Text = srld[0].Deficient_Day_Range_Start + "-" + srld[0].Deficient_Day_Range_End;
                    lblDeficientDayRange.Enabled = true;
                }
            }
            catch (FaultException<ServiceReferenceLetterDetails.LetterDetailsException> ex)
            {
                MessageBox.Show(ex.Message);
                Logger(ex.Message);
            }
        }

        /// <summary> 
        /// Method to execute btnRetrievePhysicians click event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void btnRetrievePhysicians_Click(object sender, EventArgs e)
        {
            String url = String.Empty;

            int letterTypeIndex = cmbBoxLetterType.SelectedIndex + 1;
            int facilityIndex = cmbBoxFacility.SelectedIndex;

            if (facilityIndex != 0)
            {
                try
                {
                    url = String.Format("http://localhost:49962/ServicePhysician.svc/getPhysiciansList/{0}/{1}", letterTypeIndex, facilityIndex);
                }
                catch (FaultException<ServiceReferencePhysician.PhysicianException> ex)
                {
                    MessageBox.Show(ex.Message);
                    Logger(ex.Message);
                }
            }
            else
            {
                try
                {
                    url = String.Format("http://localhost:49962/ServicePhysicianAll.svc/getphysicianslistall/{0}", letterTypeIndex);
                }
                catch (FaultException<ServiceReferencePhysicianAll.PhysicianAllException> ex)
                {
                    MessageBox.Show(ex.Message);
                    Logger(ex.Message);
                }
            }


            
                WebClient proxy = new WebClient();
                byte[] data = proxy.DownloadData(url);
                Stream stream = new MemoryStream(data);
                DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<ServiceReferencePhysician.getPhysiciansList_Results>));
                List<ServiceReferencePhysician.getPhysiciansList_Results> srp = obj.ReadObject(stream) as List<ServiceReferencePhysician.getPhysiciansList_Results>;
                dataGridViewPhysicians.Rows.Clear();

                if (srp.Count == 0)
                    MessageBox.Show("No personnel found for the selected letter type", "ProFile: Letters");
                else
                {
                    btnRetrievePhysicians.Enabled = false;
                    btnDistributeLetters.Enabled = true;
                    btnSelectAll.Enabled = true;
                    btnPrintList.Enabled = true;
                    menuItemPrint.Enabled = true;

                    btnMove.Text = "Move >";

                    for (int physicianListIndex = 0; physicianListIndex < srp.Count; ++physicianListIndex)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridViewPhysicians);

                        row.Cells[3].Value = srp[physicianListIndex].Name;
                        row.Cells[2].Value = true;
                        dataGridViewPhysicians.Rows.Add(row);
                    }

                    dataGridViewPhysicians.Rows[0].Selected = false;
                }
        }

        /// <summary> 
        /// Method to execute cmbBoxFacility selected index change event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void cmbBoxFacility_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewPhysiciansExclude.Rows.Clear();
            dataGridViewPhysicians.Rows.Clear();

            btnSelectAll.Enabled = false;
            btnMove.Enabled = false;
            btnMove.Text = "Move";
            btnDistributeLetters.Enabled = false;
            btnPrintList.Enabled = false;
            menuItemPrint.Enabled = false;

            if (cmbBoxLetterType.SelectedIndex != -1)
                btnRetrievePhysicians.Enabled = true;
        }

        /// <summary> 
        /// Method to execute btnSelectAll click event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (btnMove.Text.Contains(">"))
            {
                foreach (DataGridViewRow row in dataGridViewPhysicians.Rows)
                    row.Selected = true;
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewPhysiciansExclude.Rows)
                    row.Selected = true;
            }

            btnMove.Enabled = true;
        }

        /// <summary> 
        /// Method to center the titlebar text
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void MainForm_Resize(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;

            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }

            this.Text = tmp + this.Text.Trim();
        }

        /// <summary> 
        /// Method to paint the dataGridViewPhysician radio buttons
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void dataGridViewPhysicians_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == Email.Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);

                Rectangle rectRadioButton = new Rectangle();

                rectRadioButton.Width = 14;
                rectRadioButton.Height = 14;
                rectRadioButton.X = e.CellBounds.X + (e.CellBounds.Width - rectRadioButton.Width) / 2;
                rectRadioButton.Y = e.CellBounds.Y + (e.CellBounds.Height - rectRadioButton.Height) / 2;

                ButtonState buttonState;


                if (e.Value == null || (bool)(e.Value) == false)
                {
                    buttonState = ButtonState.Normal;
                }
                else
                {
                    buttonState = ButtonState.Checked;
                }


                ControlPaint.DrawRadioButton(e.Graphics, rectRadioButton, buttonState);

                e.Paint(e.ClipBounds, DataGridViewPaintParts.Focus);

                e.Handled = true;

            }



            if (e.ColumnIndex == Fax.Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);

                Rectangle rectRadioButton = new Rectangle();

                rectRadioButton.Width = 14;
                rectRadioButton.Height = 14;
                rectRadioButton.X = e.CellBounds.X + (e.CellBounds.Width - rectRadioButton.Width) / 2;
                rectRadioButton.Y = e.CellBounds.Y + (e.CellBounds.Height - rectRadioButton.Height) / 2;

                ButtonState buttonState;


                if (e.Value == null || (bool)(e.Value) == false)
                {
                    buttonState = ButtonState.Normal;
                }
                else
                {
                    buttonState = ButtonState.Checked;
                }


                ControlPaint.DrawRadioButton(e.Graphics, rectRadioButton, buttonState);

                e.Paint(e.ClipBounds, DataGridViewPaintParts.Focus);

                e.Handled = true;
            }

            if (e.ColumnIndex == Paper.Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);

                Rectangle rectRadioButton = new Rectangle();

                rectRadioButton.Width = 14;
                rectRadioButton.Height = 14;
                rectRadioButton.X = e.CellBounds.X + (e.CellBounds.Width - rectRadioButton.Width) / 2;
                rectRadioButton.Y = e.CellBounds.Y + (e.CellBounds.Height - rectRadioButton.Height) / 2;

                ButtonState buttonState;

                if (e.Value == null || (bool)(e.Value) == false)
                {
                    buttonState = ButtonState.Normal;
                }
                else
                {
                    buttonState = ButtonState.Checked;
                }


                ControlPaint.DrawRadioButton(e.Graphics, rectRadioButton, buttonState);

                e.Paint(e.ClipBounds, DataGridViewPaintParts.Focus);

                e.Handled = true;
            }

        }

        /// <summary> 
        /// Method to execute dataGridViewPhysicians cell click event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void dataGridViewPhysicians_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridViewPhysicians.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Value = true;
                radioButtonChanged();
            }

            btnMove.Text = "Move >";
            btnMove.Enabled = true;
            btnSelectAll.Enabled = true;

            DataGridViewRow row = this.dataGridViewPhysicians.Rows[e.RowIndex];

            if (Convert.ToBoolean(row.Cells[0].Value))
            {
                menuItemEmail.Enabled = true;
            }
            else
            {
                menuItemEmail.Enabled = false;
            }

            if (Convert.ToBoolean(row.Cells[2].Value))
            {
                menuItemPaper.Enabled = true;
            }
            else
            {
                menuItemPaper.Enabled = false;
            }
        }

        /// <summary> 
        /// Method to execute whenever dataGridViewPhysician radio button's value changes
        /// </summary> 
        /// <returns>
        /// </returns>
        private void radioButtonChanged()
        {
            int columnIndex = dataGridViewPhysicians.CurrentCell.ColumnIndex;
            int rowIndex = dataGridViewPhysicians.CurrentCell.RowIndex;

            foreach (DataGridViewRow row in dataGridViewPhysicians.Rows)
            {
                // Make sure not to uncheck the radio button the user just clicked.
                if (row.Index == rowIndex)
                {
                    foreach (DataGridViewColumn column in dataGridViewPhysicians.Columns)
                    {
                        if (column.Index != columnIndex && column.Index != 3)
                        {
                            row.Cells[column.Index].Value = false;
                        }
                    }
                }
            }


        }

        /// <summary> 
        /// Method to execute btnMove click event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void btnMove_Click(object sender, EventArgs e)
        {
            if (btnMove.Text.Contains(">"))
            {
                foreach (DataGridViewRow row in dataGridViewPhysicians.SelectedRows)
                {
                    string physicianName = row.Cells["Physician"].Value.ToString();

                    dataGridViewPhysicians.Rows.RemoveAt(row.Index);

                    DataGridViewRow rowExclude = new DataGridViewRow();
                    rowExclude.CreateCells(dataGridViewPhysiciansExclude);

                    rowExclude.Cells[0].Value = physicianName;
                    dataGridViewPhysiciansExclude.Rows.Add(rowExclude);
                }

                if (dataGridViewPhysicians.Rows.Count == 0)
                {
                    btnMove.Enabled = false;
                    btnSelectAll.Enabled = false;
                }

                if (dataGridViewPhysiciansExclude.Rows.Count != 0)
                    dataGridViewPhysiciansExclude.Rows[0].Selected = false;
            }
            else
            {
                foreach (DataGridViewRow rowExclude in dataGridViewPhysiciansExclude.SelectedRows)
                {
                    string physicianName = rowExclude.Cells["PhysicianExclude"].Value.ToString();

                    dataGridViewPhysiciansExclude.Rows.RemoveAt(rowExclude.Index);

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewPhysicians);

                    row.Cells[3].Value = physicianName;
                    row.Cells[2].Value = true;
                    dataGridViewPhysicians.Rows.Add(row);
                }

                if (dataGridViewPhysiciansExclude.Rows.Count == 0)
                {
                    btnMove.Enabled = false;
                    btnSelectAll.Enabled = false;
                }
                if (dataGridViewPhysicians.Rows.Count != 0)
                    dataGridViewPhysicians.Rows[0].Selected = false;

            }
        }

        /// <summary> 
        /// Method to execute menuItemAbout click event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wiki.ucern.com/pages/viewpage.action?spaceKey=eutmaterials&title=Using+Letters");
        }

        /// <summary> 
        /// Method to execute dataGridViewPhysiciansExclude cell click event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void dataGridViewPhysiciansExclude_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnMove.Text = "< Move";
            btnMove.Enabled = true;
            btnSelectAll.Enabled = true;
        }

        /// <summary> 
        /// Method to execute btnPrintList click event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void btnPrintList_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
            printPrvDlg.Document = printDocumentPrintList;

            printPrvDlg.ShowDialog();

        }

        /// <summary> 
        /// Method to create printDocumentPrintList
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String drawString;

            int index = 1;

            // Create font and brush.
            Font drawFont = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            if (btnMove.Text.Contains(">"))
            {
                // Create point for upper-left corner of drawing.
                PointF drawPoint = new PointF(300.0F, 150.0F);

                // Create string to draw.
                drawString = "Physicians list\n";

                // Draw string to screen.
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);

                foreach (DataGridViewRow row in dataGridViewPhysicians.Rows)
                {
                    drawString = index + ". " + row.Cells[3].Value.ToString() + "\n";

                    drawFont = new Font("Arial", 20);
                    drawBrush = new SolidBrush(Color.Black);

                    float y = index * 50;

                    drawPoint = new PointF(150.0F, 200.0F + y);

                    ++index;

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
                }
            }
            else
            {
                // Create point for upper-left corner of drawing.
                PointF drawPoint = new PointF(200.0F, 150.0F);

                // Create string to draw.
                drawString = "Physicians to exclude list\n";

                // Draw string to screen.
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);

                foreach (DataGridViewRow row in dataGridViewPhysiciansExclude.Rows)
                {
                    drawString = index + ". " + row.Cells[0].Value.ToString() + "\n";

                    drawFont = new Font("Arial", 20);
                    drawBrush = new SolidBrush(Color.Black);

                    float y = index * 50;

                    drawPoint = new PointF(150.0F, 200.0F + y);

                    ++index;

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
                }

            }
        }

        /// <summary> 
        /// Method to create printDocumentDistributeLetters
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void printDocumentDistributeLetters_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int index = 1;

            // Create font and brush.
            Font drawFont = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(180.0F, 150.0F);

            // Create string to draw.
            string drawString = "Deficiency Notification Letters\n";

            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);

            foreach (DataGridViewRow row in dataGridViewPhysicians.Rows)
            {
                if (Convert.ToBoolean(row.Cells[2].Value))
                {
                    drawString = index + ". " + row.Cells[3].Value.ToString() + "\n";

                    drawFont = new Font("Arial", 20);
                    drawBrush = new SolidBrush(Color.Black);

                    float y = index * 50;

                    drawPoint = new PointF(150.0F, 200.0F + y);

                    ++index;

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
                }
            }



        }

        /// <summary> 
        /// Method to execute btnDistributeLetters click event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void btnDistributeLetters_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
            printPrvDlg.Document = printDocumentDistributeLetters;

            printPrvDlg.ShowDialog();

            distributeLettersEmail();
        }

        /// <summary> 
        /// Method to distribute email notifications to the physicians
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void distributeLettersMenuEmail()
        {
            String url;

            int letterTypeIndex = cmbBoxLetterType.SelectedIndex + 1;
            int facilityIndex = cmbBoxFacility.SelectedIndex;

            if (facilityIndex != 0)
            {

                url = String.Format("http://localhost:49962/ServicePhysician.svc/getPhysiciansList/{0}/{1}", letterTypeIndex, facilityIndex);

            }
            else
            {
                url = String.Format("http://localhost:49962/ServicePhysicianAll.svc/getphysicianslistall/{0}", letterTypeIndex);
            }

            WebClient proxy = new WebClient();
            byte[] data = proxy.DownloadData(url);
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<ServiceReferencePhysician.getPhysiciansList_Results>));
            List<ServiceReferencePhysician.getPhysiciansList_Results> srp = obj.ReadObject(stream) as List<ServiceReferencePhysician.getPhysiciansList_Results>;

            SmtpMail oMail = new SmtpMail("TryIt");
            EASendMail.SmtpClient oSmtp = new EASendMail.SmtpClient();

            oMail.From = "karandhodi@ymail.com";

            // Set email subject
            oMail.Subject = "Deficiency Notification Letter";

            // Set email body
            oMail.TextBody = "Notifying deficiencies";

            SmtpServer oServer = new SmtpServer("smtp.mail.yahoo.com");

            oServer.User = "karandhodi@ymail.com";
            oServer.Password = "Sairam3#";

            oServer.Port = 465;

            // detect SSL type automatically
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

            foreach (DataGridViewRow row in dataGridViewPhysicians.SelectedRows)
            {
                for (int physicianListIndex = 0; physicianListIndex < srp.Count; ++physicianListIndex)
                {
                    if (srp[physicianListIndex].Name.Equals(row.Cells[3].Value.ToString()) && Convert.ToBoolean(row.Cells[0].Value))
                    {
                        try
                        {
                            // Set recipient email address
                            oMail.To = srp[physicianListIndex].Email;

                            Console.WriteLine("start to send email over SSL ...");
                            oSmtp.SendMail(oServer, oMail);
                            Console.WriteLine("email was sent successfully!");
                            MessageBox.Show("Email sent to: " + srp[physicianListIndex].Name);
                        }
                        catch (Exception ep)
                        {
                            Console.WriteLine("failed to send email with the following error:");
                            Console.WriteLine(ep.Message);
                            MessageBox.Show("Email could not be sent to: " + srp[physicianListIndex].Name);
                        }

                    }
                }
            }

        }

        /// <summary> 
        /// Method to distribute email notifications to the physicians
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void distributeLettersEmail()
        {
            String url;

            int letterTypeIndex = cmbBoxLetterType.SelectedIndex + 1;
            int facilityIndex = cmbBoxFacility.SelectedIndex;

            if (facilityIndex != 0)
            {

                url = String.Format("http://localhost:49962/ServicePhysician.svc/getPhysiciansList/{0}/{1}", letterTypeIndex, facilityIndex);

            }
            else
            {
                url = String.Format("http://localhost:49962/ServicePhysicianAll.svc/getphysicianslistall/{0}", letterTypeIndex);
            }

            WebClient proxy = new WebClient();
            byte[] data = proxy.DownloadData(url);
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<ServiceReferencePhysician.getPhysiciansList_Results>));
            List<ServiceReferencePhysician.getPhysiciansList_Results> srp = obj.ReadObject(stream) as List<ServiceReferencePhysician.getPhysiciansList_Results>;

            SmtpMail oMail = new SmtpMail("TryIt");
            EASendMail.SmtpClient oSmtp = new EASendMail.SmtpClient();

            oMail.From = "karandhodi@ymail.com";

            // Set email subject
            oMail.Subject = "Deficiency Notification Letter";

            // Set email body
            oMail.TextBody = "Notifying deficiencies";

            SmtpServer oServer = new SmtpServer("smtp.mail.yahoo.com");

            oServer.User = "karandhodi@ymail.com";
            oServer.Password = "Sairam3#";

            oServer.Port = 465;

            // detect SSL type automatically
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

            foreach (DataGridViewRow row in dataGridViewPhysicians.Rows)
            {
                for (int physicianListIndex = 0; physicianListIndex < srp.Count; ++physicianListIndex)
                {
                    if (srp[physicianListIndex].Name.Equals(row.Cells[3].Value.ToString()) && Convert.ToBoolean(row.Cells[0].Value))
                    {
                        try
                        {
                            // Set recipient email address
                            oMail.To = srp[physicianListIndex].Email;

                            Console.WriteLine("start to send email over SSL ...");
                            oSmtp.SendMail(oServer, oMail);
                            Console.WriteLine("email was sent successfully!");
                            MessageBox.Show("Email sent to: "+ srp[physicianListIndex].Name);
                        }
                        catch (Exception ep)
                        {
                            Console.WriteLine("failed to send email with the following error:");
                            Console.WriteLine(ep.Message);
                            MessageBox.Show("Email could not be sent to: "+ srp[physicianListIndex].Name);
                        }

                    }
                }
            }
        }

        /// <summary> 
        /// Method to execute menuItemPrint click event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void menuItemPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
            printPrvDlg.Document = printDocumentPrintList;

            printPrvDlg.ShowDialog();
        }

        /// <summary> 
        /// Method to handle KeyDown event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (menuItemPrint.Enabled == true)
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.P)
                {
                    PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
                    printPrvDlg.Document = printDocumentPrintList;

                    printPrvDlg.ShowDialog();
                }
            }
            

            if (menuItemPaper.Enabled == true)
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
                {
                    PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
                    printPrvDlg.Document = printDocumentDistributeLettersMenu;

                    printPrvDlg.ShowDialog();
                }
            }

            if (menuItemEmail.Enabled == true)
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
                {
                    distributeLettersMenuEmail();
                }
            }
        }

        /// <summary> 
        /// Method to handle menuItemEmail click event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void menuItemEmail_Click(object sender, EventArgs e)
        {
            distributeLettersMenuEmail();
        }

        /// <summary> 
        /// Method to handle menuItemPaper click event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void menuItemPaper_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
            printPrvDlg.Document = printDocumentDistributeLettersMenu;

            printPrvDlg.ShowDialog();
        }

        /// <summary> 
        /// Method to create printDocumentDistributeLetters
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void printDocumentDistributeLettersMenu_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int index = 1;

            // Create font and brush.
            Font drawFont = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(180.0F, 150.0F);

            // Create string to draw.
            string drawString = "Deficiency Notification Letters\n";

            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);

            foreach (DataGridViewRow row in dataGridViewPhysicians.SelectedRows)
            {
                if (Convert.ToBoolean(row.Cells[2].Value))
                {
                    drawString = index + ". " + row.Cells[3].Value.ToString() + "\n";

                    drawFont = new Font("Arial", 20);
                    drawBrush = new SolidBrush(Color.Black);

                    float y = index * 50;

                    drawPoint = new PointF(150.0F, 200.0F + y);

                    ++index;

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
                }
            }
        }

        /// <summary> 
        /// Method to handle listViewDocumentType check event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>
        /// </returns>
        private void listViewDocumentType_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item == listViewDocumentType.Items[0])
            {
                if (listViewDocumentType.Items[0].Checked == false)
                {
                    foreach (ListViewItem item in listViewDocumentType.Items)
                    {
                        item.Checked = false;
                    }

                }

                if (listViewDocumentType.Items[0].Checked == true)
                {
                    foreach (ListViewItem item in listViewDocumentType.Items)
                    {
                        item.Checked = true;
                    }
                }
            }
        }

        public void Logger(String lines)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\KD056573\\source\\repos\\HimLetters\\log.txt", true);
            file.WriteLine(lines);

            file.Close();
        }
    }
}
