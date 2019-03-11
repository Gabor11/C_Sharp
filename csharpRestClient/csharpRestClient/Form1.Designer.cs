namespace csharpRestClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtRestURI = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.tabEntity = new System.Windows.Forms.TabControl();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkID = new System.Windows.Forms.CheckBox();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.cmbCategoryID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.txtID2Update = new System.Windows.Forms.TextBox();
            this.lblID2Update = new System.Windows.Forms.Label();
            this.lblCategoryID2Update = new System.Windows.Forms.Label();
            this.cmbCategoryID2Update = new System.Windows.Forms.ComboBox();
            this.lblAuthor2Update = new System.Windows.Forms.Label();
            this.lblBody2Update = new System.Windows.Forms.Label();
            this.lblTitle2Update = new System.Windows.Forms.Label();
            this.txtBody2Update = new System.Windows.Forms.TextBox();
            this.txtAuthor2Update = new System.Windows.Forms.TextBox();
            this.txtTitle2Update = new System.Windows.Forms.TextBox();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.txtID2Delete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabEntity.SuspendLayout();
            this.tabQuery.SuspendLayout();
            this.tabCreate.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRestURI
            // 
            this.txtRestURI.Location = new System.Drawing.Point(142, 35);
            this.txtRestURI.Name = "txtRestURI";
            this.txtRestURI.Size = new System.Drawing.Size(220, 20);
            this.txtRestURI.TabIndex = 0;
            this.txtRestURI.Text = "http://127.0.0.1/php_rest/";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(6, 43);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(348, 470);
            this.txtResponse.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(4, 33);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(134, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(6, 27);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(58, 13);
            this.lblResponse.TabIndex = 3;
            this.lblResponse.Text = "Response:";
            // 
            // tabEntity
            // 
            this.tabEntity.Controls.Add(this.tabQuery);
            this.tabEntity.Controls.Add(this.tabCreate);
            this.tabEntity.Controls.Add(this.tabUpdate);
            this.tabEntity.Controls.Add(this.tabDelete);
            this.tabEntity.Location = new System.Drawing.Point(4, 61);
            this.tabEntity.Name = "tabEntity";
            this.tabEntity.SelectedIndex = 0;
            this.tabEntity.Size = new System.Drawing.Size(368, 545);
            this.tabEntity.TabIndex = 4;
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.txtID);
            this.tabQuery.Controls.Add(this.chkID);
            this.tabQuery.Controls.Add(this.txtResponse);
            this.tabQuery.Controls.Add(this.lblResponse);
            this.tabQuery.Location = new System.Drawing.Point(4, 22);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuery.Size = new System.Drawing.Size(360, 519);
            this.tabQuery.TabIndex = 0;
            this.tabQuery.Text = "Query";
            this.tabQuery.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(79, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(51, 20);
            this.txtID.TabIndex = 5;
            // 
            // chkID
            // 
            this.chkID.AutoSize = true;
            this.chkID.Location = new System.Drawing.Point(7, 7);
            this.chkID.Name = "chkID";
            this.chkID.Size = new System.Drawing.Size(59, 17);
            this.chkID.TabIndex = 4;
            this.chkID.Text = "with ID";
            this.chkID.UseVisualStyleBackColor = true;
            this.chkID.CheckedChanged += new System.EventHandler(this.chkID_CheckedChanged);
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.lblCategoryID);
            this.tabCreate.Controls.Add(this.cmbCategoryID);
            this.tabCreate.Controls.Add(this.label1);
            this.tabCreate.Controls.Add(this.lblBody);
            this.tabCreate.Controls.Add(this.lblTitle);
            this.tabCreate.Controls.Add(this.txtBody);
            this.tabCreate.Controls.Add(this.txtAuthor);
            this.tabCreate.Controls.Add(this.txtTitle);
            this.tabCreate.Location = new System.Drawing.Point(4, 22);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(360, 519);
            this.tabCreate.TabIndex = 1;
            this.tabCreate.Text = "Create";
            this.tabCreate.UseVisualStyleBackColor = true;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(311, 474);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(36, 13);
            this.lblCategoryID.TabIndex = 8;
            this.lblCategoryID.Text = "catID:";
            // 
            // cmbCategoryID
            // 
            this.cmbCategoryID.FormattingEnabled = true;
            this.cmbCategoryID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCategoryID.Location = new System.Drawing.Point(311, 493);
            this.cmbCategoryID.Name = "cmbCategoryID";
            this.cmbCategoryID.Size = new System.Drawing.Size(43, 21);
            this.cmbCategoryID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "author:";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(7, 34);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(33, 13);
            this.lblBody.TabIndex = 5;
            this.lblBody.Text = "body:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(14, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(26, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "title:";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(6, 50);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(348, 421);
            this.txtBody.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(6, 493);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(298, 20);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(46, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(209, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.txtID2Update);
            this.tabUpdate.Controls.Add(this.lblID2Update);
            this.tabUpdate.Controls.Add(this.lblCategoryID2Update);
            this.tabUpdate.Controls.Add(this.cmbCategoryID2Update);
            this.tabUpdate.Controls.Add(this.lblAuthor2Update);
            this.tabUpdate.Controls.Add(this.lblBody2Update);
            this.tabUpdate.Controls.Add(this.lblTitle2Update);
            this.tabUpdate.Controls.Add(this.txtBody2Update);
            this.tabUpdate.Controls.Add(this.txtAuthor2Update);
            this.tabUpdate.Controls.Add(this.txtTitle2Update);
            this.tabUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(360, 519);
            this.tabUpdate.TabIndex = 2;
            this.tabUpdate.Text = "Update";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // txtID2Update
            // 
            this.txtID2Update.Location = new System.Drawing.Point(46, 9);
            this.txtID2Update.Name = "txtID2Update";
            this.txtID2Update.Size = new System.Drawing.Size(59, 20);
            this.txtID2Update.TabIndex = 18;
            // 
            // lblID2Update
            // 
            this.lblID2Update.AutoSize = true;
            this.lblID2Update.Location = new System.Drawing.Point(19, 11);
            this.lblID2Update.Name = "lblID2Update";
            this.lblID2Update.Size = new System.Drawing.Size(21, 13);
            this.lblID2Update.TabIndex = 17;
            this.lblID2Update.Text = "ID:";
            // 
            // lblCategoryID2Update
            // 
            this.lblCategoryID2Update.AutoSize = true;
            this.lblCategoryID2Update.Location = new System.Drawing.Point(311, 474);
            this.lblCategoryID2Update.Name = "lblCategoryID2Update";
            this.lblCategoryID2Update.Size = new System.Drawing.Size(36, 13);
            this.lblCategoryID2Update.TabIndex = 16;
            this.lblCategoryID2Update.Text = "catID:";
            // 
            // cmbCategoryID2Update
            // 
            this.cmbCategoryID2Update.FormattingEnabled = true;
            this.cmbCategoryID2Update.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCategoryID2Update.Location = new System.Drawing.Point(311, 493);
            this.cmbCategoryID2Update.Name = "cmbCategoryID2Update";
            this.cmbCategoryID2Update.Size = new System.Drawing.Size(43, 21);
            this.cmbCategoryID2Update.TabIndex = 15;
            // 
            // lblAuthor2Update
            // 
            this.lblAuthor2Update.AutoSize = true;
            this.lblAuthor2Update.Location = new System.Drawing.Point(7, 477);
            this.lblAuthor2Update.Name = "lblAuthor2Update";
            this.lblAuthor2Update.Size = new System.Drawing.Size(40, 13);
            this.lblAuthor2Update.TabIndex = 14;
            this.lblAuthor2Update.Text = "author:";
            // 
            // lblBody2Update
            // 
            this.lblBody2Update.AutoSize = true;
            this.lblBody2Update.Location = new System.Drawing.Point(7, 34);
            this.lblBody2Update.Name = "lblBody2Update";
            this.lblBody2Update.Size = new System.Drawing.Size(33, 13);
            this.lblBody2Update.TabIndex = 13;
            this.lblBody2Update.Text = "body:";
            // 
            // lblTitle2Update
            // 
            this.lblTitle2Update.AutoSize = true;
            this.lblTitle2Update.Location = new System.Drawing.Point(113, 12);
            this.lblTitle2Update.Name = "lblTitle2Update";
            this.lblTitle2Update.Size = new System.Drawing.Size(26, 13);
            this.lblTitle2Update.TabIndex = 12;
            this.lblTitle2Update.Text = "title:";
            // 
            // txtBody2Update
            // 
            this.txtBody2Update.Location = new System.Drawing.Point(6, 50);
            this.txtBody2Update.Multiline = true;
            this.txtBody2Update.Name = "txtBody2Update";
            this.txtBody2Update.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody2Update.Size = new System.Drawing.Size(348, 421);
            this.txtBody2Update.TabIndex = 11;
            // 
            // txtAuthor2Update
            // 
            this.txtAuthor2Update.Location = new System.Drawing.Point(6, 493);
            this.txtAuthor2Update.Name = "txtAuthor2Update";
            this.txtAuthor2Update.Size = new System.Drawing.Size(298, 20);
            this.txtAuthor2Update.TabIndex = 10;
            // 
            // txtTitle2Update
            // 
            this.txtTitle2Update.Location = new System.Drawing.Point(145, 9);
            this.txtTitle2Update.Name = "txtTitle2Update";
            this.txtTitle2Update.Size = new System.Drawing.Size(209, 20);
            this.txtTitle2Update.TabIndex = 9;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.txtID2Delete);
            this.tabDelete.Controls.Add(this.label2);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(360, 519);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // txtID2Delete
            // 
            this.txtID2Delete.Location = new System.Drawing.Point(46, 9);
            this.txtID2Delete.Name = "txtID2Delete";
            this.txtID2Delete.Size = new System.Drawing.Size(59, 20);
            this.txtID2Delete.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID:";
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(200, 9);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtName.Location = new System.Drawing.Point(4, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 20);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "name";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 608);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.tabEntity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRestURI);
            this.Controls.Add(this.btnSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rest Client";
            this.tabEntity.ResumeLayout(false);
            this.tabQuery.ResumeLayout(false);
            this.tabQuery.PerformLayout();
            this.tabCreate.ResumeLayout(false);
            this.tabCreate.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRestURI;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.TabControl tabEntity;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkID;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbCategoryID;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.TextBox txtID2Update;
        private System.Windows.Forms.Label lblID2Update;
        private System.Windows.Forms.Label lblCategoryID2Update;
        private System.Windows.Forms.ComboBox cmbCategoryID2Update;
        private System.Windows.Forms.Label lblAuthor2Update;
        private System.Windows.Forms.Label lblBody2Update;
        private System.Windows.Forms.Label lblTitle2Update;
        private System.Windows.Forms.TextBox txtBody2Update;
        private System.Windows.Forms.TextBox txtAuthor2Update;
        private System.Windows.Forms.TextBox txtTitle2Update;
        private System.Windows.Forms.TextBox txtID2Delete;
        private System.Windows.Forms.Label label2;
    }
}

