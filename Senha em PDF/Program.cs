﻿/*
 * Adicione proteção por senha ao documento PDF usando C#
 */
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger;
using System.IO;
static void CriptografarPdf()
{
    DirectoryInfo diretorio = new DirectoryInfo(@"C:\temp");

    var ext = new string[] { ".pdf",".PDF" };

    FileInfo[] Arquivos = (from fi in diretorio.GetFiles() where ext.Contains(fi.Extension.ToUpper()) select fi).ToArray();

    
    foreach (FileInfo file in Arquivos)
    {
        string filePath = file.FullName;
        using (Merger merger = new Merger(filePath))
        {
            AddPasswordOptions addOptions = new AddPasswordOptions("09202224633");
            merger.AddPassword(addOptions);
            merger.Save(@"C:\temp\Frederico Hadan.pdf");
            Console.WriteLine("Arquivo Criado com sucesso");
        }
    }

    string opcaoEscolhida = Console.ReadLine()!;
}

CriptografarPdf();

