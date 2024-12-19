partial class EditDepartmentForm
{
    private System.ComponentModel.IContainer components = null;
    private TextBox txtDepartmentName;
    private Button btnSave;
    private Label lblDepartmentName;
    private ListView lvMedicationTypes;
    private ListView lvDiagnosticTypes;
    private ListView lvPreventiveTypes;
    private Button btnAddMedication;
    private Button btnEditMedication;
    private Button btnDeleteMedication;
    private Button btnAddDiagnostic;
    private Button btnEditDiagnostic;
    private Button btnDeleteDiagnostic;
    private Button btnAddPreventive;
    private Button btnEditPreventive;
    private Button btnDeletePreventive;

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
        this.txtDepartmentName = new TextBox();
        this.btnSave = new Button();
        this.lblDepartmentName = new Label();
        this.lvMedicationTypes = new ListView();
        this.lvDiagnosticTypes = new ListView();
        this.lvPreventiveTypes = new ListView();
        this.btnAddMedication = new Button();
        this.btnEditMedication = new Button();
        this.btnDeleteMedication = new Button();
        this.btnAddDiagnostic = new Button();
        this.btnEditDiagnostic = new Button();
        this.btnDeleteDiagnostic = new Button();
        this.btnAddPreventive = new Button();
        this.btnEditPreventive = new Button();
        this.btnDeletePreventive = new Button();
        this.SuspendLayout();

        // 
        // txtDepartmentName
        // 
        this.txtDepartmentName.Location = new System.Drawing.Point(12, 29);
        this.txtDepartmentName.Name = "txtDepartmentName";
        this.txtDepartmentName.Size = new System.Drawing.Size(260, 20);
        this.txtDepartmentName.TabIndex = 0;

        // 
        // lblDepartmentName
        // 
        this.lblDepartmentName.AutoSize = true;
        this.lblDepartmentName.Location = new System.Drawing.Point(12, 13);
        this.lblDepartmentName.Name = "lblDepartmentName";
        this.lblDepartmentName.Size = new System.Drawing.Size(93, 13);
        this.lblDepartmentName.TabIndex = 1;
        this.lblDepartmentName.Text = "Название отдела";

        // 
        // lvMedicationTypes
        // 
        this.lvMedicationTypes.Location = new System.Drawing.Point(12, 70);
        this.lvMedicationTypes.Name = "lvMedicationTypes";
        this.lvMedicationTypes.Size = new System.Drawing.Size(260, 70);
        this.lvMedicationTypes.TabIndex = 3;
        this.lvMedicationTypes.View = View.Details;
        this.lvMedicationTypes.Columns.Add("Наименование", 100);
        this.lvMedicationTypes.Columns.Add("Количество", 80);
        this.lvMedicationTypes.Columns.Add("Дозировка", 80);

        // 
        // btnAddMedication
        // 
        this.btnAddMedication.Location = new System.Drawing.Point(278, 70);
        this.btnAddMedication.Name = "btnAddMedication";
        this.btnAddMedication.Size = new System.Drawing.Size(75, 23);
        this.btnAddMedication.TabIndex = 6;
        this.btnAddMedication.Text = "Добавить";
        this.btnAddMedication.UseVisualStyleBackColor = true;
        this.btnAddMedication.Click += new EventHandler(this.BtnAddMedication_Click);

        // 
        // btnEditMedication
        // 
        this.btnEditMedication.Location = new System.Drawing.Point(278, 99);
        this.btnEditMedication.Name = "btnEditMedication";
        this.btnEditMedication.Size = new System.Drawing.Size(75, 23);
        this.btnEditMedication.TabIndex = 7;
        this.btnEditMedication.Text = "Изменить";
        this.btnEditMedication.UseVisualStyleBackColor = true;
        this.btnEditMedication.Click += new EventHandler(this.BtnEditMedication_Click);

        // 
        // btnDeleteMedication
        // 
        this.btnDeleteMedication.Location = new System.Drawing.Point(278, 128);
        this.btnDeleteMedication.Name = "btnDeleteMedication";
        this.btnDeleteMedication.Size = new System.Drawing.Size(75, 23);
        this.btnDeleteMedication.TabIndex = 8;
        this.btnDeleteMedication.Text = "Удалить";
        this.btnDeleteMedication.UseVisualStyleBackColor = true;
        this.btnDeleteMedication.Click += new EventHandler(this.BtnDeleteMedication_Click);

        // 
        // lvDiagnosticTypes
        // 
        this.lvDiagnosticTypes.Location = new System.Drawing.Point(12, 150);
        this.lvDiagnosticTypes.Name = "lvDiagnosticTypes";
        this.lvDiagnosticTypes.Size = new System.Drawing.Size(260, 70);
        this.lvDiagnosticTypes.TabIndex = 4;
        this.lvDiagnosticTypes.View = View.Details;
        this.lvDiagnosticTypes.Columns.Add("Наименование", 150);
        this.lvDiagnosticTypes.Columns.Add("Инструмент", 110);

        // 
        // btnAddDiagnostic
        // 
        this.btnAddDiagnostic.Location = new System.Drawing.Point(278, 150);
        this.btnAddDiagnostic.Name = "btnAddDiagnostic";
        this.btnAddDiagnostic.Size = new System.Drawing.Size(75, 23);
        this.btnAddDiagnostic.TabIndex = 9;
        this.btnAddDiagnostic.Text = "Добавить";
        this.btnAddDiagnostic.UseVisualStyleBackColor = true;
        this.btnAddDiagnostic.Click += new EventHandler(this.BtnAddDiagnostic_Click);

        // 
        // btnEditDiagnostic
        // 
        this.btnEditDiagnostic.Location = new System.Drawing.Point(278, 179);
        this.btnEditDiagnostic.Name = "btnEditDiagnostic";
        this.btnEditDiagnostic.Size = new System.Drawing.Size(75, 23);
        this.btnEditDiagnostic.TabIndex = 10;
        this.btnEditDiagnostic.Text = "Изменить";
        this.btnEditDiagnostic.UseVisualStyleBackColor = true;
        this.btnEditDiagnostic.Click += new EventHandler(this.BtnEditDiagnostic_Click);

        // 
        // btnDeleteDiagnostic
        // 
        this.btnDeleteDiagnostic.Location = new System.Drawing.Point(278, 208);
        this.btnDeleteDiagnostic.Name = "btnDeleteDiagnostic";
        this.btnDeleteDiagnostic.Size = new System.Drawing.Size(75, 23);
        this.btnDeleteDiagnostic.TabIndex = 11;
        this.btnDeleteDiagnostic.Text = "Удалить";
        this.btnDeleteDiagnostic.UseVisualStyleBackColor = true;
        this.btnDeleteDiagnostic.Click += new EventHandler(this.BtnDeleteDiagnostic_Click);

        // 
        // lvPreventiveTypes
        // 
        this.lvPreventiveTypes.Location = new System.Drawing.Point(12, 230);
        this.lvPreventiveTypes.Name = "lvPreventiveTypes";
        this.lvPreventiveTypes.Size = new System.Drawing.Size(260, 70);
        this.lvPreventiveTypes.TabIndex = 5;
        this.lvPreventiveTypes.View = View.Details;
        this.lvPreventiveTypes.Columns.Add("Наименование", 150);
        this.lvPreventiveTypes.Columns.Add("Мера профилактики", 110);

        // 
        // btnAddPreventive
        // 
        this.btnAddPreventive.Location = new System.Drawing.Point(278, 230);
        this.btnAddPreventive.Name = "btnAddPreventive";
        this.btnAddPreventive.Size = new System.Drawing.Size(75, 23);
        this.btnAddPreventive.TabIndex = 12;
        this.btnAddPreventive.Text = "Добавить";
        this.btnAddPreventive.UseVisualStyleBackColor = true;
        this.btnAddPreventive.Click += new EventHandler(this.BtnAddPreventive_Click);

        // 
        // btnEditPreventive
        // 
        this.btnEditPreventive.Location = new System.Drawing.Point(278, 259);
        this.btnEditPreventive.Name = "btnEditPreventive";
        this.btnEditPreventive.Size = new System.Drawing.Size(75, 23);
        this.btnEditPreventive.TabIndex = 13;
        this.btnEditPreventive.Text = "Изменить";
        this.btnEditPreventive.UseVisualStyleBackColor = true;
        this.btnEditPreventive.Click += new EventHandler(this.BtnEditPreventive_Click);

        // 
        // btnDeletePreventive
        // 
        this.btnDeletePreventive.Location = new System.Drawing.Point(278, 288);
        this.btnDeletePreventive.Name = "btnDeletePreventive";
        this.btnDeletePreventive.Size = new System.Drawing.Size(75, 23);
        this.btnDeletePreventive.TabIndex = 14;
        this.btnDeletePreventive.Text = "Удалить";
        this.btnDeletePreventive.UseVisualStyleBackColor = true;
        this.btnDeletePreventive.Click += new EventHandler(this.BtnDeletePreventive_Click);

        // 
        // btnSave
        // 
        this.btnSave.Location = new System.Drawing.Point(197, 310);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(75, 23);
        this.btnSave.TabIndex = 9;
        this.btnSave.Text = "Сохранить";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new EventHandler(this.BtnSave_Click);

        // 
        // EditDepartmentForm
        // 
        this.ClientSize = new System.Drawing.Size(364, 341);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.btnDeletePreventive);
        this.Controls.Add(this.btnEditPreventive);
        this.Controls.Add(this.btnAddPreventive);
        this.Controls.Add(this.btnDeleteDiagnostic);
        this.Controls.Add(this.btnEditDiagnostic);
        this.Controls.Add(this.btnAddDiagnostic);
        this.Controls.Add(this.btnDeleteMedication);
        this.Controls.Add(this.btnEditMedication);
        this.Controls.Add(this.btnAddMedication);
        this.Controls.Add(this.lblDepartmentName);
        this.Controls.Add(this.txtDepartmentName);
        this.Controls.Add(this.lvMedicationTypes);
        this.Controls.Add(this.lvDiagnosticTypes);
        this.Controls.Add(this.lvPreventiveTypes);
        this.Name = "EditDepartmentForm";
        this.Text = "Редактировать отделение";
        this.Load += new EventHandler(this.EditDepartmentForm_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
