﻿namespace BotReborn.Model
{
    public struct Version
    {
        public byte[] Incremental { get; set; }
        public byte[] Release { get; set; }
        public byte[] CodeName { get; set; }
        public uint Sdk { get; set; }
    }
}
