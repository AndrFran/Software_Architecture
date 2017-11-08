using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using Constructor.Classes;
using static Constructor.Patterns.Behavioral;

namespace Constructor.Patterns
{
    public class Creational
    {
        #region Будівельник
        public enum TaskType
        {
            Test,
            TestCase,
            BugReport
        }
        internal interface ITaskBuilder
        {
            TaskType Type { get;  }
            void SetObject(object o);
            void SetSummary();
            void SetContent();
            void SetTime();
            object GetObject();
            void Build();
        }
        public class TestBuilder:ITaskBuilder
        {
            public TaskType Type =>TaskType.Test;
            public void SetObject(object o)
            {
                if (o is DataBase.Test)
                    Input = (DataBase.Test) o;
            }
            private DataBase.Test Input { get; set; }
            private Test Result { get; set; }=new Test();

            public void SetSummary()
            {
                Result.Description = Input.summary;
            }

            public void SetContent()
            {
                Result.Correct =
                    Input.Answers.Where(x => x.IsCorrect.Value)
                        .Select(r => new Answer() {IsCorrect = r.IsCorrect, Value = r.Value_of_answer}).First();
                Result.Contex = Input.Answers.Select(r => new Answer() { IsCorrect = r.IsCorrect, Value = r.Value_of_answer }).ToArray();
            }

            public void Build()
            {
                SetSummary();
                SetContent();
            }
            public void SetTime(){}
            public object GetObject() => Result;


        }
        public class TestCaseBuilder : ITaskBuilder
        {
            public TaskType Type => TaskType.TestCase;
            public void SetObject(object o)
            {
                throw new NotImplementedException();
            }

            public void SetSummary() { }
            public void SetContent() { }
            public void SetTime() { }
            public object GetObject()
            {
                throw new NotImplementedException();
            }
            public void Build()
            {
                throw new NotImplementedException();
            }
        }
        public class BugReportBuilder : ITaskBuilder
        {
            public TaskType Type => TaskType.BugReport;
            public void SetObject(object o)
            {
                throw new NotImplementedException();
            }

            public void SetSummary() { }
            public void SetContent() { }
            public void SetTime() { }
            public object GetObject()
            {
                throw new NotImplementedException();
            }
            public void Build()
            {
                throw new NotImplementedException();
            }
        }
        #endregion
        #region Абстрактна фабрика

        internal interface ITaskFactory
        {
            string GetSummary();
            object GetContent();
        }
        public class TestFactory:ITaskFactory
        {
            public string GetSummary() => "Тести";

            public object GetContent()=>(new TestCreating()).GetInstances();
        }
        public class TestCaseFactory : ITaskFactory
        {
            public string GetSummary() => "Тест-кейси";
            public object GetContent() => null;
        }
        public class BugReportFactory : ITaskFactory
        {
            public string GetSummary() => "Баг-репорти";
            public object GetContent() => null;
        }
        #endregion
    }
}
