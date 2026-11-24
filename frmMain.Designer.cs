namespace WF_Events_FormEvents
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
			tbEvents = new System.Windows.Forms.TextBox();
			SuspendLayout();
			// 
			// tbEvents
			// 
			tbEvents.Dock = System.Windows.Forms.DockStyle.Fill;
			tbEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			tbEvents.Location = new System.Drawing.Point(0, 0);
			tbEvents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			tbEvents.Multiline = true;
			tbEvents.Name = "tbEvents";
			tbEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			tbEvents.Size = new System.Drawing.Size(765, 553);
			tbEvents.TabIndex = 0;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(765, 553);
			Controls.Add(tbEvents);
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "frmMain";
			Text = "Form events";
			Activated += frmMain_Activated;
			Deactivate += frmMain_Deactivate;
			FormClosing += frmMain_FormClosing;
			FormClosed += frmMain_FormClosed;
			Load += frmMain_Load;
			SizeChanged += frmMain_SizeChanged;
			Click += frmMain_Click;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.TextBox tbEvents;
  }
}

