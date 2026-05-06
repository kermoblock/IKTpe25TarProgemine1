namespace University.Utilities
{
    public class PaginatedList<T> : List<T>    
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }
    }
}
