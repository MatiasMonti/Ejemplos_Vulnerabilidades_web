public IActionResult DescargarArchivo(string filePath)
{
    string baseDirectory = "/var/www/files/";
    string fullPath = Path.GetFullPath(Path.Combine(baseDirectory, filePath));
    IActionResult result;

    if (!fullPath.StartsWith(baseDirectory))
    {
        result = BadRequest("Acceso denegado.");
    }
    else if (!System.IO.File.Exists(fullPath))
    {
        result = NotFound("Archivo no encontrado");
    }
    else
    {
        byte[] fileBytes = System.IO.File.ReadAllBytes(fullPath);
        result = File(fileBytes, "application/octet-stream", Path.GetFileName(fullPath));
    }

    return result;
}
