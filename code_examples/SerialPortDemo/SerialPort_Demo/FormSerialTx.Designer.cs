namespace SerialPort_Demo
{
    partial class FormSerialTx
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
            this.tbAscii = new System.Windows.Forms.TextBox();
            this.lblAsciiString = new System.Windows.Forms.Label();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.lblHex = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbAutoSend = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAscii
            // 
            this.tbAscii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAscii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAscii.Font = new System.Drawing.Font("Segoe WP", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAscii.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbAscii.Location = new System.Drawing.Point(12, 62);
            this.tbAscii.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAscii.Multiline = true;
            this.tbAscii.Name = "tbAscii";
            this.tbAscii.Size = new System.Drawing.Size(487, 181);
            this.tbAscii.TabIndex = 0;
            this.tbAscii.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAscii_KeyPress);
            // 
            // lblAsciiString
            // 
            this.lblAsciiString.AutoSize = true;
            this.lblAsciiString.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsciiString.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAsciiString.Location = new System.Drawing.Point(12, 33);
            this.lblAsciiString.Name = "lblAsciiString";
            this.lblAsciiString.Size = new System.Drawing.Size(115, 25);
            this.lblAsciiString.TabIndex = 1;
            this.lblAsciiString.Text = "ASCII String";
            // 
            // tbHex
            // 
            this.tbHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHex.BackColor = System.Drawing.SystemColors.Info;
            this.tbHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHex.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbHex.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHex.Location = new System.Drawing.Point(17, 275);
            this.tbHex.Multiline = true;
            this.tbHex.Name = "tbHex";
            this.tbHex.ReadOnly = true;
            this.tbHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHex.Size = new System.Drawing.Size(487, 83);
            this.tbHex.TabIndex = 2;
            this.tbHex.TabStop = false;
            // 
            // lblHex
            // 
            this.lblHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHex.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHex.Location = new System.Drawing.Point(12, 247);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(46, 25);
            this.lblHex.TabIndex = 3;
            this.lblHex.Text = "Hex";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe WP", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSend.Location = new System.Drawing.Point(505, 62);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 62);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comPortToolStripMenuItem,
            this.clearTextToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comPortToolStripMenuItem
            // 
            this.comPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.comPortToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comPortToolStripMenuItem.Name = "comPortToolStripMenuItem";
            this.comPortToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.comPortToolStripMenuItem.Text = "&Com Port";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.connectToolStripMenuItem.Text = "&Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // clearTextToolStripMenuItem
            // 
            this.clearTextToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clearTextToolStripMenuItem.Name = "clearTextToolStripMenuItem";
            this.clearTextToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.clearTextToolStripMenuItem.Text = "Clear Te&xt";
            this.clearTextToolStripMenuItem.Click += new System.EventHandler(this.clearTextToolStripMenuItem_Click);
            // 
            // cbAutoSend
            // 
            this.cbAutoSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoSend.AutoSize = true;
            this.cbAutoSend.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutoSend.Location = new System.Drawing.Point(520, 178);
            this.cbAutoSend.Name = "cbAutoSend";
            this.cbAutoSend.Size = new System.Drawing.Size(97, 24);
            this.cbAutoSend.TabIndex = 6;
            this.cbAutoSend.Text = "Auto-send";
            this.cbAutoSend.UseVisualStyleBackColor = true;
            this.cbAutoSend.CheckedChanged += new System.EventHandler(this.cbAutoSend_CheckedChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // FormSerialTx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(629, 370);
            this.Controls.Add(this.cbAutoSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.tbHex);
            this.Controls.Add(this.lblAsciiString);
            this.Controls.Add(this.tbAscii);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSerialTx";
            this.Text = "Serial Port Tx Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSerialTx_FormClosing);
            this.Load += new System.EventHandler(this.FormSerialTx_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAscii;
        private System.Windows.Forms.Label lblAsciiString;
        private System.Windows.Forms.TextBox tbHex;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbAutoSend;
        private System.Windows.Forms.ToolStripMenuItem clearTextToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

