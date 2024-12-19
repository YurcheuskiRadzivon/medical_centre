partial class DutyDepartmentForm
{
    private System.ComponentModel.IContainer components = null;
    private TextBox txtFirstName;
    private TextBox txtLastName;
    private TextBox txtMiddleName;
    private TextBox txtDiagnosis;
    private ComboBox cbDepartment;
    private ComboBox cbDutyDoctor;
    private Button btnSave;
    private Label lblFirstName;
    private Label lblLastName;
    private Label lblMiddleName;
    private Label lblDiagnosis;
    private Label lblDepartment;
    private Label lblDutyDoctor;

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
        this.txtFirstName = new TextBox();
        this.txtLastName = new TextBox();
        this.txtMiddleName = new TextBox();
        this.txtDiagnosis = new TextBox();
        this.cbDepartment = new ComboBox();
        this.cbDutyDoctor = new ComboBox();
        this.btnSave = new Button();
        this.lblFirstName = new Label();
        this.lblLastName = new Label();
        this.lblMiddleName = new Label();
        this.lblDiagnosis = new Label();
        this.lblDepartment = new Label();
        this.lblDutyDoctor = new Label();
        this.SuspendLayout();

        // 
        // txtFirstName
        // 
        this.txtFirstName.Location = new System.Drawing.Point(12, 29);
        this.txtFirstName.Name = "txtFirstName";
        this.txtFirstName.Size = new System.Drawing.Size(260, 20);
        this.txtFirstName.TabIndex = 0;

        // 
        // lblFirstName
        // 
        this.lblFirstName.AutoSize = true;
        this.lblFirstName.Location = new System.Drawing.Point(12, 13);
        this.lblFirstName.Name = "lblFirstName";
        this.lblFirstName.Size = new System.Drawing.Size(29, 13);
        this.lblFirstName.TabIndex = 1;
        this.lblFirstName.Text = "Имя";

        // 
        // txtLastName
        // 
        this.txtLastName.Location = new System.Drawing.Point(12, 68);
        this.txtLastName.Name = "txtLastName";
        this.txtLastName.Size = new System.Drawing.Size(260, 20);
        this.txtLastName.TabIndex = 2;

        // 
        // lblLastName
        // 
        this.lblLastName.AutoSize = true;
        this.lblLastName.Location = new System.Drawing.Point(12, 52);
        this.lblLastName.Name = "lblLastName";
        this.lblLastName.Size = new System.Drawing.Size(56, 13);
        this.lblLastName.TabIndex = 3;
        this.lblLastName.Text = "Фамилия";

        // 
        // txtMiddleName
        // 
        this.txtMiddleName.Location = new System.Drawing.Point(12, 108);
        this.txtMiddleName.Name = "txtMiddleName";
        this.txtMiddleName.Size = new System.Drawing.Size(260, 20);
        this.txtMiddleName.TabIndex = 4;

        // 
        // lblMiddleName
        // 
        this.lblMiddleName.AutoSize = true;
        this.lblMiddleName.Location = new System.Drawing.Point(12, 92);
        this.lblMiddleName.Name = "lblMiddleName";
        this.lblMiddleName.Size = new System.Drawing.Size(54, 13);
        this.lblMiddleName.TabIndex = 5;
        this.lblMiddleName.Text = "Отчество";

        // 
        // txtDiagnosis
        // 
        this.txtDiagnosis.Location = new System.Drawing.Point(12, 147);
        this.txtDiagnosis.Name = "txtDiagnosis";
        this.txtDiagnosis.Size = new System.Drawing.Size(260, 20);
        this.txtDiagnosis.TabIndex = 6;

        // 
        // lblDiagnosis
        // 
        this.lblDiagnosis.AutoSize = true;
        this.lblDiagnosis.Location = new System.Drawing.Point(12, 131);
        this.lblDiagnosis.Name = "lblDiagnosis";
        this.lblDiagnosis.Size = new System.Drawing.Size(56, 13);
        this.lblDiagnosis.TabIndex = 7;
        this.lblDiagnosis.Text = "Диагноз";

        // 
        // cbDepartment
        // 
        this.cbDepartment.FormattingEnabled = true;
        this.cbDepartment.Location = new System.Drawing.Point(12, 186);
        this.cbDepartment.Name = "cbDepartment";
        this.cbDepartment.Size = new System.Drawing.Size(260, 21);
        this.cbDepartment.TabIndex = 8;
        this.cbDepartment.SelectedIndexChanged += new EventHandler(this.CbDepartment_SelectedIndexChanged);

        // 
        // lblDepartment
        // 
        this.lblDepartment.AutoSize = true;
        this.lblDepartment.Location = new System.Drawing.Point(12, 170);
        this.lblDepartment.Name = "lblDepartment";
        this.lblDepartment.Size = new System.Drawing.Size(65, 13);
        this.lblDepartment.TabIndex = 9;
        this.lblDepartment.Text = "Отделение";

        // 
        // cbDutyDoctor
        // 
        this.cbDutyDoctor.FormattingEnabled = true;
        this.cbDutyDoctor.Location = new System.Drawing.Point(12, 225);
        this.cbDutyDoctor.Name = "cbDutyDoctor";
        this.cbDutyDoctor.Size = new System.Drawing.Size(260, 21);
        this.cbDutyDoctor.TabIndex = 10;

        // 
        // lblDutyDoctor
        // 
        this.lblDutyDoctor.AutoSize = true;
        this.lblDutyDoctor.Location = new System.Drawing.Point(12, 209);
        this.lblDutyDoctor.Name = "lblDutyDoctor";
        this.lblDutyDoctor.Size = new System.Drawing.Size(89, 13);
        this.lblDutyDoctor.TabIndex = 11;
        this.lblDutyDoctor.Text = "Дежурный врач";

        // 
        // btnSave
        // 
        this.btnSave.Location = new System.Drawing.Point(197, 263);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(75, 23);
        this.btnSave.TabIndex = 12;
        this.btnSave.Text = "Сохранить";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new EventHandler(this.BtnSave_Click);

        // 
        // DutyDepartmentForm
        // 
        this.ClientSize = new System.Drawing.Size(284, 298);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.lblDutyDoctor);
        this.Controls.Add(this.cbDutyDoctor);
        this.Controls.Add(this.lblDepartment);
        this.Controls.Add(this.cbDepartment);
        this.Controls.Add(this.lblDiagnosis);
        this.Controls.Add(this.txtDiagnosis);
        this.Controls.Add(this.lblDiagnosis);
        this.Controls.Add(this.txtDiagnosis);
        this.Controls.Add(this.lblMiddleName);
        this.Controls.Add(this.txtMiddleName);
        this.Controls.Add(this.lblLastName);
        this.Controls.Add(this.txtLastName);
        this.Controls.Add(this.lblFirstName);
        this.Controls.Add(this.txtFirstName);
        this.Name = "DutyDepartmentForm";
        this.Text = "Добавить пациента";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
