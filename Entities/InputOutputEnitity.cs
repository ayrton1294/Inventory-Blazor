using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class InputOutputEnitity
    {
        [Key]
        [StringLength(50)]
        public string InOutId { get; set; }
        [Required]
        public DateTime InOutDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool IsInput { get; set; }
        /// <summary>
        /// Relación con almacenamiento (StorangeEntity)
        /// </summary>
        public string StorageId { get; set; }
        public StorageEntity Storage { get; set; }
    }
}
