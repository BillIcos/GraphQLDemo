namespace GraphQLDemo.API.Schema
{
    public class Mutation
    {
        private readonly List<CourseType> _courses;

        public Mutation()
        {
            _courses = new List<CourseType>();
        }
        public bool CreateCourse(string name, Subject subject, Guid instructorId)
        {
            CourseType courseType = new CourseType()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Subject = subject,
                Instructor = new InstructorType()
                {
                    Id = instructorId
                }
            };
            return true;
        }
    }
}
