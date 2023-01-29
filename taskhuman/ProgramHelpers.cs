internal static class ProgramHelpers
{
    static bool CheckUpperorCorrect(string student)
    {
        if (student.Length > 5)
        {
            return false;
        }
        if (string.IsNullOrEmpty(student))
        {
            return false;
        }
        if (char.IsLower(student[0]))
        {
            return false;
        }
        for (int i = 0; i < student.Length; i++)
        {
            if (!char.IsDigit(student[0]))
            {
                return false;
            }
        }


    }
}