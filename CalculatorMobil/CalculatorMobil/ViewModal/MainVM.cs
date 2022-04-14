using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculatorMobil.ViewModal
{
    class MainVM: INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand OneCommand { protected set; get; }
        public ICommand TwoCommand { protected set; get; }
        public ICommand ThreeCommand { protected set; get; }
        public ICommand FourCommand { protected set; get; }
        public ICommand FiveCommand { protected set; get; }
        public ICommand SixCommand { protected set; get; }
        public ICommand SevenCommand { protected set; get; }
        public ICommand EightCommand { protected set; get; }
        public ICommand NineCommand { protected set; get; }
        public ICommand ZeroCommand { protected set; get; }
        public ICommand PlusCommand { protected set; get; }
        public ICommand MinusCommand { protected set; get; }
        public ICommand MultiCommand { protected set; get; }
        public ICommand DivisionCommand { protected set; get; }
        public ICommand EqualsCommand { protected set; get; }
        public ICommand ClearCommand { protected set; get; }
        public string Answer { 
            get { return answer; }
            set
            {
                answer = value;
                OnPropertyChanged("Answer");
            }
            }
        public string answer = "";

        public MainVM()
        {
            OneCommand = new Command(OneBtn);
            TwoCommand = new Command(TwoBtn);
            ThreeCommand = new Command(ThreeBtn);
            FourCommand = new Command(FourBtn);
            FiveCommand = new Command(FiveBtn);
            SixCommand = new Command(SixBtn);
            SevenCommand = new Command(SevenBtn);
            EightCommand = new Command(EightBtn);
            NineCommand = new Command(NineBtn);
            ZeroCommand = new Command(ZeroBtn);
            PlusCommand = new Command(PlusBtn);
            MinusCommand = new Command(MinusBtn);
            MultiCommand = new Command(MultiBtn);
            DivisionCommand = new Command(DivisionBtn);
            EqualsCommand = new Command(EqualsBtn);
            ClearCommand = new Command(ClearBtn);
        }

        private void OneBtn()
        {
            answer = answer + "1";
            OnPropertyChanged("Answer");
        }

        private void TwoBtn()
        {
            answer = answer + "2";
            OnPropertyChanged("Answer");
        }

        private void ThreeBtn()
        {
            answer = answer + "3";
            OnPropertyChanged("Answer");
        }

        private void FourBtn()
        {
            answer = answer + "4";
            OnPropertyChanged("Answer");
        }

        private void FiveBtn()
        {
            answer = answer + "5";
            OnPropertyChanged("Answer");
        }

        private void SixBtn()
        {
            answer = answer + "6";
            OnPropertyChanged("Answer");
        }

        private void SevenBtn()
        {
            answer = answer + "7";
            OnPropertyChanged("Answer");
        }

        private void EightBtn()
        {
            answer = answer + "8";
            OnPropertyChanged("Answer");
        }

        private void NineBtn()
        {
            answer = answer + "9";
            OnPropertyChanged("Answer");
        }

        private void ZeroBtn()
        {
            answer = answer + "0";
            OnPropertyChanged("Answer");
        }

        private void PlusBtn()
        {
            answer = answer + "+";
            OnPropertyChanged("Answer");
        }

        private void MinusBtn()
        {
            answer = answer + "-";
            OnPropertyChanged("Answer");
        }

        private void MultiBtn()
        {
            answer = answer + "*";
            OnPropertyChanged("Answer");
        }

        private void DivisionBtn()
        {
            answer = answer + "/";
            OnPropertyChanged("Answer");
        }

        private void EqualsBtn()
        {
            if (Char.IsDigit(answer[answer.Length - 1]))
            {
                Answer = Convert.ToDouble(new DataTable().Compute(answer, "")).ToString();
                OnPropertyChanged("Answer");
            }
        }

        private void ClearBtn()
        {
            answer = " ";
            OnPropertyChanged("Answer");
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
