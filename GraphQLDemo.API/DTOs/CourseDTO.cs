﻿using GraphQLDemo.API.Models;

namespace GraphQLDemo.API.DTOs
{
    public class CourseDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public Subject Subject { get; set; }

        public Guid InstructorId { get; set; } 

        [GraphQLNonNullType]
        public InstructorDTO? Instructor { get; set; }

        public IEnumerable<StudentDTO>? Students { get; set; }

        public string Description()
        {
            return $"{Id}: this is id";
        }
    }
}
