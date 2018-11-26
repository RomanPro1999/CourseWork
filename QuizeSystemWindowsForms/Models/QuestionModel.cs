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
        public TopicModel Topic { get; set; }
        public int Value { get; set; }
        public List<UserChoice> Answers { get; set; }
        public List<UserChoice> Choises { get; set; }
        public QuestionModel(string questionText,string questionType, TopicModel topic,int value)
        {
            this.QuestionText = questionText;
            this.QuestionType = questionType;
            this.Topic = topic;
            this.Value = value;
            Answers = new List<UserChoice>();
            Choises = new List<UserChoice>();
        }
        public QuestionModel()
        {
            Answers = new List<UserChoice>();
            Choises = new List<UserChoice>();
        }
    }
}
