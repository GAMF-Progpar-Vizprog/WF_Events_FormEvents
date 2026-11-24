using System;
using System.Windows.Forms;

namespace WF_Events_FormEvents
{
	public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
    }

    private void frmMain_Activated(object sender, EventArgs e)
    {
      tbEvents.Text += "Activated\r\n";
    }

    private void frmMain_Deactivate(object sender, EventArgs e)
    {
      tbEvents.Text += "Deactivate\r\n";
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      tbEvents.Text += "Load\r\n";
    }

    private void frmMain_Click(object sender, EventArgs e)
    {
      tbEvents.Text += "Click\r\n";
    }

    private void frmMain_SizeChanged(object sender, EventArgs e)
    {
      tbEvents.Text += "SizeChanged\r\n";
    }

    

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      tbEvents.Text += "FormClosing\r\n";
      if(MessageBox.Show("FormClosing","Message",MessageBoxButtons.OKCancel)==DialogResult.Cancel)
				e.Cancel=true;
    }

    private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      tbEvents.Text += "FormClosed\r\n";
      MessageBox.Show("FormClosed");
    }

    
  }
}
