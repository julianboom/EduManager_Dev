
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
    
public partial class Users
{

    public System.Guid ID { get; set; }

    public Nullable<System.Guid> DeptID { get; set; }

    public Nullable<System.Guid> RoleID { get; set; }

    public Nullable<System.Guid> MasterID { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string RealName { get; set; }

    public Nullable<int> Rank { get; set; }

    public bool IsKeyNode { get; set; }

    public string MasterType { get; set; }

    public string IP { get; set; }

    public string Region { get; set; }

    public bool IsDeleted { get; set; }

    public Nullable<System.DateTime> Timestamp { get; set; }

}

}
