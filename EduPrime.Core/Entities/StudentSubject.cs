﻿using EduPrime.Core.Enums;

namespace EduPrime.Core.Entities
{
    /// <summary>
    /// StudentSubject Entity
    /// </summary>
    public class StudentSubject : BaseEntity
    {
        public int StudentId { get; set; }

        public int SubjectId { get; set; }

        public int FirstGrade { get; set; }

        public int SecondGrade { get; set; }

        public int FinalGrade { get; set; }

        public SubjectGradeStatus Status { get; set; }

        public Student Student { get; set; }

        public Subject Subject { get; set; }
    }
}
