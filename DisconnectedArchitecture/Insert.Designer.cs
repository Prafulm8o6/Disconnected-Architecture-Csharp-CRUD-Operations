namespace DisconnectedArchitecture
{
    partial class Insert
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
            this.lnkLblDelete = new System.Windows.Forms.LinkLabel();
            this.lnkLblUpdate = new System.Windows.Forms.LinkLabel();
            this.lnkLblView = new System.Windows.Forms.LinkLabel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dpDOB = new System.Windows.Forms.DateTimePicker();
            this.mtxtRollNo = new System.Windows.Forms.MaskedTextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblSEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSName = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.lblCRUDOps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkLblDelete
            // 
            this.lnkLblDelete.AutoSize = true;
            this.lnkLblDelete.Location = new System.Drawing.Point(507, 523);
            this.lnkLblDelete.Name = "lnkLblDelete";
            this.lnkLblDelete.Size = new System.Drawing.Size(75, 26);
            this.lnkLblDelete.TabIndex = 17;
            this.lnkLblDelete.TabStop = true;
            this.lnkLblDelete.Text = "Delete";
            this.lnkLblDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblDelete_LinkClicked);
            // 
            // lnkLblUpdate
            // 
            this.lnkLblUpdate.AutoSize = true;
            this.lnkLblUpdate.Location = new System.Drawing.Point(403, 523);
            this.lnkLblUpdate.Name = "lnkLblUpdate";
            this.lnkLblUpdate.Size = new System.Drawing.Size(82, 26);
            this.lnkLblUpdate.TabIndex = 18;
            this.lnkLblUpdate.TabStop = true;
            this.lnkLblUpdate.Text = "Update";
            this.lnkLblUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblUpdate_LinkClicked);
            // 
            // lnkLblView
            // 
            this.lnkLblView.AutoSize = true;
            this.lnkLblView.Location = new System.Drawing.Point(315, 523);
            this.lnkLblView.Name = "lnkLblView";
            this.lnkLblView.Size = new System.Drawing.Size(60, 26);
            this.lnkLblView.TabIndex = 19;
            this.lnkLblView.TabStop = true;
            this.lnkLblView.Text = "View";
            this.lnkLblView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblView_LinkClicked);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(320, 408);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 44);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dpDOB
            // 
            this.dpDOB.Location = new System.Drawing.Point(320, 347);
            this.dpDOB.MaxDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dpDOB.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dpDOB.Name = "dpDOB";
            this.dpDOB.Size = new System.Drawing.Size(379, 32);
            this.dpDOB.TabIndex = 15;
            this.dpDOB.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // mtxtRollNo
            // 
            this.mtxtRollNo.Location = new System.Drawing.Point(320, 176);
            this.mtxtRollNo.Mask = "000";
            this.mtxtRollNo.Name = "mtxtRollNo";
            this.mtxtRollNo.Size = new System.Drawing.Size(141, 32);
            this.mtxtRollNo.TabIndex = 7;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(153, 352);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(156, 26);
            this.lblDOB.TabIndex = 8;
            this.lblDOB.Text = "Date Of Birth  :";
            // 
            // lblSEmail
            // 
            this.lblSEmail.AutoSize = true;
            this.lblSEmail.Location = new System.Drawing.Point(226, 292);
            this.lblSEmail.Name = "lblSEmail";
            this.lblSEmail.Size = new System.Drawing.Size(80, 26);
            this.lblSEmail.TabIndex = 9;
            this.lblSEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(320, 289);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(379, 32);
            this.txtEmail.TabIndex = 14;
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(226, 234);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(83, 26);
            this.lblSName.TabIndex = 10;
            this.lblSName.Text = "Name :";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(320, 231);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(379, 32);
            this.txtSName.TabIndex = 13;
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Location = new System.Drawing.Point(207, 179);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(102, 26);
            this.lblRollNo.TabIndex = 11;
            this.lblRollNo.Text = "Roll No. :";
            // 
            // lblCRUDOps
            // 
            this.lblCRUDOps.AutoSize = true;
            this.lblCRUDOps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCRUDOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblCRUDOps.Location = new System.Drawing.Point(320, 85);
            this.lblCRUDOps.Name = "lblCRUDOps";
            this.lblCRUDOps.Padding = new System.Windows.Forms.Padding(8);
            this.lblCRUDOps.Size = new System.Drawing.Size(298, 49);
            this.lblCRUDOps.TabIndex = 12;
            this.lblCRUDOps.Text = "CRUD OPERATIONS";
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 642);
            this.Controls.Add(this.lnkLblDelete);
            this.Controls.Add(this.lnkLblUpdate);
            this.Controls.Add(this.lnkLblView);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dpDOB);
            this.Controls.Add(this.mtxtRollNo);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblSEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.lblCRUDOps);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSERT | Disconnected Architecture Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkLblDelete;
        private System.Windows.Forms.LinkLabel lnkLblUpdate;
        private System.Windows.Forms.LinkLabel lnkLblView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dpDOB;
        private System.Windows.Forms.MaskedTextBox mtxtRollNo;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblSEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.Label lblCRUDOps;
    }
}

