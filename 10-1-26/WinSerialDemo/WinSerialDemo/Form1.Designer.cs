namespace WinSerialDemo
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
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnBinSerialize = new System.Windows.Forms.Button();
            this.btnBinDeSeialize = new System.Windows.Forms.Button();
            this.btnXMLSerialize = new System.Windows.Forms.Button();
            this.btnXMLDeSerialize = new System.Windows.Forms.Button();
            this.btnSoapSerialize = new System.Windows.Forms.Button();
            this.btnSoapDeSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(287, 80);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(96, 22);
            this.txtEmployeeID.TabIndex = 0;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(200, 83);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(79, 16);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(200, 120);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(287, 117);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(96, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(200, 155);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(43, 16);
            this.lblSalary.TabIndex = 5;
            this.lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(287, 152);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(96, 22);
            this.txtSalary.TabIndex = 4;
            // 
            // btnBinSerialize
            // 
            this.btnBinSerialize.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinSerialize.Location = new System.Drawing.Point(104, 214);
            this.btnBinSerialize.Name = "btnBinSerialize";
            this.btnBinSerialize.Size = new System.Drawing.Size(109, 23);
            this.btnBinSerialize.TabIndex = 6;
            this.btnBinSerialize.Text = "Bin Serialize";
            this.btnBinSerialize.UseVisualStyleBackColor = true;
            this.btnBinSerialize.Click += new System.EventHandler(this.btnBinSerialize_Click);
            // 
            // btnBinDeSeialize
            // 
            this.btnBinDeSeialize.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinDeSeialize.Location = new System.Drawing.Point(104, 257);
            this.btnBinDeSeialize.Name = "btnBinDeSeialize";
            this.btnBinDeSeialize.Size = new System.Drawing.Size(109, 23);
            this.btnBinDeSeialize.TabIndex = 7;
            this.btnBinDeSeialize.Text = "Bin DeSerialize";
            this.btnBinDeSeialize.UseVisualStyleBackColor = true;
            this.btnBinDeSeialize.Click += new System.EventHandler(this.btnBinDeSeialize_Click);
            // 
            // btnXMLSerialize
            // 
            this.btnXMLSerialize.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLSerialize.Location = new System.Drawing.Point(247, 214);
            this.btnXMLSerialize.Name = "btnXMLSerialize";
            this.btnXMLSerialize.Size = new System.Drawing.Size(119, 23);
            this.btnXMLSerialize.TabIndex = 8;
            this.btnXMLSerialize.Text = "XML Serialize";
            this.btnXMLSerialize.UseVisualStyleBackColor = true;
            this.btnXMLSerialize.Click += new System.EventHandler(this.btnXMLSerialize_Click);
            // 
            // btnXMLDeSerialize
            // 
            this.btnXMLDeSerialize.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLDeSerialize.Location = new System.Drawing.Point(247, 257);
            this.btnXMLDeSerialize.Name = "btnXMLDeSerialize";
            this.btnXMLDeSerialize.Size = new System.Drawing.Size(119, 23);
            this.btnXMLDeSerialize.TabIndex = 9;
            this.btnXMLDeSerialize.Text = "XML DeSerialize";
            this.btnXMLDeSerialize.UseVisualStyleBackColor = true;
            this.btnXMLDeSerialize.Click += new System.EventHandler(this.btnXMLDeSerialize_Click);
            // 
            // btnSoapSerialize
            // 
            this.btnSoapSerialize.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoapSerialize.Location = new System.Drawing.Point(399, 214);
            this.btnSoapSerialize.Name = "btnSoapSerialize";
            this.btnSoapSerialize.Size = new System.Drawing.Size(122, 23);
            this.btnSoapSerialize.TabIndex = 10;
            this.btnSoapSerialize.Text = "Soap Serialize";
            this.btnSoapSerialize.UseVisualStyleBackColor = true;
            this.btnSoapSerialize.Click += new System.EventHandler(this.btnSoapSerialize_Click);
            // 
            // btnSoapDeSerialize
            // 
            this.btnSoapDeSerialize.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoapDeSerialize.Location = new System.Drawing.Point(399, 257);
            this.btnSoapDeSerialize.Name = "btnSoapDeSerialize";
            this.btnSoapDeSerialize.Size = new System.Drawing.Size(122, 23);
            this.btnSoapDeSerialize.TabIndex = 11;
            this.btnSoapDeSerialize.Text = "Soap DeSerialize";
            this.btnSoapDeSerialize.UseVisualStyleBackColor = true;
            this.btnSoapDeSerialize.Click += new System.EventHandler(this.btnSoapDeSerialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSoapDeSerialize);
            this.Controls.Add(this.btnSoapSerialize);
            this.Controls.Add(this.btnXMLDeSerialize);
            this.Controls.Add(this.btnXMLSerialize);
            this.Controls.Add(this.btnBinDeSeialize);
            this.Controls.Add(this.btnBinSerialize);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txtEmployeeID);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnBinSerialize;
        private System.Windows.Forms.Button btnBinDeSeialize;
        private System.Windows.Forms.Button btnXMLSerialize;
        private System.Windows.Forms.Button btnXMLDeSerialize;
        private System.Windows.Forms.Button btnSoapSerialize;
        private System.Windows.Forms.Button btnSoapDeSerialize;
    }
}

