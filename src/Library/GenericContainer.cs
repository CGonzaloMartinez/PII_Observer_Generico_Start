
using System.Collections.Generic;

namespace Observer
{
    public class GenericContainer<T>
    {
        private IList<T> items = new List<T>(); 
    }
}