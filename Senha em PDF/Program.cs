/*
 * Adicione proteção por senha ao documento PDF usando C#
 */
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger;

string filePath = @"C:\Users\frodrigues\Downloads\Teste\89246.pdf";

using (Merger merger = new Merger(filePath))
{
    AddPasswordOptions addOptions = new AddPasswordOptions("09202224633");
    merger.AddPassword(addOptions);
    merger.Save(@"C:\Users\frodrigues\Downloads\Teste\Frederico Hadan.pdf");
}