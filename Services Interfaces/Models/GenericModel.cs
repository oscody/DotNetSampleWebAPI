using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Interfaces.Models
{
    [Keyless]
    public class GenericModel
    {
        public string? Name { get; set; }
    }
}
