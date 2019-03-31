namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        [DisplayName("Tên danh mục")]
        [Required (ErrorMessage ="Bạn chưa nhập tên danh mục!")]
        public string Name { get; set; }

        [StringLength(50)]
        public string Alias { get; set; }

        public int? ParentID { get; set; }
        [Required(ErrorMessage ="Ngày tạo phải được điền!")]
        public DateTime? CreatedDate { get; set; }
        [DisplayName("Số thứ tự")]
        [Range(0,Int32.MaxValue, ErrorMessage ="Trường nhập liệu là số")]
        public int? Order { get; set; }

        public bool? Status { get; set; }
    }
}
