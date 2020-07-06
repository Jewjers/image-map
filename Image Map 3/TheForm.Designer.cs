﻿namespace ImageMap
{
    partial class TheForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheForm));
            this.JavaWorldButton = new System.Windows.Forms.Button();
            this.SelectWorldLabel = new System.Windows.Forms.Label();
            this.BedrockWorldButton = new System.Windows.Forms.Button();
            this.MapViewZone = new System.Windows.Forms.Panel();
            this.ImportContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ImportContextSend = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportContextChangeID = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportContextDiscard = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportContextSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ExistingContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExistingContextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ExistingContextChangeID = new System.Windows.Forms.ToolStripMenuItem();
            this.ExistingContextExport = new System.Windows.Forms.ToolStripMenuItem();
            this.ExistingContextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ExistingContextSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportContextMenu.SuspendLayout();
            this.ExistingContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // JavaWorldButton
            // 
            this.JavaWorldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.JavaWorldButton.Location = new System.Drawing.Point(8, 8);
            this.JavaWorldButton.Margin = new System.Windows.Forms.Padding(2);
            this.JavaWorldButton.Name = "JavaWorldButton";
            this.JavaWorldButton.Size = new System.Drawing.Size(118, 75);
            this.JavaWorldButton.TabIndex = 0;
            this.JavaWorldButton.Text = "Java World";
            this.JavaWorldButton.UseVisualStyleBackColor = true;
            this.JavaWorldButton.Click += new System.EventHandler(this.JavaWorldButton_Click);
            // 
            // SelectWorldLabel
            // 
            this.SelectWorldLabel.AutoSize = true;
            this.SelectWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SelectWorldLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SelectWorldLabel.Location = new System.Drawing.Point(229, 29);
            this.SelectWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectWorldLabel.Name = "SelectWorldLabel";
            this.SelectWorldLabel.Size = new System.Drawing.Size(461, 186);
            this.SelectWorldLabel.TabIndex = 17;
            this.SelectWorldLabel.Text = "← Click Here!\r\n\r\nMaps will show up in this\r\narea once you select a world.\r\n\r\nOr, " +
    "just drag a world folder right here!";
            // 
            // BedrockWorldButton
            // 
            this.BedrockWorldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BedrockWorldButton.Location = new System.Drawing.Point(8, 93);
            this.BedrockWorldButton.Margin = new System.Windows.Forms.Padding(2);
            this.BedrockWorldButton.Name = "BedrockWorldButton";
            this.BedrockWorldButton.Size = new System.Drawing.Size(118, 75);
            this.BedrockWorldButton.TabIndex = 21;
            this.BedrockWorldButton.Text = "Bedrock World";
            this.BedrockWorldButton.UseVisualStyleBackColor = true;
            this.BedrockWorldButton.Click += new System.EventHandler(this.BedrockWorldButton_Click);
            // 
            // MapViewZone
            // 
            this.MapViewZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapViewZone.Location = new System.Drawing.Point(131, 10);
            this.MapViewZone.Margin = new System.Windows.Forms.Padding(2);
            this.MapViewZone.Name = "MapViewZone";
            this.MapViewZone.Size = new System.Drawing.Size(595, 367);
            this.MapViewZone.TabIndex = 5;
            this.MapViewZone.Visible = false;
            // 
            // ImportContextMenu
            // 
            this.ImportContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ImportContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportContextSend,
            this.ImportContextChangeID,
            this.ImportContextDiscard,
            this.ImportContextSelectAll});
            this.ImportContextMenu.Name = "ImportContextMenu";
            this.ImportContextMenu.Size = new System.Drawing.Size(148, 92);
            this.ImportContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ImportContextMenu_Opening);
            // 
            // ImportContextSend
            // 
            this.ImportContextSend.Name = "ImportContextSend";
            this.ImportContextSend.Size = new System.Drawing.Size(147, 22);
            this.ImportContextSend.Text = "Send to world";
            this.ImportContextSend.Click += new System.EventHandler(this.ImportContextSend_Click);
            // 
            // ImportContextChangeID
            // 
            this.ImportContextChangeID.Name = "ImportContextChangeID";
            this.ImportContextChangeID.Size = new System.Drawing.Size(147, 22);
            this.ImportContextChangeID.Text = "Change ID";
            this.ImportContextChangeID.Click += new System.EventHandler(this.ImportContextChangeID_Click);
            // 
            // ImportContextDiscard
            // 
            this.ImportContextDiscard.Name = "ImportContextDiscard";
            this.ImportContextDiscard.Size = new System.Drawing.Size(147, 22);
            this.ImportContextDiscard.Text = "Discard";
            this.ImportContextDiscard.Click += new System.EventHandler(this.ImportContextDiscard_Click);
            // 
            // ImportContextSelectAll
            // 
            this.ImportContextSelectAll.Name = "ImportContextSelectAll";
            this.ImportContextSelectAll.Size = new System.Drawing.Size(147, 22);
            this.ImportContextSelectAll.Text = "Select all";
            this.ImportContextSelectAll.Click += new System.EventHandler(this.ImportContextSelectAll_Click);
            // 
            // ExistingContextMenu
            // 
            this.ExistingContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ExistingContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExistingContextAdd,
            this.ExistingContextChangeID,
            this.ExistingContextExport,
            this.ExistingContextDelete,
            this.ExistingContextSelectAll});
            this.ExistingContextMenu.Name = "ImportContextMenu";
            this.ExistingContextMenu.Size = new System.Drawing.Size(164, 114);
            this.ExistingContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ExistingContextMenu_Opening);
            // 
            // ExistingContextAdd
            // 
            this.ExistingContextAdd.Name = "ExistingContextAdd";
            this.ExistingContextAdd.Size = new System.Drawing.Size(163, 22);
            this.ExistingContextAdd.Text = "Add to inventory";
            this.ExistingContextAdd.Click += new System.EventHandler(this.ExistingContextAdd_Click);
            // 
            // ExistingContextChangeID
            // 
            this.ExistingContextChangeID.Name = "ExistingContextChangeID";
            this.ExistingContextChangeID.Size = new System.Drawing.Size(163, 22);
            this.ExistingContextChangeID.Text = "Change ID";
            this.ExistingContextChangeID.Click += new System.EventHandler(this.ExistingContextChangeID_Click);
            // 
            // ExistingContextExport
            // 
            this.ExistingContextExport.Name = "ExistingContextExport";
            this.ExistingContextExport.Size = new System.Drawing.Size(163, 22);
            this.ExistingContextExport.Text = "Export image";
            this.ExistingContextExport.Click += new System.EventHandler(this.ExistingContextExport_Click);
            // 
            // ExistingContextDelete
            // 
            this.ExistingContextDelete.Name = "ExistingContextDelete";
            this.ExistingContextDelete.Size = new System.Drawing.Size(163, 22);
            this.ExistingContextDelete.Text = "Delete";
            this.ExistingContextDelete.Click += new System.EventHandler(this.ExistingContextDelete_Click);
            // 
            // ExistingContextSelectAll
            // 
            this.ExistingContextSelectAll.Name = "ExistingContextSelectAll";
            this.ExistingContextSelectAll.Size = new System.Drawing.Size(163, 22);
            this.ExistingContextSelectAll.Text = "Select all";
            this.ExistingContextSelectAll.Click += new System.EventHandler(this.ExistingContextSelectAll_Click);
            // 
            // TheForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 377);
            this.Controls.Add(this.BedrockWorldButton);
            this.Controls.Add(this.JavaWorldButton);
            this.Controls.Add(this.MapViewZone);
            this.Controls.Add(this.SelectWorldLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(304, 210);
            this.Name = "TheForm";
            this.Text = "Image Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TheForm_FormClosed);
            this.Load += new System.EventHandler(this.TheForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.TheForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.TheForm_DragEnter);
            this.ImportContextMenu.ResumeLayout(false);
            this.ExistingContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button JavaWorldButton;
        public System.Windows.Forms.Label SelectWorldLabel;
        public System.Windows.Forms.Button BedrockWorldButton;
        public System.Windows.Forms.Panel MapViewZone;
        public System.Windows.Forms.ContextMenuStrip ImportContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ImportContextSend;
        private System.Windows.Forms.ToolStripMenuItem ImportContextChangeID;
        private System.Windows.Forms.ToolStripMenuItem ImportContextDiscard;
        private System.Windows.Forms.ToolStripMenuItem ImportContextSelectAll;
        public System.Windows.Forms.ContextMenuStrip ExistingContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ExistingContextAdd;
        private System.Windows.Forms.ToolStripMenuItem ExistingContextChangeID;
        private System.Windows.Forms.ToolStripMenuItem ExistingContextExport;
        private System.Windows.Forms.ToolStripMenuItem ExistingContextDelete;
        private System.Windows.Forms.ToolStripMenuItem ExistingContextSelectAll;
    }
}

