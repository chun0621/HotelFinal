
//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------


namespace OrderTest
{

using System;
    using System.Collections.Generic;
    
public partial class RoomMember
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public RoomMember()
    {

        this.Comments = new HashSet<Comment>();

        this.Orders = new HashSet<Order>();

    }


    public string AdminID { get; set; }

    public string MemberID { get; set; }

    public string MemberName { get; set; }

    public Nullable<System.DateTime> MemberBirthday { get; set; }

    public string MemberGender { get; set; }

    public string MemberIdentity { get; set; }

    public string MemberPhone { get; set; }

    public string MemberEMail { get; set; }

    public byte[] MemberPhoto { get; set; }

    public string MemberPassword { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Comment> Comments { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Order> Orders { get; set; }

    public virtual RoomAdmin RoomAdmin { get; set; }

}

}