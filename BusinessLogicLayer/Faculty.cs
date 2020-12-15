using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public class Faculty
    {
        private PayDesk payDesk = new PayDesk();
        private Exam exam = new Exam();

        public bool CanTakeExam(Student student)
        {
            bool result = true;

            if (!payDesk.IsExamPayed(student))
            {
                result = false;
            }

            if (!exam.IsPrerequisiteExamPassed(student))
            {
                result = false;
            }

            return result;
        }
    }

    class PayDesk
    {
        public bool IsExamPayed(Student student)
        {
            return true;
        }
    }

    class Exam
    {
        public bool IsPrerequisiteExamPassed(Student student)
        {
            return true;
        }
    }
}
