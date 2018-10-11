namespace ContactCatalogApp.Forms
{
    partial class MainWindow
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
            this.btnCreatePerson = new System.Windows.Forms.Button();
            this.btnReadPerson = new System.Windows.Forms.Button();
            this.btnUpdatePerson = new System.Windows.Forms.Button();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDatabaseList = new System.Windows.Forms.ListBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxContactType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreatePerson
            // 
            this.btnCreatePerson.Location = new System.Drawing.Point(33, 62);
            this.btnCreatePerson.Name = "btnCreatePerson";
            this.btnCreatePerson.Size = new System.Drawing.Size(251, 67);
            this.btnCreatePerson.TabIndex = 0;
            this.btnCreatePerson.Text = "Create Person";
            this.btnCreatePerson.UseVisualStyleBackColor = true;
            this.btnCreatePerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // btnReadPerson
            // 
            this.btnReadPerson.Location = new System.Drawing.Point(290, 62);
            this.btnReadPerson.Name = "btnReadPerson";
            this.btnReadPerson.Size = new System.Drawing.Size(251, 67);
            this.btnReadPerson.TabIndex = 1;
            this.btnReadPerson.Text = "Read Person";
            this.btnReadPerson.UseVisualStyleBackColor = true;
            this.btnReadPerson.Click += new System.EventHandler(this.btnReadPerson_Click);
            // 
            // btnUpdatePerson
            // 
            this.btnUpdatePerson.Location = new System.Drawing.Point(547, 62);
            this.btnUpdatePerson.Name = "btnUpdatePerson";
            this.btnUpdatePerson.Size = new System.Drawing.Size(251, 67);
            this.btnUpdatePerson.TabIndex = 2;
            this.btnUpdatePerson.Text = "Update Person";
            this.btnUpdatePerson.UseVisualStyleBackColor = true;
            this.btnUpdatePerson.Click += new System.EventHandler(this.btnUpdatePerson_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Location = new System.Drawing.Point(804, 62);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(251, 67);
            this.btnDeletePerson.TabIndex = 3;
            this.btnDeletePerson.Text = "Delete Person";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CRUD Operations:";
            // 
            // listBoxDatabaseList
            // 
            this.listBoxDatabaseList.FormattingEnabled = true;
            this.listBoxDatabaseList.ItemHeight = 25;
            this.listBoxDatabaseList.Location = new System.Drawing.Point(33, 325);
            this.listBoxDatabaseList.Name = "listBoxDatabaseList";
            this.listBoxDatabaseList.Size = new System.Drawing.Size(1022, 179);
            this.listBoxDatabaseList.TabIndex = 5;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(215, 154);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(150, 31);
            this.txtBoxFirstName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Middle name:";
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(215, 191);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(150, 31);
            this.txtBoxMiddleName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last name:";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(215, 228);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(150, 31);
            this.txtBoxLastName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Contact Type:";
            // 
            // txtBoxContactType
            // 
            this.txtBoxContactType.Location = new System.Drawing.Point(215, 265);
            this.txtBoxContactType.Name = "txtBoxContactType";
            this.txtBoxContactType.Size = new System.Drawing.Size(150, 31);
            this.txtBoxContactType.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 540);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxContactType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxMiddleName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.listBoxDatabaseList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletePerson);
            this.Controls.Add(this.btnUpdatePerson);
            this.Controls.Add(this.btnReadPerson);
            this.Controls.Add(this.btnCreatePerson);
            this.Name = "MainWindow";
            this.Text = "Contact Catalog v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePerson;
        private System.Windows.Forms.Button btnReadPerson;
        private System.Windows.Forms.Button btnUpdatePerson;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDatabaseList;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMiddleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxContactType;
    }
}

