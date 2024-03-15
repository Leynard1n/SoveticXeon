using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoveticXeon.Model.DTO;

namespace SoveticXeon.VievModel
{
    public class MainVM : BaseVM
    {
        private CPUdb newCPU;

        public CPUdb NewCPU
        {
            get => newCPU;
            set
            {
                newCPU = value;
                Signal();
            }
        }

        public CommandVM AddCPU { get; }

        public ObservableCollection<CPUdb> CPU { get; set; }

        public MainVM()
        {
            AddCPU = new CommandVM(() => {
                CPU.Add(newCPU);
                NewCPU = new CPUdb();
            });
            CPU = new();

            NewCPU = new CPUdb();
        }
    }
}

