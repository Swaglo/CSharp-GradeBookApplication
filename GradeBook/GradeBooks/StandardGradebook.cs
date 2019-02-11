using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBOok : BaseGradeBook
    {
        public StandardGradeBOok (string name) : base(name)
        {
            Type = GradeBookType.Standard;

        }
    }
}
