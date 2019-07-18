using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mode2.Models
{
    class ItemModel
    {
        public int isCount;
        public ObservableCollection<string> name = new ObservableCollection<string>();
    }
}
