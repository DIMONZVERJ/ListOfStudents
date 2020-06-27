using System;

namespace ListStudents
{
    public class FilterOrder : IMyIterator
    {
        public int Position { get; private set; } = -1;
        public Tuple<string, string> criteria_value;

        StudentsCollection _collection;
        public object Current => _collection.students_list[Position];

        public FilterOrder(StudentsCollection collection)
        {
            this._collection = collection;
        }

        int FindPos(int dir, int Position)
        {
            switch (criteria_value.Item1)
            {
                case "Имя":
                    {
                        if (Position == -1) Position++;
                        else
                        {
                            if (_collection.Current.FirstName == criteria_value.Item2)
                            {
                                if (dir == 1) Position++;
                                else Position--;
                            }
                        }
                        return dir == 1 ? _collection.students_list.FindIndex(Position, x => x.FirstName == criteria_value.Item2) :
                            _collection.students_list.FindLastIndex(Position, x => x.FirstName == criteria_value.Item2);
                    }
                case "Фамилия":
                    {
                        if (Position == -1) Position++;
                        else
                        {
                            if (_collection.Current.SecondName == criteria_value.Item2)
                            {
                                if (dir == 1) Position++;
                                else Position--;
                            }
                        }
                        return dir == 1 ? _collection.students_list.FindIndex(Position, x => x.SecondName == criteria_value.Item2) :
                            _collection.students_list.FindLastIndex(Position, x => x.SecondName == criteria_value.Item2);
                    }
                case "Факультет":
                    {
                        if (Position == -1) Position++;
                        else
                        {
                            if (_collection.Current.Faculty == criteria_value.Item2)
                            {
                                if (dir == 1) Position++;
                                else Position--;
                            }
                        }
                        return dir == 1 ? _collection.students_list.FindIndex(Position, x => x.Faculty == criteria_value.Item2) :
                            _collection.students_list.FindLastIndex(Position, x => x.Faculty == criteria_value.Item2);
                    }
                default:
                    return -1;
            }
        }

        public bool MoveNext()
        {
            Position = FindPos(1, Position);
            if (Position != -1) return true;
            else Position = _collection.students_list.Count - 1;
            return false;
        }

        public bool MovePrev()
        {
            Position = FindPos(-1, Position);
            if (Position != -1) return true;
            else Position = 0;
            return false;
        }

        public void Reset()
        {
            Position = -1;
        }

        public bool MoveEnd()
        {
            if (_collection.students_list.Count > 0)
            {
                Position = _collection.students_list.Count - 1;
                return true;
            }
            else return false;
        }

        public bool MoveFirst()
        {
            Reset();
            Position = FindPos(1, Position);
            if (Position != -1)
                return true;
            else return false;
        }

        public bool IsLast()
        {
            if (Position == _collection.students_list.Count - 1) return true;
            if (FindPos(1, Position) == -1) return true;
            return false;
        }

        public bool IsFirst()
        {
            if (Position == 0) return true;
            int pos = FindPos(-1, Position);
            if (pos == -1 || pos == 0) return true;
            return false;
        }
    }
}
