namespace Constructor.Classes
{
    internal interface ITask
    {
        string Description { get; set; }
        object Correct { get; set; }
        dynamic Contex { get; set; }
    }

    #region Тест та відповідь
    public class Test : ITask
    {
        public string Description { get; set; }
        public object Correct { get; set; }
        public dynamic Contex { get; set; }
    }

    public class Answer
    {
        public string Value { get; set; }
        public bool? IsCorrect { get; set; }
    }
    #endregion

}