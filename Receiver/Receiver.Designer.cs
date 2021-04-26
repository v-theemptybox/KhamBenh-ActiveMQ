
namespace Receiver
{
    partial class ReceiverFrm
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
            this.gbxPatient = new System.Windows.Forms.GroupBox();
            this.btnCall = new System.Windows.Forms.Button();
            this.lbxPatient = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbxContent = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxPatient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPatient
            // 
            this.gbxPatient.Controls.Add(this.btnCall);
            this.gbxPatient.Controls.Add(this.lbxPatient);
            this.gbxPatient.Location = new System.Drawing.Point(13, 13);
            this.gbxPatient.Name = "gbxPatient";
            this.gbxPatient.Size = new System.Drawing.Size(200, 310);
            this.gbxPatient.TabIndex = 0;
            this.gbxPatient.TabStop = false;
            this.gbxPatient.Text = "Danh sách bệnh nhân";
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(7, 278);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(187, 23);
            this.btnCall.TabIndex = 1;
            this.btnCall.Text = "Gọi Khám";
            this.btnCall.UseVisualStyleBackColor = true;
            // 
            // lbxPatient
            // 
            this.lbxPatient.FormattingEnabled = true;
            this.lbxPatient.Location = new System.Drawing.Point(7, 20);
            this.lbxPatient.Name = "lbxPatient";
            this.lbxPatient.Size = new System.Drawing.Size(187, 251);
            this.lbxPatient.TabIndex = 0;
            this.lbxPatient.SelectedIndexChanged += new System.EventHandler(this.lbxPatient_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbxContent);
            this.groupBox2.Controls.Add(this.txtAddr);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtPId);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(220, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bệnh nhân được chọn";
            // 
            // gbxContent
            // 
            this.gbxContent.Controls.Add(this.btnUpdate);
            this.gbxContent.Controls.Add(this.rtxtContent);
            this.gbxContent.Location = new System.Drawing.Point(7, 200);
            this.gbxContent.Name = "gbxContent";
            this.gbxContent.Size = new System.Drawing.Size(412, 104);
            this.gbxContent.TabIndex = 16;
            this.gbxContent.TabStop = false;
            this.gbxContent.Text = "Nội dung khám";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(7, 73);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(399, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật thông tin khám bệnh";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // rtxtContent
            // 
            this.rtxtContent.Location = new System.Drawing.Point(7, 20);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(399, 47);
            this.rtxtContent.TabIndex = 0;
            this.rtxtContent.Text = "";
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(111, 126);
            this.txtAddr.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(308, 62);
            this.txtAddr.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(111, 93);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 27);
            this.txtName.TabIndex = 14;
            // 
            // txtPId
            // 
            this.txtPId.Enabled = false;
            this.txtPId.Location = new System.Drawing.Point(111, 60);
            this.txtPId.Margin = new System.Windows.Forms.Padding(2);
            this.txtPId.Multiline = true;
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(308, 27);
            this.txtPId.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(111, 20);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(308, 27);
            this.txtId.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CMND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã bệnh nhân";
            // 
            // ReceiverFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxPatient);
            this.Name = "ReceiverFrm";
            this.Text = "Receiver";
            this.gbxPatient.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPatient;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.ListBox lbxPatient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxContent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

