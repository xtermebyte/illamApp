using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace illam.Models
{
    public class QuestionModel : INotifyPropertyChanged
    {
        public string ImageURL
        {
            get;
            set;
        }

        public string RightImageURL
        {
            get;
            set;
        }

        public string WrongImageURL
        {
            get;
            set;
        }
 
        public bool ShowAnswer
        {
            get;
            set;
        }

        public string OrgQuestion
        {
            get
            {
                return ImageURL.Replace(".png", "").Replace(".PNG", "").Replace("q", "");
            }
        }

        public bool IsCorrect
        {
            get { return ShowAnswer && answer == ExpectedAnswer; }
        }

        public bool IsWrong
        {
            get { return ShowAnswer && answer != ExpectedAnswer; }
        }

        public string ExpectedAnswer
        {
            get;
            set;
        }

        private string answer;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Answer
        {
            get { return answer; }
            set {
                answer = value;
            }
        }

        public int QuestionNumber
        {
            get;
            set;
        }

        public string ColorA
        {
            get { return Answer.ToUpper() == "A" ? "Silver" : "White";  }
        }

        public string ColorB
        {
            get { return Answer.ToUpper() == "B" ? "Silver" : "White"; }
        }

        public string ColorC
        {
            get { return Answer.ToUpper() == "C" ? "Silver" : "White"; }
        }

        public string ColorD
        {
            get { return Answer.ToUpper() == "D" ? "Silver" : "White"; }
        }

        public virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public QuestionModel(int qNumber, string image, string rightImage, string wrongImage, string answer)
        {
            ImageURL = image; //.Replace("png", "PNG");
            QuestionNumber = qNumber;
            ExpectedAnswer = answer;
            RightImageURL = rightImage; //.Replace("png", "PNG");
            WrongImageURL = wrongImage; //.Replace("png", "PNG");
            Answer = string.Empty;
            ShowAnswer = false;
        }
    }
}
