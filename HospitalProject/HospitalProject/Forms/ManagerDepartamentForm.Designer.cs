partial class ManagerDepartamentForm
{
    private System.ComponentModel.IContainer components = null;
    private Button btnBack;
    private ListView lstDepartments;
    private Button btnAddDepartment;
    private Button btnDeleteDepartment;
    private ColumnHeader columnHeaderName;
    private ColumnHeader columnHeaderId;
    private ColumnHeader columnHeaderDoctors;
    private ColumnHeader columnHeaderNurses;
    private ColumnHeader columnHeaderPatients;
    private ColumnHeader columnHeaderMedication;
    private ColumnHeader columnHeaderDiagnostic;
    private ColumnHeader columnHeaderPreventive;

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
        this.btnBack = new Button();
        this.lstDepartments = new ListView();
        this.btnAddDepartment = new Button();
        this.btnDeleteDepartment = new Button();
        this.columnHeaderName = new ColumnHeader();
        this.columnHeaderId = new ColumnHeader();
        this.columnHeaderDoctors = new ColumnHeader();
        this.columnHeaderNurses = new ColumnHeader();
        this.columnHeaderPatients = new ColumnHeader();
        this.columnHeaderMedication = new ColumnHeader();
        this.columnHeaderDiagnostic = new ColumnHeader();
        this.columnHeaderPreventive = new ColumnHeader();
        this.SuspendLayout();

        // 
        // btnBack
        // 
        this.btnBack.Location = new System.Drawing.Point(12, 12);
        this.btnBack.Name = "btnBack";
        this.btnBack.Size = new System.Drawing.Size(75, 23);
        this.btnBack.TabIndex = 0;
        this.btnBack.Text = "Назад";
        this.btnBack.UseVisualStyleBackColor = true;
        this.btnBack.Click += new EventHandler(this.BtnBack_Click);

        // 
        // lstDepartments
        // 
        this.lstDepartments.Columns.AddRange(new ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderId,
            this.columnHeaderDoctors,
            this.columnHeaderNurses,
            this.columnHeaderPatients,
            this.columnHeaderMedication,
            this.columnHeaderDiagnostic,
            this.columnHeaderPreventive});
        this.lstDepartments.Location = new System.Drawing.Point(12, 41);
        this.lstDepartments.Name = "lstDepartments";
        this.lstDepartments.Size = new System.Drawing.Size(776, 366);
        this.lstDepartments.TabIndex = 1;
        this.lstDepartments.UseCompatibleStateImageBehavior = false;
        this.lstDepartments.View = View.Details;
        this.lstDepartments.ItemActivate += new EventHandler(this.LstDepartments_ItemActivate);

        // 
        // columnHeaderName
        // 
        this.columnHeaderName.Text = "Название";
        this.columnHeaderName.Width = 100;

        // 
        // columnHeaderId
        // 
        this.columnHeaderId.Text = "ID";
        this.columnHeaderId.Width = 40;

        // 
        // columnHeaderDoctors
        // 
        this.columnHeaderDoctors.Text = "Врачи";
        this.columnHeaderDoctors.Width = 50;

        // 
        // columnHeaderNurses
        // 
        this.columnHeaderNurses.Text = "Медсестры";
        this.columnHeaderNurses.Width = 70;

        // 
        // columnHeaderPatients
        // 
        this.columnHeaderPatients.Text = "Пациенты";
        this.columnHeaderPatients.Width = 70;

        // 
        // columnHeaderMedication
        // 
        this.columnHeaderMedication.Text = "Медикаменты";
        this.columnHeaderMedication.Width = 100;

        // 
        // columnHeaderDiagnostic
        // 
        this.columnHeaderDiagnostic.Text = "Диагностика";
        this.columnHeaderDiagnostic.Width = 100;

        // 
        // columnHeaderPreventive
        // 
        this.columnHeaderPreventive.Text = "Профилактика";
        this.columnHeaderPreventive.Width = 100;

        // 
        // btnAddDepartment
        // 
        this.btnAddDepartment.Location = new System.Drawing.Point(713, 413);
        this.btnAddDepartment.Name = "btnAddDepartment";
        this.btnAddDepartment.Size = new System.Drawing.Size(75, 23);
        this.btnAddDepartment.TabIndex = 2;
        this.btnAddDepartment.Text = "Добавить";
        this.btnAddDepartment.UseVisualStyleBackColor = true;
        this.btnAddDepartment.Click += new EventHandler(this.BtnAddDepartment_Click);

        // 
        // btnDeleteDepartment
        // 
        this.btnDeleteDepartment.Location = new System.Drawing.Point(632, 413);
        this.btnDeleteDepartment.Name = "btnDeleteDepartment";
        this.btnDeleteDepartment.Size = new System.Drawing.Size(75, 23);
        this.btnDeleteDepartment.TabIndex = 3;
        this.btnDeleteDepartment.Text = "Удалить";
        this.btnDeleteDepartment.UseVisualStyleBackColor = true;
        this.btnDeleteDepartment.Click += new EventHandler(this.BtnDeleteDepartment_Click);

        // 
        // ManagerDepartamentForm
        // 
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnDeleteDepartment);
        this.Controls.Add(this.btnAddDepartment);
        this.Controls.Add(this.lstDepartments);
        this.Controls.Add(this.btnBack);
        this.Name = "ManagerDepartamentForm";
        this.Text = "Менеджер отделений";
        this.Load += new EventHandler(this.ManagerDepartamentForm_Load);
        this.ResumeLayout(false);
    }
}
