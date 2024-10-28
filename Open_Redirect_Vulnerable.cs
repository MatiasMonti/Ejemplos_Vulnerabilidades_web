//direccion valida dentro de mi dominio
string urlRedireccion = "https://miaplicacion.com/confirmar?redirectUrl=http://miaplicacion.com/home";

//direccion maliciosa fuera de mi dominio
string urlRedireccionMaliciosa = "https://miaplicacion.com/confirmar?redirectUrl=https://sitio-malicioso.com";


public IActionResult Confirmar(string redirectUrl)
{
    return Redirect(redirectUrl);
}