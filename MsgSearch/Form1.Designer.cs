namespace MsgSearch
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtQuery = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.tree = new System.Windows.Forms.TreeView();
			this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.drag = new System.Windows.Forms.Panel();
			this.picLoading = new System.Windows.Forms.PictureBox();
			this.lblDrag = new System.Windows.Forms.Label();
			this.bw = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cms.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.drag.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtQuery
			// 
			this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtQuery.Location = new System.Drawing.Point(3, 10);
			this.txtQuery.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.txtQuery.Name = "txtQuery";
			this.txtQuery.Size = new System.Drawing.Size(550, 22);
			this.txtQuery.TabIndex = 2;
			// 
			// btnSearch
			// 
			this.btnSearch.Enabled = false;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnSearch.Location = new System.Drawing.Point(559, 3);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(94, 36);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "SEARCH";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tree
			// 
			this.tree.ContextMenuStrip = this.cms;
			this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tree.Location = new System.Drawing.Point(3, 58);
			this.tree.Name = "tree";
			this.tree.Size = new System.Drawing.Size(656, 363);
			this.tree.TabIndex = 4;
			this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
			// 
			// cms
			// 
			this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyTestToolStripMenuItem});
			this.cms.Name = "cms";
			this.cms.Size = new System.Drawing.Size(125, 26);
			// 
			// copyTestToolStripMenuItem
			// 
			this.copyTestToolStripMenuItem.Name = "copyTestToolStripMenuItem";
			this.copyTestToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.copyTestToolStripMenuItem.Text = "Copy text";
			this.copyTestToolStripMenuItem.Click += new System.EventHandler(this.copyTestToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tree);
			this.groupBox1.Controls.Add(this.tableLayoutPanel2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 103);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(662, 424);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Search";
			// 
			// drag
			// 
			this.drag.AllowDrop = true;
			this.drag.Controls.Add(this.picLoading);
			this.drag.Controls.Add(this.lblDrag);
			this.drag.Dock = System.Windows.Forms.DockStyle.Top;
			this.drag.Location = new System.Drawing.Point(3, 3);
			this.drag.Name = "drag";
			this.drag.Size = new System.Drawing.Size(662, 90);
			this.drag.TabIndex = 6;
			this.drag.DragDrop += new System.Windows.Forms.DragEventHandler(this.drag_DragDrop);
			this.drag.DragEnter += new System.Windows.Forms.DragEventHandler(this.drag_DragEnter);
			// 
			// picLoading
			// 
			this.picLoading.Image = global::MsgSearch.Properties.Resources.loading;
			this.picLoading.Location = new System.Drawing.Point(298, 7);
			this.picLoading.Name = "picLoading";
			this.picLoading.Size = new System.Drawing.Size(65, 65);
			this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLoading.TabIndex = 1;
			this.picLoading.TabStop = false;
			this.picLoading.Visible = false;
			// 
			// lblDrag
			// 
			this.lblDrag.AutoSize = true;
			this.lblDrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblDrag.Location = new System.Drawing.Point(249, 30);
			this.lblDrag.Name = "lblDrag";
			this.lblDrag.Size = new System.Drawing.Size(165, 16);
			this.lblDrag.TabIndex = 0;
			this.lblDrag.Text = "Drag messages.html Here";
			// 
			// bw
			// 
			this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
			this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.drag, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(668, 530);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel2.Controls.Add(this.btnSearch, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.txtQuery, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(656, 42);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 530);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "MsgSearch";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.cms.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.drag.ResumeLayout(false);
			this.drag.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txtQuery;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TreeView tree;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel drag;
		private System.Windows.Forms.Label lblDrag;
		private System.ComponentModel.BackgroundWorker bw;
		private System.Windows.Forms.ContextMenuStrip cms;
		private System.Windows.Forms.ToolStripMenuItem copyTestToolStripMenuItem;
		private System.Windows.Forms.PictureBox picLoading;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

