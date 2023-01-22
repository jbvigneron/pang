﻿using Bang.Database.Enums;

namespace Bang.Database.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public PlayerStatus Status { get; set; }
        public Character? Character { get; set; }
        public int Lives { get; set; }
        public bool IsScheriff { get; set; }
        public virtual PlayerRole? Role { get; set; }
        public Weapon? Weapon { get; set; }
    }
}
