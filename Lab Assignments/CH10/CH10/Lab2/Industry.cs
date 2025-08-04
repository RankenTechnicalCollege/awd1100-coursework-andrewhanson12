using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Industry
    {
        private string _industryName;
        private Job[] _jobs;

        public Industry(string industryName, Job[] jobs)
        {
            _industryName = industryName;
            _jobs = jobs;
        }
        public string IndustryName
        {
            get
            {
                return _industryName;
            }
            set
            {
                _industryName= value;
            }
        }
        public Job[] Jobs
        {
            get => _jobs;
            set => _jobs = value;
        }
        public override string ToString()
        {
            return _industryName;
        }
    }
}
