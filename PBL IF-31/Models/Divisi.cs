using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL_IF_31.Models
{
    [Table("DIVISI")]
    [Keyless]
    public class Divisi
    {
        [Column("Nama_Divisi")]
        public string NamaDivisi { get; set; }

        [Key]
        public int Id { get; set; }
    }
}