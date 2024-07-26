// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Security.Cryptography;
using System;

string IVKEY = "R3PR353N";
string EncryptionK = "rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5";

string sTexto= Console.ReadLine();

byte[] IV = ASCIIEncoding.ASCII.GetBytes(IVKEY);
byte[] EncryptionKey= Convert.FromBase64String(EncryptionK);
byte[] BUFFER = Encoding.UTF8.GetBytes(sTexto);
TripleDESCryptoServiceProvider  des = new TripleDESCryptoServiceProvider();
des.Key = EncryptionKey;
des.IV = IV;
Console.WriteLine( Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(BUFFER, 0, BUFFER.Length)));





//Public Function Encriptar(ByVal sTexto As String) As String
//        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes(IvKey)
//        Dim EncryptionKey() As Byte = Convert.FromBase64String(EncryptionK)
//        Dim buffer() As Byte = Encoding.UTF8.GetBytes(sTexto)
//        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
//        des.Key = EncryptionKey
//        des.IV = IV
//        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
//    End Function