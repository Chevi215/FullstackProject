using Kids_Canvas.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_Canvas.Core.Services
{
    public interface IDrowingsService
    {
        IEnumerable<Drowings> GetAll();

        Drowings? GetById(int id);

        Drowings Add(Drowings obj);

        Drowings? Update(int id, Drowings obj);

        void Delete(Drowings obj);
    }
}
