using System;
using System.Windows.Forms;

namespace WebBrowserTest
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void btnNavigateWebBrowser_Click(object sender, EventArgs e)
    {
      using var webBrowser = new WebBrowser();
      webBrowser.Navigated += (o, args) => MessageBox.Show("Navigated");
      webBrowser.DocumentCompleted += (o, args) => MessageBox.Show("DocumentCompleted");

      using var form = new Form();
      form.Controls.Add(webBrowser);
      webBrowser.Dock = DockStyle.Fill;
      webBrowser.Navigate(tbUrl.Text);

      form.ShowDialog(this);
    }

    private void btnNavigateCefSharp_Click(object sender, EventArgs e)
    {
      using var form = new ChromiumForm(tbUrl.Text);
      form.Navigated += () => MessageBox.Show("Navigated");
      form.ShowDialog(this);
    }
  }
}
