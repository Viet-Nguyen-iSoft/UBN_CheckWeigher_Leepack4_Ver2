namespace CheckWeigherUBN
{
  partial class FrmAlarm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.btnWarning = new System.Windows.Forms.Button();
      this.btnError = new System.Windows.Forms.Button();
      this.btImportFromExcel = new System.Windows.Forms.Button();
      this.btSave = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.btExit = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.tableLayoutPanel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 729);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.ColumnCount = 6;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.56635F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.56635F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.86729F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel2.Controls.Add(this.btImportFromExcel, 3, 0);
      this.tableLayoutPanel2.Controls.Add(this.btSave, 4, 0);
      this.tableLayoutPanel2.Controls.Add(this.btExit, 5, 0);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(1350, 55);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(3, 99);
      this.dataGridView1.Name = "dataGridView1";
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.Size = new System.Drawing.Size(1344, 627);
      this.dataGridView1.TabIndex = 1;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Controls.Add(this.btnWarning, 1, 0);
      this.tableLayoutPanel3.Controls.Add(this.btnError, 0, 0);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 55);
      this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(1350, 41);
      this.tableLayoutPanel3.TabIndex = 2;
      // 
      // btnWarning
      // 
      this.btnWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnWarning.BackColor = System.Drawing.Color.DimGray;
      this.btnWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnWarning.ForeColor = System.Drawing.Color.White;
      this.btnWarning.Location = new System.Drawing.Point(675, 0);
      this.btnWarning.Margin = new System.Windows.Forms.Padding(0);
      this.btnWarning.Name = "btnWarning";
      this.btnWarning.Size = new System.Drawing.Size(675, 41);
      this.btnWarning.TabIndex = 1;
      this.btnWarning.Text = "Warning";
      this.btnWarning.UseVisualStyleBackColor = false;
      this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click_1);
      // 
      // btnError
      // 
      this.btnError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.btnError.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnError.ForeColor = System.Drawing.Color.White;
      this.btnError.Location = new System.Drawing.Point(0, 0);
      this.btnError.Margin = new System.Windows.Forms.Padding(0);
      this.btnError.Name = "btnError";
      this.btnError.Size = new System.Drawing.Size(675, 41);
      this.btnError.TabIndex = 0;
      this.btnError.Text = "Error";
      this.btnError.UseVisualStyleBackColor = false;
      this.btnError.Click += new System.EventHandler(this.btnError_Click_1);
      // 
      // btImportFromExcel
      // 
      this.btImportFromExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btImportFromExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
      this.btImportFromExcel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
      this.btImportFromExcel.FlatAppearance.BorderSize = 5;
      this.btImportFromExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btImportFromExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btImportFromExcel.ForeColor = System.Drawing.Color.White;
      this.btImportFromExcel.Image = global::CheckWeigherUBN.Properties.Resources.excel_24x24;
      this.btImportFromExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btImportFromExcel.Location = new System.Drawing.Point(812, 3);
      this.btImportFromExcel.Name = "btImportFromExcel";
      this.btImportFromExcel.Size = new System.Drawing.Size(224, 47);
      this.btImportFromExcel.TabIndex = 18;
      this.btImportFromExcel.Text = " Import từ excel";
      this.btImportFromExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btImportFromExcel.UseVisualStyleBackColor = false;
      this.btImportFromExcel.Click += new System.EventHandler(this.btImportFromExcel_Click);
      // 
      // btSave
      // 
      this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
      this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
      this.btSave.FlatAppearance.BorderSize = 5;
      this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btSave.ForeColor = System.Drawing.Color.White;
      this.btSave.Image = global::CheckWeigherUBN.Properties.Resources.Save_25px;
      this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btSave.Location = new System.Drawing.Point(1042, 3);
      this.btSave.Name = "btSave";
      this.btSave.Size = new System.Drawing.Size(153, 47);
      this.btSave.TabIndex = 17;
      this.btSave.Text = "    Lưu";
      this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btSave.UseVisualStyleBackColor = false;
      this.btSave.Click += new System.EventHandler(this.btSave_Click_1);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
      // 
      // btExit
      // 
      this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
      this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
      this.btExit.FlatAppearance.BorderSize = 5;
      this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btExit.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btExit.ForeColor = System.Drawing.Color.White;
      this.btExit.Image = global::CheckWeigherUBN.Properties.Resources.icons8_Shutdown_30px;
      this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btExit.Location = new System.Drawing.Point(1201, 3);
      this.btExit.Name = "btExit";
      this.btExit.Size = new System.Drawing.Size(146, 47);
      this.btExit.TabIndex = 20;
      this.btExit.Text = " Thoát";
      this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btExit.UseVisualStyleBackColor = false;
      this.btExit.Click += new System.EventHandler(this.btExit_Click);
      // 
      // FrmAlarm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1350, 729);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmAlarm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Load += new System.EventHandler(this.FrmAlarm_Load_1);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button btImportFromExcel;
    private System.Windows.Forms.Button btSave;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Button btnWarning;
    private System.Windows.Forms.Button btnError;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button btExit;
  }
}