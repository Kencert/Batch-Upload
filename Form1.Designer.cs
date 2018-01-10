namespace WindowsFormsApplication1
{
    partial class BatchUploader
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
            this.btn_browse = new System.Windows.Forms.Button();
            this.helpLabel = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioCust = new System.Windows.Forms.RadioButton();
            this.radioVen = new System.Windows.Forms.RadioButton();
            this.radioPay = new System.Windows.Forms.RadioButton();
            this.btn_finish = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_browse.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_browse.Location = new System.Drawing.Point(409, 169);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 30);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.helpLabel.Location = new System.Drawing.Point(66, 34);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(504, 26);
            this.helpLabel.TabIndex = 1;
            this.helpLabel.Text = "Select File Option and Browse For The XML Document";
           // this.helpLabel.Click += new System.EventHandler(this.helpLabel_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(107, 175);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(296, 20);
            this.txtURL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(35, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Path:";
            // 
            // radioCust
            // 
            this.radioCust.AutoSize = true;
            this.radioCust.Checked = true;
            this.radioCust.ForeColor = System.Drawing.Color.Honeydew;
            this.radioCust.Location = new System.Drawing.Point(69, 95);
            this.radioCust.Name = "radioCust";
            this.radioCust.Size = new System.Drawing.Size(126, 17);
            this.radioCust.TabIndex = 4;
            this.radioCust.TabStop = true;
            this.radioCust.Text = "Update Customer List";
            this.radioCust.UseVisualStyleBackColor = true;
           // this.radioCust.CheckedChanged += new System.EventHandler(this.radioCust_CheckedChanged);
            // 
            // radioVen
            // 
            this.radioVen.AutoSize = true;
            this.radioVen.ForeColor = System.Drawing.Color.Honeydew;
            this.radioVen.Location = new System.Drawing.Point(69, 118);
            this.radioVen.Name = "radioVen";
            this.radioVen.Size = new System.Drawing.Size(121, 17);
            this.radioVen.TabIndex = 5;
            this.radioVen.Text = "Update Vendors List";
            this.radioVen.UseVisualStyleBackColor = true;
            // 
            // radioPay
            // 
            this.radioPay.AutoSize = true;
            this.radioPay.ForeColor = System.Drawing.Color.Honeydew;
            this.radioPay.Location = new System.Drawing.Point(69, 141);
            this.radioPay.Name = "radioPay";
            this.radioPay.Size = new System.Drawing.Size(109, 17);
            this.radioPay.TabIndex = 6;
            this.radioPay.Text = "Update Payments";
            this.radioPay.UseVisualStyleBackColor = true;
            // 
            // btn_finish
            // 
            this.btn_finish.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finish.Enabled = false;
            this.btn_finish.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_finish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_finish.Location = new System.Drawing.Point(490, 169);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(139, 29);
            this.btn_finish.TabIndex = 7;
            this.btn_finish.Text = "Upload Document";
            this.btn_finish.UseVisualStyleBackColor = false;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(409, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BatchUploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(641, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.radioPay);
            this.Controls.Add(this.radioVen);
            this.Controls.Add(this.radioCust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.btn_browse);
            this.ForeColor = System.Drawing.Color.SkyBlue;
            this.MaximizeBox = false;
            this.Name = "BatchUploader";
            this.Text = "Batch Uploader For Dynamic NAV";
           // this.Load += new System.EventHandler(this.BatchUploader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioCust;
        private System.Windows.Forms.RadioButton radioVen;
        private System.Windows.Forms.RadioButton radioPay;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Button button1;
    }
}

