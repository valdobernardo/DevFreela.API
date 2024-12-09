namespace DevFreela.API.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            CreateAt = DateTime.Now;
            IsDeleted = false;
        }
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public bool IsDeleted { get; set; }
        public void SetAsDeleted()
        {
            IsDeleted = true;
        }
    }
}
