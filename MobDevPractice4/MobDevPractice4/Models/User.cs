using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobDevPractice4.Models
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPass { get; set; }
    }
}
