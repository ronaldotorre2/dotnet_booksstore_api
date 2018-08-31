using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.BooksStore.Models
{
    /***************************************************
    * @Project:      BooksStore
    * @Structure:    API
    * @Title:        Book
    * @Description:  Entidade refente a Livro
    * @Author:       Ronaldo Torre
    * ------------------------------------------------
    ***************************************************/

    [Table("Book")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdBook", TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Name", TypeName = "varchar")]
        public string Name { get; set; }

        [Required]
        [MaxLength(25)]
        [Column("Edition", TypeName = "varchar")]
        public string Edition { get; set; }

        [Required]
        [Column("Year", TypeName = "int")]
        public int Year { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Author", TypeName = "varchar")]
        public string Author { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Publishing", TypeName = "varchar")]
        public string Publishing { get; set; }

        [Required]
        [Column("Price", TypeName = "decimal")]
        public decimal Price { get; set; }

    }
}