using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDoctors.Domain.Dbo;
public class Doctor : BaseEntity
{
    public string FirstName {  get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }

    public Specialization Specialization { get; set; }
    public Guid SpecializationId {  get; set; }
}

public class Specialization : BaseEntity
{
    public string Name { get; set; }
}