//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WowCaseApp.Model
{
    using System;
    using System.Collections.Generic;
    
    [Serializable]
    public partial class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RealName { get; set; }
        public string Type { get; set; }
        public bool IsIndexed { get; set; }
        public bool IsNullable { get; set; }
        public bool IsFKey { get; set; }
        public bool IsPKey { get; set; }
    }
}
