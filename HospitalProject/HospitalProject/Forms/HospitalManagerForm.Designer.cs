partial class HospitalManagerForm
{
    private System.ComponentModel.IContainer components = null;
    private Button btnManagerDepartament;
    private Button btnManagerPersonnel;
    private Button btnBack;

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
        btnManagerDepartament = new Button();
        btnManagerPersonnel = new Button();
        btnBack = new Button();
        SuspendLayout();
        // 
        // btnManagerDepartament
        // 
        btnManagerDepartament.Location = new Point(50, 50);
        btnManagerDepartament.Name = "btnManagerDepartament";
        btnManagerDepartament.Size = new Size(200, 50);
        btnManagerDepartament.TabIndex = 0;
        btnManagerDepartament.Text = "Менеджер отделений";
        btnManagerDepartament.UseVisualStyleBackColor = true;
        btnManagerDepartament.Click += BtnManagerDepartament_Click;
        // 
        // btnManagerPersonnel
        // 
        btnManagerPersonnel.Location = new Point(50, 110);
        btnManagerPersonnel.Name = "btnManagerPersonnel";
        btnManagerPersonnel.Size = new Size(200, 50);
        btnManagerPersonnel.TabIndex = 1;
        btnManagerPersonnel.Text = "Менеджер персонала";
        btnManagerPersonnel.UseVisualStyleBackColor = true;
        btnManagerPersonnel.Click += BtnManagerPersonnel_Click;
        // 
        // btnBack
        // 
        btnBack.Location = new Point(50, 170);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(200, 50);
        btnBack.TabIndex = 2;
        btnBack.Text = "Назад";
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Click += BtnBack_Click;
        // 
        // HospitalManagerForm
        // 
        ClientSize = new Size(300, 300);
        Controls.Add(btnManagerDepartament);
        Controls.Add(btnManagerPersonnel);
        Controls.Add(btnBack);
        Name = "HospitalManagerForm";
        Text = "Менеджер Больницы";
        Load += HospitalManagerForm_Load;
        ResumeLayout(false);
    }
}
