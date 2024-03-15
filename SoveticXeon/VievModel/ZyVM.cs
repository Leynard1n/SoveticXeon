using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoveticXeon.Model.DTO;

namespace SoveticXeon.VievModel
{
    public class ZyVM : BaseVM
    {
        private ZY newZY;

        public ZY NewZY
        {
            get => newZY;
            set
            {
                newZY = value;
                Signal();
            }
        }

        public CommandVM AddZY { get; }

        public ObservableCollection<ZY> ZY { get; set; }

        public ZyVM()
        {
            AddZY = new CommandVM(() => {
                ZY.Add(newZY);
                NewZY = new ZY();
            });
            ZY = new();

            NewZY = new ZY();
        }
    }
}
