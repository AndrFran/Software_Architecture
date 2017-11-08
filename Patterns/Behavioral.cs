using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Constructor.Classes;
using static Constructor.Patterns.Creational;

namespace Constructor.Patterns
{
    public class Behavioral
    {
        #region Стратегія
        internal interface IStrategy
        {
            object GetInstances();
        }
        public class TestCreating:IStrategy
        {
            public object GetInstances()
            {
                ITaskBuilder builder=new TestBuilder();
                var testsDB = Struct.dbConnection.GetInstance().GetTests();
                List<Test> instances=new List<Test>();
                if (testsDB.Any())
                {
                    foreach (var test in testsDB)
                    {
                        builder.SetObject(test);
                        builder.Build();
                        instances.Add((Test) builder.GetObject());
                        if(instances.Count ==10) break;///
                    }
                }
                return instances;
            }
        }
        public class TestCaseCreating : IStrategy
        {
            public object GetInstances()
            {
                throw new NotImplementedException();
            }
        }
        public class BugReportCreating : IStrategy
        {
            public object GetInstances()
            {
                throw new NotImplementedException();
            }
        }
        #endregion
    }
}
