﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Form_Carga
{
    
     public static class MD5
    {
        
        public static string Encriptar(string input)
        {
            string key = "smoke";

            
                //arreglo de bytes donde guardaremos la llave
                byte[] keyArray;
                //arreglo de bytes donde guardaremos el texto
                //que vamos a encriptar
                byte[] Arreglo_a_Cifrar =
                UTF8Encoding.UTF8.GetBytes(input);

                //se utilizan las clases de encriptación
                //provistas por el Framework
                //Algoritmo MD5
                MD5CryptoServiceProvider hashmd5 =
                new MD5CryptoServiceProvider();
                //se guarda la llave para que se le realice
                //hashing
                keyArray = hashmd5.ComputeHash(
                UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                //Algoritmo 3DAS
                TripleDESCryptoServiceProvider tdes =
                new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                //se empieza con la transformación de la cadena
                ICryptoTransform cTransform =
                tdes.CreateEncryptor();

                //arreglo de bytes donde se guarda la
                //cadena cifrada
                byte[] ArrayResultado =
                cTransform.TransformFinalBlock(Arreglo_a_Cifrar,
                0, Arreglo_a_Cifrar.Length);

                tdes.Clear();

                //se regresa el resultado en forma de una cadena
                return Convert.ToBase64String(ArrayResultado,
                0, ArrayResultado.Length);
            


        }

        
    }
}
