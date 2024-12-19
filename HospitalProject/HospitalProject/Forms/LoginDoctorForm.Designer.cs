partial class LoginDoctorForm
{
    private System.ComponentModel.IContainer components = null;
    private ComboBox cbDepartment;
    private ComboBox cbDoctor;
    private Button btnLogin;
    private Label lblDepartment;
    private Label lblDoctor;

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
        this.cbDepartment = new ComboBox();
        this.cbDoctor = new ComboBox();
        this.btnLogin = new Button();
        this.lblDepartment = new Label();
        this.lblDoctor = new Label();
        this.SuspendLayout();

        // 
        // cbDepartment
        // 
        this.cbDepartment.FormattingEnabled = true;
        this.cbDepartment.Location = new System.Drawing.Point(12, 29);
        this.cbDepartment.Name = "cbDepartment";
        this.cbDepartment.Size = new System.Drawing.Size(260, 21);
        this.cbDepartment.TabIndex = 0;
        this.cbDepartment.SelectedIndexChanged += new EventHandler(this.CbDepartment_SelectedIndexChanged);

        // 
        // lblDepartment
        // 
        this.lblDepartment.AutoSize = true;
        this.lblDepartment.Location = new System.Drawing.Point(12, 13);
        this.lblDepartment.Name = "lblDepartment";
        this.lblDepartment.Size = new System.Drawing.Size(65, 13);
        this.lblDepartment.TabIndex = 1;
        this.lblDepartment.Text = "Отделение";

        // 
        // cbDoctor
        // 
        this.cbDoctor.FormattingEnabled = true;
        this.cbDoctor.Location = new System.Drawing.Point(12, 68);
        this.cbDoctor.Name = "cbDoctor";
        this.cbDoctor.Size = new System.Drawing.Size(260, 21);
        this.cbDoctor.TabIndex = 2;

        // 
        // lblDoctor
        // 
        this.lblDoctor.AutoSize = true;
        this.lblDoctor.Location = new System.Drawing.Point(12, 52);
        this.lblDoctor.Name = "lblDoctor";
        this.lblDoctor.Size = new System.Drawing.Size(35, 13);
        this.lblDoctor.TabIndex = 3;
        this.lblDoctor.Text = "Врач";

        // 
        // btnLogin
        // 
        this.btnLogin.Location = new System.Drawing.Point(197, 105);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(75, 23);
        this.btnLogin.TabIndex = 4;
        this.btnLogin.Text = "Войти";
        this.btnLogin.UseVisualStyleBackColor = true;
        this.btnLogin.Click += new EventHandler(this.BtnLogin_Click);

        // 
        // LoginDoctorForm
        // 
        this.ClientSize = new System.Drawing.Size(284, 140);
        this.Controls.Add(this.btnLogin);
        this.Controls.Add(this.lblDoctor);
        this.Controls.Add(this.cbDoctor);
        this.Controls.Add(this.lblDepartment);
        this.Controls.Add(this.cbDepartment);
        this.Name = "LoginDoctorForm";
        this.Text = "Вход для врача";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
