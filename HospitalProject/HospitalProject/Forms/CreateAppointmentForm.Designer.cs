partial class CreateAppointmentForm
{
    private System.ComponentModel.IContainer components = null;
    private TextBox txtDescription;
    private ComboBox cbAppointmentType;
    private ComboBox cbPersonnel;
    private Button btnCreate;
    private Label lblDescription;
    private Label lblAppointmentType;
    private Label lblPersonnel;

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
        this.txtDescription = new TextBox();
        this.cbAppointmentType = new ComboBox();
        this.cbPersonnel = new ComboBox();
        this.btnCreate = new Button();
        this.lblDescription = new Label();
        this.lblAppointmentType = new Label();
        this.lblPersonnel = new Label();
        this.SuspendLayout();

        // 
        // txtDescription
        // 
        this.txtDescription.Location = new System.Drawing.Point(12, 29);
        this.txtDescription.Multiline = true;
        this.txtDescription.Name = "txtDescription";
        this.txtDescription.Size = new System.Drawing.Size(260, 60);
        this.txtDescription.TabIndex = 0;

        // 
        // lblDescription
        // 
        this.lblDescription.AutoSize = true;
        this.lblDescription.Location = new System.Drawing.Point(12, 13);
        this.lblDescription.Name = "lblDescription";
        this.lblDescription.Size = new System.Drawing.Size(57, 13);
        this.lblDescription.TabIndex = 1;
        this.lblDescription.Text = "Описание";

        // 
        // cbAppointmentType
        // 
        this.cbAppointmentType.FormattingEnabled = true;
        this.cbAppointmentType.Location = new System.Drawing.Point(12, 108);
        this.cbAppointmentType.Name = "cbAppointmentType";
        this.cbAppointmentType.Size = new System.Drawing.Size(260, 21);
        this.cbAppointmentType.TabIndex = 2;
        this.cbAppointmentType.SelectedIndexChanged += new EventHandler(this.CbAppointmentType_SelectedIndexChanged);

        // 
        // lblAppointmentType
        // 
        this.lblAppointmentType.AutoSize = true;
        this.lblAppointmentType.Location = new System.Drawing.Point(12, 92);
        this.lblAppointmentType.Name = "lblAppointmentType";
        this.lblAppointmentType.Size = new System.Drawing.Size(86, 13);
        this.lblAppointmentType.TabIndex = 3;
        this.lblAppointmentType.Text = "Тип назначения";

        // 
        // cbPersonnel
        // 
        this.cbPersonnel.FormattingEnabled = true;
        this.cbPersonnel.Location = new System.Drawing.Point(12, 163);
        this.cbPersonnel.Name = "cbPersonnel";
        this.cbPersonnel.Size = new System.Drawing.Size(260, 21);
        this.cbPersonnel.TabIndex = 4;

        // 
        // lblPersonnel
        // 
        this.lblPersonnel.AutoSize = true;
        this.lblPersonnel.Location = new System.Drawing.Point(12, 147);
        this.lblPersonnel.Name = "lblPersonnel";
        this.lblPersonnel.Size = new System.Drawing.Size(94, 13);
        this.lblPersonnel.TabIndex = 5;
        this.lblPersonnel.Text = "Исполнитель";

        // 
        // btnCreate
        // 
        this.btnCreate.Location = new System.Drawing.Point(197, 200);
        this.btnCreate.Name = "btnCreate";
        this.btnCreate.Size = new System.Drawing.Size(75, 23);
        this.btnCreate.TabIndex = 6;
        this.btnCreate.Text = "Создать";
        this.btnCreate.UseVisualStyleBackColor = true;
        this.btnCreate.Click += new EventHandler(this.BtnCreate_Click);

        // 
        // CreateAppointmentForm
        // 
        this.ClientSize = new System.Drawing.Size(284, 235);
        this.Controls.Add(this.btnCreate);
        this.Controls.Add(this.lblPersonnel);
        this.Controls.Add(this.cbPersonnel);
        this.Controls.Add(this.lblAppointmentType);
        this.Controls.Add(this.cbAppointmentType);
        this.Controls.Add(this.lblDescription);
        this.Controls.Add(this.txtDescription);
        this.Name = "CreateAppointmentForm";
        this.Text = "Создание назначения";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
