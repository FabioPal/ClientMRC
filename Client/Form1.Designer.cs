namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.connectionBtn = new System.Windows.Forms.Button();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.humLabel = new System.Windows.Forms.Label();
            this.presLabel = new System.Windows.Forms.Label();
            this.tempBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.humBox = new System.Windows.Forms.TextBox();
            this.presBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(137, 36);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(100, 20);
            this.ipBox.TabIndex = 0;
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(137, 86);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(100, 20);
            this.portBox.TabIndex = 1;
            // 
            // connectionBtn
            // 
            this.connectionBtn.Location = new System.Drawing.Point(212, 290);
            this.connectionBtn.Name = "connectionBtn";
            this.connectionBtn.Size = new System.Drawing.Size(116, 29);
            this.connectionBtn.TabIndex = 2;
            this.connectionBtn.Text = "Connettiti";
            this.connectionBtn.UseVisualStyleBackColor = true;
            this.connectionBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(70, 43);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(61, 13);
            this.ipLabel.TabIndex = 3;
            this.ipLabel.Text = "Indirizzo IP:";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(43, 93);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(88, 13);
            this.portLabel.TabIndex = 4;
            this.portLabel.Text = "Numero di porta: ";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(70, 157);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(60, 13);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "ID Sensore";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(64, 185);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(67, 13);
            this.tempLabel.TabIndex = 7;
            this.tempLabel.Text = "Temperatura";
            // 
            // humLabel
            // 
            this.humLabel.AutoSize = true;
            this.humLabel.Location = new System.Drawing.Point(88, 213);
            this.humLabel.Name = "humLabel";
            this.humLabel.Size = new System.Drawing.Size(42, 13);
            this.humLabel.TabIndex = 8;
            this.humLabel.Text = "Umidità";
            // 
            // presLabel
            // 
            this.presLabel.AutoSize = true;
            this.presLabel.Location = new System.Drawing.Point(78, 241);
            this.presLabel.Name = "presLabel";
            this.presLabel.Size = new System.Drawing.Size(53, 13);
            this.presLabel.TabIndex = 9;
            this.presLabel.Text = "Pressione";
            // 
            // tempBox
            // 
            this.tempBox.Location = new System.Drawing.Point(137, 178);
            this.tempBox.Name = "tempBox";
            this.tempBox.Size = new System.Drawing.Size(100, 20);
            this.tempBox.TabIndex = 10;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(137, 150);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 11;
            // 
            // humBox
            // 
            this.humBox.Location = new System.Drawing.Point(137, 206);
            this.humBox.Name = "humBox";
            this.humBox.Size = new System.Drawing.Size(100, 20);
            this.humBox.TabIndex = 12;
            // 
            // presBox
            // 
            this.presBox.Location = new System.Drawing.Point(137, 234);
            this.presBox.Name = "presBox";
            this.presBox.Size = new System.Drawing.Size(100, 20);
            this.presBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 345);
            this.Controls.Add(this.presBox);
            this.Controls.Add(this.humBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.tempBox);
            this.Controls.Add(this.presLabel);
            this.Controls.Add(this.humLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.connectionBtn);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.ipBox);
            this.Name = "Form1";
            this.Text = "Sensor - Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Button connectionBtn;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label humLabel;
        private System.Windows.Forms.Label presLabel;
        private System.Windows.Forms.TextBox tempBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox humBox;
        private System.Windows.Forms.TextBox presBox;
    }
}

