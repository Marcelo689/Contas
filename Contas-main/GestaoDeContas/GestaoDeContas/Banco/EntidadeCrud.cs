using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoDeContas.Banco
{
    public class EntidadeCrud<TEntity> where TEntity : class
    {
        private Conexao _conexao;

        public EntidadeCrud()
        {
            _conexao = new Conexao();
        }

        public TEntity Last()
        {
            var quantidade = GetAll().Count;
            if (quantidade > 0)
                return _conexao.Set<TEntity>().AsEnumerable().Last();
            else
                return null;
        }
        public void Create(TEntity entidade)
        {
            _conexao.Set<TEntity>().Add(entidade);
            _conexao.SaveChanges();
        }
        public void InsertMultipleEntities(IEnumerable<TEntity> entidade)
        {
            _conexao.Set<TEntity>().AddRange(entidade);
            _conexao.SaveChanges();
        }

        public void Delete(TEntity entidade)
        {
            _conexao.Set<TEntity>().Remove(entidade);
            _conexao.SaveChanges();
        }

        public void Delete(int id)
        {
            var entidade = _conexao.Set<TEntity>().Find(id);
            Delete(entidade);
        }

        public void Update(TEntity entidade)
        {
            _conexao.Set<TEntity>().Update(entidade);
            _conexao.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            var lista  = _conexao.Set<TEntity>().AsQueryable().ToList();

            foreach (var item in lista)
            {
                _conexao.Entry<TEntity>(item).Reload();
            }

            return lista;
        }

    }
}
