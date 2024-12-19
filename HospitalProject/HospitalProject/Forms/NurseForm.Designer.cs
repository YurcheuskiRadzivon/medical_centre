partial class NurseForm
{
    private System.ComponentModel.IContainer components = null;
    private ListView lvAppointments;
    private Button btnCompleteAppointment;
    private Label lblAppointments;
    private ColumnHeader columnHeaderId;
    private ColumnHeader columnHeaderDescription;
    private ColumnHeader columnHeaderType;
    private ColumnHeader columnHeaderTime;

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
        this.lvAppointments = new ListView();
        this.btnCompleteAppointment = new Button();
        this.lblAppointments = new Label();
        this.columnHeaderId = new ColumnHeader();
        this.columnHeaderDescription = new ColumnHeader();
        this.columnHeaderType = new ColumnHeader();
        this.columnHeaderTime = new ColumnHeader();
        this.SuspendLayout();

        // 
        // lvAppointments
        // 
        this.lvAppointments.Columns.AddRange(new ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderDescription,
            this.columnHeaderType,
            this.columnHeaderTime});
        this.lvAppointments.FullRowSelect = true;
        this.lvAppointments.GridLines = true;
        this.lvAppointments.Location = new System.Drawing.Point(12, 29);
        this.lvAppointments.Name = "lvAppointments";
        this.lvAppointments.Size = new System.Drawing.Size(560, 300);
        this.lvAppointments.TabIndex = 0;
        this.lvAppointments.UseCompatibleStateImageBehavior = false;
        this.lvAppointments.View = View.Details;

        // 
        // columnHeaderId
        // 
        this.columnHeaderId.Text = "ID";
        this.columnHeaderId.Width = 50;

        // 
        // columnHeaderDescription
        // 
        this.columnHeaderDescription.Text = "Описание";
        this.columnHeaderDescription.Width = 200;

        // 
        // columnHeaderType
        // 
        this.columnHeaderType.Text = "Тип назначения";
        this.columnHeaderType.Width = 150;

        // 
        // columnHeaderTime
        // 
        this.columnHeaderTime.Text = "Время";
        this.columnHeaderTime.Width = 160;

        // 
        // btnCompleteAppointment
        // 
        this.btnCompleteAppointment.Location = new System.Drawing.Point(12, 340);
        this.btnCompleteAppointment.Name = "btnCompleteAppointment";
        this.btnCompleteAppointment.Size = new System.Drawing.Size(200, 30);
        this.btnCompleteAppointment.TabIndex = 1;
        this.btnCompleteAppointment.Text = "Выполнить назначение";
        this.btnCompleteAppointment.UseVisualStyleBackColor = true;
        this.btnCompleteAppointment.Click += new EventHandler(this.BtnCompleteAppointment_Click);

        // 
        // lblAppointments
        // 
        this.lblAppointments.AutoSize = true;
        this.lblAppointments.Location = new System.Drawing.Point(12, 13);
        this.lblAppointments.Name = "lblAppointments";
        this.lblAppointments.Size = new System.Drawing.Size(78, 13);
        this.lblAppointments.TabIndex = 2;
        this.lblAppointments.Text = "Назначения";

        // 
        // NurseForm
        // 
        this.ClientSize = new System.Drawing.Size(584, 381);
        this.Controls.Add(this.lblAppointments);
        this.Controls.Add(this.btnCompleteAppointment);
        this.Controls.Add(this.lvAppointments);
        this.Name = "NurseForm";
        this.Text = "Медсестра";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
