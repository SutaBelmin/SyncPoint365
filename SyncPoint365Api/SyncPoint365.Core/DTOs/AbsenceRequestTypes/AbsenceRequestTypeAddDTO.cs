﻿namespace SyncPoint365.Core.DTOs.AbsenceRequestTypes
{
    public class AbsenceRequestTypeAddDTO : BaseAddDTO
    {
        public string Name { get; set; } = default!;
        public bool IsActive { get; set; }
        public string? Color { get; set; }
    }
}
