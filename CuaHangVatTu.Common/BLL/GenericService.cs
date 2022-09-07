using System;
using System.Collections.Generic;
using CuaHangVatTu.Common.DAL;
using CuaHangVatTu.Common.Response;
using System.Linq;
using System.Linq.Expressions;


namespace CuaHangVatTu.Common.BLL
{
  
    public class GenericService<D, T> : IGenericService<T> where T : class where D : IGenericRep<T>, new()
    {
        #region -- Implements --

        /// <summary>
        /// Create the model
        /// </summary>
        /// <param name="m">The model</param>
        /// <returns>Return the result</returns>
        public virtual SingleResponse Create(T m)
        {
            var res = new SingleResponse();

            try
            {
                var now = DateTime.Now;
                _rep.Create(m);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }

            return res;
        }

        /// <summary>
        /// Create the models
        /// </summary>
        /// <param name="l">List model</param>
        /// <returns>Return the result</returns>
        public virtual MultipleResponse Create(List<T> l)
        {
            var res = new MultipleResponse();

            try
            {
                _rep.Create(l);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }

            return res;
        }

        /// <summary>
        /// Read by
        /// </summary>
        /// <param name="p">Predicate</param>
        /// <returns>Return query data</returns>
        public IQueryable<T> Read(Expression<Func<T, bool>> p)
        {
            return _rep.Read(p);
        }


        /// <summary>
        /// Read single object
        /// </summary>
        /// <param name="id">Primary key</param>
        /// <returns>Return the object</returns>
        public virtual SingleResponse Read(int id)
        {
            return null;
        }

        /// <summary>
        /// Read single object
        /// </summary>
        /// <param name="code">Secondary key</param>
        /// <returns>Return the object</returns>
        public virtual SingleResponse Read(string code)
        {
            return null;
        }

        /// <summary>
        /// Update the model
        /// </summary>
        /// <param name="m">The model</param>
        /// <returns>Return the result</returns>
        public virtual SingleResponse Update(T m)
        {
            var res = new SingleResponse();

            try
            {
                _rep.Update(m);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }

            return res;
        }

        /// <summary>
        /// Update the models
        /// </summary>
        /// <param name="l">List model</param>
        /// <returns>Return the result</returns>
        public virtual MultipleResponse Update(List<T> l)
        {
            var res = new MultipleResponse();

            try
            {
                _rep.Update(l);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }

            return res;
        }

        /// <summary>
        /// Delete single object
        /// </summary>
        /// <param name="id">Primary key</param>
        /// <returns>Return the result</returns>
        public virtual SingleResponse Delete(int id)
        {
            return null;
        }

        /// <summary>
        /// Delete single object
        /// </summary>
        /// <param name="code">Secondary key</param>
        /// <returns>Return the result</returns>
        public virtual SingleResponse Delete(string code)
        {
            return null;
        }

        /// <summary>
        /// Restore the model
        /// </summary>
        /// <param name="id">Primary key</param>
        /// <returns>Return the result</returns>
        public virtual SingleResponse Restore(int id)
        {
            return null;
        }

        /// <summary>
        /// Restore the model
        /// </summary>
        /// <param name="code">Secondary key</param>
        /// <returns>Return the result</returns>
        public virtual SingleResponse Restore(string code)
        {
            return null;
        }

        /// <summary>
        /// Remove and not restore
        /// </summary>
        /// <param name="id">Primary key</param>
        /// <returns>Number of affect</returns>
        public virtual int Remove(int id)
        {
            return 0;
        }

        SingleResponse IGenericService<T>.Create(T m)
        {
            throw new NotImplementedException();
        }

        MultipleResponse IGenericService<T>.Create(List<T> l)
        {
            throw new NotImplementedException();
        }

     //   public IQueryable<T> Read(Expression<Func<T, bool>> p)
       // {
       //     throw new NotImplementedException();
//}

        SingleResponse IGenericService<T>.Read(int id)
        {
            throw new NotImplementedException();
        }

        SingleResponse IGenericService<T>.Read(string code)
        {
            throw new NotImplementedException();
        }

        SingleResponse IGenericService<T>.Update(T m)
        {
            throw new NotImplementedException();
        }

        MultipleResponse IGenericService<T>.Update(List<T> l)
        {
            throw new NotImplementedException();
        }

        SingleResponse IGenericService<T>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        SingleResponse IGenericService<T>.Delete(string code)
        {
            throw new NotImplementedException();
        }

        SingleResponse IGenericService<T>.Restore(int id)
        {
            throw new NotImplementedException();
        }

        SingleResponse IGenericService<T>.Restore(string code)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return query all data
        /// </summary>
        public IQueryable<T> All
        {
            get
            {
                return _rep.All;
            }
        }

        IQueryable<T> IGenericService<T>.All => throw new NotImplementedException();

        #endregion

        #region -- Methods --

        /// <summary>
        /// Initialize
        /// </summary>
        public GenericService()
        {
            _rep = new D();
        }

        #endregion

        #region -- Fields --

        /// <summary>
        /// The repository
        /// </summary>
        protected D _rep;

        #endregion
    }
}
