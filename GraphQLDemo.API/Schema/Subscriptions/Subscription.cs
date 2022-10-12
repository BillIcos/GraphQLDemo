using GraphQLDemo.API.Schema.Queries;

namespace GraphQLDemo.API.Schema.Subscriptions
{
    public class Subscription
    {
        [Subscribe]
        public CourseType CourseCreated( [EventMessage] CourseType course) => course;
    }
}
