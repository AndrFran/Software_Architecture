//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Constructor.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_of_labPI
    {
        public User_of_labPI()
        {
            this.Statistics = new HashSet<Statistic>();
        }
    
        public int id_user { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<Statistic> Statistics { get; set; }
    }
}