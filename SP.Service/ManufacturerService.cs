using SP.Data.Models;
using SP.Repo.Contracts;
using SP.Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Service
{
    public class ManufacturerService: IManufacturerService
    {
        private IUnitOfWork _uow;
        public ManufacturerService(IUnitOfWork unit)
        {
            _uow = unit;           
        }
        public IEnumerable<PartManufacturer> GetManufacturersPart(int manufId)
        {
            var manufacturerList = _uow.PartManufacturer.GetAll();         
            manufacturerList.FirstOrDefault(x => x.ManufacId == manufId).SelectedYN = true;
          
            return manufacturerList;
        }
        public PartManufacturer GetManufacturerById(int manufId)
        {
            return _uow.PartManufacturer.GetManufacturerById(manufId);
        }

    }
}
