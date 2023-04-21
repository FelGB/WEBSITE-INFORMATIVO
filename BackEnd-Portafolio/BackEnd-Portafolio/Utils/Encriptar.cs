using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace BackEnd_Portafolio.Utils
{
    public static class Encriptar
    {

        public static string EncriptarPassword(string input)
        {
            MD5 mdSHash = MD5.Create();


            byte[] data = mdSHash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for(int i=0; i<data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("X2"));
            }

            return sBuilder.ToString(); 
        }

    }
}
