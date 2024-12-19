partial class TreatingDoctorForm
{
    private System.ComponentModel.IContainer components = null;
    private ListView lvPatients;
    private Button btnCreateAppointment;
    private Button btnViewMedicalRecord;
    private Button btnDischargePatient;
    private Label lblPatients;
    private ColumnHeader columnHeaderId;
    private ColumnHeader columnHeaderFirstName;
    private ColumnHeader columnHeaderLastName;
    private ColumnHeader columnHeaderMiddleName;
    private ColumnHeader columnHeaderDiagnosis;

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
        this.lvPatients = new ListView();
        this.btnCreateAppointment = new Button();
        this.btnViewMedicalRecord = new Button();
        this.btnDischargePatient = new Button();
        this.lblPatients = new Label();
        this.columnHeaderId = new ColumnHeader();
        this.columnHeaderFirstName = new ColumnHeader();
        this.columnHeaderLastName = new ColumnHeader();
        this.columnHeaderMiddleName = new ColumnHeader();
        this.columnHeaderDiagnosis = new ColumnHeader();
        this.SuspendLayout();

        // 
        // lvPatients
        // 
        this.lvPatients.Columns.AddRange(new ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeaderMiddleName,
            this.columnHeaderDiagnosis});
        this.lvPatients.FullRowSelect = true;
        this.lvPatients.GridLines = true;
        this.lvPatients.Location = new System.Drawing.Point(12, 29);
        this.lvPatients.Name = "lvPatients";
        this.lvPatients.Size = new System.Drawing.Size(560, 300);
        this.lvPatients.TabIndex = 0;
        this.lvPatients.UseCompatibleStateImageBehavior = false;
        this.lvPatients.View = View.Details;

        // 
        // columnHeaderId
        // 
        this.columnHeaderId.Text = "ID";
        this.columnHeaderId.Width = 50;

        // 
        // columnHeaderFirstName
        // 
        this.columnHeaderFirstName.Text = "Имя";
        this.columnHeaderFirstName.Width = 100;

        // 
        // columnHeaderLastName
        // 
        this.columnHeaderLastName.Text = "Фамилия";
        this.columnHeaderLastName.Width = 100;

        // 
        // columnHeaderMiddleName
        // 
        this.columnHeaderMiddleName.Text = "Отчество";
        this.columnHeaderMiddleName.Width = 100;

        // 
        // columnHeaderDiagnosis
        // 
        this.columnHeaderDiagnosis.Text = "Диагноз";
        this.columnHeaderDiagnosis.Width = 200;

        // 
        // btnCreateAppointment
        // 
        this.btnCreateAppointment.Location = new System.Drawing.Point(12, 340);
        this.btnCreateAppointment.Name = "btnCreateAppointment";
        this.btnCreateAppointment.Size = new System.Drawing.Size(150, 30);
        this.btnCreateAppointment.TabIndex = 1;
        this.btnCreateAppointment.Text = "Создать назначение";
        this.btnCreateAppointment.UseVisualStyleBackColor = true;
        this.btnCreateAppointment.Click += new EventHandler(this.BtnCreateAppointment_Click);

        // 
        // btnViewMedicalRecord
        // 
        this.btnViewMedicalRecord.Location = new System.Drawing.Point(180, 340);
        this.btnViewMedicalRecord.Name = "btnViewMedicalRecord";
        this.btnViewMedicalRecord.Size = new System.Drawing.Size(150, 30);
        this.btnViewMedicalRecord.TabIndex = 2;
        this.btnViewMedicalRecord.Text = "Просмотреть карту";
        this.btnViewMedicalRecord.UseVisualStyleBackColor = true;
        this.btnViewMedicalRecord.Click += new EventHandler(this.BtnViewMedicalRecord_Click);

        // 
        // btnDischargePatient
        // 
        this.btnDischargePatient.Location = new System.Drawing.Point(342, 340);
        this.btnDischargePatient.Name = "btnDischargePatient";
        this.btnDischargePatient.Size = new System.Drawing.Size(150, 30);
        this.btnDischargePatient.TabIndex = 3;
        this.btnDischargePatient.Text = "Выписать пациента";
        this.btnDischargePatient.UseVisualStyleBackColor = true;
        this.btnDischargePatient.Click += new EventHandler(this.BtnDischargePatient_Click);

        // 
        // lblPatients
        // 
        this.lblPatients.AutoSize = true;
        this.lblPatients.Location = new System.Drawing.Point(12, 13);
        this.lblPatients.Name = "lblPatients";
        this.lblPatients.Size = new System.Drawing.Size(63, 13);
        this.lblPatients.TabIndex = 4;
        this.lblPatients.Text = "Пациенты";

        // 
        // TreatingDoctorForm
        // 
        this.ClientSize = new System.Drawing.Size(584, 381);
        this.Controls.Add(this.lblPatients);
        this.Controls.Add(this.btnDischargePatient);
        this.Controls.Add(this.btnViewMedicalRecord);
        this.Controls.Add(this.btnCreateAppointment);
        this.Controls.Add(this.lvPatients);
        this.Name = "TreatingDoctorForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
