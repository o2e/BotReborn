namespace BotReborn.Jce
{
    public static class JceStructsEx
    {
        public static byte[] GetBytes(this IJceStruct s)
        {
            var writer = new JceStream();
            writer.WriteJceStructRaw(s);
            return writer.ToArray();
        }

    }
}
