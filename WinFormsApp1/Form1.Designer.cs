namespace RepairRequestApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtRequestNumber = new System.Windows.Forms.TextBox();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.txtFaultType = new System.Windows.Forms.TextBox();
            this.txtProblemDescription = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.btnEditRequest = new System.Windows.Forms.Button();
            this.lstRequests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // 
            // txtRequestNumber
            // 
            this.txtRequestNumber.Location = new System.Drawing.Point(12, 12);
            this.txtRequestNumber.Name = "txtRequestNumber";
            this.txtRequestNumber.Size = new System.Drawing.Size(200, 20);
            this.txtRequestNumber.TabIndex = 0;
            this.txtRequestNumber.PlaceholderText = "Номер заявки";
            this.txtRequestNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRequestNumber_KeyPress);

            // 
            // txtEquipment
            // 
            this.txtEquipment.Location = new System.Drawing.Point(12, 38);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(200, 20);
            this.txtEquipment.TabIndex = 1;
            this.txtEquipment.PlaceholderText = "Оборудование";

            // 
            // txtFaultType
            // 
            this.txtFaultType.Location = new System.Drawing.Point(12, 64);
            this.txtFaultType.Name = "txtFaultType";
            this.txtFaultType.Size = new System.Drawing.Size(200, 20);
            this.txtFaultType.TabIndex = 2;
            this.txtFaultType.PlaceholderText = "Тип неисправности";

            // 
            // txtProblemDescription
            // 
            this.txtProblemDescription.Location = new System.Drawing.Point(12, 90);
            this.txtProblemDescription.Multiline = true;
            this.txtProblemDescription.Name = "txtProblemDescription";
            this.txtProblemDescription.Size = new System.Drawing.Size(200, 60);
            this.txtProblemDescription.TabIndex = 3;
            this.txtProblemDescription.PlaceholderText = "Описание проблемы";

            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(12, 156);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(200, 20);
            this.txtClientName.TabIndex = 4;
            this.txtClientName.PlaceholderText = "Клиент";

            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] { "В ожидании", "В работе", "Выполнено" });
            this.cmbStatus.Location = new System.Drawing.Point(12, 182);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 5;

            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(12, 210);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(75, 23);
            this.btnAddRequest.TabIndex = 6;
            this.btnAddRequest.Text = "Добавить";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new EventHandler(this.btnAddRequest_Click);

            // 
            // btnEditRequest
            // 
            this.btnEditRequest.Location = new System.Drawing.Point(137, 210);
            this.btnEditRequest.Name = "btnEditRequest";
            this.btnEditRequest.Size = new System.Drawing.Size(75, 23);
            this.btnEditRequest.TabIndex = 7;
            this.btnEditRequest.Text = "Редактировать";
            this.btnEditRequest.UseVisualStyleBackColor = true;
            this.btnEditRequest.Click += new EventHandler(this.btnEditRequest_Click);

            // 
            // lstRequests
            // 
            this.lstRequests.FormattingEnabled = true;
            this.lstRequests.Location = new System.Drawing.Point(220, 12);
            this.lstRequests.Name = "lstRequests";
            this.lstRequests.Size = new System.Drawing.Size(300, 225);
            this.lstRequests.TabIndex = 8;

            // 
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.lstRequests);
            this.Controls.Add(this.btnEditRequest);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.txtProblemDescription);
            this.Controls.Add(this.txtFaultType);
            this.Controls.Add(this.txtEquipment);
            this.Controls.Add(this.txtRequestNumber);

            this.Name = "Form1";
            this.Text = "Учет заявок на ремонт оборудования";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtRequestNumber;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.TextBox txtFaultType;
        private System.Windows.Forms.TextBox txtProblemDescription;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnEditRequest;
        private System.Windows.Forms.ListBox lstRequests;
    }
}