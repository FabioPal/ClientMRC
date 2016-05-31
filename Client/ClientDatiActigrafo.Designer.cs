namespace Client
{
    partial class ClientDatiActigrafo
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
            this.idBox = new System.Windows.Forms.TextBox();
            this.activityBox = new System.Windows.Forms.TextBox();
            this.activityLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(132, 135);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 19;
            // 
            // activityBox
            // 
            this.activityBox.Location = new System.Drawing.Point(132, 163);
            this.activityBox.Name = "activityBox";
            this.activityBox.Size = new System.Drawing.Size(100, 20);
            this.activityBox.TabIndex = 18;
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Location = new System.Drawing.Point(29, 170);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(97, 13);
            this.activityLabel.TabIndex = 17;
            this.activityLabel.Text = "Indice attività fisica";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(65, 142);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(63, 13);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "ID Actigrafo";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(38, 78);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(88, 13);
            this.portLabel.TabIndex = 15;
            this.portLabel.Text = "Numero di porta: ";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(65, 28);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(61, 13);
            this.ipLabel.TabIndex = 14;
            this.ipLabel.Text = "Indirizzo IP:";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(132, 71);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(100, 20);
            this.portBox.TabIndex = 13;
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(132, 21);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(100, 20);
            this.ipBox.TabIndex = 12;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(132, 221);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(116, 29);
            this.sendBtn.TabIndex = 20;
            this.sendBtn.Text = "Invia dati";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // ClientDatiActigrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.activityBox);
            this.Controls.Add(this.activityLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.ipBox);
            this.Name = "ClientDatiActigrafo";
            this.Text = "Client dati actigrafo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox activityBox;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Button sendBtn;
    }
}