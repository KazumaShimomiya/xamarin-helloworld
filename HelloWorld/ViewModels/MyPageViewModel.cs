using System;
using HelloWorld.Services;
using System.Collections.ObjectModel;
using HelloWorld.Models;
using Xamarin.Forms;

namespace HelloWorld.ViewModels
{
    public class MyPageViewModel: BindableBase
    {
        private double slideValue;

        public double SliderValue
        {
            get { return this.slideValue; }
            set { this.SetProperty(ref this.slideValue, value); this.OnPropertyChenged(nameof(LabelValue)); }

        }

        public string LabelValue => string.Format("This is slider value '{0:000}'", this.slideValue);

        public ObservableCollection<Person> People { get; } = new ObservableCollection<Person>();

        public MyPageViewModel()
        {
            var r = new Random();
            Device.StartTimer(
                TimeSpan.FromSeconds(5),
                () =>
                {
                    this.People.Add(new Person { Name = "test" });
                    return true;
                });
        }
    }
}
