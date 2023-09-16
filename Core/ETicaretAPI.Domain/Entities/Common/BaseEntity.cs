namespace ETicaretAPI.Domain.Entities.Common
{
    public class BaseEntity
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// CreatedDate
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Updated date
        /// </summary>
        public DateTime UpdatedDate { get; set; }
    }
}
