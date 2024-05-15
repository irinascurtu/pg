using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PGShop.Entities;

public partial class Num
{
    [Key]
    [Column("n")]
    public int N { get; set; }
}
