using GraphQLDemo.API.Schema.Queries;

namespace GraphQLDemo.API.Schema.Mutations
{
    public class Mutation
    {
        private readonly List<CourseResult> _courses;

        public Mutation()
        {
            _courses = new List<CourseResult>();
        }
        public CourseResult CreateCourse(string name, Subject subject, Guid instructorId)
        {
            CourseResult courseType = new CourseResult()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Subject = subject,
                InstructorId = instructorId
            };
            _courses.Add(courseType);
            return courseType;
        }

        public CourseResult UpdateCourse(Guid id, string name, Subject subject, Guid instructorId)
        {
            CourseResult course = _courses.Find(x => x.Id == id);
            if(course == null)
            {
                throw new GraphQLException(new Error("Course not found", "1001"));
                //throw new Exception("Course not found");
            };
            course.Name = name;
            course.Subject = subject;
            course.InstructorId = instructorId;            

            return course;
        }

        public bool DeleteCourse(Guid id)
        {
            return _courses.RemoveAll(a => a.Id == id) >= 1;
        }
    }
}
