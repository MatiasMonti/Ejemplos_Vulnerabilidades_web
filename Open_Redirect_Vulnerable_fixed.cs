//Mi lista con todas las urls validas para redirect:
var allowedDomains = new List<string> { "https://miaplicacion.com", "https://miaplicacion.com/home" }; 

public IActionResult Confirmar(string redirectUrl)
{
    if (!allowedDomains.Contains(redirectUrl))
    {
        return BadRequest("Redirección no permitida.");
    }
    
    return Redirect(redirectUrl);
}