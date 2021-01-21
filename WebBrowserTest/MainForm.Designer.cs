
namespace WebBrowserTest
{
  partial class MainForm
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
      this.btnNavigateWebBrowser = new System.Windows.Forms.Button();
      this.tbUrl = new System.Windows.Forms.TextBox();
      this.btnNavigateCefSharp = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnNavigateWebBrowser
      // 
      this.btnNavigateWebBrowser.Location = new System.Drawing.Point(43, 50);
      this.btnNavigateWebBrowser.Name = "btnNavigateWebBrowser";
      this.btnNavigateWebBrowser.Size = new System.Drawing.Size(75, 23);
      this.btnNavigateWebBrowser.TabIndex = 0;
      this.btnNavigateWebBrowser.Text = "WebBrowser";
      this.btnNavigateWebBrowser.UseVisualStyleBackColor = true;
      this.btnNavigateWebBrowser.Click += new System.EventHandler(this.btnNavigateWebBrowser_Click);
      // 
      // tbUrl
      // 
      this.tbUrl.Location = new System.Drawing.Point(43, 24);
      this.tbUrl.Name = "tbUrl";
      this.tbUrl.Size = new System.Drawing.Size(438, 20);
      this.tbUrl.TabIndex = 1;
      // 
      // btnNavigateCefSharp
      // 
      this.btnNavigateCefSharp.Location = new System.Drawing.Point(124, 50);
      this.btnNavigateCefSharp.Name = "btnNavigateCefSharp";
      this.btnNavigateCefSharp.Size = new System.Drawing.Size(75, 23);
      this.btnNavigateCefSharp.TabIndex = 2;
      this.btnNavigateCefSharp.Text = "CefSharp";
      this.btnNavigateCefSharp.UseVisualStyleBackColor = true;
      this.btnNavigateCefSharp.Click += new System.EventHandler(this.btnNavigateCefSharp_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(604, 344);
      this.Controls.Add(this.btnNavigateCefSharp);
      this.Controls.Add(this.tbUrl);
      this.Controls.Add(this.btnNavigateWebBrowser);
      this.Name = "MainForm";
      this.Text = "Test";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnNavigateWebBrowser;
    private System.Windows.Forms.TextBox tbUrl;
    private System.Windows.Forms.Button btnNavigateCefSharp;
  }
}

