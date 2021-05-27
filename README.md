# How to search the empty rows in WinForms DataGrid (SfDataGrid)?

## About the sample

This example illustrates how to search and filter the empty rows in WinForms DataGrid (SfDataGrid).

[WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid) allows you to search and filter empty rows by customizing the [SearchController](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SearchController.html).

```C#

public Form1()
{
    InitializeComponent();

    sfDataGrid1.SearchController = new SearchControllerExt(sfDataGrid1, panel);
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
```

## Requirements to run the demo 

Visual Studio 2015 and above versions.

