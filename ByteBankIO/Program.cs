using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";


        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;


            var buffer = new byte[1024]; //1KB

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            fluxoDoArquivo.Close();

        }

    }

    static void EscreverBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding();

        #region
        //foreach (byte b in buffer)
        //{
        //    Console.Write(b);
        //    Console.Write(" ");
        //}
        #endregion

        var texto = utf8.GetString(buffer);
        Console.Write(texto);
    }
}