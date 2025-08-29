using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDoctors.Domain.Dbo;
public class Disease : BaseEntity
{
    public string Name {  get; set; }
    public string Description { get; set; }
}
