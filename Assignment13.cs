using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_Assignment
{
    class Patient
    {
        static int PatientNo = 1000;
        public Patient()
        {
            PatientId = ++PatientNo;
        }
        public Patient(int id)
        {
            PatientId = id;
        }
        public int PatientId { get; private set; }
        public string PatientName { get; set; }
        public int PhoneNo{ get; set; }
        public int BillAmount { get; set; }
        public override string ToString()
        {
            return $"{PatientId},{PatientName},{PhoneNo},{BillAmount}";
        }
        
    }
    class Assignment13
    {
        const string fileName = "PatientDetails.txt";
        public static void WriteTofile(Patient patient)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine(patient);
            writer.Close();
            fs.Close();
        }
        public static Patient ReadFromFile()
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs);
                string data = reader.ReadLine();
                string[] details = data.Split(',');
                Patient patient = new Patient(int.Parse(details[0]));
                patient.PatientName = details[1];
                patient.PhoneNo = int.Parse(details[2]);
                patient.BillAmount = int.Parse(details[3]);
                fs.Close();
                return patient;
            }
            
                throw new FileNotFoundException();

        }
        static void Main(string[] args)
        {
            string PatientName = Util.GetString("Enter the name of Patient");
            int PhoneNo = Util.GetNumber("Enter the phone number");
            int BillAmount = Util.GetNumber("Enter the bill amount");
            Patient patient = new Patient { PatientName = PatientName, PhoneNo = PhoneNo, BillAmount = BillAmount };
            WriteTofile(patient);
            Console.WriteLine(ReadFromFile());
        }
    }
}
