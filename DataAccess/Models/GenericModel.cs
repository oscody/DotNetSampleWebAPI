using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Keyless]
    public class GenericModel
    {
        public String? Name { get; set; }
    }
}
