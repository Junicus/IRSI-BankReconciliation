namespace BankReconciliation
{
  partial class frmRequestData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbPeriod = new System.Windows.Forms.TextBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Period:";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(98, 37);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 2;
            this.tbYear.TextChanged += new System.EventHandler(this.tbYear_TextChanged);
            this.tbYear.Validating += new System.ComponentModel.CancelEventHandler(this.tbYear_Validating);
            // 
            // tbPeriod
            // 
            this.tbPeriod.Location = new System.Drawing.Point(98, 63);
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Size = new System.Drawing.Size(100, 20);
            this.tbPeriod.TabIndex = 3;
            this.tbPeriod.TextChanged += new System.EventHandler(this.tbPeriod_TextChanged);
            this.tbPeriod.Validating += new System.ComponentModel.CancelEventHandler(this.tbPeriod_Validating);
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(44, 98);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 4;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(125, 98);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmRequestData
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(255, 143);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.tbPeriod);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRequestData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Required Information";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.TextBox tbYear;
	private System.Windows.Forms.TextBox tbPeriod;
	private System.Windows.Forms.Button cmdOk;
	private System.Windows.Forms.Button cmdCancel;
	private System.Windows.Forms.ErrorProvider errorProvider;
  }
}