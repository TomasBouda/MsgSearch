using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MsgSearchLib;
using System.IO;

namespace MsgSearch
{
	public partial class Form1 : Form
	{
		private Manager _mgr = new Manager();
        private string _file;

		public Form1()
		{
			InitializeComponent();
			drag.BorderStyle = BorderStyle.Fixed3D;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
            tree.Nodes.Clear();
            var messages = _mgr?.Search(txtQuery.Text, txtFrom.Text, int.Parse(txtLimit.Text), int.Parse(txtSkip.Text));
			foreach (var message in messages)
			{
				var node = new TreeNode();
				node.Text = message.Posted + " | " + message.From + " | " + message.Text;
				node.Tag = message;

				var previousNode = new TreeNode("Previous");
				foreach (var prevMsg in message.Previous(5))
				{
					var subNode = new TreeNode();
					subNode.Text = prevMsg.Posted + " | " + prevMsg.From + " | " + prevMsg.Text;
					subNode.Tag = prevMsg;
					previousNode.Nodes.Add(subNode);
				}

				var nextNode = new TreeNode("Next");
				foreach (var nextMsg in message.Next(5))
				{
					var subNode = new TreeNode();
					subNode.Text = nextMsg.Posted + " | " + nextMsg.From + " | " + nextMsg.Text;
					subNode.Tag = nextMsg;
					nextNode.Nodes.Add(subNode);
				}

				node.Nodes.Add(previousNode);
				node.Nodes.Add(nextNode);

				tree.Nodes.Add(node);
			}
		}

		private void tree_AfterSelect(object sender, TreeViewEventArgs e)
		{

		}

		private void drag_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
			
		}

		private void drag_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            LoadFiles(files);
		}

        private async void LoadFiles(string[] files)
        {
            btnSearch.Enabled = false;
            picLoading.Visible = true;
            lblDrag.Visible = false;

            await Task.Run(() => 
            {
                foreach(var file in files)
                {
                    if (Path.GetExtension(file) == ".html" | Path.GetExtension(file) == ".htm")
                    {
                        _mgr.AddFile(file);
                    }
                }
            });

            btnSearch.Enabled = true;
            picLoading.Visible = false;
            lblDrag.Visible = true;
            lblDrag.Text = "Initialized";
        }

		private void bw_DoWork(object sender, DoWorkEventArgs e)
		{
            
		}

		private void copyTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(tree.SelectedNode != null)
			{
				Clipboard.SetText(tree.SelectedNode.Text);
			}
		}

		private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnSearch.Enabled = true;
			picLoading.Visible = false;
			lblDrag.Visible = true;
			lblDrag.Text = "Initialized";
		}

        private void btnClear_Click(object sender, EventArgs e)
        {
            _mgr = new Manager();
            tree.Nodes.Clear();
        }
    }
}
