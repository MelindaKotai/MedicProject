﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            Patient Ionut = new Patient() 
            {FirstName = "Ionut",
                LastName="Iga",
                Address="str. Soarelui nr.19",
                Phone="1234567890",
                PIN="1992753857251" ,
                BirthDate="25.09.1999",
                BirthPlace="New York",
                Email="ionut.iga@yahoo.com" };

            BindingContext = Ionut;
            if (int.Parse(Ionut.PIN.Substring(0, 1)) % 2 != 0)
                imgPatient.Source = ImageSource.FromResource("mobile.Images.manWhite.png");
            else
                imgPatient.Source = ImageSource.FromResource("mobile.Images.womanWhite.png");

        }
    }
}