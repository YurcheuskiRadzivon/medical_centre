partial class MainMenu
{
    private System.ComponentModel.IContainer components = null;
    private Button btnHospitalManager;
    private Button btnDutyDepartment;
    private Button btnPatientManagement;
    private Button btnExit;

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
        btnHospitalManager = new Button();
        btnDutyDepartment = new Button();
        btnPatientManagement = new Button();
        btnExit = new Button();
        SuspendLayout();
        // 
        // btnHospitalManager
        // 
        btnHospitalManager.Location = new Point(50, 50);
        btnHospitalManager.Name = "btnHospitalManager";
        btnHospitalManager.Size = new Size(200, 50);
        btnHospitalManager.TabIndex = 0;
        btnHospitalManager.Text = "Менеджер Больницы";
        btnHospitalManager.UseVisualStyleBackColor = true;
        btnHospitalManager.Click += BtnHospitalManager_Click;
        // 
        // btnDutyDepartment
        // 
        btnDutyDepartment.Location = new Point(50, 110);
        btnDutyDepartment.Name = "btnDutyDepartment";
        btnDutyDepartment.Size = new Size(200, 50);
        btnDutyDepartment.TabIndex = 1;
        btnDutyDepartment.Text = "Дежурное отделение";
        btnDutyDepartment.UseVisualStyleBackColor = true;
        btnDutyDepartment.Click += BtnDutyDepartment_Click;
        // 
        // btnPatientManagement
        // 
        btnPatientManagement.Location = new Point(50, 170);
        btnPatientManagement.Name = "btnPatientManagement";
        btnPatientManagement.Size = new Size(200, 50);
        btnPatientManagement.TabIndex = 2;
        btnPatientManagement.Text = "Управление пациентами";
        btnPatientManagement.UseVisualStyleBackColor = true;
        btnPatientManagement.Click += BtnPatientManagement_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(50, 230);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(200, 50);
        btnExit.TabIndex = 3;
        btnExit.Text = "Выход";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += BtnExit_Click;
        // 
        // MainMenu
        // 
        ClientSize = new Size(300, 300);
        Controls.Add(btnHospitalManager);
        Controls.Add(btnDutyDepartment);
        Controls.Add(btnPatientManagement);
        Controls.Add(btnExit);
        Name = "MainMenu";
        Text = "Главное меню";
        Load += MainMenu_Load;
        ResumeLayout(false);
    }
}
