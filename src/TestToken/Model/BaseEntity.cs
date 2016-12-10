using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestToken.Model
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// Id of entity with format as Guid
        /// </summary>
        [Key]
        [Required]
        public string Id { get; set; }

        /// <summary>
        /// Created Date in UTC of entity
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Updated Dated in UTC of entity
        /// </summary>
        public DateTime UpdatedOnUtc { get; set; }


        protected BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreatedOnUtc = DateTime.UtcNow;
            UpdatedOnUtc = DateTime.UtcNow;
        }
    }
}
