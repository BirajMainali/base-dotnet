﻿#nullable enable
using System;
using Base.Constants;

namespace Base.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime RecDate { get; set; } = DateTime.Now;
        public DateTime? ChangeAt { get; set; }
        public string? RecAuditLog { get; set; }
        public char RecStatus { get; set; } = Status.Active;
    }
}