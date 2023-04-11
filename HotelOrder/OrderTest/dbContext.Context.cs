﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelOrderEntities : DbContext
    {
        public HotelOrderEntities()
            : base("name=HotelOrderEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<HotelFacility> HotelFacilities { get; set; }
        public virtual DbSet<HotelIndustry> HotelIndustries { get; set; }
        public virtual DbSet<HotelRegionName> HotelRegionNames { get; set; }
        public virtual DbSet<MultipleFacility> MultipleFacilities { get; set; }
        public virtual DbSet<MultipleHotelFacility> MultipleHotelFacilities { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderDetailStatu> OrderDetailStatus { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomAdmin> RoomAdmins { get; set; }
        public virtual DbSet<RoomClass> RoomClasses { get; set; }
        public virtual DbSet<RoomImage> RoomImages { get; set; }
        public virtual DbSet<RoomMember> RoomMembers { get; set; }
        public virtual DbSet<RoomStyle> RoomStyles { get; set; }
        public virtual DbSet<RoomTimePrice> RoomTimePrices { get; set; }
    }
}
