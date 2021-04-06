namespace Owner.JogoGourmet.KnowledgeBase
{
    public interface IKnowledgeBase<T>
    {
        T CurrentItem { get; }
        T FirstCategory { get; }
        T FirstDish { get; }
        bool IsCurrentItemDish { get; }
        T NextItem { get; }
        bool HasNextItem { get; }
        void AddItem(string dish, string category = null);
    }
}
