using HospitalProject.Business.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

static class Program
{
    private static DataContext dataContext = new DataContext();
    private static Hospital hospital;

    [STAThread]
    static void Main()
    {
        Application.ApplicationExit += new EventHandler(OnApplicationExit);

        hospital = dataContext.LoadHospitalData();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainMenu(hospital));
    }

    private static void OnApplicationExit(object sender, EventArgs e)
    {
        dataContext.SaveHospitalData(hospital);
    }
}
