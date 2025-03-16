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
    public class Favorite_DrowingsService : IFavorite_DrowingsService
    {
        private readonly IRepository<Favorite_Drowings> _favorite_drowings;

        public Favorite_DrowingsService(IRepository<Favorite_Drowings> favorite_drowings)
        {
            _favorite_drowings = favorite_drowings;
        }

        public Favorite_Drowings Add(Favorite_Drowings obj)
        {
            return _favorite_drowings.Add(obj);
        }

        public void Delete(Favorite_Drowings obj)
        {
            _favorite_drowings.Delete(obj);
        }

        public IEnumerable<Favorite_Drowings> GetAll()
        {
             return _favorite_drowings.GetAll();
        }

        public Favorite_Drowings? GetById(int id)
        {
            return _favorite_drowings.GetById(id);
        }

        public Favorite_Drowings? Update(int id, Favorite_Drowings obj)
        {
            return _favorite_drowings.Update( obj);
        }
    }
}
