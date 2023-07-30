using System.Collections.Generic;
using System.Text;
using System.Web;

public static class ExportHelper
{
    public static byte[] ExportClientsToCsv(List<Client> clients)
    {
        StringBuilder csvContent = new StringBuilder();
        csvContent.AppendLine("Id,Name,Gender"); 

        foreach (var client in clients)
        {
            // Add client information to the CSV content
            csvContent.AppendLine($"{client.Id},{EscapeCsvField(client.Name)},{client.Gender}");
        }

        // Convert the CSV content to a byte array
        byte[] csvBytes = Encoding.UTF8.GetBytes(csvContent.ToString());
        return csvBytes;
    }

    // Helper method to escape CSV fields
    private static string EscapeCsvField(string field)
    {
        if (field.Contains(",") || field.Contains("\"") || field.Contains("\r") || field.Contains("\n"))
        {
            return $"\"{field.Replace("\"", "\"\"")}\"";
        }
        return field;
    }
}
