using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    [ServiceContract]
    interface IMyService
    {
        [OperationContract]
        string GetData();

        [OperationContract]
        int GetNumber(int a, int b);

        [OperationContract]
        string GetResult(Student s);

        [OperationContract]
        string GetTopper(List<Student> LS);

        [OperationContract]
        List<Pollens> GetAllPollens();

        [OperationContract]
        List<Pollen> GetPollens(string initial_date, string final_date, string city, string name_pollen);

        [OperationContract]
        List<City> GetAllCities();
    }

    [DataContract]
    class Student
    {
        [DataMember]
        public int Sid { get; set; }

        [DataMember]
        public string StudenName { get; set; }

        [DataMember]
        public int M1 { get; set; }

        [DataMember]
        public int M2 { get; set; }

        [DataMember]
        public int M3 { get; set; }
    }

    [DataContract]
    class Pollens
    {
        [DataMember]
        public string polen { get; set; }

        [DataMember]
        public string nombre_grafico { get; set; }      

    }

    [DataContract]

    class Pollen
    {
        [DataMember]
        public string date { get; set; }

        //[DataMember]
        //public string initial_date { get; set; }

        //[DataMember]
        //public string final_date { get; set; }

        [DataMember]
        public string city { get; set; }

        [DataMember]
        public string name_pollen { get; set; }
    }

    [DataContract]
    class City
    {
        [DataMember]
        public string ciudad { get; set; }
        
    }
}
