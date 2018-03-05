using System;
using System.Collections.Generic;

namespace illam.Model
{
    public class TestModel
    {
        public TestModel()
        {
        }

        public string RightImage
        {
            get;
            set;
        }

        public string WrongImage
        {
            get;
            set;
        }

        public List<QuestionModel> Questions
        {
            get;
            set;
        }
    }

    public class QuestionModel
    {
        public string ImageURL
        {
            get;
            set;
        }

        public string Answer
        {
            get;
            set;
        }

        public string QNo
        {
            get;
            set;
        }
    }
}