partial class ManagerPersonnelForm
{
    private System.ComponentModel.IContainer components = null;
    private Button btnBack;
    private ListView lvDoctors;
    private ListView lvNurses;
    private Button btnAddDoctor;
    private Button btnAddNurse;
    private Button btnDeleteDoctor;
    private Button btnDeleteNurse;
    private ColumnHeader columnHeaderDoctorId;
    private ColumnHeader columnHeaderDoctorLastName;
    private ColumnHeader columnHeaderDoctorFirstName;
    private ColumnHeader columnHeaderDoctorMiddleName;
    private ColumnHeader columnHeaderDoctorSpecialty;
    private ColumnHeader columnHeaderDoctorDepartmentId;
    private ColumnHeader columnHeaderNurseId;
    private ColumnHeader columnHeaderNurseLastName;
    private ColumnHeader columnHeaderNurseFirstName;
    private ColumnHeader columnHeaderNurseMiddleName;
    private ColumnHeader columnHeaderNurseDepartmentId;

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
        this.lvDoctors = new ListView();
        this.lvNurses = new ListView();
        this.btnAddDoctor = new Button();
        this.btnAddNurse = new Button();
        this.btnDeleteDoctor = new Button();
        this.btnDeleteNurse = new Button();
        this.columnHeaderDoctorId = new ColumnHeader();
        this.columnHeaderDoctorLastName = new ColumnHeader();
        this.columnHeaderDoctorFirstName = new ColumnHeader();
        this.columnHeaderDoctorMiddleName = new ColumnHeader();
        this.columnHeaderDoctorSpecialty = new ColumnHeader();
        this.columnHeaderDoctorDepartmentId = new ColumnHeader();
        this.columnHeaderNurseId = new ColumnHeader();
        this.columnHeaderNurseLastName = new ColumnHeader();
        this.columnHeaderNurseFirstName = new ColumnHeader();
        this.columnHeaderNurseMiddleName = new ColumnHeader();
        this.columnHeaderNurseDepartmentId = new ColumnHeader();
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
        // lvDoctors
        // 
        this.lvDoctors.Columns.AddRange(new ColumnHeader[] {
            this.columnHeaderDoctorId,
            this.columnHeaderDoctorLastName,
            this.columnHeaderDoctorFirstName,
            this.columnHeaderDoctorMiddleName,
            this.columnHeaderDoctorSpecialty,
            this.columnHeaderDoctorDepartmentId});
        this.lvDoctors.Location = new System.Drawing.Point(12, 41);
        this.lvDoctors.Name = "lvDoctors";
        this.lvDoctors.Size = new System.Drawing.Size(500, 300);
        this.lvDoctors.TabIndex = 1;
        this.lvDoctors.UseCompatibleStateImageBehavior = false;
        this.lvDoctors.View = View.Details;
        this.lvDoctors.ItemActivate += new EventHandler(this.LvDoctors_ItemActivate);

        // 
        // columnHeaderDoctorId
        // 
        this.columnHeaderDoctorId.Text = "ID";
        this.columnHeaderDoctorId.Width = 40;

        // 
        // columnHeaderDoctorLastName
        // 
        this.columnHeaderDoctorLastName.Text = "Фамилия";
        this.columnHeaderDoctorLastName.Width = 100;

        // 
        // columnHeaderDoctorFirstName
        // 
        this.columnHeaderDoctorFirstName.Text = "Имя";
        this.columnHeaderDoctorFirstName.Width = 100;

        // 
        // columnHeaderDoctorMiddleName
        // 
        this.columnHeaderDoctorMiddleName.Text = "Отчество";
        this.columnHeaderDoctorMiddleName.Width = 100;

        // 
        // columnHeaderDoctorSpecialty
        // 
        this.columnHeaderDoctorSpecialty.Text = "Специальность";
        this.columnHeaderDoctorSpecialty.Width = 100;

        // 
        // columnHeaderDoctorDepartmentId
        // 
        this.columnHeaderDoctorDepartmentId.Text = "ID Отделения";
        this.columnHeaderDoctorDepartmentId.Width = 100;

        // 
        // lvNurses
        // 
        this.lvNurses.Columns.AddRange(new ColumnHeader[] {
            this.columnHeaderNurseId,
            this.columnHeaderNurseLastName,
            this.columnHeaderNurseFirstName,
            this.columnHeaderNurseMiddleName,
            this.columnHeaderNurseDepartmentId});
        this.lvNurses.Location = new System.Drawing.Point(518, 41);
        this.lvNurses.Name = "lvNurses";
        this.lvNurses.Size = new System.Drawing.Size(400, 300);
        this.lvNurses.TabIndex = 2;
        this.lvNurses.UseCompatibleStateImageBehavior = false;
        this.lvNurses.View = View.Details;
        this.lvNurses.ItemActivate += new EventHandler(this.LvNurses_ItemActivate);

        // 
        // columnHeaderNurseId
        // 
        this.columnHeaderNurseId.Text = "ID";
        this.columnHeaderNurseId.Width = 40;

        // 
        // columnHeaderNurseLastName
        // 
        this.columnHeaderNurseLastName.Text = "Фамилия";
        this.columnHeaderNurseLastName.Width = 100;

        // 
        // columnHeaderNurseFirstName
        // 
        this.columnHeaderNurseFirstName.Text = "Имя";
        this.columnHeaderNurseFirstName.Width = 100;

        // 
        // columnHeaderNurseMiddleName
        // 
        this.columnHeaderNurseMiddleName.Text = "Отчество";
        this.columnHeaderNurseMiddleName.Width = 100;

        // 
        // columnHeaderNurseDepartmentId
        // 
        this.columnHeaderNurseDepartmentId.Text = "ID Отделения";
        this.columnHeaderNurseDepartmentId.Width = 100;

        // 
        // btnAddDoctor
        // 
        this.btnAddDoctor.Location = new System.Drawing.Point(12, 347);
        this.btnAddDoctor.Name = "btnAddDoctor";
        this.btnAddDoctor.Size = new System.Drawing.Size(100, 23);
        this.btnAddDoctor.TabIndex = 3;
        this.btnAddDoctor.Text = "Добавить врача";
        this.btnAddDoctor.UseVisualStyleBackColor = true;
        this.btnAddDoctor.Click += new EventHandler(this.BtnAddDoctor_Click);

        // 
        // btnAddNurse
        // 
        this.btnAddNurse.Location = new System.Drawing.Point(518, 347);
        this.btnAddNurse.Name = "btnAddNurse";
        this.btnAddNurse.Size = new System.Drawing.Size(120, 23);
        this.btnAddNurse.TabIndex = 4;
        this.btnAddNurse.Text = "Добавить медсестру";
        this.btnAddNurse.UseVisualStyleBackColor = true;
        this.btnAddNurse.Click += new EventHandler(this.BtnAddNurse_Click);

        // 
        // btnDeleteDoctor
        // 
        this.btnDeleteDoctor.Location = new System.Drawing.Point(118, 347);
        this.btnDeleteDoctor.Name = "btnDeleteDoctor";
        this.btnDeleteDoctor.Size = new System.Drawing.Size(100, 23);
        this.btnDeleteDoctor.TabIndex = 5;
        this.btnDeleteDoctor.Text = "Удалить врача";
        this.btnDeleteDoctor.UseVisualStyleBackColor = true;
        this.btnDeleteDoctor.Click += new EventHandler(this.BtnDeleteDoctor_Click);

        // 
        // btnDeleteNurse
        // 
        this.btnDeleteNurse.Location = new System.Drawing.Point(644, 347);
        this.btnDeleteNurse.Name = "btnDeleteNurse";
        this.btnDeleteNurse.Size = new System.Drawing.Size(120, 23);
        this.btnDeleteNurse.TabIndex = 6;
        this.btnDeleteNurse.Text = "Удалить медсестру";
        this.btnDeleteNurse.UseVisualStyleBackColor = true;
        this.btnDeleteNurse.Click += new EventHandler(this.BtnDeleteNurse_Click);

        // 
        // ManagerPersonnelForm
        // 
        this.ClientSize = new System.Drawing.Size(930, 390);
        this.Controls.Add(this.btnDeleteNurse);
        this.Controls.Add(this.btnDeleteDoctor);
        this.Controls.Add(this.btnAddNurse);
        this.Controls.Add(this.btnAddDoctor);
        this.Controls.Add(this.lvNurses);
        this.Controls.Add(this.lvDoctors);
        this.Controls.Add(this.btnBack);
        this.Name = "ManagerPersonnelForm";
        this.Text = "Менеджер персонала";
        this.Load += new EventHandler(this.ManagerPersonnelForm_Load);
        this.ResumeLayout(false);
    }
}
