
//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace Model
{

using System;
    using System.Collections.Generic;
    
public partial class Dept
{

    public System.Guid ID { get; set; }

    public string DeptName { get; set; }

    public Nullable<System.Guid> UserID { get; set; }

    public Nullable<System.Guid> ParentID { get; set; }

    public Nullable<int> Sequence { get; set; }

    public bool IsDeleted { get; set; }

    public Nullable<System.DateTime> Timestamp { get; set; }

}

}
