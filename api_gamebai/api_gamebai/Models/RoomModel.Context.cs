﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api_gamebai.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DatabaseGameBai_Room : DbContext
    {
        public DatabaseGameBai_Room()
            : base("name=DatabaseGameBai_Room")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<player> players { get; set; }
        public virtual DbSet<room_list> room_list { get; set; }
        public virtual DbSet<room_listplayer> room_listplayer { get; set; }
        public virtual DbSet<vroom_listplayer> vroom_listplayer { get; set; }
    
        public virtual int addRoomList(Nullable<int> owner_id, Nullable<int> limit_player, string password, string room_name)
        {
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var limit_playerParameter = limit_player.HasValue ?
                new ObjectParameter("limit_player", limit_player) :
                new ObjectParameter("limit_player", typeof(int));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var room_nameParameter = room_name != null ?
                new ObjectParameter("room_name", room_name) :
                new ObjectParameter("room_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addRoomList", owner_idParameter, limit_playerParameter, passwordParameter, room_nameParameter);
        }
    
        public virtual int JoinRoomList(Nullable<int> room_id, Nullable<int> player_id)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(int));
    
            var player_idParameter = player_id.HasValue ?
                new ObjectParameter("player_id", player_id) :
                new ObjectParameter("player_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("JoinRoomList", room_idParameter, player_idParameter);
        }
    
        public virtual int OutRoom(Nullable<int> room_id, Nullable<int> player_id)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(int));
    
            var player_idParameter = player_id.HasValue ?
                new ObjectParameter("player_id", player_id) :
                new ObjectParameter("player_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OutRoom", room_idParameter, player_idParameter);
        }
    
        public virtual int CountCurrentPlayer(Nullable<int> room_id)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CountCurrentPlayer", room_idParameter);
        }
    
        public virtual ObjectResult<GetListPlayerInRoom_Result> GetListPlayerInRoom(Nullable<int> iD_room)
        {
            var iD_roomParameter = iD_room.HasValue ?
                new ObjectParameter("ID_room", iD_room) :
                new ObjectParameter("ID_room", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetListPlayerInRoom_Result>("GetListPlayerInRoom", iD_roomParameter);
        }
    }
}
