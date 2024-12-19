partial class AddPreventiveForm
{
    private System.ComponentModel.IContainer components = null;
    private TextBox txtPreventiveName;
    private TextBox txtPreventiveMeasure;
    private Button btnSave;
    private Label lblPreventiveName;
    private Label lblPreventiveMeasure;

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
        this.txtPreventiveName = new TextBox();
        this.txtPreventiveMeasure = new TextBox();
        this.btnSave = new Button();
        this.lblPreventiveName = new Label();
        this.lblPreventiveMeasure = new Label();
        this.SuspendLayout();

        // 
        // txtPreventiveName
        // 
        this.txtPreventiveName.Location = new System.Drawing.Point(12, 29);
        this.txtPreventiveName.Name = "txtPreventiveName";
        this.txtPreventiveName.Size = new System.Drawing.Size(260, 20);
        this.txtPreventiveName.TabIndex = 0;

        // 
        // lblPreventiveName
        // 
        this.lblPreventiveName.AutoSize = true;
        this.lblPreventiveName.Location = new System.Drawing.Point(12, 13);
        this.lblPreventiveName.Name = "lblPreventiveName";
        this.lblPreventiveName.Size = new System.Drawing.Size(112, 13);
        this.lblPreventiveName.TabIndex = 1;
        this.lblPreventiveName.Text = "Название профилактики";

        // 
        // txtPreventiveMeasure
        // 
        this.txtPreventiveMeasure.Location = new System.Drawing.Point(12, 68);
        this.txtPreventiveMeasure.Name = "txtPreventiveMeasure";
        this.txtPreventiveMeasure.Size = new System.Drawing.Size(260, 20);
        this.txtPreventiveMeasure.TabIndex = 2;

        // 
        // lblPreventiveMeasure
        // 
        this.lblPreventiveMeasure.AutoSize = true;
        this.lblPreventiveMeasure.Location = new System.Drawing.Point(12, 52);
        this.lblPreventiveMeasure.Name = "lblPreventiveMeasure";
        this.lblPreventiveMeasure.Size = new System.Drawing.Size(94, 13);
        this.lblPreventiveMeasure.TabIndex = 3;
        this.lblPreventiveMeasure.Text = "Мера профилактики";

        // 
        // btnSave
        // 
        this.btnSave.Location = new System.Drawing.Point(197, 94);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(75, 23);
        this.btnSave.TabIndex = 4;
        this.btnSave.Text = "Сохранить";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new EventHandler(this.BtnSave_Click);

        // 
        // AddPreventiveForm
        // 
        this.ClientSize = new System.Drawing.Size(284, 129);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.lblPreventiveMeasure);
        this.Controls.Add(this.txtPreventiveMeasure);
        this.Controls.Add(this.lblPreventiveName);
        this.Controls.Add(this.txtPreventiveName);
        this.Name = "AddPreventiveForm";
        this.Text = "Добавить профилактическое назначение";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
