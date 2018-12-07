using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuizeSystemWindowsForms.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public Image Image { get; set; }
        public TestModel Test { get; set; }
        public int Value { get; set; }
        public List<UserChoice> Answers { get; set; }
        public List<UserChoice> Choises { get; set; }
        public QuestionModel(string questionText,string questionType, TestModel test,int value)
        {
            this.QuestionText = questionText;
            this.QuestionType = questionType;
            this.Test = test;
            this.Value = value;
            Answers = new List<UserChoice>();
            Choises = new List<UserChoice>();
        }
        public QuestionModel()
        {
            Answers = new List<UserChoice>();
            Choises = new List<UserChoice>();
        }
        public override string ToString()
        {
            return Id.ToString() + " " + QuestionText + " " + QuestionType + " " + Value.ToString();
        }
        public bool ModelIsValid()
        {
            bool isSuccess = true;
            return isSuccess;
        }
    }
}
