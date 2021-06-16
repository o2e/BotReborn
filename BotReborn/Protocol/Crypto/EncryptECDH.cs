namespace BotReborn.Protocol.Crypto {
    public struct EncryptEcdh {
        public byte[] InitialShareKey { get; set; }
        public byte[] PublicKey { get; set; }
        public ushort PublicKeyVer { get; set; }
    }
}