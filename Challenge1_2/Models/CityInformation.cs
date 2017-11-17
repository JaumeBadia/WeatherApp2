using System;
using System.Collections.Generic;
using Challenge1_2.Common;

namespace Challenge1_2.Models
{
    public class CityInformation : ObservableBase
    {

        List<Predictions> _predictions;
        public List<Predictions> predictions
        {
            get { return _predictions; }
            set { SetProperty(ref _predictions, value); }
        }

        public class Predictions : ObservableBase
        {
            
            Structured_formatting _structured_formatting;
            public Structured_formatting structured_formatting
            {
                get { return _structured_formatting; }
                set { SetProperty(ref _structured_formatting, value); }
            }

        }

        public class Structured_formatting : ObservableBase
        {

            String _main_text;
            public string main_text
            {
                get { return _main_text; }
                set { SetProperty(ref _main_text, value); }
            }

            String _secondary_text;
            public string secondary_text
            {
                get { return _secondary_text; }
                set { SetProperty(ref _secondary_text, value); }
            }

        }

    }
}
