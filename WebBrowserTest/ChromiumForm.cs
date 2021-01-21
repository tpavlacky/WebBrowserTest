using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace WebBrowserTest
{
  public partial class ChromiumForm : Form
  {
    public ChromiumWebBrowser _chromeBrowser;
    public event Action Navigated;

    public ChromiumForm(string url)
    {
      InitializeComponent();
      InitializeChromium(url);
    }

    private void InitializeChromium(string url)
    {
      var settings = new CefSettings();
      if (!Cef.IsInitialized)
      {
        Cef.Initialize(settings);
      }
      _chromeBrowser = new ChromiumWebBrowser(url);
      _chromeBrowser.LoadingStateChanged += ChromeBrowserOnLoadingStateChanged;
      Controls.Add(_chromeBrowser);
      _chromeBrowser.Dock = DockStyle.Fill;
    }

    private void ChromeBrowserOnLoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
    {
      if (!e.IsLoading)
      {
        Navigated?.Invoke();
      }
    }

    public void Navigate(string url)
    {
      _chromeBrowser.Load(url);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      Cef.Shutdown();
    }
  }
}
