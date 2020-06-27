using System.Collections;

namespace ListStudents
{
    public enum TypeOrder { ConsistenlyOrder, FilterOrder };
    public interface IMyIterator : IEnumerator
    {
        int Position { get; }
        bool MovePrev();
        bool MoveEnd();
        bool MoveFirst();
        bool IsFirst();
        bool IsLast();
    }
}
