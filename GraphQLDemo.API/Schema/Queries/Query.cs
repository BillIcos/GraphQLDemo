using Bogus;

namespace GraphQLDemo.API.Schema.Queries
{
    public class Query
    {
        public IEnumerable<CourseType> GetCourses()
        {
            Faker<InstructorType> instructorFaker = new Faker<InstructorType>();
            Faker<CourseType> courseFaker = new Faker<CourseType>()
                .RuleFor(c => c.Id, f => Guid.NewGuid())
                .RuleFor(c => c.Instructor, f => instructorFaker.Generate());
            List<CourseType> courses = courseFaker.Generate(5);
            return courses;
        }
        public IEnumerable<CourseType> GetCoursesById()
        {
            Faker<InstructorType> instructorFaker = new Faker<InstructorType>();
            Faker<CourseType> courseFaker = new Faker<CourseType>()
                .RuleFor(c => c.Id, f => Guid.NewGuid())
                .RuleFor(c => c.Instructor, f => instructorFaker.Generate());
            List<CourseType> courses = courseFaker.Generate(5);
            return courses;
        }

        [GraphQLDeprecated("Not used any more")]
        public string Hello() => "Not used"
         ;
    }
}
