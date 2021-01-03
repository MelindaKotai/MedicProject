﻿using mobile.Models;
using mobile.Resources;
using mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppointmentsPage : ContentPage
    {
        AppointmentModel apt = new AppointmentModel();
        public static CreateAppointment createAppt = new CreateAppointment();

        public AppointmentsPage()
        {
            InitializeComponent();
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = apt;
        }
        //time span for doctor schedule
        TimeSpan startTime = new TimeSpan(8, 0, 0);
        TimeSpan endTime = new TimeSpan(17, 0, 0);
       
         private void btnMake_Clicked(object sender, EventArgs e)
        {
            lblAvailable.IsVisible = true;
            //compare data choosen by user with schedule
            int ver1 = TimeSpan.Compare(tpAppointment.Time, startTime);
            int ver2 = TimeSpan.Compare(tpAppointment.Time, endTime);
            if ( ver1 == -1 || ver2 == 1 ){
                lblAvailable.IsVisible = true;
                lblAvailable.Text = AppResources.UnavailableDate;
            }
            else
            {
                //saved data in object to send with the api
                CreateAppointment sendAppt = new CreateAppointment()
                {
                    Date = dpAppointment.Date,
                    Hour = tpAppointment.Time.ToString(),
                    UserId = App.user.id
                };
                //command that consumes api to
                apt.CreateApppointmentCommand.Execute(sendAppt);
            }
           
        }
    }
}