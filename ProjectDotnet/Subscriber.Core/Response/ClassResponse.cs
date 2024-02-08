using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Subscriber.Core.Response
{
    public class ClassResponse
    {
        public ClassResponse(int id, float height, float weight, float bmi, string firstName, string lastName)
        {
            Id = id;
            Height = height;
            Weight = weight;
            BMI = bmi;
            FirstName = firstName;
            LastName = lastName;
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float BMI { get; set; }


    }
}
