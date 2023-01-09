using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesMVVM.services
{
    class ServiceSuperheroe
    {
        public ObservableCollection<Superheroe> getSuperheroes()
        {
            return Superheroe.GetSamples();
        }
    }
}
