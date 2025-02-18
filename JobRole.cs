using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18feb_generics
{
    
    abstract class JobRole
    {
        public string RoleName { get; set; }
        protected JobRole(string roleName)
        {
            RoleName = roleName;
        }
    }

    class SoftwareEngineer : JobRole
    {
        public SoftwareEngineer() : base("Software Engineer") { }
    }

    class DataScientist : JobRole
    {
        public DataScientist() : base("Data Scientist") { }
    }

    // Generic Resume class restricted to JobRole
    class Resume<T> where T : JobRole
    {
        public string CandidateName { get; set; }
        public T JobCategory { get; set; }

        public Resume(string candidateName, T jobCategory)
        {
            CandidateName = candidateName;
            JobCategory = jobCategory;
        }

        public void Display()
        {
            Console.WriteLine($"Candidate: {CandidateName}, Applying for: {JobCategory.RoleName}");
        }
    }

    // Generic method to process resumes
    static class ResumeProcessor
    {
        public static void ProcessResume<T>(T resume) where T : Resume<JobRole>
        {
            Console.WriteLine($"Processing resume for: {resume.CandidateName}, Job Role: {resume.JobCategory.RoleName}");
        }
    }

    class Program
    {
        static void Main()
        {
            Resume<SoftwareEngineer> seResume = new Resume<SoftwareEngineer>("Alice Johnson", new SoftwareEngineer());
            Resume<DataScientist> dsResume = new Resume<DataScientist>("Bob Smith", new DataScientist());

            List<Resume<JobRole>> resumePipeline = new List<Resume<JobRole>> { seResume, dsResume };

            Console.WriteLine("\nResume Screening Pipeline:");
            foreach (var resume in resumePipeline)
            {
                ResumeProcessor.ProcessResume(resume);
            }

            Console.WriteLine("\nResume Details:");
            seResume.Display();
            dsResume.Display();
        }
    }


}
