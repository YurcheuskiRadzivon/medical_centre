partial class ManagePatientsForm
{
    private System.ComponentModel.IContainer components = null;
    private Button btnLoginAsDoctor;
    private Button btnLoginAsNurse;

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
        this.btnLoginAsDoctor = new Button();
        this.btnLoginAsNurse = new Button();
        this.SuspendLayout();

        // 
        // btnLoginAsDoctor
        // 
        this.btnLoginAsDoctor.Location = new System.Drawing.Point(50, 50);
        this.btnLoginAsDoctor.Name = "btnLoginAsDoctor";
        this.btnLoginAsDoctor.Size = new System.Drawing.Size(200, 50);
        this.btnLoginAsDoctor.TabIndex = 0;
        this.btnLoginAsDoctor.Text = "Зайти как врач";
        this.btnLoginAsDoctor.UseVisualStyleBackColor = true;
        this.btnLoginAsDoctor.Click += new EventHandler(this.BtnLoginAsDoctor_Click);

        // 
        // btnLoginAsNurse
        // 
        this.btnLoginAsNurse.Location = new System.Drawing.Point(50, 120);
        this.btnLoginAsNurse.Name = "btnLoginAsNurse";
        this.btnLoginAsNurse.Size = new System.Drawing.Size(200, 50);
        this.btnLoginAsNurse.TabIndex = 1;
        this.btnLoginAsNurse.Text = "Зайти как медсестра";
        this.btnLoginAsNurse.UseVisualStyleBackColor = true;
        this.btnLoginAsNurse.Click += new EventHandler(this.BtnLoginAsNurse_Click);

        // 
        // ManagePatientsForm
        // 
        this.ClientSize = new System.Drawing.Size(300, 220);
        this.Controls.Add(this.btnLoginAsNurse);
        this.Controls.Add(this.btnLoginAsDoctor);
        this.Name = "ManagePatientsForm";
        this.Text = "Управление пациентами";
        this.ResumeLayout(false);
    }
}
