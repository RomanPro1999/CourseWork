using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizeSystemWindowsForms.Models
{
    public class TopicModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SubjectModel Subject { get; set; }
        public string Describtion { get; set; }
        public TopicModel(string name,SubjectModel subject , string describtion)
        {
            this.Name = name;
            this.Subject = subject;
            this.Describtion = describtion;
        }
        public TopicModel()
        {

        }
    }
}
