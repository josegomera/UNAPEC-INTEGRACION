using APEC.DAL.SQL;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace APEC
{
  public static class GenerarNomina
  {
    private static string folderName = @"C:\temp";
    private static string fileName = $@"{folderName}\NominaApec.txt";

    public async static void Generate()
    {
      try
      {
        var path = Directory.CreateDirectory(folderName);
        if (!path.Exists)
        {
          Directory.CreateDirectory(folderName);
        }

        var query = "SELECT Id, TipoRegistro, ClaveNomina, TipoDocumento, NoDocumento, MontoPagar, Cuenta FROM Nominas";
        using (var _dbContext = new ApecDbContext())
        {
          var nomina = await _dbContext.Nominas.FromSql(query).ToListAsync();

          foreach (var item in nomina)
          {
            writeFileLine($"{item.TipoRegistro}|{item.ClaveNomina}|{item.TipoDocumento}|{item.NoDocumento}|{item.MontoPagar}|{item.Cuenta}");
          }

          _dbContext.Dispose();
          Console.WriteLine("Archivo generado");
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }

    private static void writeFileLine(string pLine)
    {
      using (StreamWriter w = File.AppendText(fileName))
      {
        w.WriteLine(pLine);
      }
    }

    public static string ToApplicationPath(this string fileName)
    {
      var exePath = Path.GetDirectoryName(System.Reflection
                          .Assembly.GetExecutingAssembly().CodeBase);
      Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
      var appRoot = appPathMatcher.Match(exePath).Value;
      return Path.Combine(appRoot, fileName);
    }
  }
}
