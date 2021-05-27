using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace Search
{
    public partial class SearchPanel : UserControl
    {
        private SfDataGrid sfDataGrid;
        public SearchPanel(SfDataGrid sfDataGrid)
        {
            this.sfDataGrid = sfDataGrid;
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            btnClear.Click += btnPrevious_Click;
            chkApplyFilter.Click += ChkApplyFilter_Click;          
        }

        private void ChkApplyFilter_Click(object sender, EventArgs e)
        {
            this.sfDataGrid.SearchController.AllowFiltering = true;
        }

        void btnPrevious_Click(object sender, EventArgs e)
        {
            sfDataGrid.SearchController.ClearSearch();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sfDataGrid.SearchController.Search(" ");
        }
    }
}
