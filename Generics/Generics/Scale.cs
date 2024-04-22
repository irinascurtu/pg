using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /// <summary>
    /// Create a class Scale<T> that holds two elements - left and right. 
    /// The scale should receive the elements through its single constructor.
    /// Should have a single method Named GetHeavier that returns the heaviest side.
    /// return null if the elements are equal in size
    /// </summary>
    public class Scale<T> where T : IComparable<T>
    {
        private readonly T left;
        private readonly T right;

        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T GetHeavier()
        {
            var comparison = left.CompareTo(right);
            if (comparison > 0)
            {
                return left;
            }

            if (comparison < 0)
            {
                return right;
            }
            //  -1 0 1

            return default(T);
        }
    }
}
