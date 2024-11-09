namespace TJS.ObjectTimer.UI
{
    partial class frmObjectTimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblElapsedTime = new Label();
            btnStartClock = new Button();
            tmrClock = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            btnStopTimer = new Button();
            btnExit = new Button();
            lbxSplitTimes = new ListBox();
            btnSplit = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblElapsedTime
            // 
            lblElapsedTime.AutoSize = true;
            lblElapsedTime.Location = new Point(82, 20);
            lblElapsedTime.Name = "lblElapsedTime";
            lblElapsedTime.Size = new Size(49, 15);
            lblElapsedTime.TabIndex = 0;
            lblElapsedTime.Text = "00:00:00";
            // 
            // btnStartClock
            // 
            btnStartClock.Location = new Point(12, 47);
            btnStartClock.Name = "btnStartClock";
            btnStartClock.Size = new Size(75, 23);
            btnStartClock.TabIndex = 1;
            btnStartClock.Text = "Start Clock";
            btnStartClock.UseVisualStyleBackColor = true;
            btnStartClock.Click += btnStartClock_Click;
            // 
            // tmrClock
            // 
            tmrClock.Tick += tmrClock_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 254);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(219, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 17);
            // 
            // btnStopTimer
            // 
            btnStopTimer.Location = new Point(132, 47);
            btnStopTimer.Name = "btnStopTimer";
            btnStopTimer.Size = new Size(75, 23);
            btnStopTimer.TabIndex = 3;
            btnStopTimer.Text = "Stop Timer";
            btnStopTimer.UseVisualStyleBackColor = true;
            btnStopTimer.Click += btnStopTimer_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(132, 76);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbxSplitTimes
            // 
            lbxSplitTimes.FormattingEnabled = true;
            lbxSplitTimes.ItemHeight = 15;
            lbxSplitTimes.Location = new Point(2, 114);
            lbxSplitTimes.Name = "lbxSplitTimes";
            lbxSplitTimes.Size = new Size(205, 139);
            lbxSplitTimes.TabIndex = 5;
            // 
            // btnSplit
            // 
            btnSplit.Location = new Point(12, 76);
            btnSplit.Name = "btnSplit";
            btnSplit.Size = new Size(75, 23);
            btnSplit.TabIndex = 6;
            btnSplit.Text = "Split Time";
            btnSplit.UseVisualStyleBackColor = true;
            btnSplit.Click += btnSplit_Click;
            // 
            // frmObjectTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 276);
            Controls.Add(btnSplit);
            Controls.Add(lbxSplitTimes);
            Controls.Add(btnExit);
            Controls.Add(btnStopTimer);
            Controls.Add(statusStrip1);
            Controls.Add(btnStartClock);
            Controls.Add(lblElapsedTime);
            Name = "frmObjectTimer";
            Text = "Object Timer";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblElapsedTime;
        private Button btnStartClock;
        private System.Windows.Forms.Timer tmrClock;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Button btnStopTimer;
        private Button btnExit;
        private ListBox lbxSplitTimes;
        private Button btnSplit;
    }
}
