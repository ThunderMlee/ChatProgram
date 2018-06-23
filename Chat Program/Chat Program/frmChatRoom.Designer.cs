namespace Chat_Program
{
    partial class frmChatRoom
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
            this.lstChatLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.grpStatInfo = new System.Windows.Forms.GroupBox();
            this.lblRecpConnect = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMsgStat = new System.Windows.Forms.Label();
            this.lblUName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpStatInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstChatLog
            // 
            this.lstChatLog.FormattingEnabled = true;
            this.lstChatLog.Location = new System.Drawing.Point(268, 38);
            this.lstChatLog.Name = "lstChatLog";
            this.lstChatLog.Size = new System.Drawing.Size(520, 329);
            this.lstChatLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chat Log";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(268, 374);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(430, 64);
            this.txtMsg.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(704, 374);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 64);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // grpStatInfo
            // 
            this.grpStatInfo.Controls.Add(this.lblRecpConnect);
            this.grpStatInfo.Controls.Add(this.label6);
            this.grpStatInfo.Controls.Add(this.lblMsgStat);
            this.grpStatInfo.Controls.Add(this.lblUName);
            this.grpStatInfo.Controls.Add(this.label5);
            this.grpStatInfo.Controls.Add(this.label4);
            this.grpStatInfo.Controls.Add(this.label3);
            this.grpStatInfo.Controls.Add(this.label2);
            this.grpStatInfo.Location = new System.Drawing.Point(12, 38);
            this.grpStatInfo.Name = "grpStatInfo";
            this.grpStatInfo.Size = new System.Drawing.Size(233, 400);
            this.grpStatInfo.TabIndex = 4;
            this.grpStatInfo.TabStop = false;
            this.grpStatInfo.Text = "Status Information";
            // 
            // lblRecpConnect
            // 
            this.lblRecpConnect.AutoSize = true;
            this.lblRecpConnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRecpConnect.Location = new System.Drawing.Point(142, 73);
            this.lblRecpConnect.Name = "lblRecpConnect";
            this.lblRecpConnect.Size = new System.Drawing.Size(27, 13);
            this.lblRecpConnect.TabIndex = 7;
            this.lblRecpConnect.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Recipent Connection:";
            // 
            // lblMsgStat
            // 
            this.lblMsgStat.AutoSize = true;
            this.lblMsgStat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMsgStat.Location = new System.Drawing.Point(113, 95);
            this.lblMsgStat.Name = "lblMsgStat";
            this.lblMsgStat.Size = new System.Drawing.Size(27, 13);
            this.lblMsgStat.TabIndex = 5;
            this.lblMsgStat.Text = "N/A";
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Location = new System.Drawing.Point(80, 25);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(27, 13);
            this.lblUName.TabIndex = 4;
            this.lblUName.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(87, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Message Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Connection:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // frmChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpStatInfo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstChatLog);
            this.Name = "frmChatRoom";
            this.Text = "Chat Room";
            this.grpStatInfo.ResumeLayout(false);
            this.grpStatInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstChatLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox grpStatInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecpConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMsgStat;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Label label5;
    }
}

