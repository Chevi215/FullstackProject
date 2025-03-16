using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kids_Canvas.Core.Services;
using Kids_Canvas.Core.Entities;
using Kids_Canvas.Core.Repositories;

namespace Kids_Canvas.Service
{
    public class DrowingsService : IDrowingsService
    {
        private readonly IRepository<Drowings> _drowingsRepository;

        public DrowingsService(IRepository<Drowings> drowingsRepository)
        {
            _drowingsRepository = drowingsRepository;
        }

        public Drowings Add(Drowings obj)
        {
            return _drowingsRepository.Add(obj);
        }

        public void Delete(Drowings obj)
        {
            _drowingsRepository.Delete(obj);
        }

        public IEnumerable<Drowings> GetAll()
        {
            return _drowingsRepository.GetAll();
        }

        public Drowings? GetById(int id)
        {
            return _drowingsRepository.GetById(id);
        }

        public Drowings? Update(int id, Drowings obj)
        {
            return _drowingsRepository.Update(obj);
        }
    }
}
