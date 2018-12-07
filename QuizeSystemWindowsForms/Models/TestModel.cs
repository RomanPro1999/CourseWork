using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizeSystemWindowsForms.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfQuestions { get; set; }
        public SubjectModel Subject { get; set; }
        
        public TestModel(string Name,int numberOfQuestions,SubjectModel subject)
        {
            this.Name = Name;
            this.NumberOfQuestions = numberOfQuestions;
            this.Subject = subject;
        }
        public TestModel() { }
        public bool ModelIsValid()
        {
            bool isSuccess = true;
            return isSuccess;
        }
    }
}
