using System;
using Aplicatie_Examen.Data;
using System.IO;

namespace Aplicatie_Examen
{

    public partial class App 
    {
        static CarListDatabase database;
        public static CarListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new CarListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "CarList.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ListEntryPage());
        }


