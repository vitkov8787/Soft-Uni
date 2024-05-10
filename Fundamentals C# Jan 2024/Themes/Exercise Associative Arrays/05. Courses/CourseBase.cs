namespace _05._Courses
{
    private class CourseBase
    {

        public override string ToString()
        {
            foreach (var item in StudentName)
            {
                return $"-- {item}";
            }

        }
    }
}