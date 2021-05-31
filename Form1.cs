using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Interactivity;
using Syncfusion.WinForms.GridCommon.ScrollAxis;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search
{
    public partial class Form1 : Form
    {
        #region Fields
        OrderInfoCollection orderInfo;
        SearchPanel panel;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            orderInfo = new OrderInfoCollection();
            this.sfDataGrid1.DataSource = orderInfo.OrdersListDetails;
            panel = new SearchPanel(this.sfDataGrid1);
            sfDataGrid1.Controls.Add(panel);
            panel.BringToFront();
            panel.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            panel.Location = sfDataGrid1.TableControl.PointToClient(new Point(sfDataGrid1.Width - (panel.Width) - 8, 0));
            panel.Show();
         
            sfDataGrid1.TableControl.KeyDown += TableControl_KeyDown;
            this.sfDataGrid1.SearchController.AllowHighlightSearchText = false;
            sfDataGrid1.SearchController = new SearchControllerExt(sfDataGrid1, panel);
        }

        void TableControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                panel.Visible = true;
            }
        }
        #endregion
    }

    public class SearchControllerExt : SearchController
    {
        SearchPanel searchPanel;
        public SearchControllerExt(SfDataGrid grid, SearchPanel panel) :
        base(grid)
        {
            searchPanel = panel;
            this.AllowHighlightSearchText = false;
        }

        protected override bool FilterRecords(object dataRow)
        {
            if (this.Provider == null)
                Provider = this.DataGrid.View.GetPropertyAccessProvider();
            if (searchPanel.chkEmptyRows.Checked)
            {
                for (int i = 0; i < this.DataGrid.Columns.Count; i++)
                {
                    var col = this.DataGrid.Columns[i];
                    var cellvalue = Provider.GetFormattedValue(dataRow, col.MappingName);
                    if (cellvalue == null)
                        continue;
                    else
                        return false;
                }
                return true;
            }
            else if (searchPanel.chkNonEmpty.Checked)
            {
                for (int i = 0; i < this.DataGrid.Columns.Count; i++)
                {
                    var col = this.DataGrid.Columns[i];
                    var cellvalue = Provider.GetFormattedValue(dataRow, col.MappingName);
                    if (cellvalue != null)
                        continue;
                    else
                        return false;
                }
                return true;
            }
            else if(searchPanel.chkEmptyCell.Checked)
            {

                for (int i = 0; i < this.DataGrid.Columns.Count; i++)
                {
                    var col = this.DataGrid.Columns[i];
                    var cellvalue = Provider.GetFormattedValue(dataRow, col.MappingName);
                    if (cellvalue == null)
                        return true;
                    else
                        continue;
                }
                return false;
            }
            else
                return base.FilterRecords(dataRow);
        }
       
    }

}
