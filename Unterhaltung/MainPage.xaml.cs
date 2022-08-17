using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Unterhaltung
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void buttonTest()
        {
            
        }

        private void ButtonUns_Clicked(object sender, EventArgs e)
        {
            QuestionLabel.Text = QuestionHandler.getNextUnsQuestion();
        }

        private void ButtonMich_Clicked(object sender, EventArgs e)
        {
            QuestionLabel.Text = QuestionHandler.getNextMichQuestion();
        }

        private void ButtonDich_Clicked(object sender, EventArgs e)
        {
            QuestionLabel.Text = QuestionHandler.getNextDichQuestion();
        }
    }
}
