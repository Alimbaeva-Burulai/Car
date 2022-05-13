using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceCarÁdám_2.Model
{
    public class RaceResult : ObservableObject
    {
        private IList<OneResult> oneResults;

        public IList<OneResult> OneResults
        {
            get { return oneResults; }
            set {
                OnPropertyChanged();
                SetProperty(ref oneResults, value);
            }
        }

    }
}
