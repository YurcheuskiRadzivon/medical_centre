partial class AddMedicationForm
{
    private System.ComponentModel.IContainer components = null;
    private TextBox txtMedicationName;
    private TextBox txtQuantity;
    private TextBox txtDosage;
    private Button btnSave;
    private Label lblMedicationName;
    private Label lblQuantity;
    private Label lblDosage;

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
        this.txtMedicationName = new TextBox();
        this.txtQuantity = new TextBox();
        this.txtDosage = new TextBox();
        this.btnSave = new Button();
        this.lblMedicationName = new Label();
        this.lblQuantity = new Label();
        this.lblDosage = new Label();
        this.SuspendLayout();

        // 
        // txtMedicationName
        // 
        this.txtMedicationName.Location = new System.Drawing.Point(12, 29);
        this.txtMedicationName.Name = "txtMedicationName";
        this.txtMedicationName.Size = new System.Drawing.Size(260, 20);
        this.txtMedicationName.TabIndex = 0;

        // 
        // lblMedicationName
        // 
        this.lblMedicationName.AutoSize = true;
        this.lblMedicationName.Location = new System.Drawing.Point(12, 13);
        this.lblMedicationName.Name = "lblMedicationName";
        this.lblMedicationName.Size = new System.Drawing.Size(83, 13);
        this.lblMedicationName.TabIndex = 1;
        this.lblMedicationName.Text = "Название лек.";

        // 
        // txtQuantity
        // 
        this.txtQuantity.Location = new System.Drawing.Point(12, 68);
        this.txtQuantity.Name = "txtQuantity";
        this.txtQuantity.Size = new System.Drawing.Size(260, 20);
        this.txtQuantity.TabIndex = 2;

        // 
        // lblQuantity
        // 
        this.lblQuantity.AutoSize = true;
        this.lblQuantity.Location = new System.Drawing.Point(12, 52);
        this.lblQuantity.Name = "lblQuantity";
        this.lblQuantity.Size = new System.Drawing.Size(66, 13);
        this.lblQuantity.TabIndex = 3;
        this.lblQuantity.Text = "Количество";

        // 
        // txtDosage
        // 
        this.txtDosage.Location = new System.Drawing.Point(12, 107);
        this.txtDosage.Name = "txtDosage";
        this.txtDosage.Size = new System.Drawing.Size(260, 20);
        this.txtDosage.TabIndex = 4;

        // 
        // lblDosage
        // 
        this.lblDosage.AutoSize = true;
        this.lblDosage.Location = new System.Drawing.Point(12, 91);
        this.lblDosage.Name = "lblDosage";
        this.lblDosage.Size = new System.Drawing.Size(62, 13);
        this.lblDosage.TabIndex = 5;
        this.lblDosage.Text = "Дозировка";

        // 
        // btnSave
        // 
        this.btnSave.Location = new System.Drawing.Point(197, 133);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(75, 23);
        this.btnSave.TabIndex = 6;
        this.btnSave.Text = "Сохранить";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new EventHandler(this.BtnSave_Click);

        // 
        // AddMedicationForm
        // 
        this.ClientSize = new System.Drawing.Size(284, 168);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.lblDosage);
        this.Controls.Add(this.txtDosage);
        this.Controls.Add(this.lblQuantity);
        this.Controls.Add(this.txtQuantity);
        this.Controls.Add(this.lblMedicationName);
        this.Controls.Add(this.txtMedicationName);
        this.Name = "AddMedicationForm";
        this.Text = "Добавить назначение медикамента";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
