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
    
    public partial class Cell
    {
        public Cell()
        {
            this.Options = new HashSet<Option>();
        }
    
        public int id_cell { get; set; }
        public string cell_summary { get; set; }
        public int id_constructor { get; set; }
        public int id_statistic { get; set; }
        public int id_user { get; set; }
    
        public virtual ICollection<Option> Options { get; set; }
        public virtual Constructor Constructor { get; set; }
    }
}
