using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuizeSystemWindowsForms.Models
{
    public class SubjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }

        public SubjectModel(string name,Image img)
        {
            this.Name = name;
            this.Image = img;
        }
        public SubjectModel()
        {

        }
        public string ToString() => Name;
        public bool ModelIsValid()
        {
            bool isSuccess = true;
            return isSuccess;
        }
    }
}
