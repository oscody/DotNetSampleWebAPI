using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Models
{
    [Keyless]
    public class GenericModel

    {

        public string? Text { get; set; }
    }
}
