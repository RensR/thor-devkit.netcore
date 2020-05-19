using System;
using System.Numerics;

namespace Org.VeChain.Thor.Devkit.Extension
{
    public static class ByteExtension
    {
        public static string ConvertToHexString(this byte[] data)
        {
            return "0x" + BitConverter.ToString(data).Replace("-","").ToLower();
        } 
    }
}