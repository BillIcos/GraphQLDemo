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
        public CourseResult CreateCourse(CourseInputType courseInput)
        {
            CourseResult courseType = new CourseResult()
            {
                Id = Guid.NewGuid(),
                Name = courseInput.Name,
                Subject = courseInput.Subject,
                InstructorId = courseInput.InstructorId
            };
            _courses.Add(courseType);
            return courseType;
        }

        public CourseResult UpdateCourse(Guid id, CourseInputType courseInput)
        {
            CourseResult course = _courses.Find(x => x.Id == id);
            if(course == null)
            {
                throw new GraphQLException(new Error("Course not found", "1001"));
                //throw new Exception("Course not found");
            };
            course.Name = courseInput.Name;
            course.Subject = courseInput.Subject;
            course.InstructorId = courseInput.InstructorId;            

            return course;
        }

        public bool DeleteCourse(Guid id)
        {
            return _courses.RemoveAll(a => a.Id == id) >= 1;
        }
    }
}
