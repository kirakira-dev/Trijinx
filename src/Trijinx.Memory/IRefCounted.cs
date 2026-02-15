namespace Trijinx.Memory
{
    public interface IRefCounted
    {
        void IncrementReferenceCount();
        void DecrementReferenceCount();
    }
}
