﻿using System;

namespace jobPortalAPI.Data.Entities
{
    public class ApplicantLogo
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
    }
}