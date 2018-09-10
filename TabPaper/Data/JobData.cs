using System;
using System.Collections.Generic;
using System.Linq;


namespace TabPaper.Data
{
    public class JobData
    {
        /**
         * A data store for Job objects
         */

        
        //public List<string> Employers { get; set; } = new List<string>();
        //public List<string> Locations { get; set; } = new List<string>();
        //public List<string> PositionTypes { get; set; } = new List<string>();
        //public List<string> CoreCompetencies { get; set; } = new List<string>();
       

        public JobData()
        {
            //JobDataImporter.LoadData(this);
        }

        public static JobData instance;

        public object Jobs { get; internal set; }

        public static JobData GetInstance()
        {
            if (instance == null)
            {
                instance = new JobData();
            }

            return instance;
        }


        /**
         * Return all Job objects in the data store
         * with a field containing the given term
         */
        /*public List<string> FindByValue(string value)
        {
            /*var results = from j in Jobs
                          where j.Employer.Contains(value)
                          || j.Location.Contains(value)
                          || j.Name.ToLower().Contains(value.ToLower())
                          || j.CoreCompetency.Contains(value)
                          || j.PositionType.Contains(value)
                          select j;results.ToList();

            return value.ToArray();
        }
        */

        /**
         * Returns results of search the jobs data by key/value, using
         * inclusion of the search term.
         */
        /*public List<Job> FindByColumnAndValue(JobFieldType column, string value)
        {
            var results = from j in Jobs
                          where GetFieldByType(j, column).Contains(value)
                          select j;

            return results.ToList();
        }

        /**
         * Returns the JobField of the given type from the Job object,
         * for all types other than JobFieldType.All. In this case, 
         * null is returned.
         */
       /* public static JobField GetFieldByType(Job job, JobFieldType type)
        {
            switch (type)
            {
                case JobFieldType.Employer:
                    return job.Employer;
                case JobFieldType.Location:
                    return job.Location;
                case JobFieldType.CoreCompetency:
                    return job.CoreCompetency;
                case JobFieldType.PositionType:
                    return job.PositionType;
            }

            throw new ArgumentException("Cannot get field of type: " + type);
        }
        
        */

        /**
         * Returns the Job with the given ID,
         * if it exists in the store
         */
       /* public Job Find(int id)
        {
            var results = from j in Jobs
                          where j.ID == id
                          select j;

            return results.Single();
        }*/

    }
}
