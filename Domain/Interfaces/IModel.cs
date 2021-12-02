using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface IModel<T>
	{
		void Create(T t);
		void Delele(T t);
		ICollection<T> Read();

		int GetLastId();
		

	}
}
