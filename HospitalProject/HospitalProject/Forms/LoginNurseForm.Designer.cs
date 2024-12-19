partial class LoginNurseForm
{
    private System.ComponentModel.IContainer components = null;
    private ComboBox cbDepartment;
    private ComboBox cbNurse;
    private Button btnLogin;
    private Label lblDepartment;
    private Label lblNurse;

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
        this.cbNurse = new ComboBox();
        this.btnLogin = new Button();
        this.lblDepartment = new Label();
        this.lblNurse = new Label();
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
        // cbNurse
        // 
        this.cbNurse.FormattingEnabled = true;
        this.cbNurse.Location = new System.Drawing.Point(12, 68);
        this.cbNurse.Name = "cbNurse";
        this.cbNurse.Size = new System.Drawing.Size(260, 21);
        this.cbNurse.TabIndex = 2;

        // 
        // lblNurse
        // 
        this.lblNurse.AutoSize = true;
        this.lblNurse.Location = new System.Drawing.Point(12, 52);
        this.lblNurse.Name = "lblNurse";
        this.lblNurse.Size = new System.Drawing.Size(64, 13);
        this.lblNurse.TabIndex = 3;
        this.lblNurse.Text = "Медсестра";

        // 
        // btnLogin
        // 
        this.btnLogin.Location = new System.Drawing.Point(197, 95);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(75, 23);
        this.btnLogin.TabIndex = 4;
        this.btnLogin.Text = "Войти";
        this.btnLogin.UseVisualStyleBackColor = true;
        this.btnLogin.Click += new EventHandler(this.BtnLogin_Click);

        // 
        // LoginNurseForm
        // 
        this.ClientSize = new System.Drawing.Size(284, 130);
        this.Controls.Add(this.btnLogin);
        this.Controls.Add(this.lblNurse);
        this.Controls.Add(this.cbNurse);
        this.Controls.Add(this.lblDepartment);
        this.Controls.Add(this.cbDepartment);
        this.Name = "LoginNurseForm";
        this.Text = "Вход для медсестры";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
