using System;
using System.Collections.Generic;

namespace FPTUniversityLibrary.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string? DoctorName { get; set; }

    public int? SpecializationId { get; set; }

    public string? Address { get; set; }

    public virtual Specialization? Specialization { get; set; }
}
