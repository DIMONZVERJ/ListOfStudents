using System.Collections;

namespace ListStudents
{
    public class ConsistenlyOrder : IMyIterator
    {
        public int Position { get; private set; } = -1;
        private StudentsCollection _collection;

        public ConsistenlyOrder(StudentsCollection collection)
        {
            this._collection = collection;
        }

        object IEnumerator.Current => _collection.students_list[Position];

        public bool MoveNext()
        {
            int new_position = Position + 1;
            if (new_position < _collection.students_list.Count)
            {
                Position = new_position;
                return true;
            }
            else
            {
                Position = _collection.students_list.Count;
                return false;
            }
        }

        public bool MovePrev()
        {
            if (Position <= 0)
            {
                return false;
            }

            --Position;
            return true;

        }

        public void Reset()
        {
            Position = -1;
        }

        public bool MoveEnd()
        {
            if (_collection.students_list.Count > 0)
            {
                Position = _collection.students_list.Count;
                return true;
            }
            return false;
        }

        public bool MoveFirst()
        {
            if (_collection.students_list.Count > 0)
            {
                Position = 0;
                return true;
            }
            return false;
        }

        public bool IsFirst() => Position == 0;

        public bool IsLast() => Position == _collection.students_list.Count;
    }
}
