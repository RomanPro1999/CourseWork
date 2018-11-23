using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuizeSystemWindowsForms.Models
{
    public class SubjectModell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }

        public SubjectModell(string name,Image img)
        {
            this.Name = name;
            this.Image = img;
        }
        public SubjectModell()
        {

        }
        public string ToString()
        {
            return Name;
        }
    }
}
