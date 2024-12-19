partial class MedicalRecordForm
{
    private System.ComponentModel.IContainer components = null;
    private ListView lvMedicalRecord;
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
        this.lvMedicalRecord = new ListView();
        this.columnHeaderId = new ColumnHeader();
        this.columnHeaderDescription = new ColumnHeader();
        this.columnHeaderType = new ColumnHeader();
        this.columnHeaderTime = new ColumnHeader();
        this.SuspendLayout();

        // 
        // lvMedicalRecord
        // 
        this.lvMedicalRecord.Columns.AddRange(new ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderDescription,
            this.columnHeaderType,
            this.columnHeaderTime});
        this.lvMedicalRecord.FullRowSelect = true;
        this.lvMedicalRecord.GridLines = true;
        this.lvMedicalRecord.Location = new System.Drawing.Point(12, 12);
        this.lvMedicalRecord.Name = "lvMedicalRecord";
        this.lvMedicalRecord.Size = new System.Drawing.Size(560, 300);
        this.lvMedicalRecord.TabIndex = 0;
        this.lvMedicalRecord.UseCompatibleStateImageBehavior = false;
        this.lvMedicalRecord.View = View.Details;

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
        // MedicalRecordForm
        // 
        this.ClientSize = new System.Drawing.Size(584, 321);
        this.Controls.Add(this.lvMedicalRecord);
        this.Name = "MedicalRecordForm";
        this.Text = "Медицинская карта";
        this.ResumeLayout(false);
    }
}
