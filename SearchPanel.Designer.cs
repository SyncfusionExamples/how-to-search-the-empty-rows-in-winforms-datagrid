namespace Search
{
    partial class SearchPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkNonEmpty = new System.Windows.Forms.CheckBox();
            this.chkEmptyCell = new System.Windows.Forms.CheckBox();
            this.chkEmptyRows = new System.Windows.Forms.CheckBox();
            this.chkApplyFilter = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkNonEmpty
            // 
            this.chkNonEmpty.AutoSize = true;
            this.chkNonEmpty.Location = new System.Drawing.Point(18, 143);
            this.chkNonEmpty.Name = "chkNonEmpty";
            this.chkNonEmpty.Size = new System.Drawing.Size(103, 17);
            this.chkNonEmpty.TabIndex = 18;
            this.chkNonEmpty.Text = "Non Empty rows";
            this.chkNonEmpty.UseVisualStyleBackColor = false;
            // 
            // chkEmptyCell
            // 
            this.chkEmptyCell.AutoSize = true;
            this.chkEmptyCell.Location = new System.Drawing.Point(151, 143);
            this.chkEmptyCell.Name = "chkEmptyCell";
            this.chkEmptyCell.Size = new System.Drawing.Size(134, 17);
            this.chkEmptyCell.TabIndex = 15;
            this.chkEmptyCell.Text = "AtLeast one Empty cell";
            this.chkEmptyCell.UseVisualStyleBackColor = false;
            // 
            // chkEmptyRows
            // 
            this.chkEmptyRows.AutoSize = true;
            this.chkEmptyRows.Location = new System.Drawing.Point(151, 117);
            this.chkEmptyRows.Name = "chkEmptyRows";
            this.chkEmptyRows.Size = new System.Drawing.Size(85, 17);
            this.chkEmptyRows.TabIndex = 14;
            this.chkEmptyRows.Text = "Empty Rows";
            this.chkEmptyRows.UseVisualStyleBackColor = false;
            // 
            // chkApplyFilter
            // 
            this.chkApplyFilter.AutoSize = true;
            this.chkApplyFilter.Location = new System.Drawing.Point(18, 117);
            this.chkApplyFilter.Name = "chkApplyFilter";
            this.chkApplyFilter.Size = new System.Drawing.Size(77, 17);
            this.chkApplyFilter.TabIndex = 13;
            this.chkApplyFilter.Text = "Apply Filter";
            this.chkApplyFilter.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(170, 39);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Search";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search Panel";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 38);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 39);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 25);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search Empty Rows";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkNonEmpty);
            this.Controls.Add(this.chkEmptyCell);
            this.Controls.Add(this.chkEmptyRows);
            this.Controls.Add(this.chkApplyFilter);
            this.Controls.Add(this.btnClear);
            this.Name = "SearchPanel";
            this.Size = new System.Drawing.Size(345, 169);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chkNonEmpty;
        public System.Windows.Forms.CheckBox chkEmptyCell;
        public System.Windows.Forms.CheckBox chkEmptyRows;
        private System.Windows.Forms.CheckBox chkApplyFilter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
    }
}
