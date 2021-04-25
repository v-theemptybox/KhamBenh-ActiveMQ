
namespace KhamBenhMQ
{
    partial class SendFrm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPersonalId = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(230, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tiếp Nhận Bệnh";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(63, 54);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(155, 20);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Thông tin bệnh nhân";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(67, 90);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Mã số";
            // 
            // lblPersonalId
            // 
            this.lblPersonalId.AutoSize = true;
            this.lblPersonalId.Location = new System.Drawing.Point(67, 121);
            this.lblPersonalId.Name = "lblPersonalId";
            this.lblPersonalId.Size = new System.Drawing.Size(55, 13);
            this.lblPersonalId.TabIndex = 2;
            this.lblPersonalId.Text = "Số CMND";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(67, 155);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(58, 13);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Họ và Tên";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(67, 192);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(40, 13);
            this.lblAddr.TabIndex = 2;
            this.lblAddr.Text = "Địa chỉ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(215, 87);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(358, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtPId
            // 
            this.txtPId.Location = new System.Drawing.Point(215, 118);
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(358, 20);
            this.txtPId.TabIndex = 3;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(215, 152);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(358, 20);
            this.txtFName.TabIndex = 3;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(215, 189);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(358, 20);
            this.txtAddr.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(266, 240);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(159, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Lưu thông tin";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // SendFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 281);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtPId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblPersonalId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "SendFrm";
            this.Text = "Sender";
            this.Load += new System.EventHandler(this.SendFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPersonalId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Button btnSend;
    }
}

