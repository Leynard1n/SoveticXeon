using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoveticXeon.Model.DTO;

namespace SoveticXeon.VievModel
{
    public class GpuVM : BaseVM
    {
        private GPU newGPU;

        public GPU NewGPU
        {
            get => newGPU;
            set
            {
                newGPU = value;
                Signal();
            }
        }

        public CommandVM AddGPU { get; }

        public ObservableCollection<GPU> GPU { get; set; }

        public GpuVM()
        {
            AddGPU = new CommandVM(() => {
                GPU.Add(newGPU);
                NewGPU = new GPU();
            });
            GPU = new();

            NewGPU = new GPU();
        }
    }
}
