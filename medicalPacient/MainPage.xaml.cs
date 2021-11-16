using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Firebase.Database;
using Firebase.Database.Query;

namespace medicalPacient
{
    public partial class MainPage : ContentPage
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://pacients-67ea3-default-rtdb.firebaseio.com/");
        public MainPage()
        {
            InitializeComponent();
            
        }
       
        private void Button_Clicked(object sender, EventArgs e)
        {
            firebaseClient.Child("pacients").PostAsync(new Visitor
            {
                height_cm = height_cm.Text,
                pressure= pressure.Text,
                Saturation = saturation.Text,
                Temperature = temperature.Text,
                Weight_kg = weight_kg.Text
            }
            );
            height_cm.Text = "";
        }
    }

    public class Visitor
    {
        public string height_cm { get; set; }
        public string pressure { get; set; }
        public string Saturation { get; set; }
        public string Temperature { get; set; }
        public string Weight_kg { get; set; }

    }
}
