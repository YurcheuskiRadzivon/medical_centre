partial class AddDiagnosticForm
{
    private System.ComponentModel.IContainer components = null;
    private TextBox txtDiagnosticName;
    private TextBox txtDiagnosticTool;
    private Button btnSave;
    private Label lblDiagnosticName;
    private Label lblDiagnosticTool;

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
        this.txtDiagnosticName = new TextBox();
        this.txtDiagnosticTool = new TextBox();
        this.btnSave = new Button();
        this.lblDiagnosticName = new Label();
        this.lblDiagnosticTool = new Label();
        this.SuspendLayout();

        // 
        // txtDiagnosticName
        // 
        this.txtDiagnosticName.Location = new System.Drawing.Point(12, 29);
        this.txtDiagnosticName.Name = "txtDiagnosticName";
        this.txtDiagnosticName.Size = new System.Drawing.Size(260, 20);
        this.txtDiagnosticName.TabIndex = 0;

        // 
        // lblDiagnosticName
        // 
        this.lblDiagnosticName.AutoSize = true;
        this.lblDiagnosticName.Location = new System.Drawing.Point(12, 13);
        this.lblDiagnosticName.Name = "lblDiagnosticName";
        this.lblDiagnosticName.Size = new System.Drawing.Size(113, 13);
        this.lblDiagnosticName.TabIndex = 1;
        this.lblDiagnosticName.Text = "Название диагностики";

        // 
        // txtDiagnosticTool
        // 
        this.txtDiagnosticTool.Location = new System.Drawing.Point(12, 68);
        this.txtDiagnosticTool.Name = "txtDiagnosticTool";
        this.txtDiagnosticTool.Size = new System.Drawing.Size(260, 20);
        this.txtDiagnosticTool.TabIndex = 2;

        // 
        // lblDiagnosticTool
        // 
        this.lblDiagnosticTool.AutoSize = true;
        this.lblDiagnosticTool.Location = new System.Drawing.Point(12, 52);
        this.lblDiagnosticTool.Name = "lblDiagnosticTool";
        this.lblDiagnosticTool.Size = new System.Drawing.Size(61, 13);
        this.lblDiagnosticTool.TabIndex = 3;
        this.lblDiagnosticTool.Text = "Инструмент";

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
        // AddDiagnosticForm
        // 
        this.ClientSize = new System.Drawing.Size(284, 129);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.lblDiagnosticTool);
        this.Controls.Add(this.txtDiagnosticTool);
        this.Controls.Add(this.lblDiagnosticName);
        this.Controls.Add(this.txtDiagnosticName);
        this.Name = "AddDiagnosticForm";
        this.Text = "Добавить диагностическое назначение";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
