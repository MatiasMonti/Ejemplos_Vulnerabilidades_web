[HttpPost]
[Authorize]
public IActionResult CambiarContraseña(string newPassword)
{
    ActualizarContraseña(newPassword);
    return Ok("Contraseña cambiada exitosamente.");
}
