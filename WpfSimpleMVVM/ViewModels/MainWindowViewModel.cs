using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfSimpleMVVM.Exeptions;
using WpfSimpleMVVM.Models;
using WpfSimpleMVVM.Tools;

namespace WpfSimpleMVVM.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Fields

        

        private string _nameInput;
        private string _secondnameInput;
        private string _emailInput;
        private DateTime? _dateInput;

        private string _nameOutput;
        private string _secondNameOutput;
        private string _emailOutput;
        private string _dateOutput;

        private string _adultOutput;
        private string _birthDayOutput;
        private string _sunSignOutput;
        private string _chineseSignOutput;

        public string Nameinput
        {
            get => _nameInput;
            set
            {
                _nameInput = value;
                NotifyPropertyChanged();
            }
        }
        public string Secondnameinput
        {
            get => _secondnameInput;
            set
            {
                _secondnameInput = value;

                NotifyPropertyChanged();
            }
        }
        public string Emailinput
        {
            get => _emailInput;
            set
            {
                _emailInput = value;
                NotifyPropertyChanged();
            }
        }
        public DateTime? Dateinput
        {
            get => _dateInput;
            set
            {
                _dateInput = value;
                NotifyPropertyChanged();
            }
        }
        public string NameOutput
        {
            get => _nameOutput;
            set
            {
                _nameOutput = value;
                NotifyPropertyChanged();
            }
        }
        public string SecondNameOutput
        {
            get => _secondNameOutput;
            set
            {
                _secondNameOutput = value;
                NotifyPropertyChanged();
            }
        }
        public string EmailOutput
        {
            get => _emailOutput;
            set
            {
                _emailOutput = value;
                NotifyPropertyChanged();
            }
        }
        public string DateOutput
        {
            get => _dateOutput;
            set
            {
                _dateOutput = value;
                NotifyPropertyChanged();
            }
        }
        public string AdultOutput
        {
            get => _adultOutput;
            set
            {
                _adultOutput = value;
                NotifyPropertyChanged();
            }
        }
        public string BirthDayOutput
        {
            get => _birthDayOutput;
            set
            {
                _birthDayOutput = value;
                NotifyPropertyChanged();
            }
        }
        public string SunSignOutput
        {
            get => _sunSignOutput;
            set
            {
                _sunSignOutput = value;
                NotifyPropertyChanged();
            }
        }
        public string ChineseSignOutput
        {
            get => _chineseSignOutput;
            set
            {
                _chineseSignOutput = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        private ICommand _proceedCommand;
        public ICommand ProceedCommand => _proceedCommand ?? (_proceedCommand = new RelayCommand<object>(o => Proceed(), o => !string.IsNullOrEmpty(_emailInput) && !string.IsNullOrEmpty(_dateInput.ToString()) && !string.IsNullOrEmpty(_nameInput) && !string.IsNullOrEmpty(_secondnameInput)));

        public async void Proceed()
        {
            try
            {
                DateTime date = Dateinput ?? DateTime.Now;
                Person p = new Person(Nameinput, Secondnameinput, Emailinput, date);

                await Task.Run(() => NameOutput = p.Name);
                await Task.Run(() => SecondNameOutput = p.SecondName);
                await Task.Run(() => EmailOutput = p.EMail);
                await Task.Run(() => DateOutput = p.Date.ToShortDateString());
                await Task.Run(() => BirthDayOutput = p.isBithday.ToString());
                await Task.Run(() => AdultOutput = p.IsAdult.ToString());
                await Task.Run(() => SunSignOutput = p.SunSign);
                await Task.Run(() => ChineseSignOutput = p.ChineseSign);
            }
            catch (AgeExeption ex)
            {
                MessageBox.Show("ERROR: " +ex.Message+" -> " + ex.Value);
            }
            catch (DateExeption ex)
            {
                MessageBox.Show("ERROR: " + ex.Message + " -> " + ex.Value);
            }
            catch (EMailExeption ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }



        #region OnProperetyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(
            [CallerMemberName] String propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
