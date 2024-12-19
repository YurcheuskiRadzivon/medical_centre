using HospitalProject.Business.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

public partial class ManagePatientsForm : Form
{
    private Hospital hospital;

    public ManagePatientsForm(Hospital hospital)
    {
        this.hospital = hospital;
        InitializeComponent();
    }

    private void BtnLoginAsDoctor_Click(object sender, EventArgs e)
    {
        var loginDoctorForm = new LoginDoctorForm(hospital);
        loginDoctorForm.DoctorLoggedIn += (s, doctor) =>
        {
            if (doctor.Specialty == "Лечащий врач")
            {
                var treatingDoctorForm = new TreatingDoctorForm(hospital, doctor);
                treatingDoctorForm.Show();
            }
            else
            {
                var otherDoctorForm = new OtherDoctorForm(hospital, doctor);
                otherDoctorForm.Show();
            }
        };
        loginDoctorForm.Show();
    }

    private void BtnLoginAsNurse_Click(object sender, EventArgs e)
    {
        var loginNurseForm = new LoginNurseForm(hospital);
        loginNurseForm.NurseLoggedIn += (s, nurse) =>
        {
            var nurseForm = new NurseForm(hospital, nurse);
            nurseForm.Show();
        };
        loginNurseForm.Show();
    }
}
