using System;

using BotReborn;

public static class Tlv
{
    public static byte[] T1(uint uin, byte[] ip)
    {
        if (ip.Length != 4)
        {
            throw new Exception("Invalid ip");
        }

        var b = new BinaryStream();
        b.WriteUInt16(0x01);


        return b.ToArray();
    }
}
