using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection; // for methodinfo

namespace CopyPasty
{
    // http://stackoverflow.com/a/1394225
    // Must inherit Control, not Component, in order to have Handle
    //[DefaultEvent("ClipboardChanged")]


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trayIcon.Visible = true;
            //panelClips.VerticalScroll.Visible = true;
            //panelClips.VerticalScroll.Enabled = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            trayIcon.Visible = true;
        }

        // this function maybe should be moved? because window is showed in taskbar
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                trayIcon.Visible = true;
                //trayIcon.ShowBalloonTip(3000);
                ShowInTaskbar = false;
            }
        }

        


        private void addNewStrClip(string strNewClip)
        {
            // remove first (oldest) clip when max amount of clips is reached
            if (strClips.Count >= trackBarNClipboards.Value) deleteClip( 0, false );

            strClips.Add(strNewClip);
            // add a new clip (clipboard data)
            // fired whenever non-existing clipboard data is copied
            TextBox newTextBoxClip = new TextBox();
            newTextBoxClip.Text = strNewClip;
            newTextBoxClip.Multiline = true;
            newTextBoxClip.AutoSize = true;
            newTextBoxClip.Dock = DockStyle.Top;
            newTextBoxClip.ContextMenuStrip = contextMenuStripClip;

            panelClips.Controls.Add(newTextBoxClip);

            string strNewClipTruncated;
            int maxLength = 50;
            if (strNewClip.Length > maxLength)
            {
                strNewClipTruncated = string.Join("", strNewClip.Take(maxLength));
                strNewClipTruncated = string.Concat(strNewClipTruncated, "...");
            }
            else
            {
                strNewClipTruncated = strNewClip;
            }
            ToolStripItem item = contextMenuStripTray.Items.Add(strNewClipTruncated, Properties.Resources.IconCopy.ToBitmap(), copyTrayToolStripMenuItem_Click);
            contextMenuStripTray.Items.Insert(0, item);
        }

        //string[] strClips = {}; //new string[30]; // 30 strings
        List<string> strClips = new List<string>();
        private void timerClipboardMonitor_Tick(object sender, EventArgs e)
        {
            // working way of accessing clipboard data
            // https://msdn.microsoft.com/en-us/library/system.windows.forms.clipboard.getdataobject%28v=vs.110%29.aspx
            // Declares an IDataObject to hold the data returned from the clipboard.
            // Retrieves the data from the clipboard.
            IDataObject iData = Clipboard.GetDataObject();

            // Determines whether the data is in a format you can use.
            // Probably checks if it's text data
            if (iData.GetDataPresent(DataFormats.Text))
            {
                string strNewClip = (String)iData.GetData(DataFormats.Text);
                // if (!strClips.Any(strNewClip.Contains)) addNewStrClip(strNewClip); // works but not always (with partial strings?)
                if (!strClips.Any(c => c == strNewClip)) addNewStrClip(strNewClip);
                labelCurrentClip.Text = string.Concat("Current clipboard data:\n", strNewClip);
            }
            /*else {
                // No it is not.
                textBox1.Text = "Could not retrieve data off the clipboard.";
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerClipboardMonitor.Start();
        }

        private void deleteClip(int index, bool confirm=true)
        {
            if (index < 0) return;

            // handle removing data that is currently in the clipboard (either create an event handler to only add clips on clipboard change, or create a function for getting clipboard data text)
            if (confirm)
            {
                DialogResult result = MessageBox.Show("Delete this data?\n\n" + strClips[index], "Delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Cancel) return;
            }
            strClips.RemoveAt(index);
            /* probably because of docking, the lowest index of the tray menu
            is at the bottom of the clips, which means we gotta
            count the index to delete from the total number of clips
            (-1 because .Count is 1-based)
            and then perhaps do +1 because of the Quit button? */
            contextMenuStripTray.Items[strClips.Count - 1 + 1 - index].Dispose();
            panelClips.Controls[index].Dispose();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // delete the selected clip, its corresponding string and tray menu item
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    int index = strClips.FindIndex(c => c == sourceControl.Text);
                    deleteClip(index);
                }
            }
            
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    if (sourceControl != null)
                    {
                        System.Windows.Forms.Clipboard.SetText(sourceControl.Text);
                    }
                }
            }
        }

        private void copyTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // get index of menu item
                int index = strClips.Count - 1 - contextMenuStripTray.Items.IndexOf(menuItem);
                System.Windows.Forms.Clipboard.SetText( strClips[index] );
            }
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MethodInfo methodInfo = typeof(NotifyIcon).GetMethod("ShowContextMenu",
                    BindingFlags.Instance | BindingFlags.NonPublic);

                methodInfo.Invoke(this.trayIcon, null);
            }
        }

        private void LabelBy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.manoli.se");
        }

        private void trackBarNClipboards_Scroll(object sender, EventArgs e)
        {
            labelNClipboards.Text = "Keep " + trackBarNClipboards.Value.ToString() + " clipboards";
            while( strClips.Count > trackBarNClipboards.Value) deleteClip(0, false);
        }
    }
}
