namespace BankReconciliation
{
  partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBrowseSource = new System.Windows.Forms.Button();
            this.tbFilenameSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgTransactions = new System.Windows.Forms.DataGridView();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GLCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsData = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmdProcess = new System.Windows.Forms.Button();
            this.cmdBrowseDestination = new System.Windows.Forms.Button();
            this.tbFilenameDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ofdSource = new System.Windows.Forms.OpenFileDialog();
            this.sfdDestination = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 451);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdBrowseSource);
            this.groupBox1.Controls.Add(this.tbFilenameSource);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // cmdBrowseSource
            // 
            this.cmdBrowseSource.Location = new System.Drawing.Point(366, 18);
            this.cmdBrowseSource.Name = "cmdBrowseSource";
            this.cmdBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowseSource.TabIndex = 2;
            this.cmdBrowseSource.Text = "Browse...";
            this.cmdBrowseSource.UseVisualStyleBackColor = true;
            this.cmdBrowseSource.Click += new System.EventHandler(this.cmdBrowseSource_Click);
            // 
            // tbFilenameSource
            // 
            this.tbFilenameSource.Location = new System.Drawing.Point(43, 19);
            this.tbFilenameSource.Name = "tbFilenameSource";
            this.tbFilenameSource.Size = new System.Drawing.Size(317, 20);
            this.tbFilenameSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgTransactions);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(555, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transactions";
            // 
            // dgTransactions
            // 
            this.dgTransactions.AllowUserToAddRows = false;
            this.dgTransactions.AllowUserToDeleteRows = false;
            this.dgTransactions.AutoGenerateColumns = false;
            this.dgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionDate,
            this.Sequence,
            this.VendorName,
            this.CheckNumber,
            this.DDebit,
            this.DCredit,
            this.GLCode,
            this.IBalance,
            this.Movement,
            this.FBalance});
            this.dgTransactions.DataSource = this.bsData;
            this.dgTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTransactions.Location = new System.Drawing.Point(10, 23);
            this.dgTransactions.Name = "dgTransactions";
            this.dgTransactions.ReadOnly = true;
            this.dgTransactions.Size = new System.Drawing.Size(535, 262);
            this.dgTransactions.TabIndex = 0;
            // 
            // TransactionDate
            // 
            this.TransactionDate.DataPropertyName = "TransactionDate";
            this.TransactionDate.HeaderText = "Transaction Date";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            // 
            // Sequence
            // 
            this.Sequence.DataPropertyName = "Sequence";
            this.Sequence.HeaderText = "Sequence";
            this.Sequence.Name = "Sequence";
            this.Sequence.ReadOnly = true;
            // 
            // VendorName
            // 
            this.VendorName.DataPropertyName = "VendorName";
            this.VendorName.HeaderText = "Vendor Name";
            this.VendorName.Name = "VendorName";
            this.VendorName.ReadOnly = true;
            // 
            // CheckNumber
            // 
            this.CheckNumber.DataPropertyName = "CheckNumber";
            this.CheckNumber.HeaderText = "Check Number";
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.ReadOnly = true;
            // 
            // DDebit
            // 
            this.DDebit.DataPropertyName = "DDebit";
            this.DDebit.HeaderText = "Debit";
            this.DDebit.Name = "DDebit";
            this.DDebit.ReadOnly = true;
            // 
            // DCredit
            // 
            this.DCredit.DataPropertyName = "DCredit";
            this.DCredit.HeaderText = "Credit";
            this.DCredit.Name = "DCredit";
            this.DCredit.ReadOnly = true;
            // 
            // GLCode
            // 
            this.GLCode.DataPropertyName = "GLCode";
            this.GLCode.HeaderText = "GL Code";
            this.GLCode.Name = "GLCode";
            this.GLCode.ReadOnly = true;
            // 
            // IBalance
            // 
            this.IBalance.DataPropertyName = "IBalance";
            this.IBalance.HeaderText = "Initial Balance";
            this.IBalance.Name = "IBalance";
            this.IBalance.ReadOnly = true;
            // 
            // Movement
            // 
            this.Movement.DataPropertyName = "Movement";
            this.Movement.HeaderText = "Movement";
            this.Movement.Name = "Movement";
            this.Movement.ReadOnly = true;
            // 
            // FBalance
            // 
            this.FBalance.DataPropertyName = "FBalance";
            this.FBalance.HeaderText = "Final Balance";
            this.FBalance.Name = "FBalance";
            this.FBalance.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.cmdProcess);
            this.groupBox3.Controls.Add(this.cmdBrowseDestination);
            this.groupBox3.Controls.Add(this.tbFilenameDestination);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 84);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destination";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 46);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(536, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // cmdProcess
            // 
            this.cmdProcess.Enabled = false;
            this.cmdProcess.Location = new System.Drawing.Point(447, 17);
            this.cmdProcess.Name = "cmdProcess";
            this.cmdProcess.Size = new System.Drawing.Size(75, 23);
            this.cmdProcess.TabIndex = 3;
            this.cmdProcess.Text = "Process";
            this.cmdProcess.UseVisualStyleBackColor = true;
            this.cmdProcess.Click += new System.EventHandler(this.cmdProcess_Click);
            // 
            // cmdBrowseDestination
            // 
            this.cmdBrowseDestination.Location = new System.Drawing.Point(366, 17);
            this.cmdBrowseDestination.Name = "cmdBrowseDestination";
            this.cmdBrowseDestination.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowseDestination.TabIndex = 2;
            this.cmdBrowseDestination.Text = "Browse...";
            this.cmdBrowseDestination.UseVisualStyleBackColor = true;
            this.cmdBrowseDestination.Click += new System.EventHandler(this.cmdBrowseDestination_Click);
            // 
            // tbFilenameDestination
            // 
            this.tbFilenameDestination.Location = new System.Drawing.Point(43, 18);
            this.tbFilenameDestination.Name = "tbFilenameDestination";
            this.tbFilenameDestination.Size = new System.Drawing.Size(317, 20);
            this.tbFilenameDestination.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "File:";
            // 
            // ofdSource
            // 
            this.ofdSource.DefaultExt = "xls";
            this.ofdSource.Filter = "Data (XLS)|*.xls|Data (CSV)|*.csv|(All Files)|*.*";
            this.ofdSource.Title = "Open Data File";
            // 
            // sfdDestination
            // 
            this.sfdDestination.DefaultExt = "dat";
            this.sfdDestination.FileName = "GL.dat";
            this.sfdDestination.Filter = "GL Data|*.dat|(All Files)|*.*";
            this.sfdDestination.Title = "Save GL Data";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(577, 490);
            this.Name = "frmMain";
            this.Text = "Bank Reconciliation Data Converter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

	}

	#endregion

	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.Button cmdBrowseSource;
	private System.Windows.Forms.TextBox tbFilenameSource;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.GroupBox groupBox2;
	private System.Windows.Forms.DataGridView dgTransactions;
	private System.Windows.Forms.BindingSource bsData;
	private System.Windows.Forms.GroupBox groupBox3;
	private System.Windows.Forms.ProgressBar progressBar1;
	private System.Windows.Forms.Button cmdProcess;
	private System.Windows.Forms.Button cmdBrowseDestination;
	private System.Windows.Forms.TextBox tbFilenameDestination;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.OpenFileDialog ofdSource;
	private System.Windows.Forms.SaveFileDialog sfdDestination;
	private System.Windows.Forms.ErrorProvider errorProvider;
	private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
	private System.Windows.Forms.DataGridViewTextBoxColumn Sequence;
	private System.Windows.Forms.DataGridViewTextBoxColumn VendorName;
	private System.Windows.Forms.DataGridViewTextBoxColumn CheckNumber;
	private System.Windows.Forms.DataGridViewTextBoxColumn DDebit;
	private System.Windows.Forms.DataGridViewTextBoxColumn DCredit;
	private System.Windows.Forms.DataGridViewTextBoxColumn GLCode;
	private System.Windows.Forms.DataGridViewTextBoxColumn IBalance;
	private System.Windows.Forms.DataGridViewTextBoxColumn Movement;
	private System.Windows.Forms.DataGridViewTextBoxColumn FBalance;
  }
}

