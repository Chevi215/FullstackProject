using Kids_Canvas.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_Canvas.Core.Services
{
    public interface IFavorite_DrowingsService
    {
        IEnumerable<Favorite_Drowings> GetAll();

        Favorite_Drowings? GetById(int id);

        Favorite_Drowings Add(Favorite_Drowings obj);

        Favorite_Drowings? Update(int id, Favorite_Drowings obj);

        void Delete(Favorite_Drowings obj);
    }
}
