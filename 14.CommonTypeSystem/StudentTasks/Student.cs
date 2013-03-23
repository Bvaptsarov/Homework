using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace StudentTasks
{
    [Serializable]
    public class Student : ICloneable ,IComparable<Student>
    {
        public String FName { get; set; }
        public String MName { get; set; }
        public String LName { get; set; }
        public long SSN { get; private set; }
        public String PermanentAdress { get; private set; }
        public String MobileNumber { get; set; }
        public String Email { get; set; }
        public String Course { get; set; }
        public Univercity Uni { get; set; }
        public Faculty Fac { get; set; }
        public Specialty Spec { get; set; }

        public Student(String fName, String mName, String lName,long ssn, String mobileNumber, String email, String course, Univercity uni, Faculty fac, Specialty spec)
        {
            FName = fName;
            MName = mName;
            LName = lName;
            SSN = ssn;
            MobileNumber = mobileNumber;
            Email = email;
            Course = course;
            Uni = uni;
            Fac = fac;
            Spec = spec;
        }

        public override bool Equals(object obj)
        {
            Student tmp = obj as Student;
            if (tmp == null)
                return false;
            if (FName==tmp.FName && MName==tmp.MName && LName==tmp.LName && SSN==tmp.SSN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Student first,Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !(Student.Equals(first, second));
        }

        public override int GetHashCode()
        {
            return FName.GetHashCode() ^ MName.GetHashCode() ^ LName.GetHashCode() ^ SSN.GetHashCode();
        }

        public object Clone()
        {
            return DeepClone<Student>(new Student(FName, MName, LName,SSN, MobileNumber, Email, Course, Uni, Fac, Spec));
        }

        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            if (FName != other.FName)
            {
                return String.Compare(FName, other.FName);
            }
            if(MName !=other.MName)
            {
                return String.Compare(MName,other.MName);
            }
            if (LName != other.LName)
            {
                return String.Compare(LName, other.LName);
            }
            if (SSN != other.SSN)
            {
                return (int)(SSN - other.SSN);
            }
            return 0;
        }
    }
}