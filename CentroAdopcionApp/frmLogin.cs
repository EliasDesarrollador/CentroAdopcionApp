private void button1_Click(object sender, EventArgs e)
{
    string usuario = txtUsuario.Text.Trim();
    string contrase�a = txtContrase�a.Text.Trim();
    // Validaci�n para iniciar sesi�n 
    if (usuario == "admin" && contrase�a == "1234")
    {
        MessageBox.Show("Inicio de sesi�n exitoso", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Hide(); // Oculta el formulario de login
        frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(); // Crea una instancia del formulario principal
        menuPrincipal.Show(); // Muestra el formulario principal
    }
    else
    {
        MessageBox.Show("Usuario o contrase�a incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
