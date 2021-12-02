using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
	public interface IServices<T>
	{
		void Create(T t);
		void Delele(T t);
		ICollection<T> Read();
		int GetLastId();
	}
}
